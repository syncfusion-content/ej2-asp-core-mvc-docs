---
layout: post
title: Row in ##Platform_Name## Tree Grid Component
description: Learn here all about Row in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Row
publishingplatform: ##Platform_Name##
documentation: ug
---


# Row

The row represents record details fetched from data source.

## Customize rows

You can customize the appearance of a row by using the [`rowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event.
The [`rowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event triggers for every row. In the event handler, you can get the
**args** which contains details of the row.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRows.cs" %}
{% include code-snippet/tree-grid/row/customize-rows/CustomizeRows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRows.cs" %}
{% include code-snippet/tree-grid/row/customize-rows/CustomizeRows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Styling alternate rows

 You can change the treegrid's alternative rows' background color by overriding the **.e-altrow** class.

```css
.e-treegrid .e-altrow {
    background-color: #ffd800;
}
```

Please refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/alternate-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AlternateRows.cs" %}
{% include code-snippet/tree-grid/row/alternate-rows/alternateRows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/alternate-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AlternateRows.cs" %}
{% include code-snippet/tree-grid/row/alternate-rows/alternateRows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Row height

You can customize the row height of treegrid rows through the [`rowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowHeight.html) property. The [`rowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowHeight.html) property is used to change the row height of entire treegrid rows.

In the below example, the rowHeight is set as **60px**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/tree-grid/row/row-height/rowHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/tree-grid/row/row-height/rowHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customize row height for particular row

Grid row height for particular row can be customized using the [`rowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html)
event by setting the [`rowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowHeight.html) in arguments for each row based on the requirement.

In the below example, the row height for the row with Task ID as '3' is set as '90px' using the [`rowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRowHeight.cs" %}
{% include code-snippet/tree-grid/row/customize-row-height/customizeRowHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRowHeight.cs" %}
{% include code-snippet/tree-grid/row/customize-row-height/customizeRowHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Row template

The **rowTemplate** has an option to customise the look and behavior of the treegrid rows. The [`rowTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowTemplate.html) property accepts either
the **template** string or HTML element ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/tree-grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/tree-grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The [`rowTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowTemplate.html) property accepts only the TR element.

### Row template with formatting

If the [`rowTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowTemplate.html) is used, the value cannot be  formatted  inside the template using the [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property. In that case, a function should be defined globally to format the value and invoke it inside the template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/rowtemplate-formatting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowtemplate-formatting.cs" %}
{% include code-snippet/tree-grid/row/rowtemplate-formatting/rowtemplate-formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/rowtemplate-formatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowtemplate-formatting.cs" %}
{% include code-snippet/tree-grid/row/rowtemplate-formatting/rowtemplate-formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Limitations

Row template feature is not compatible with all the features which are available in treegrid and it has limited features support. Here we have listed out the features which are compatible with row template feature.

* Filtering
* Paging
* Sorting
* Scrolling
* Searching
* Rtl
* Context Menu
* State Persistence

## Detail template

The detail template provides additional information about a particular row. By expanding the parent row the child rows are expanded along with their detail template. The [`detailTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DetailTemplate.html) property accepts either the template string or HTML element ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/detailtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Detailtemplate.cs" %}
{% include code-snippet/tree-grid/row/detailtemplate/detailtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/detailtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Detailtemplate.cs" %}
{% include code-snippet/tree-grid/row/detailtemplate/detailtemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Drag and drop

The TreeGrid rows can be reordered, dropped to another TreeGrid or custom control by enabling the [`allowRowDragAndDrop`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowRowDragAndDrop.html) to true.

### Drag and drop within TreeGrid

The TreeGrid row drag and drop allows you to drag and drop TreeGrid rows on the same TreeGrid using drag icon. To enable row drag and drop, set the [`allowRowDragAndDrop`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowRowDragAndDrop.html) to true. It provides the way to drop the row above, below or child to the target row with respective to the target row position.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-drag-single/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/tree-grid/row/row-drag-single/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-drag-single/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/tree-grid/row/row-drag-single/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * Selection feature must be enabled for row drag and drop.
> * For multiple row selection, the [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~Type.html) property must be set to `multiple`.

### Drag and drop to another TreeGrid

To drag and drop between two TreeGrid, enable the [`allowRowDragAndDrop`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowRowDragAndDrop.html) property and specify the target TreeGrid ID in [`targetID`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridRowDropSettings~TargetID.html) property of rowDropSettings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-drag-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/tree-grid/row/row-drag-drop/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-drag-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/tree-grid/row/row-drag-drop/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Drag and drop events

The following events are triggered while drag and drop the treegrid rows.

[`RowDragStartHelper`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDragStartHelper.html) - Triggers when click the drag icon or treegrid row and this event is used to customize the drag element based on user criteria.<br/>
[`RowDragStart`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDragStart.html) -Triggers when starts to drag the treegrid row. <br/>
[`RowDrag`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDrag.html) - Triggers while dragging the treegrid row. <br/>
[`RowDrop`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDrop.html) - Triggers when a drag element is dropped on the target element. <br/>

> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.