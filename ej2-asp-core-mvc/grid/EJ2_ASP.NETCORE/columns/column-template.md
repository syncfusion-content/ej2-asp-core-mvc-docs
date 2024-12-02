---
layout: post
title: Column Template in ##Platform_Name## Grid Component
description: Learn here all about Column Template in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Template in ASP.NET Core Grid Component

Grid control provides a `template` option that allows you to display custom elements in a column instead of the field value. This can be useful when you need to display images, buttons, or other custom content within a column.

> When using template columns, they are primarily meant for rendering custom content and may not provide built-in support for grid actions like sorting, filtering, editing. It is must to define the `field` property of the column to perform any grid actions.

## Render image in a column

To render an image in a grid column, you need to define a `template` for the column using the template property. The `template` property expects the HTML element or a function that returns the HTML element.

The following example demonstrates how to define a `template` for the **Employee Image** field that displays an image element. The `template` property is set to the HTML element that contains an image tag. You have utilized the `src` and `alt` attributes to an image tag.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/template/template.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template Image](../images/column-template/column-template-image.png)

> The `template` option allows to define any HTML content within a column.

## Render hyperlink in a column

The Grid control provides support for rendering hyperlink columns and performing routing on click using the `template` property. This feature is useful when displaying data that requires a link to another page or website.

The following example demonstrates, how to render hyperlink column in the Grid using the `template` property of the `column`. To define a `template` for the column,  you can use the `template` with the `a` tag to create the hyperlink.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-template-hyperlink/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/column-template-hyperlink/column-template-hyperlink.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template HyberLink](../images/column-template/column-template-hyperlink.png)

>The window.open() method is a built-in JavaScript function that opens a new browser window or tab with the specified URL.

## Render other controls in a column

The column template has options to render a custom control in a grid column instead of a field value.

### Render LineChart control in a column

The [LineChart](https://ej2.syncfusion.com/aspnetcore/documentation/sparkline/getting-started) control of Syncfusion provides an elegant way to represent and compare data over time. It displays data points connected by straight line segments to visualize trends in data. 

In the following example, we have rendered the Sparkline Chart control in the Grid column by defining the `template` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-template-linechart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/column-template-linechart/column-template-linechart.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template LineChart](../images/column-template/column-template-linechart.png)

### Render ColorPicker control in a column

The [ColorPicker](https://ej2.syncfusion.com/aspnetcore/documentation/color-picker/getting-started) control of Syncfusion provides a user-friendly way to select colors from a pre-defined color palette or custom colors. It can be used in a variety of scenarios such as picking a theme color or changing the color of an element on a page.  

In the following code, we rendered the ColorPicker control in the Grid column by defining the `template` property.

```js
function colorPicker(args) {
  let inputElement = args.cell.querySelector('input')
    let colorPickerObject = new ej.inputs.ColorPicker({
      type: 'color',
      mode: 'Palette',
      change: change,
    });
    colorPickerObject.appendTo(inputElement);
  }
``` 
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-template-colorpicker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/column-template-colorpicker/column-template-colorpicker.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template ColorPicker](../images/column-template/column-template-colorpicker.gif)

### Render DropDownList control in a column

To render a custom control in a grid column, you need to define a `template` for the column using the `template` property. In the following code, we rendered the [DropDownList](https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started) control in the **Order Status** column by defining the `template` property.

```js
function dropdown(args) {
  if (args.column.field === 'OrderStatus') {
      let drop = new ej.dropdowns.DropDownList({
          dataSource: dropData,
          value: args.data['OrderStatus'],
          popupHeight: 150,
          popupWidth: 150,
      });
      drop.appendTo(args.cell.querySelector('#dropElement'));
  }
}
```
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-template-dropdownlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/column-template-dropdownlist/column-template-dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template Dropdownlist](../images/column-template/column-template-dropdownlist.png)

### Render Chip control in a column

The Grid control provides support for rendering [Chips](https://ej2.syncfusion.com/aspnetcore/documentation/chips/getting-started) control in a column using the `template` property. This feature is useful when displaying data that requires a chip control to be rendered in a column.

In the following code, we rendered the Chips control in the Grid **First Name** column by defining the `template` property.

```js
function queryCellInfo(args) {
  if (args.column.field === 'FirstName') {
    let chip = new ej.buttons.ChipList({
      text: args.data[args.column.field],
    });
    chip.appendTo(args.cell.querySelector('#chipElement'));
  }
}
```
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-template-chip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/column-template-chip/column-template-chip.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template Chip](../images/column-template/column-template-chip.png)

