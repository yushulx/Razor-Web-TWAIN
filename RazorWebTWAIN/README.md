# Razor Web TWAIN
A Razor class library for [Dynamic Web TWAIN](https://www.dynamsoft.com/web-twain/overview/). It allows you to add scanning functionality to your Blazor application.

## Dynamic Web TWAIN Version
v18.1

## Prerequisites
- Visual Studio 2022
- [Dynamic Web TWAIN license key](https://www.dynamsoft.com/customer/license/trialLicense?product=dwt)

## Quick Start
1. Import the `RazorWebTWAIN` package in the `_Imports.razor` file:
    ```cs
    @using RazorWebTWAIN
    ```
2. Add the following code to your razor page:

    ```csharp
    @page "/"
    @inject IJSRuntime JSRuntime
    @using System.Text.Json;

    <h1> Dynamic Web TWAIN Sample</h1>
    <select id="sources"></select>
    <br />
    <button @onclick="AcquireImage">Scan Documents</button>
    <button @onclick="LoadDocument">Load Documents</button>
    <button @onclick="RemoveSelected">Remove Selected</button>
    <button @onclick="RemoveAll">Remove All</button>
    <button @onclick="Save">Download Documents</button>

    <div id="document-container"></div>

    @code {
        JsInterop jsInterop;
        protected override void OnInitialized()
        {
            jsInterop = new JsInterop(JSRuntime);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await jsInterop.LoadDWT("LICENSE-KEY");
                await jsInterop.InitContainer("document-container", 640, 640);
                await jsInterop.GetDevices("sources");
            }
        }

        public async Task AcquireImage()
        {
            // https://www.dynamsoft.com/web-twain/docs/info/api/WebTwain_Acquire.html#acquireimageasync
            var deviceConfiguration = new {
                IfShowUI = false,
                PixelType = PixelType.TWPT_RGB,
                Resolution = 300,
                IfFeederEnabled = true,
                IfDuplexEnabled = false,
                IfDisableSourceAfterAcquire = true,
                IfGetImageInfo = true,
                IfGetExtImageInfo = true,
                extendedImageInfoQueryLevel = 0
            };
            // serialize the object to a JSON string
            var jsonString = JsonSerializer.Serialize(deviceConfiguration);

            await jsInterop.AcquireImage(jsonString);

        }

        public async Task LoadDocument()
        {
            await jsInterop.LoadDocument();
        }

        public async Task RemoveSelected()
        {
            await jsInterop.RemoveSelected();
        }

        public async Task RemoveAll()
        {
            await jsInterop.RemoveAll();
        }

        public async Task Save()
        {
            await jsInterop.Save(ImageType.PDF, "test");
        }
    }

    ```

3. Run your project:

    ![.NET MAUI Blazor: scan documents with Dynamic Web TWAIN](https://www.dynamsoft.com/codepool/img/2023/04/dotnet-maui-windows-document-scanner.png)