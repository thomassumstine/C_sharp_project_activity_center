#pragma checksum "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/ActivityEvent/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e35af22276bc1319792dc0631008fa6caa4a2a50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ActivityEvent_Details), @"mvc.1.0.view", @"/Views/ActivityEvent/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ActivityEvent/Details.cshtml", typeof(AspNetCore.Views_ActivityEvent_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/_ViewImports.cshtml"
using DojoActivityCenter;

#line default
#line hidden
#line 2 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/_ViewImports.cshtml"
using DojoActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e35af22276bc1319792dc0631008fa6caa4a2a50", @"/Views/ActivityEvent/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e72ab6140e435fa7efd67238cade4d60e8f980", @"/Views/_ViewImports.cshtml")]
    public class Views_ActivityEvent_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityEvent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ActivityEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 129, true);
            WriteLiteral("\n<div class=\"card mx-auto text-center mb-3\" style=\"width: 25rem;\">\n  <div class=\"card-header\">\n    <h5 class=\"card-title\">\n      ");
            EndContext();
            BeginContext(151, 18, false);
#line 6 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/ActivityEvent/Details.cshtml"
 Write(Model.ActivityType);

#line default
#line hidden
            EndContext();
            BeginContext(169, 111, true);
            WriteLiteral("\n    </h5>\n  </div>\n  <div class=\"card-body\">\n    <h6 class=\"card-subtitle mb-2 text-muted\">Event Coordinator: ");
            EndContext();
            BeginContext(281, 33, false);
#line 10 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/ActivityEvent/Details.cshtml"
                                                            Write(Model.EventCoordinator.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(314, 120, true);
            WriteLiteral("</h6>\n  </div>\n  <div class=\"card-body\">\n    <h6 class=\"card-subtitle mb-2 text-muted\">Description: </h6>\n    <p>\n      ");
            EndContext();
            BeginContext(435, 17, false);
#line 15 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/ActivityEvent/Details.cshtml"
 Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(452, 111, true);
            WriteLiteral("\n    </p>\n  </div>\n  <div class=\"card-body\">\n    <h6 class=\"card-subtitle mb-2 text-muted\">Participants: </h6>\n");
            EndContext();
#line 20 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/ActivityEvent/Details.cshtml"
     foreach(var participant in Model.Participants){

#line default
#line hidden
            BeginContext(616, 14, true);
            WriteLiteral("    <p>\n      ");
            EndContext();
            BeginContext(631, 27, false);
#line 22 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/ActivityEvent/Details.cshtml"
 Write(participant.user.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(658, 10, true);
            WriteLiteral("\n    </p>\n");
            EndContext();
#line 24 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/DojoActivityCenter/Views/ActivityEvent/Details.cshtml"
    }

#line default
#line hidden
            BeginContext(674, 42, true);
            WriteLiteral("  </div>\n\n  <div class=\"card-footer\">\n    ");
            EndContext();
            BeginContext(716, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e35af22276bc1319792dc0631008fa6caa4a2a507237", async() => {
                BeginContext(794, 16, true);
                WriteLiteral("\n      Back\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(814, 16, true);
            WriteLiteral("\n  </div>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityEvent> Html { get; private set; }
    }
}
#pragma warning restore 1591
