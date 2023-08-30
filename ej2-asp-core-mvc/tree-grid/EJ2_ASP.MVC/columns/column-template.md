---
layout: post
title: Column Template in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Column Template in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Template in ASP.NET MVC Tree Grid Component

The column [`Template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Template.html) has options to display custom element instead of a field value in the column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Column-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/column-template/column-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/column-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/column-template/column-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> TreeGrid actions such as editing, filtering and sorting etc. will depend upon the column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html). If the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the template column, the treegrid actions cannot be performed.

## Using condition template

You can render the template elements based on condition.

In the following code, checkbox is rendered based on **Approved** field value.

```html
  <script id="template" type="text/x-template">
            <div class="template_checkbox">
                ${if(approved)}
                <input type="checkbox" checked> ${else}
                <input type="checkbox"> ${/if}
            </div>
        </script>
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Using-condition-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/using-condition-template/using-condition-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/using-condition-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Using-condition-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/using-condition-template/using-condition-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Render other components in a column

Tree Grid allows you to render any component in a [`Column`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) using the [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Template) property. This provides the ability to create custom components or use existing ones from Syncfusion or third-party libraries.

To render other components in the Tree Grid, ensure the following steps:

**Step 1**: Provide the HTML content for your custom component using `Template` property.

```typescript
     
     col.Field("Priority").HeaderText("Priority").Template("<input type='text' tabindex='1' id='ddlelement' />").Width(100).Add();

```

**Step 2**: Use [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event to render the DropDown component on the HTML element placed in `Template` with the following code.

```typescript
    function dropdown(args) {
        var ele = args.cell.querySelector("#ddlelement");
        var drop = new ej.dropdowns.DropDownList({ dataSource: dropData, popupHeight: 100, popupWidth: 100, value: args.data["Priority"]});
        drop.appendTo(ele);
    }

```
Refer to the below complete code example about how to render dropdown component in Tree Grid column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Using-condition-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/render-other-comp/render-other-comp.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/render-other-comp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Using-condition-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/render-other-comp/render-other-comp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.