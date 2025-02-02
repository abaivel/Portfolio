using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using Portfolio.Layout;

namespace Portfolio.Pages
{
    public partial class Home
    {
        [Inject] public IJSRuntime jSRuntime { get; set; } = default!;
        [CascadingParameter]
        public MainLayout Layout { get; set; }
        public int Age { get; set; } = 21;
        protected override void OnInitialized()
        {
            Layout.isHome = true;
            Age = (DateTime.Now.Year - 2003) - ((DateTime.Now<new DateTime(DateTime.Now.Year, 12,15)) ? 1 : 0);
        }

        protected async override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                await jSRuntime.InvokeVoidAsync("generateAnimationHome", DotNetObjectReference.Create(this));
            }
        }
    }
}
