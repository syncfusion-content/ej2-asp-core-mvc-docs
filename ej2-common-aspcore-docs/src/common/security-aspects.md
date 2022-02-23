# Security Aspects

This documentation will help to develop a secure ASP.NET Core MVC web application with Syncfusion Components.

## Applicable Security Aspects

Syncfusion ASP.NET Core components are applicable for the below security aspects to secure the web application.

   * Cross-Site Scripting
   * Injection
   * Broken Authentication
   * Sensitive Data Exposure
   * XML External Entities

### Cross-Site Scripting and Injection

Cross-Site Scripting is a security vulnerability and a client-side injection attack. Attackers inject the malicious code in a web application, usually JavaScript but could also be HTML or CSS.

To prevent this aspect, we have provided the API `EnableHtmlSanitizer` and its default value is set to true.

For more details, please refer to the API documentation for our Syncfusion ASP.NET Core controls that are having ‘EnableHtmlSanitizer’ property. Some of them are listed below for reference.

* [ToolBar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarBuilder.html#Syncfusion_EJ2_Navigations_ToolbarBuilder_EnableHtmlSanitizer_System_Boolean_)
* [Menu](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_EnableHtmlSanitizer)
* [Accordion](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Accordion.html#Syncfusion_EJ2_Navigations_Accordion_EnableHtmlSanitizer)

Also, we can find the documentation about preventing these security aspects from the components section in our user guide that are applicable to it. Here, you can refer to the documentation links for about preventing Cross-Site scripting in [Grid]( https://ej2.syncfusion.com/aspnetcore/documentation/grid/how-to/#perform-crud-operation-using-anti-forgery-token) and [RichTextEditor](https://ej2.syncfusion.com/aspnetcore/documentation/rich-text-editor/miscellaneous/#prevention-of-cross-site-scripting-xss).

### Application level aspects

For other security threats like **Broken Authentication, Sensitive Data Exposure, XML External Entities**, we need to be configured from the application end. And, we would like to recommend the following [Syncfusion blog](https://www.syncfusion.com/blogs/post/10-practices-secure-asp-net-core-mvc-app.aspx) to develop an ASP.NET Core MVC web application securely.