---
layout: post
title: Column Chooser in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Column Chooser in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Chooser
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Chooser in ##Platform_Name## Tree Grid Component

The column chooser has options to show or hide columns dynamically. It can be enabled by defining the [`ShowColumnChooser`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ShowColumnChooser) as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can hide the column names in column chooser by defining the [`ShowInColumnChooser`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ShowColumnChooser) as false.

## Open column chooser by external button

The Column chooser can be displayed on a page through external button by invoking the **openColumnChooser** method with X and Y axis positions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Column chooser template in Syncfusion ##Platform_Name## TreeGrid

The column chooser template feature allows full customization of the column chooser’s header, content, and footer, making it easier to manage column visibility. To enable the column chooser, set [ShowColumnChooser](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ShowColumnChooser) to **true** and add **ColumnChooser** to the [Toolbar](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html) property.

To implement a custom column chooser template in the TreeGrid, use the following properties:

* **ColumnChooserSettings.HeaderTemplate** - Defines the header template of the column chooser.

* **ColumnChooserSettings.Template**- Defines the content template.

* **ColumnChooserSettings.FooterTemplate** - Defines the footer template.

* **ColumnChooserSettings.RenderCustomColumnChooser** -  Allows you to override the default column chooser UI with a fully customized layout.

In this example, a Syncfusion TreeView component is rendered inside the column chooser. To use the TreeView component, install the Syncfusion TreeView package as described in the [documentation](../../treeview/getting-started). The `ColumnChooserSettings.Template` property defines a element with the `Id` set to **tree**, providing as a container for the TreeView component. The `ColumnChooserSettings.RenderCustomColumnChooser` method initializes the TreeView with checkboxes and appends it to this template. Checkbox selection is handled using the [NodeClicked](../../api/treeview/#nodeclicked) and [keyPress](../../api/treeview/#keypress) events, which organize columns into **Task Info**, **Schedule**, and **Progress**.

The column chooser footer is customized using `ColumnChooserSettings.FooterTemplate`, replacing the default buttons with customized **Apply** and **Close** buttons. The **Apply** button updates column visibility based on selection, while the **Close** button closes the column chooser via the `onClick` event. Additionally, the header is customized using `ColumnChooserSettings.HeaderTemplate` to include a title and an icon.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/column-chooser-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="empty-record-template.cs" %}
{% include code-snippet/tree-grid/columns-core/column-chooser-template/column-chooser-template.cs %}
{% endhighlight %}
{% endtabs %}

![Column Chooser Template TreeGrid](../images/column-chooser-template)

N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.