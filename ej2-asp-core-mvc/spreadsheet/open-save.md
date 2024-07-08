---
layout: post
title: Open Save in ##Platform_Name## Syncfusion Spreadsheet Component
description: Learn here all about Open Save in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Open Save
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open and Save in Spreadsheet control

To import an excel file, it needs to be read and converted to client side Spreadsheet model. The converted client side Spreadsheet model is sent as JSON which is used to render Spreadsheet. Similarly, when you save the Spreadsheet, the client Spreadsheet model is sent to the server as JSON for processing and saved. Server configuration is used for this process.

## Open

The Spreadsheet component opens an Excel document with its data, style, format, and more. To enable this feature, set [`allowOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowOpen) as `true` and assign service url to the [`openUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_OpenUrl) property.

**User Interface**:

In user interface you can open an Excel document by clicking `File > Open` menu item in ribbon.

The following sample shows the `Open` option by using the [`openUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_OpenUrl) property in the Spreadsheet control. You can also use the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeOpen) event to trigger before opening an Excel file.

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



Find the below table for the beforeOpen event arguments.

 | **Parameter** | **Type** | **Description** |
| ----- | ----- | ----- |
| file | FileList or string or File | To get the file stream. `FileList` -  contains length and item index. <br/> `File` - specifies the file lastModified and file name. |
| cancel | boolean | To prevent the open operation. |
| requestData | object |  To provide the Form data. |

N> * Use `Ctrl + O` keyboard shortcut to open Excel documents.
<br/> * The default value of the [allowOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowOpen) property is `true`. For demonstration purpose, we have showcased the [allowOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowOpen) property in previous code snippet.

### Open an external URL excel file while initial load

You can achieve to access the remote excel file by using the [`created`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_Created) event. In this event you can fetch the excel file and convert it to a blob. Convert this blob to a file and `open` this file by using Spreadsheet component open method.

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

### To add custom header during open

You can add your own custom header to the open action in the Spreadsheet. For processing the data, it has to be sent from server to client side and adding customer header can provide privacy to the data with the help of Authorization Token. Through the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeOpen) event, the custom header can be added to the request during open action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-header/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-header/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Open excel file into a read-only mode

You can open excel file into a read-only mode by using the [`openComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_OpenComplete) event. In this event, you must protect all the sheets and lock its used range cells by using `protectSheet` and `lockCells` methods.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-readonly/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-readonly/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-readonly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-readonly/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Open an excel file using a file uploader

If you explore your machine to select and upload an excel document using the file uploader, you will receive the uploaded document as a raw file in the `success` event of the file uploader. In this `success` event, you should pass the received raw file as an argument to the Spreadsheet's `open` method to see the appropriate output.

The following code example shows how to import an excel document using file uploader in spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-uploader/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-uploader/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-uploader/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-uploader/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Configure JSON deserialization options

Previously, when opening a workbook JSON object into the Spreadsheet using the `openFromJson` method, the entire workbook, including all features specified in the JSON object, was processed and loaded into the Spreadsheet. 

Now, you have the option to selectively ignore some features during the opening of the JSON object by configuring deserialization options and passing them as arguments to the `openFromJson` method. This argument is optional, and if not configured, the entire workbook JSON object will be loaded without ignoring any features.

```ts
spreadsheet.openFromJson({ file: file }, { ignoreStyle: true });
```

| Options | Description |
| ----- | ----- |
| onlyValues |  If **true**, only the cell values will be loaded. |
| ignoreStyle | If **true**, styles will be excluded when loading the JSON data. |
| ignoreFormula | If **true**, formulas will be excluded when loading the JSON data. |
| ignoreFormat | If **true**, number formats will be excluded when loading the JSON data. |
| ignoreConditionalFormat | If **true**, conditional formatting will be excluded when loading the JSON data. |
| ignoreValidation | If **true**, data validation rules will be excluded when loading the JSON data. |
| ignoreFreezePane | If **true**, freeze panes will be excluded when loading the JSON data. |
| ignoreWrap | If **true**, text wrapping settings will be excluded when loading the JSON data. |
| ignoreChart | If **true**, charts will be excluded when loading the JSON data. |
| ignoreImage | If **true**, images will be excluded when loading the JSON data. |
| ignoreNote | If **true**, notes will be excluded when loading the JSON data. |

The following code snippet demonstrates how to configure the deserialization options and pass them as arguments to the openFromJson method:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-from-json/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/open-from-json/openController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-from-json/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/open-from-json/openController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Open an excel file from Base64 string data

In the Syncfusion Spreadsheet component, there is no direct option to open data as a `Base64` string. To achieve this, the `import()` function fetches the `Base64` string, converts it to a Blob, creates a File object from the Blob, and then opens it using the `open` method in the spreadsheet.

The following code example shows how to open the spreadsheet data as base64 string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/base-64-string/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/base-64-string/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/base-64-string/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/base-64-string/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### To open an excel file from blob data

