using Microsoft.JSInterop;

namespace JavascriptWrapper.Services
{
    public class PaulsMessageService
    {
        private IJSRuntime _jsRuntime;

        public PaulsMessageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task PressButton()
        {
            await _jsRuntime.InvokeVoidAsync("buttonPress");
        }

        public async Task SayName(string name)
        {
            await _jsRuntime.InvokeVoidAsync("sayName", name);
        }
    }
}
