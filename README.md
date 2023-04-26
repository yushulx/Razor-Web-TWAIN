# Dynamic Web TWAIN for Blazor
The repository contains a Razor class library for [Dynamic Web TWAIN](https://www.dynamsoft.com/web-twain/overview/) and two sample projects for using the library on Windows and Web.

## Example
- [.NET MAUI Blazor](https://github.com/yushulx/Razor-Web-TWAIN/tree/main/example/MauiDocumentScanner)
    
    ![.NET MAUI Blazor: scan documents with Dynamic Web TWAIN](https://camo.githubusercontent.com/7ef7a507d341011a71fe687ac15bb0212b398c0f187db8df1672c784243b7f9c/68747470733a2f2f7777772e64796e616d736f66742e636f6d2f636f6465706f6f6c2f696d672f323032332f30342f646f746e65742d6d6175692d77696e646f77732d646f63756d656e742d7363616e6e65722e706e67)

- [Blazor WebAssembly](https://github.com/yushulx/Razor-Web-TWAIN/tree/main/example/web)

    ![Blazor WebAssembly: scan documents with Dynamic Web TWAIN](https://camo.githubusercontent.com/9118868842619b7454460ec606a18824b873e264237903b62bf5775095aba377/68747470733a2f2f7777772e64796e616d736f66742e636f6d2f636f6465706f6f6c2f696d672f323032332f30342f646f746e65742d626c617a6f722d7765622d646f63756d656e742d7363616e6e65722e706e67)

## How to Run the Example
1. Import the project into Visual Studio 2022.
2. Replace the [license key](https://www.dynamsoft.com/customer/license/trialLicense?product=dwt) in `Index.razor` with your own.
    ```cs
    await jsInterop.LoadDWT("LICENSE-KEY");
    ```
3. Run the project.
    
## Blog
[How to Build Desktop and Web Document Scanning App Using .NET MAUI and Blazor](https://www.dynamsoft.com/codepool/dotnet-maui-blazor-document-scanning.html)
