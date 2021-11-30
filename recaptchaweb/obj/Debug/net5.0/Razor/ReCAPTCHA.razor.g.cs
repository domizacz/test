#pragma checksum "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\ReCAPTCHA.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9ca4095a806457264fd254f7eba94b9a1347f0d"
// <auto-generated/>
#pragma warning disable 1591
namespace recaptchaweb
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using recaptchaweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\_Imports.razor"
using recaptchaweb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\ReCAPTCHA.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    public partial class ReCAPTCHA : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", 
#nullable restore
#line 4 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\ReCAPTCHA.razor"
          UniqueId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\monster\Source\Repos\domizacz\test\recaptchaweb\ReCAPTCHA.razor"
        [Parameter]
            public string SiteKey { get; set; }

            [Parameter]
            public EventCallback<string> OnSuccess { get; set; }

            [Parameter]
            public EventCallback OnExpired { get; set; }

            private string UniqueId = Guid.NewGuid().ToString();

            private int WidgetId;

            protected override async Task OnAfterRenderAsync(bool firstRender)
            {
                if (firstRender)
                {
                    await JS.InvokeAsync<object>("My.reCAPTCHA.init");
                    this.WidgetId = await JS.InvokeAsync<int>("My.reCAPTCHA.render", DotNetObjectReference.Create(this), UniqueId, SiteKey);
                }
            }

            [JSInvokable, EditorBrowsable(EditorBrowsableState.Never)]
            public void CallbackOnSuccess(string response)
            {
                if (OnSuccess.HasDelegate)
                {
                    OnSuccess.InvokeAsync(response);
                }
            }

            [JSInvokable, EditorBrowsable(EditorBrowsableState.Never)]
            public void CallbackOnExpired()
            {
                if (OnExpired.HasDelegate)
                {
                    OnExpired.InvokeAsync(null);
                }
            }

            public ValueTask<string> GetResponseAsync()
            {
                return JS.InvokeAsync<string>("My.reCAPTCHA.getResponse", WidgetId);
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
