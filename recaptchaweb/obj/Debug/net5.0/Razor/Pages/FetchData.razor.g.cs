#pragma checksum "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d24dc07fb114f8195fdb8e3f6ef09c476f1cab8a"
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
#nullable restore
#line 3 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
using recaptchaweb.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "section");
            __builder.OpenComponent<recaptchaweb.ReCAPTCHA>(2);
            __builder.AddAttribute(3, "SiteKey", "6Le7j7AUAAAAAORWIiHLTzHJtrQHOqC9d5GykoEl");
            __builder.AddAttribute(4, "OnSuccess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 11 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                                                                                                       OnSuccess

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "OnExpired", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                                                                                                                             OnExpired

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(6, (__value) => {
#nullable restore
#line 11 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                     reCAPTCHAComponent = (recaptchaweb.ReCAPTCHA)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.AddMarkupContent(8, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(9, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "section");
#nullable restore
#line 19 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
     if (!@DisablePostButton)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<h1>Test</h1>");
#nullable restore
#line 22 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                      OnClickPost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "disabled", 
#nullable restore
#line 24 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                                              DisablePostButton

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n\r\n        POST\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<p><em>Loading...</em></p>");
#nullable restore
#line 33 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table");
            __builder.AddMarkupContent(20, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(21, "tbody");
#nullable restore
#line 46 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 49 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 50 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 51 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 52 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Dom\Documents\Project\test\recaptchaweb\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SampleAPI SampleAPI { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
