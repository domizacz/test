// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Notyfication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Notyfication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dom\Documents\Project\test\Notyfication\_Imports.razor"
using Notyfication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Dom\Documents\Project\test\Notyfication\Pages\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Dom\Documents\Project\test\Notyfication\Pages\Index.razor"
                                             


    private ExampleModel exampleModel = new();
    public string test;

    public class ExampleModel
    {
        [Required]

        [StringLength(18, ErrorMessage = "Name is too long.")]
        [Customer(ErrorMessage ="noooooo")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(ExampleModel))]
    public partial class Customer : ValidationAttribute
    {
        public bool my { get; set; }

        public override bool IsValid(object value)
        {
            string imput = value as string;
            if ( imput[0]=='2')
                {
                return true;
                }

            return false;
        }
    }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
