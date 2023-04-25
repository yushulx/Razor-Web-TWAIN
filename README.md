# Dynamic Web TWAIN for Blazor
The repository contains a Razor class library for [Dynamic Web TWAIN](https://www.dynamsoft.com/web-twain/overview/) and two sample projects for using the library on Windows and Web.

## Example
- [.NET MAUI Blazor](https://github.com/yushulx/Razor-Web-TWAIN/tree/main/example/MauiDocumentScanner)
    
    ![.NET MAUI Blazor: scan documents with Dynamic Web TWAIN](https://www.dynamsoft.com/codepool/img/2023/04/dotnet-maui-windows-document-scanner.png)

- [Blazor WebAssembly](https://github.com/yushulx/Razor-Web-TWAIN/tree/main/example/web)

    ![Blazor WebAssembly: scan documents with Dynamic Web TWAIN](https://www.dynamsoft.com/codepool/img/2023/04/dotnet-blazor-web-document-scanner.png)

## How to Run the Example
1. Import the project into Visual Studio 2022.
2. Replace the [license key](https://www.dynamsoft.com/customer/license/trialLicense?product=dwt) in `Index.razor` with your own.
    ```cs
    await jsInterop.LoadDWT("LICENSE-KEY");
    ```
3. Run the project.
    
    