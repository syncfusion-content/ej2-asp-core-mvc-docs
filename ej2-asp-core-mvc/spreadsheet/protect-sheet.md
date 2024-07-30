---
layout: post
title: Protect Sheet in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about Protect Sheet in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Protect Sheet
publishingplatform: ##Platform_Name##
documentation: ug
---


# Protection in Spreadsheet Control

Sheet protection helps you to prevent the users from modifying the data in the spreadsheet.

## Protect Sheet

Protect sheet feature helps you to prevent the unknown users from accidentally changing, editing, moving, or deleting data in a spreadsheet. And you can also protect the sheet with password. You can use the [`isProtected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_IsProtected) property to enable or disable the Protecting functionality.

N> The default value for `isProtected` property is `false`.

By default in protected sheet, selecting, formatting, inserting, deleting functionalities are disabled. To enable some of the above said functionalities the `protectSettings` options are used in a protected spreadsheet.

The available `protectSettings` options in spreadsheet are,

| Options | Uses |
|-----|------|
| `Select Cells` | Used to perform Cell Selection. |
| `Format Cells` | Used to perform Cell formatting. |
| `Format Rows` | Used to perform Row formatting. |
| `Format Columns` | Used to perform Column formatting. |
| `Insert Link` | Used to perform Hyperlink Insertions. |

N> * The default value for all `protectSettings` options are `false`.

By default, the `Protect Sheet` module is injected internally into the Spreadsheet to perform sheet protection function.

**User Interface**:

In the active Spreadsheet, the sheet protection can be done by any of the following ways:

* Select the Protect Sheet item in the Ribbon toolbar under the Data Tab, and then select your desired options.
* Right-click the sheet tab, select the Protect Sheet item in the context menu, and then select your desired options.
* Use the `protectSheet()` method programmatically.

The following example shows `Protect Sheet` functionality with password in the Spreadsheet control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/protect-sheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ProtectSheetController.cs" %}
{% include code-snippet/spreadsheet/protect-sheet/protectSheetController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/protect-sheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ProtectSheetController.cs" %}
{% include code-snippet/spreadsheet/protect-sheet/protectSheetController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Limitations of Protect sheet

* Password encryption is not supported

## Unprotect Sheet

Unprotect sheet is used to enable all the functionalities that are already disabled in a protected spreadsheet.

**User Interface**:

In the active Spreadsheet, the sheet Unprotection can be done by any of the following ways:

* Select the `Unprotect Sheet` item in the Ribbon toolbar under the Data Tab.
* Right-click the sheet tab, select the `Unprotect Sheet` item in the context menu.
* Use the `unprotectSheet()` method programmatically.

## Unlock the particular cells in the protected sheet

In protected spreadsheet, to make some particular cell or range of cells are editable, you can use `lockCells()` method, with the parameter `range` and `isLocked` property as false.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/lock-cells/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LockCellController.cs" %}
{% include code-snippet/spreadsheet/lock-cells/lockCellController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/lock-cells/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LockCellController.cs" %}
{% include code-snippet/spreadsheet/lock-cells/lockCellController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Make cells read-only without protecting worksheet

Previously, you could make cells read-only by protecting the entire sheet using the `protectSheet` method or through the UI option. Meanwhile, to make a specific range of cells editable within a protected sheet, you needed to use the `lockCells` method, passing the `range` parameter and setting the `isLocked` property to **false**. 

Now, you can make an entire row, an entire column, or a specific range of cells read-only using the `setRangeReadOnly` method without protecting the entire sheet. This method accepts three parameters, as detailed in the following table:

| Parameter | Description |
|-----|------|
| `readOnly` | Specifies whether an entire row, an entire column, or a specific range of cells should be set as read-only (**true**) or editable (**false**). |.
| `range` | Specifies the particular range of cells to be set as read-only. |
| `sheetIndex` | Specifies the index of the sheet. |

You can make an entire row, an entire column, or a specific range of cells read-only by passing the range as shown in the code snippet below:

```js
// To set read-only for single cell.
spreadsheet.setRangeReadOnly(true, 'A2', 0)
// To set read-only for range of cells.
spreadsheet.setRangeReadOnly(true, 'A2:B5', 0)
// To set read-only for entire row.
spreadsheet.setRangeReadOnly(true, '3:3', 0)
// To set read-only for entire column.
spreadsheet.setRangeReadOnly(true, 'A:A', 0)
```

You can make the cells read-only in the cell data binding by setting the `isReadOnly` property to **true** for the respective rows, columns, and cells.

The following example demonstrates how to make rows, columns, and cells read-only without protecting the sheet:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/read-only/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnlyController.cs" %}
{% include code-snippet/spreadsheet/read-only/readOnlyController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/read-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnlyController.cs" %}
{% include code-snippet/spreadsheet/read-only/readOnlyController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Protect Workbook

Protect workbook feature helps you to protect the workbook so that users cannot insert, delete, rename, hide the sheets in the spreadsheet.

You can use the [`password`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_Password) property to protect workbook with password.

You can use the [`isProtected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_IsProtected) property to protect or unprotect the workbook without the password.

N> The default value for `isProtected` property is `false`.

**User Interface**:

In the active Spreadsheet, you can protect the worksheet by selecting the Data tab in the Ribbon toolbar and choosing the `Protect Workbook` item. Then, enter the password and confirm it and click on OK.

The following example shows `Protect Workbook` by using the [`isProtected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_IsProtected) property in the Spreadsheet control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/protect-workbook/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ProtectWorkbookController.cs" %}
{% include code-snippet/spreadsheet/protect-workbook/protectWorkbookController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/protect-workbook/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ProtectWorkbookController.cs" %}
{% include code-snippet/spreadsheet/protect-workbook/protectWorkbookController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following example shows `Protect Workbook` by using the [`password`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_Password) property in the Spreadsheet control. To unprotect the workbook, click the unprotect workbook button in the data tab and provide the password as syncfusion in the dialog box.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/password/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PasswordController.cs" %}
{% include code-snippet/spreadsheet/password/passwordController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/password/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PasswordController.cs" %}
{% include code-snippet/spreadsheet/password/passwordController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Unprotect Workbook

Unprotect Workbook is used to enable the insert, delete, rename, move, copy, hide or unhide sheets feature  in the spreadsheet.

**User Interface**:

In the active Spreadsheet, the workbook Unprotection can be done in any of the following ways:

* Select the `Unprotect Workbook` item in the Ribbon toolbar under the Data Tab and provide the valid password in the dialog box.

## See Also

* [Hyperlink](./link)