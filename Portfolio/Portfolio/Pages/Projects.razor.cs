using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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
        protected override void OnInitialized()
        {
            Layout.isHome = true;
            ListProjects  = ProjectService.getProjects();
        }

        protected async override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                await jSRuntime.InvokeVoidAsync("generateAnimationAllScreen", DotNetObjectReference.Create(this));
            }
        }
    }
}
