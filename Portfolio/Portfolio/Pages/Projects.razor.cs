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
        public List<ProjectModel> ListProjectsSearched { get; set; }
        public ProjectModel? ProjectSelected { get; set; }
        public bool projectOpen = false;
        public Position Position { get; set; }
        public string? ValueSearched = null;
        protected override async Task OnInitializedAsync()
        {
            Layout.isHome = true;
            ListProjects  = ProjectService.getProjects();
            ListProjectsSearched = ListProjects.ToList();
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

        public void ValueSearchedChanged(string value)
        {
            ListProjectsSearched = ListProjects.Where(x => x.Name.ToLower().Contains(value.ToLower()) ||x.Language.ToLower().Contains(value.ToLower())).ToList();
            ValueSearched = value;
        }

        public void OpenProject(ProjectModel p)
        {
            ProjectSelected = p;
            projectOpen = true;
            StateHasChanged();
        }

        public void CloseProject()
        {
            ProjectSelected = null;
            projectOpen = false;
        }
    }
}
