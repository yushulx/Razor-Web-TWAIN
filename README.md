# Dynamic Web TWAIN for Blazor
The repository contains a Razor class library for Dynamic Web TWAIN and a sample project for using the library.

## How to Run the Sample
1. Import the project into Visual Studio 2022.
2. Replace the [license key](https://www.dynamsoft.com/customer/license/trialLicense?product=dwt) in `MauiDocumentScanner\Pages\Index.razor` with your own.
    ```cs
    await jsInterop.LoadDWT("LICENSE-KEY");
    ```
3. Run the project.
    
    ![.NET MAUI Blazor: scan documents with Dynamic Web TWAIN](https://www.dynamsoft.com/codepool/img/2023/04/dotnet-maui-windows-document-scanner.png)