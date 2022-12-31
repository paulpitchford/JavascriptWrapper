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

        public async Task SayHi()
        {
            await _jsRuntime.InvokeVoidAsync("sayHi");
        }

        public async Task SayName(string name)
        {
            await _jsRuntime.InvokeVoidAsync("sayName", name);
        }
    }
}
