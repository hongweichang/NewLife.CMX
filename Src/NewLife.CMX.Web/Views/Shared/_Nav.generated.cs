﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.CMX;
    using NewLife.CMX.Web;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Nav.cshtml")]
    public partial class _Views_Shared__Nav_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Nav_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_Nav.cshtml"
  
    var category = Model as ICategory;
    if (category == null)
    {
        category = (Model as IInfo).Category;
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<ol");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 170), Tuple.Create("\"", 179)
, Tuple.Create(Tuple.Create("", 177), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 177), false)
);

WriteLiteral(">首页</a></li>\r\n");

            
            #line 10 "..\..\Views\Shared\_Nav.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Shared\_Nav.cshtml"
     foreach (ICategory cat in category.AllParents)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 282), Tuple.Create("\"", 314)
            
            #line 13 "..\..\Views\Shared\_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 289), Tuple.Create<System.Object, System.Int32>(this.GetCategoryUrl(cat)
            
            #line default
            #line hidden
, 289), false)
);

WriteLiteral(">");

            
            #line 13 "..\..\Views\Shared\_Nav.cshtml"
                                           Write(cat.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </li>\r\n");

            
            #line 15 "..\..\Views\Shared\_Nav.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 388), Tuple.Create("\"", 425)
            
            #line 17 "..\..\Views\Shared\_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 395), Tuple.Create<System.Object, System.Int32>(this.GetCategoryUrl(category)
            
            #line default
            #line hidden
, 395), false)
);

WriteLiteral(">");

            
            #line 17 "..\..\Views\Shared\_Nav.cshtml"
                                            Write(category.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </li>\r\n</ol>");

        }
    }
}
#pragma warning restore 1591