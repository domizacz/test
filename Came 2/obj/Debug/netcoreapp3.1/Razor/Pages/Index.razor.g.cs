#pragma checksum "C:\Users\Dom\Documents\Project\TestCame\Came 2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a87890ba12fa4bcc3d55a516b8211305c642d8e3"
// <auto-generated/>
#pragma warning disable 1591
namespace Came_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using Came_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dom\Documents\Project\TestCame\Came 2\_Imports.razor"
using Came_2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"select\">\r\n        <label for=\"audioSource\">Audio input source: </label><select id=\"audioSource\"></select>\r\n    </div>\r\n\r\n    ");
            __builder.AddMarkupContent(5, "<div class=\"select\">\r\n        <label for=\"audioOutput\">Audio output destination: </label><select id=\"audioOutput\"></select>\r\n    </div>\r\n\r\n    ");
            __builder.AddMarkupContent(6, "<div class=\"select\">\r\n        <label for=\"videoSource\">Video source: </label><select id=\"videoSource\"></select>\r\n    </div>\r\n\r\n    <video id=\"video\" playsinline autoplay></video>\r\n    ");
            __builder.OpenElement(7, "video");
            __builder.AddAttribute(8, "id", "");
            __builder.AddAttribute(9, "playsinline", true);
            __builder.AddAttribute(10, "autoplay", true);
            __builder.AddElementReferenceCapture(11, (__value) => {
#nullable restore
#line 19 "C:\Users\Dom\Documents\Project\TestCame\Came 2\Pages\Index.razor"
                 divElement = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Dom\Documents\Project\TestCame\Came 2\Pages\Index.razor"
 


    private ElementReference divElement;


    // protected override void OnInitialized()
    

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await IJR.InvokeVoidAsync("test.start", divElement);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJR { get; set; }
    }
}
#pragma warning restore 1591
