---
layout: post
title: Custom Toolbar in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Custom Toolbar in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom toolbar in ASP.NET Core Grid component

Custom toolbar in Syncfusion ASP.NET Core Grid allows you to create a distinctive toolbar layout, style, and functionality that aligns with the specific needs of your application, providing a personalized experience within the Grid component.

This can be achieved by utilizing the [toolbarTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarTemplate) property, which offers extensive customization options for the toolbar. You can define a custom template for the toolbar and handle the actions of the toolbar items in the [clicked](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.navigations.toolbar.html#Syncfusion_EJ2_Navigations_Toolbar_Clicked) event.

The following example demonstrates, how to render the custom toolbar using `toolbarTemplate`

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/customtoolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="custom-toolbar.cs" %}
{% include code-snippet/grid/toolbar/customtoolbar/custom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Custom toolbar](../images/toolbar/customtoolbar.png)

## Render image with text in custom toolbar

Render an image with text in custom toolbar in Syncfusion ASP.NET Core Grid allows easily render an image along with text in the toolbar of the Grid. This feature enhances the visual presentation of the Grid, providing additional context and improving the overall experience.

To render an image with text in custom toolbar, This can be achieved by utilizing the [toolbarTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarTemplate)property.

The following example demonstrates how to render an image in the toolbar of the grid using `toolbarTemplate`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/customtoolbar-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="custom-toolbar.cs" %}
{% include code-snippet/grid/toolbar/customtoolbar-image/custom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Render image with text in custom toolbar](../images/toolbar/customtoolbar-image.png)

> You can further customize the styles and layout of the image and text in the custom toolbar to suit your specific design requirements.

## Render DropDownList in custom toolbar

Render DropDownList in custom toolbar in Syncfusion ASP.NET Core Grid enables you to extend the functionality of the custom toolbar by incorporating a [DropDownList](https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started) component, allowing you to perform various actions within the Grid based on their selections.

This can be achieved by utilizing the [toolbarTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarTemplate). The example below demonstrates how to render the **DropDownList** component in the custom toolbar, where the toolbar template includes the its [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event is bound to the **onChange** method.

In the **onChange** method, the text of the selected item is checked to determine the appropriate action. For example, if **Update** is chosen, the `endEdit` method is called to exit the edit mode. If **Edit** is selected, the selected record is passed to the `startEdit` method to initiate the edit mode dynamically. Similarly, if **Delete** is picked, the selected record is passed to the `deleteRecord` method to remove it from the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/customtoolbar-dropdownlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="custom-toolbar.cs" %}
{% include code-snippet/grid/toolbar/customtoolbar-dropdownlist/custom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Render DropDownList in custom toolbar](../images/toolbar/customtoolbar-dropdownlist.png)

## Render a component or element using the toolbar template

Rendering a component or element using the toolbar template in the Syncfusion ASP.NET Core Grid allows you to extend the capabilities of the grid toolbar by incorporating custom components or elements. This provides flexibility to enhance the toolbar with custom buttons, dropdowns, input fields, icons, or any other desired UI elements. You can bind event handlers or handle interactions within the template to enable specific actions or behaviors associated with the added components or elements.

To render custom components or elements within the toolbar, use the [toolbarTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarTemplate). This allows you to include other components, such as a [Button](https://ej2.syncfusion.com/aspnetcore/documentation/button/getting-started), and perform specific grid actions based on the button click. For example, when the **ExcelExport** button is clicked, the `excelExport` method is called to export the grid to Excel. Similarly, when the **PdfExport** button is clicked, the `pdfExport` method is called to export the grid to PDF format.Likewise, when the **Print** button is clicked, the `print` method will triggered to print the grid.

The following example demonstrates how to render a **Button** component in the toolbar using `toolbarTemplate` and perform grid action based on the respected button click.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/customtoolbar-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="custom-toolbar.cs" %}
{% include code-snippet/grid/toolbar/customtoolbar-template/custom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Render a component or element using the toolbar template](../images/toolbar/customtoolbar-element.png)