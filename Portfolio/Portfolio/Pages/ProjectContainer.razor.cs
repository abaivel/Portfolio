using Microsoft.AspNetCore.Components;
using Portfolio.Models;

namespace Portfolio.Pages
{
    public partial class ProjectContainer
    {
        [Parameter]
        public ProjectModel Project { get; set; }
    }
}
