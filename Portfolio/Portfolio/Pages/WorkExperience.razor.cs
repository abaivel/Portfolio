using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Layout;

namespace Portfolio.Pages
{
    public partial class WorkExperience
    {
        [Inject] public IJSRuntime jSRuntime { get; set; } = default!;
        [CascadingParameter]
        public MainLayout Layout { get; set; }

        public List<string> LanguagesAndFrameworks { get; set; } = new List<string>() { "C#", "Blazor", "MudBlazor", "ASP.NET Core", "Entity Framework", "OpenIddict", "Hangfire"};
        public List<string> Tools { get; set; } = new List<string>() { "Visual Studio", "SQL Server", "Azure DevOps"};
        protected override void OnInitialized()
        {
            Layout.isHome = true;
        }

        protected async override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                //await jSRuntime.InvokeVoidAsync("generateAnimationAllScreen", DotNetObjectReference.Create(this));
            }
        }
    }
}
