using Microsoft.AspNetCore.Components;
using Portfolio.Models;

namespace Portfolio.Pages
{
    public partial class PanelProject
    {
        [Parameter]
        public ProjectModel Project { get; set; }
    }
}
