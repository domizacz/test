#pragma checksum "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8eed7de12471e8e544414c2ca03a1f31c2f81d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TutorWeb.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using TutorWeb.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\_Imports.razor"
using TutorWeb.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Dom\Documents\Project\TestCame\TutorWeb\Client\Pages\Counter.razor"
           
        private int currentCount = 0;
        public static int currentCountn = 0;
        private static int currentCountStatuc = 0;
       [par]


        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            singelton.number++;
            transition.number++;
            await jst.InvokeVoidAsync("dotnetStaticInvocation");
        }


        [JSInvokable]
         public static Task<int> GetCuntentCount()
         {
             return Task.FromResult(currentCountStatuc);
         }









    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jst { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TransitionService transition { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SingletorService singelton { get; set; }
    }
}
#pragma warning restore 1591
