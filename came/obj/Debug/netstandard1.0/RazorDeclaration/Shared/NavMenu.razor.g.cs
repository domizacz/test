#pragma checksum "C:\Users\Dom\Documents\Project\TestCame\came\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a525ae8c52e496ec5ae548b150257102f7f95c1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace came.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#line 7 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using came;

#line default
#line hidden
#line 9 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using came.Shared;

#line default
#line hidden
#line 10 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using Microsoft.MixedReality.WebRTC;

#line default
#line hidden
#line 11 "C:\Users\Dom\Documents\Project\TestCame\came\_Imports.razor"
using Microsoft.MixedReality;

#line default
#line hidden
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "C:\Users\Dom\Documents\Project\TestCame\came\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
