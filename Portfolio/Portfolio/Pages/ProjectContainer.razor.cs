using Microsoft.AspNetCore.Components;
using Portfolio.Models;
using static MudBlazor.CategoryTypes;

namespace Portfolio.Pages
{
    public partial class ProjectContainer
    {
        [Parameter]
        public ProjectModel Project { get; set; }

        public string iconFigma = "<path fill=\"#ffffff\" fill-rule=\"evenodd\" " +
            "d=\"M7 7c0 1.043.533 1.963 1.341 2.5A3 3 0 0 0 7 12c0 1.043.533 1.963 1.341 2.5A3 " +
            "3 0 1 0 13 17v-2.764A3 3 0 1 0 16.659 9.5 3 3 0 0 0 15 4h-5a3 3 0 0 0-3 3m8 2a2 " +
            "2 0 1 0 0-4h-2v4zm-2 3a2 2 0 1 0 4 0 2 2 0 0 0-4 0m-1 2h-2a2 2 0 1 1 0-4h2zm-2 " +
            "1h2v2a2 2 0 1 1-2-2m2-6h-2a2 2 0 1 1 0-4h2z\" clip-rule=\"evenodd\">" +
            "</path>";
    }
}
