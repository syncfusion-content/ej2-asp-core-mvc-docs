---
layout: post
title: Customize the Expand And Collapse Icons in ##Platform_Name## TreeView Control | Syncfusion
description: Learn here all about Customize the Expand And Collapse Icons in Syncfusion ##Platform_Name## TreeView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the expand and collapse icons

You can customize the TreeView's expand and collapse icons by using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TreeView~CssClass.html) property of TreeView. Refer to the following sample to see how to customize expand/collapse icons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize.cs" %}
{% include code-snippet/treeview/how-to/customize/customize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize.cs" %}
{% include code-snippet/treeview/how-to/customize/customize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](../images/customise.PNG)