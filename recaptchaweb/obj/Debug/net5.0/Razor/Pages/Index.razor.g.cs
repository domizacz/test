#pragma checksum "C:\Users\Dom\Documents\git\test\recaptchaweb\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "361c13788d105bb36ad64a0ac5ec3490148708b8"
// <auto-generated/>
#pragma warning disable 1591
namespace recaptchaweb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using recaptchaweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dom\Documents\git\test\recaptchaweb\_Imports.razor"
using recaptchaweb.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "section");
            __builder.OpenComponent<recaptchaweb.ReCAPTCHA>(2);
            __builder.AddAttribute(3, "SiteKey", "6LfEGxIaAAAAAMWQG77K8UmwdaDqPHwNg6fZcmD9");
            __builder.AddAttribute(4, "OnSuccess", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "C:\Users\Dom\Documents\git\test\recaptchaweb\Pages\Index.razor"
                                                                                                       OnSuccess

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "OnExpired", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\Dom\Documents\git\test\recaptchaweb\Pages\Index.razor"
                                                                                                                             OnExpired

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(6, (__value) => {
#nullable restore
#line 7 "C:\Users\Dom\Documents\git\test\recaptchaweb\Pages\Index.razor"
                     reCAPTCHAComponent = (recaptchaweb.ReCAPTCHA)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "section");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Dom\Documents\git\test\recaptchaweb\Pages\Index.razor"
                      OnClickPost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "disabled", 
#nullable restore
#line 11 "C:\Users\Dom\Documents\git\test\recaptchaweb\Pages\Index.razor"
                                              DisablePostButton

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n        POST\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Dom\Documents\git\test\recaptchaweb\Pages\Index.razor"
        private ReCAPTCHA reCAPTCHAComponent;

    private bool ValidReCAPTCHA = false;

    private bool ServerVerificatiing = false;

    private bool DisablePostButton => !ValidReCAPTCHA || ServerVerificatiing;

    private void OnSuccess()
    {
        ValidReCAPTCHA = true;
    }

    private void OnExpired()
    {
        ValidReCAPTCHA = false;
    }

    private async Task OnClickPost()
    {
        if (ValidReCAPTCHA)
        {
            var response = await reCAPTCHAComponent.GetResponseAsync();
            try
            {
                ServerVerificatiing = true;
                StateHasChanged();
                var result = await SampleAPI.Post(response);
                if (result.Success)
                {
                    Navigation.NavigateTo("/valid");
                }
                else
                {
                    await JS.InvokeAsync<object>("alert", string.Join(", ", result.ErrorCodes));
                    ServerVerificatiing = false;
                    StateHasChanged();
                }
            }
            catch (HttpRequestException e)
            {
                await JS.InvokeAsync<object>("alert", e.Message);
                ServerVerificatiing = false;
                StateHasChanged();
            }
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SampleAPI SampleAPI { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