By default, the Spreadsheet control provides an option to browse files from the local file system and open them within the control. If you want to open an Excel file from blob data, you need to fetch the blob data from the server or another source and convert this blob data into a `File` object. Then, you can use the `open` method in the Spreadsheet control to load that `File` object.

Please find the code to fetch the blob data and load it into the Spreadsheet control below.

### External workbook confirmation dialog

When you open an excel file that contains external workbook references, you will see a confirmation dialog. This dialog allows you to either continue with the file opening or cancel the operation. This confirmation dialog will appear only if you set the `AllowExternalWorkbook` property value to **false** during the open request, as shown below. This prevents the spreadsheet from displaying inconsistent data.

```csharp
public IActionResult Open(IFormCollection openRequest)
    {
        OpenRequest open = new OpenRequest();
        open.AllowExternalWorkbook = false;
        open.File = openRequest.Files[0];
        return Content(Workbook.Open(open));
    }
```

> This feature is only applicable when importing an Excel file and not when loading JSON data or binding cell data.

![External workbook confirmation dialog](./images/external-reference-dialog-alert.png)

## Supported file formats

The following list of Excel file formats are supported in Spreadsheet:

* Microsoft Excel (.xlsx)
* Microsoft Excel 97-2003 (.xls)
* Comma Separated Values (.csv)
* Excel Macro-Enabled Workbook (.xlsm)
* Excel Binary Workbook(.xlsb)

## Save

The Spreadsheet component saves its data, style, format, and more as Excel file document. To enable this feature, set [`allowSave`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowSave) as `true` and assign service url to the [`saveUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SaveUrl) property.

**User Interface**:

In user interface, you can save Spreadsheet data as Excel document by clicking `File > Save As` menu item in ribbon.

The following sample shows the `Save` option by using the [`saveUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SaveUrl) property in the Spreadsheet control. You can also use the [`beforeSave`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeSave) event to trigger before saving the Spreadsheet as an Excel file.

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



Find the below table for the beforeSave event arguments.

| **Parameter** | **Type** | **Description** |
| ----- | ----- | ----- |
| url | string |  Specifies the save url.  |
| fileName | string | Specifies the file name. |
| saveType | SaveType | Specifies the saveType like `Xlsx`, `Xls`, `Csv` and `Pdf`. |
| customParams | object | Passing the custom parameters from client to server while performing save operation. |
| isFullPost | boolean | It sends the form data from client to server, when set to true. It fetches the data from client to server and returns the data from server to client, when set to false. |
| needBlobData | boolean | You can get the blob data if set to true. |
| cancel | boolean | To prevent the save operations. |

N> * Use `Ctrl + S` keyboard shortcut to save the Spreadsheet data as Excel file.
<br/> * The default value of [allowSave](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowSave) property is `true`. For demonstration purpose, we have showcased the [allowSave](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowSave) property in previous code snippet.
<br/> * Demo purpose only, we have used the online web service url link.

### To send and receive custom params from client to server

Passing the custom parameters from client to server by using [`beforeSave`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeSave) event.

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

### To add custom header during save

