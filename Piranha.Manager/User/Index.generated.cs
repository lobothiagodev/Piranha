﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Manager.User
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/User/Index.cshtml")]
    public class Index : Piranha.WebPages.ContentPage<Piranha.Manager.Models.UserListModel>
    {

                // Resolve package relative syntax
                // Also, if it comes from a static embedded resource, change the path accordingly
                public override string Href(string virtualPath, params object[] pathParts) {
                    virtualPath = ApplicationPart.ProcessVirtualPath(GetType().Assembly, VirtualPath, virtualPath);
                    return base.Href(virtualPath, pathParts);
                }
        public Index()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n");



            
            #line 3 "..\..\User\Index.cshtml"
  
    Page.Title = @Piranha.Resources.Settings.ListTitleUsers ;
    Layout = "~/Manager/Shared/_Layout.cshtml" ;


            
            #line default
            #line hidden

DefineSection("Head", () => {

WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            var options = {
                listClass: 'list-js',
                searchId: 'search',
                valueNames: ['login', 'name', 'group', 'updated', 'created']
            };
            var list = new List('list', options);
        });
    </script>
");


});

WriteLiteral("\r\n");


DefineSection("Toolbar", () => {

WriteLiteral("\r\n");



WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <div class=\"inner\">\r\n        <ul>\r\n            <li i" +
"d=\"add\"><a href=\"");


            
            #line 24 "..\..\User\Index.cshtml"
                             Write(Href("~/manager/user/edit"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"add\">");


            
            #line 24 "..\..\User\Index.cshtml"
                                                                       Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a href=\"");


            
            #line 25 "..\..\User\Index.cshtml"
                    Write(Href("~/manager/user"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"refresh\">");


            
            #line 25 "..\..\User\Index.cshtml"
                                                             Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button class=\"search\"></button>");


            
            #line 27 "..\..\User\Index.cshtml"
                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</div>\r\n");


});

WriteLiteral("\r\n\r\n<div class=\"grid_12\">\r\n    <table id=\"list\" class=\"list\">\r\n        <thead>\r\n " +
"           <tr>\r\n                <th></th>\r\n                <th><span class=\"sor" +
"t asc\" data-sort=\"login\">");


            
            #line 38 "..\..\User\Index.cshtml"
                                                        Write(Piranha.Resources.Global.Username);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span class=\"sort\" data-sort=\"name\">");


            
            #line 39 "..\..\User\Index.cshtml"
                                                   Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span class=\"sort\" data-sort=\"group\">");


            
            #line 40 "..\..\User\Index.cshtml"
                                                    Write(Piranha.Resources.Global.Group);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th class=\"date\"><span class=\"sort\" data-sort=\"upda" +
"ted\">");


            
            #line 41 "..\..\User\Index.cshtml"
                                                                   Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th class=\"date\"><span class=\"sort\" data-sort=\"crea" +
"ted\">");


            
            #line 42 "..\..\User\Index.cshtml"
                                                                   Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th class=\"one\"></th>\r\n            </tr>\r\n        <" +
"/thead>\r\n        <tbody class=\"list-js\">\r\n");


            
            #line 47 "..\..\User\Index.cshtml"
             foreach (var user in Model.Users) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td class=\"gravatar\">\r\n");


            
            #line 50 "..\..\User\Index.cshtml"
                     if (!String.IsNullOrEmpty(user.Email)) {

            
            #line default
            #line hidden
WriteLiteral("                        <img src=\"");


            
            #line 51 "..\..\User\Index.cshtml"
                             Write(UI.Gravatar.Image(user.Email, 30));

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Gravatar for ");


            
            #line 51 "..\..\User\Index.cshtml"
                                                                                   Write(user.Email);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");


            
            #line 52 "..\..\User\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td class=\"login\">\r\n");


            
            #line 55 "..\..\User\Index.cshtml"
                     if (User.IsMember(user.GroupId.Value)) {

            
            #line default
            #line hidden
WriteLiteral("                    <a href=\"");


            
            #line 56 "..\..\User\Index.cshtml"
                        Write(Href("~/manager/user/edit/" + user.Id));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 56 "..\..\User\Index.cshtml"
                                                                 Write(user.Login);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");


            
            #line 57 "..\..\User\Index.cshtml"
                    } else {
                    
            
            #line default
            #line hidden
            
            #line 58 "..\..\User\Index.cshtml"
               Write(user.Login);

            
            #line default
            #line hidden
            
            #line 58 "..\..\User\Index.cshtml"
                               
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>        \r\n                <td class=\"name\">");


            
            #line 61 "..\..\User\Index.cshtml"
                            Write(user.Firstname);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 61 "..\..\User\Index.cshtml"
                                            Write(user.Surname);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"group\">");


            
            #line 62 "..\..\User\Index.cshtml"
                             Write(user.Group.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"updated\">");


            
            #line 63 "..\..\User\Index.cshtml"
                               Write(user.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"created\">");


            
            #line 64 "..\..\User\Index.cshtml"
                               Write(user.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"buttons\">\r\n");


            
            #line 66 "..\..\User\Index.cshtml"
                     if (User.IsMember(user.GroupId.Value)) {

            
            #line default
            #line hidden
WriteLiteral("                    <a class=\"icon delete\" href=\"");


            
            #line 67 "..\..\User\Index.cshtml"
                                            Write(Href("~/manager/user/edit/delete/" + user.Id));

            
            #line default
            #line hidden
WriteLiteral("\"></a>\r\n");


            
            #line 68 "..\..\User\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");


            
            #line 71 "..\..\User\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
