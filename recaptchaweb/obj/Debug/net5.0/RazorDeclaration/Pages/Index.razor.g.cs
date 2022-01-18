// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace recaptchaweb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
using recaptchaweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dom\Documents\Project\test\recaptchaweb\_Imports.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\Index.razor"
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
