using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DojoActivityCenter.Models;

namespace DojoActivityCenter.Controllers
{
    public class ActivityEventController : Controller
    {
        private DojoActivityCenterContext dbContext;
        private int? _uid
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
        }

        public ActivityEventController(DojoActivityCenterContext context)
        {
            dbContext = context;
        }

        [HttpGet("ActivityEvent/Dashboard")]
        public IActionResult Dashboard()
        {
            var uid = _uid;
            if (_uid != null)
            {
                var allInfo = dbContext.ActivityEvent
                    .Include(activity => activity.EventCoordinator)
                    .Include(participant => participant.Participants)
                    .ThenInclude(u => u.user).ToList();
                User user = dbContext.Users.FirstOrDefault(u => u.UserId == _uid);
                ViewBag.user = user;
                return View("Dashboard", allInfo);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("ActivityEvent/details/{id}")]
        public IActionResult Details(int id)
        {
            ActivityEvent selectedActivityEvent = dbContext.ActivityEvent
                .Include(activityEvent => activityEvent.EventCoordinator)
                .Include(activity => activity.Participants)
                .ThenInclude(eachparticipant => eachparticipant.user)
                .FirstOrDefault(a => a.ActivityEventId == id);

            // in case user manually types URL
            if (selectedActivityEvent == null)
                RedirectToAction("All");

            ViewBag.Uid = _uid;
            return View(selectedActivityEvent);
        }

        [HttpGet("ActivityEvent/create")]
        public IActionResult create()
        {

            if (_uid == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost("ActivityEvent/AddNewActivityEvent")]
        public IActionResult AddNewActivityEvent(ActivityEvent newActivityEvent)
        {
            if (ModelState.IsValid)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserId == _uid);
                newActivityEvent.EventCoordinator = user;
                newActivityEvent.EventCoordinatorId = user.UserId;
                dbContext.Add(newActivityEvent);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("create");
        }

        [HttpGet("ActivityEvent/delete/{ActivityEventId}")]
        public IActionResult delete(int activityEventId)
        {
            if (_uid == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ActivityEvent activityEvent = dbContext.ActivityEvent.FirstOrDefault(a => a.ActivityEventId == activityEventId);
            dbContext.Remove(activityEvent);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("ActivityEvent/join/{activityEventId}")]
        public IActionResult join(int activityEventId)
        {
            if (_uid == null)
            {
                return RedirectToAction("Index", "Home");
            }
            User user = dbContext.Users.FirstOrDefault(u => u.UserId == _uid);
            ActivityEvent activityEvent = dbContext.ActivityEvent.FirstOrDefault(a => a.ActivityEventId == activityEventId);
            Join join = new Join();
            join.ActivityEventId = activityEvent.ActivityEventId;
            join.UserId = user.UserId;
            dbContext.Join.Add(join);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("ActivityEvent/leave/{activityEvtIdToLeave}")]
        public IActionResult leave(int activityEvtIdToLeave){
            if (_uid == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Join join = dbContext.Join.FirstOrDefault(j => j.UserId==_uid && j.ActivityEventId == activityEvtIdToLeave);
            dbContext.Join.Remove(join);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

    }
}