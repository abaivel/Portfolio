using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Layout;
using MudBlazor;
using System.Net.Http.Json;
using System.Web;

namespace Portfolio.Pages
{
    public partial class Contact
    {
        [Inject] public IJSRuntime jSRuntime { get; set; } = default!;
        [CascadingParameter]
        public MainLayout Layout { get; set; }
        bool success;
        MudForm form;
        bool captchaValide = false;
        string Message { get; set; } = "";
        string Email { get; set; } = "";
        protected override void OnInitialized()
        {
            Layout.isHome = true;
        }

        protected async override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                await jSRuntime.InvokeVoidAsync("generateAnimationAllScreen", DotNetObjectReference.Create(this));
            }
        }
        private async Task ValidateCaptcha()
        {
            captchaValide = await jSRuntime.InvokeAsync<bool>("getCaptchaResponse");
            if (captchaValide)
            {
                using var httpClient = new HttpClient();
                var response = await httpClient.PostAsJsonAsync("https://www.baivel.com/portfolioApi/sendMail", new
                {
                    email_sender = Email,
                    email_message = Message,
                    email_destinataire = "abaivel+portfolio@outlook.fr",
                    email_object = "Contact via Portfolio - " + Email
                });

            }

        }
    }
}
