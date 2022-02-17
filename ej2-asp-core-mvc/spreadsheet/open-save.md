---
layout: post
title: Open Save in ##Platform_Name## Spreadsheet Component
description: Learn here all about Open Save in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Open Save
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open and Save

To import an excel file, it needs to be read and converted to client side Spreadsheet model. The converted client side Spreadsheet model is sent as JSON which is used to render Spreadsheet. Similarly, when you save the Spreadsheet, the client Spreadsheet model is sent to the server as JSON for processing and saved. Server configuration is used for this process.

## Open

The Spreadsheet component opens an Excel document with its data, style, format, and more. To enable this feature, set [`allowOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowOpen) as `true` and assign service url to the [`openUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_OpenUrl) property.

**User Interface**:

In user interface you can open an Excel document by clicking `File > Open` menu item in ribbon.

The following sample shows the `Open` option by using the [`openUrl`](../api/spreadsheet/#openUrl) property in the Spreadsheet control. You can also use the [`beforeOpen`](../api/spreadsheet/#beforeOpen) event to trigger before opening an Excel file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Please find the below table for the beforeOpen event arguments.

 | **Parameter** | **Type** | **Description** |
| ----- | ----- | ----- |
| file | FileList or string or File | To get the file stream. `FileList` -  contains length and item index. <br/> `File` - specifies the file lastModified and file name. |
| cancel | boolean | To prevent the open operation. |
| requestData | object |  To provide the Form data. |

> * Use `Ctrl + O` keyboard shortcut to open Excel documents.
> * The default value of the [allowOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowOpen) property is `true`. For demonstration purpose, we have showcased the [allowOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowOpen) property in previous code snippet.

### Open an external URL excel file while initial load

You can achieve to access the remote excel file by using the [`created`](../api/spreadsheet/#created) event. In this event you can fetch the excel file and convert it to a blob. Convert this blob to a file and [`open`](../api/spreadsheet/#open) this file by using Spreadsheet component open method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-url/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-url/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Save

The Spreadsheet component saves its data, style, format, and more as Excel file document. To enable this feature, set [`allowSave`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowSave) as `true` and assign service url to the [`saveUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SaveUrl) property.

**User Interface**:

In user interface, you can save Spreadsheet data as Excel document by clicking `File > Save As` menu item in ribbon.

The following sample shows the `Save` option by using the [`saveUrl`](../api/spreadsheet/#saveUrl) property in the Spreadsheet control. You can also use the [`beforeSave`](../api/spreadsheet/#beforeSave) event to trigger before saving the Spreadsheet as an Excel file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/save/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Savecontroller.cs" %}
{% include code-snippet/spreadsheet/save/savecontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/save/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Savecontroller.cs" %}
{% include code-snippet/spreadsheet/save/savecontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Please find the below table for the beforeSave event arguments.

| **Parameter** | **Type** | **Description** |
| ----- | ----- | ----- |
| url | string |  Specifies the save url.  |
| fileName | string | Specifies the file name. |
| saveType | SaveType | Specifies the saveType like Xlsx, Xls, Csv and Pdf. |
| customParams | object | Passing the custom parameters from client to server while performing save operation. |
| isFullPost | boolean | It sends the form data from client to server, when set to true. It fetches the data from client to server and returns the data from server to client, when set to false. |
| needBlobData | boolean | You can get the blob data if set to true. |
| cancel | boolean | To prevent the save operations. |

> * Use `Ctrl + S` keyboard shortcut to save the Spreadsheet data as Excel file.
> * The default value of [allowSave](../api/spreadsheet/#allowsave) property is `true`. For demonstration purpose, we have showcased the [allowSave](../api/spreadsheet/#allowsave) property in previous code snippet.
> * Demo purpose only, we have used the online web service url link.

### To send and receive custom params from client to server

Passing the custom parameters from client to server by using [`beforeSave`](../api/spreadsheet/#beforeSave) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/custom-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomParamsController.cs" %}
{% include code-snippet/spreadsheet/custom-params/customParamsController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/custom-params/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomParamsController.cs" %}
{% include code-snippet/spreadsheet/custom-params/customParamsController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Methods

To save the Spreadsheet document as an `xlsx, xls, csv, or pdf` file, by using [save](../api/spreadsheet/#save) method should be called with the `url`, `fileName` and `saveType` as parameters. The following code example shows to save the spreadsheet file as an `xlsx, xls, csv, or pdf` in the button click event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-save/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OpenSaveController.cs" %}
{% include code-snippet/spreadsheet/open-save/openSaveController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-save/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OpenSaveController.cs" %}
{% include code-snippet/spreadsheet/open-save/openSaveController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Server Configuration

In Spreadsheet component, import and export operation processed in `server-side`, to use importing and exporting in your projects, it is required to create a server with any of the following web services.

* WebAPI
* WCF Service
* ASP.NET MVC Controller Action

> * Refer the above open and save operation to shows the create a server using WebAPI configuration for Excel import and export. In ASP.NET Core and ASP.NET MVC you can configure the server in controller.

## Server Dependencies

Open and save helper functions are shipped in the Syncfusion.EJ2.Spreadsheet package, which is available in Essential Studio and [`nuget.org`](https://www.nuget.org/). Following list of dependencies required for Spreadsheet open and save operations.

| **Platforms** | **Assembly** | **Nuget Package** |
| ----- | ----- | ----- |
| ASP.NET Core (Targeting .NET Core) | Syncfusion.EJ2.AspNet.Core <br/> Syncfusion.EJ2.Spreadsheet.AspNet.Core <br/> Syncfusion.Compression.Net.Core <br/> Syncfusion.XlsIO.Net.Core <br/> Syncfusion.XlsIORenderer.Net.Core <br/> | [Syncfusion.EJ2.Spreadsheet.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.Spreadsheet.AspNet.Core) <br/> [Syncfusion.XlsIORenderer.Net.Core](https://www.nuget.org/packages/Syncfusion.XlsIORenderer.Net.Core) |
| ASP.NET MVC4 | Syncfusion.EJ2.MVC4 <br/>Syncfusion.EJ2.Spreadsheet.AspNet.MVC4 <br/> Syncfusion.Compression.Base <br/> Syncfusion.XlsIO.AspNet.Mvc4 <br/> Syncfusion.ExcelToPdfConverter.AspNet.Mvc4 <br/> | [Syncfusion.EJ2.Spreadsheet.AspNet.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.Spreadsheet.AspNet.MVC4) <br/> [Syncfusion.ExcelToPdfConverter.AspNet.Mvc4](https://www.nuget.org/packages/Syncfusion.ExcelToPdfConverter.AspNet.Mvc4) |
| ASP.NET MVC5 | Syncfusion.EJ2.MVC5 <br/>Syncfusion.EJ2.Spreadsheet.AspNet.MVC5 <br/> Syncfusion.Compression.Base <br/> Syncfusion.XlsIO.AspNet.Mvc5 <br/> Syncfusion.ExcelToPdfConverter.AspNet.Mvc5 <br/> | [Syncfusion.EJ2.Spreadsheet.AspNet.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.Spreadsheet.AspNet.MVC5) <br/> [Syncfusion.ExcelToPdfConverter.AspNet.Mvc5](https://www.nuget.org/packages/Syncfusion.ExcelToPdfConverter.AspNet.Mvc5) |

## Supported File Formats

The following list of Excel file formats are supported in Spreadsheet:

* MS Excel (.xlsx)
* MS Excel 97-2003 (.xls)
* Comma Separated Values (.csv)

## See Also

* [Filtering](./filter)
* [Sorting](./sort)
* [Hyperlink](./link)