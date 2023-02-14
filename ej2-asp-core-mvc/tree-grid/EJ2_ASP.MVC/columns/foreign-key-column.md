---
layout: post
title: Foreign Key Column in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Foreign Key Column in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Foreign Key Column in ASP.NET MVC Tree Grid Component

Since Tree Grid Databinding concept based on hierarchy relationship, there is no in-built support for foreign key datasource. However, it is possible to display foreign key values in the Tree Grid at initial rendering as well as while Editing.

To display the foreignKey value at initial rendering, use[`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event of the Tree Grid and also by using the [`EditType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_EditType) and [`columns.edit`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Edit) properties of Tree Grid Column, we can render Dropdownlist with external or foreign dataSource.

In the following example, **EmployeeID** is a foreign column which shows **EmployeeName** from foreign data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/foreign/foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ForeignKey.cs" %}
{% include code-snippet/tree-grid/columns-mvc/foreign/foreign.cs %}
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

Tree Grid allows you to render any component in a column using the [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Template) property.

To render other components in the Tree Grid, ensure the following steps:

**Step 1**: Initialize the column template for your custom component using `Template` property.

```typescript
     
     col.Field("Priority").HeaderText("Priority").Template("<input type='text' tabindex='1' id='ddlelement' />").Width(100).Add();

```

**Step 2**: Use [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event to render the DropDown component in Tree Grid column with the following code.

```typescript
    function dropdown(args) {
        var ele = args.cell.querySelector("#ddlelement");
        var drop = new ej.dropdowns.DropDownList({ dataSource: dropData, popupHeight: 100, popupWidth: 100, value: args.data["Priority"]});
        drop.appendTo(ele);
    }

```

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