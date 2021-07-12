#pragma checksum "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db7eedd086369e1629ef372058528bc0311acb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Edit), @"mvc.1.0.view", @"/Views/Contact/Edit.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\_ViewImports.cshtml"
using ContactsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\_ViewImports.cshtml"
using ContactsWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db7eedd086369e1629ef372058528bc0311acb1", @"/Views/Contact/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f78ba656edd7525055b133266e5abf2710bf0b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
  
    ViewData["Title"] = "Contacts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
 using (Html.BeginForm("Edit", "Contact", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
Write(Html.HiddenFor(x => x.ContactItem.ContactId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" shadow-lg card\">\r\n        <h5 class=\"card-header\">Contacts information</h5>\r\n        <div class=\" card-body border-info\">\r\n            <h5 class=\"card-title\">Full Name</h5>\r\n            ");
#nullable restore
#line 13 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.ContactItem.FullName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.ContactItem.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <h5 class=\"card-title\">Phone Number</h5>\r\n            ");
#nullable restore
#line 16 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.ContactItem.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.ContactItem.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <h5 class=\"card-title\">Email</h5>\r\n            ");
#nullable restore
#line 19 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.ContactItem.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.ContactItem.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <h5 class=\"card-title\">Address</h5>\r\n            ");
#nullable restore
#line 22 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.ContactItem.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.ContactItem.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <h5 class=\"card-title\">Where to save?</h5>\r\n            ");
#nullable restore
#line 25 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.RadioButtonFor(m => m.IsSqlSelected, true));

#line default
#line hidden
#nullable disable
            WriteLiteral(" SQL\r\n            ");
#nullable restore
#line 26 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
       Write(Html.RadioButtonFor(m => m.IsSqlSelected, false));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" JSON
            <div class=""col"">
                <div class=""row"">
                    <button type=""button"" data-toggle=""modal"" data-target=""#exampleModalCenter"" class=""btn btn-outline-success"" style=""margin:5px;"">Save changes</button>
                    <a class=""btn btn-outline-dark"" href=""../Home/Contacts/"" style=""margin:5px;"">Go Back</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Atention!</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
               ");
            WriteLiteral(@" </div>
                <div class=""modal-body"">
                    Save contact's changes?
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" name=""search"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 54 "C:\Users\User\Desktop\ContactWebApp\Contact Web App\ContactsWebApp\Views\Contact\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
