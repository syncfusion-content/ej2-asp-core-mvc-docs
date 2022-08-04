---
layout: post
title: Column Template in ##Platform_Name## Tree Grid Component
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



> TreeGrid actions such as editing, filtering and sorting etc. will depend upon the column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html). If the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the template column, the treegrid actions cannot be performed.

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



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.