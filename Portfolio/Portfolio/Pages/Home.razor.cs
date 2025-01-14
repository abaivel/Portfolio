
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
        protected override void OnInitialized()
        {
            Layout.isHome = true;
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