You can add your own custom header to the save action in the Spreadsheet. For processing the data, it has to be sent from client to server side and adding customer header can provide privacy to the data with the help of Authorization Token. Through the [`fileMenuItemSelect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_FileMenuItemSelect) event, the custom header can be added to the request during save action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/save-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomHeaderController.cs" %}
{% include code-snippet/spreadsheet/save-header/CustomHeaderController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/save-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomHeaderController.cs" %}
{% include code-snippet/spreadsheet/save-header/CustomHeaderController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### To change the PDF orientation

By default, the PDF document is created in **Portrait** orientation. You can change the orientation of the PDF document by using the `args.pdfLayoutSettings.orientation` argument settings in the [`beforeSave`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeSave) event.

The possible values are:

* **Portrait** - Used to display content in a vertical layout.
* **Landscape** - Used to display content in a horizontal layout.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/pdf-orientation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="pdfOrientationController.cs" %}
{% include code-snippet/spreadsheet/pdf-orientation/pdfOrientationController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/pdf-orientation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="pdfOrientationController.cs" %}
{% include code-snippet/spreadsheet/pdf-orientation/pdfOrientationController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Configure JSON serialization options

Previously, when saving the Spreadsheet as a workbook JSON object using the `saveAsJson` method, the entire workbook with all loaded features were processed and saved as a JSON object. 

Now, you have the option to selectively ignore some features while saving the Spreadsheet as a JSON object by configuring serialization options and passing them as arguments to the `saveAsJson` method. This argument is optional, and if not configured, the entire workbook JSON object will be saved without ignoring any features.

```ts
spreadsheet.saveAsJson({ onlyValues: true });
```

| Options | Description |
| ----- | ----- |
| onlyValues |  If **true**, includes only the cell values in the JSON output. |
| ignoreStyle | If **true**, excludes styles from the JSON output. |
| ignoreFormula | If **true**, excludes formulas from the JSON output. |
| ignoreFormat | If **true**, excludes number formats from the JSON output. |
| ignoreConditionalFormat | If **true**, excludes conditional formatting from the JSON output. |
| ignoreValidation | If **true**, excludes data validation rules from the JSON output. |
| ignoreFreezePane | If **true**, excludes freeze panes from the JSON output. |
| ignoreWrap | If **true**, excludes text wrapping settings from the JSON output. |
| ignoreChart | If **true**, excludes charts from the JSON output. |
| ignoreImage | If **true**, excludes images from the JSON output. |
| ignoreNote | If **true**, excludes notes from the JSON output. |

The following code snippet demonstrates how to configure the serialization options and pass them as arguments to the saveAsJson method:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/save-as-json/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SaveController.cs" %}
{% include code-snippet/spreadsheet/save-as-json/saveController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/save-as-json/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SaveController.cs" %}
{% include code-snippet/spreadsheet/save-as-json/saveController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### To save data as a Base64 string

In the Spreadsheet control, there is currently no direct option to save data as a `Base64` string. You can achieve this by saving the Spreadsheet data as blob data and then converting that saved blob data to a `Base64` string using `FileReader`. 

> You can get the Spreadsheet data as blob in the [saveComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.spreadsheet.spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SaveComplete) event when you set the  `needBlobData` as **true** and `isFullPost` as **false** in the [beforeSave](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.spreadsheet.spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeSave) event.

The following code example shows how to save the spreadsheet data as base64 string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/base-64-string/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/base-64-string/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/base-64-string/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/base-64-string/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### To save an excel file as blob data

By default, the Spreadsheet control saves the Excel file and downloads it to the local file system. If you want to save an Excel file as blob data, you need to set `needBlobData` property to **true** and `isFullPost` property to **false** in the `beforeSave` event of the spreadsheet. Subsequently, you will receive the spreadsheet data as a blob in the `saveComplete` event. You can then post the blob data to the server endpoint for saving.

Please find below the code to retrieve blob data from the Spreadsheet control below.

### Supported file formats

The following list of Excel file formats are supported in Spreadsheet:

* Microsoft Excel (.xlsx)
* Microsoft Excel 97-2003 (.xls)
* Comma Separated Values (.csv)
* Portable Document Format (.pdf)

### Methods

To save the Spreadsheet document as an `xlsx, xls, csv, or pdf` file, by using `save` method should be called with the `url`, `fileName` and `saveType` as parameters. The following code example shows to save the spreadsheet file as an `xlsx, xls, csv, or pdf` in the button click event.

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

N> * Refer the above open and save operation to shows the create a server using WebAPI configuration for Excel import and export. In ASP.NET Core and ASP.NET MVC you can configure the server in controller.

## Server Dependencies

Open and save helper functions are shipped in the Syncfusion.EJ2.Spreadsheet package, which is available in Essential Studio and [`nuget.org`](https://www.nuget.org/). Following list of dependencies required for Spreadsheet open and save operations.

| **Platforms** | **Assembly** | **Nuget Package** |
| ----- | ----- | ----- |
| ASP.NET Core (Targeting .NET Core) | Syncfusion.EJ2.AspNet.Core <br/> Syncfusion.EJ2.Spreadsheet.AspNet.Core <br/> Syncfusion.Compression.Net.Core <br/> Syncfusion.XlsIO.Net.Core <br/> Syncfusion.XlsIORenderer.Net.Core <br/> | [Syncfusion.EJ2.Spreadsheet.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.Spreadsheet.AspNet.Core) <br/> [Syncfusion.XlsIORenderer.Net.Core](https://www.nuget.org/packages/Syncfusion.XlsIORenderer.Net.Core) |
| ASP.NET MVC4 | Syncfusion.EJ2.MVC4 <br/>Syncfusion.EJ2.Spreadsheet.AspNet.MVC4 <br/> Syncfusion.Compression.Base <br/> Syncfusion.XlsIO.AspNet.Mvc4 <br/> Syncfusion.ExcelToPdfConverter.AspNet.Mvc4 <br/> | [Syncfusion.EJ2.Spreadsheet.AspNet.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.Spreadsheet.AspNet.MVC4) <br/> [Syncfusion.ExcelToPdfConverter.AspNet.Mvc4](https://www.nuget.org/packages/Syncfusion.ExcelToPdfConverter.AspNet.Mvc4) |
| ASP.NET MVC5 | Syncfusion.EJ2.MVC5 <br/>Syncfusion.EJ2.Spreadsheet.AspNet.MVC5 <br/> Syncfusion.Compression.Base <br/> Syncfusion.XlsIO.AspNet.Mvc5 <br/> Syncfusion.ExcelToPdfConverter.AspNet.Mvc5 <br/> | [Syncfusion.EJ2.Spreadsheet.AspNet.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.Spreadsheet.AspNet.MVC5) <br/> [Syncfusion.ExcelToPdfConverter.AspNet.Mvc5](https://www.nuget.org/packages/Syncfusion.ExcelToPdfConverter.AspNet.Mvc5) |


## See Also

* [Filtering](filter)
* [Sorting](sort)
* [Hyperlink](link)
