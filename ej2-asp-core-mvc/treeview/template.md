---
layout: post
title: Template in ##Platform_Name## Treeview Component
description: Learn here all about Template in Syncfusion ##Platform_Name## Treeview component and more.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Template

The TreeView control allows you to customize the look of TreeView nodes by using the [nodeTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TreeView~NodeTemplate.html) property. This property accepts either `template string` or HTML element ID.

In the following sample, employee information such as employee photo, name, and designation have been included using the `nodeTemplate` property.

The template expression should be provided inside the `${...}` interpolation syntax.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Templatemodel.cs" %}
{% include code-snippet/treeview/template/templatemodel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Templatemodel.cs" %}
{% include code-snippet/treeview/template/templatemodel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](./images/template.PNG)

## See Also

* [How to customize the expand and collapse icons](./how-to/customize-the-expand-and-collapse-icons)
* [How to customize the tree nodes based on levels](./how-to/customize-the-tree-nodes-based-on-levels)