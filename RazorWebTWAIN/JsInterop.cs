using Microsoft.JSInterop;

namespace RazorWebTWAIN
{
    public class JsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public JsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/RazorWebTWAIN/jsInterop.js").AsTask());
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        public async Task LoadDWT(String licenseKey)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("loadDWT", licenseKey);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }

        public async Task AcquireImage(string jsonString)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("acquireImage", jsonString);
        }

        public async Task InitContainer(string containerId, int width, int height)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("initContainer", containerId, width, height);
        }

        public async Task GetDevices(string selectId)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("getDevices", selectId);
        }
        public async Task LoadDocument()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("loadDocument");
        }

        public async Task RemoveSelected()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("removeSelected");
        }

        public async Task RemoveAll()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("removeAll");
        }

        public async Task Save(ImageType type, string name)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("save", type, name);
        }
    }
}