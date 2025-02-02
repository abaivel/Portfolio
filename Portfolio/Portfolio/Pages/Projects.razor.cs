using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using Portfolio.Layout;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages
{
    public partial class Projects
    {
        [Inject] public IJSRuntime jSRuntime { get; set; } = default!;
        [CascadingParameter]
        public MainLayout Layout { get; set; }

        public List<ProjectModel> ListProjects { get; set; }

        public Position Position { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Layout.isHome = true;
            ListProjects  = ProjectService.getProjects();
            var res = await jSRuntime.InvokeAsync<bool>("isDevice", "");
            if (res)
            {
                Position = Position.Top;
            }
            else
            {
                Position = Position.Left;
            }
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