### Render ProgressBar control in a column

The Syncfusion Grid control supports rendering the [Progress Bar](https://ej2.syncfusion.com/aspnetcore/documentation/progress-bar/getting-started) control within a column using the `template`property. Displaying the `Progress Bar` control in a grid column allows users to visually track the progress of tasks or operations associated with specific records. This feature is particularly useful for applications involving processes such as data loading, task completion, or other progressive activities.

In the following code, the `Progress Bar` control render in the Grid **Freight** column by defining the `template` property.

```js
function queryCellInfo(args) {
  if (args.column.field === 'Freight') {
    let percentageProgress = new ej.progressbar.ProgressBar({
      type: 'Linear',
      height: '60',
      value: args.data['Freight'],
      trackThickness:24,
      progressThickness:20
    });
    percentageProgress.appendTo(args.cell.querySelector('#progressBarElement'));
  }
}
``` 
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-template-progressbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/column-template-progressbar/column-template-progressbar.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template ProgressBar](../images/column-template/column-template-progressbar.png)

## Using condition template

The conditional column `template` allows you to display template elements based on specific conditions.

The following example demonstrates how to use the `template` property with the `template` element and add the condition to render the checkbox based on the value of the **Discontinued** field. The **Discontinued** field will render a checkbox in each row for which the value of the **Discontinued** field is **true**. 

```
  <script id="template" type="text/x-template">
            <div class="template_checkbox">
                ${if(Discontinued)}
                <input type="checkbox" checked> ${else}
                <input type="checkbox"> ${/if}
            </div>
        </script>
```

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/condition-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/condition-template/template.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template Condition](../images/column-template/column-template-condition.png)

>You can use any template element or custom control instead of the checkbox in the conditional template based on your requirement.

## How to get the row object by clicking on the template element

The Grid control allows you to retrieve the row object of the selected record when clicking on a `template` element. This feature can be useful when you need to perform custom actions based on the selected record.

In the following code, the button element is rendered in the **Employee Data** column and `Click` event binding is used to call the showDetails method when the template element is clicked. The showDetails method is passed the data object as an argument, which allows you to access the selected row object and display it in the dialog popup.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/row-object/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-object.cs" %}
{% include code-snippet/grid/columns/row-object/row-object.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template RowDetail](../images/column-template/column-template-getRowDetails.gif)

## Use custom helper inside the template

The Syncfusion Grid allows you to use custom helpers inside the `template` property of a column. This feature allows you to create complex templates that can incorporate additional helper functions that are not available through the default `template` syntax.

To use the custom helper function inside a column template, you must first add the function to the template's context.

The following example illustrates how to implement a custom helper function within the template property, utilizing the `template` property specifically for the Freight column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-template-customhelper/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/column-template-customhelper/column-template-customhelper.cs %}
{% endhighlight %}
{% endtabs %}

![Column Template Custom-Helper](../images/column-template/column-template-customHelper.png)

> Custom helpers can only be used inside the template property of a column. 

## Dynamically adding template column

The Syncfusion Grid control allows you to dynamically add template columns at runtime. This capability is particularly useful when the structure of the grid needs to be modified based on individual interactions or other dynamic conditions.

Dynamically adding template columns involves creating and inserting columns with custom templates after the grid has been initialized. This approach provides flexibility in presenting data in a highly customizable manner.

The following example demonstrates how to add template column using external button click. In this example, the **ShipCountry** column with a [Dropdownlist](https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started) is added in column `template`, and an icon is displayed in the column header by using the `headerTemplate` for the **ShipCountry** column. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-template-adding-dynamically/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/column-template-adding-dynamically/column-tempate-adding-dynamically.cs %}
{% endhighlight %}
{% endtabs %}

![Column Dynamically Adding Template](../images/column-template/column-dynamically-add-template.gif)

## See Also

* [Dynamically render the icon based on the value in data source](https://www.syncfusion.com/forums/174307/change-variable-icon-based-on-the-information-obtained-from-the-datasource)
