---
layout: post
title: Auto Wrap in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Auto Wrap in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Auto Wrap
publishingplatform: ##Platform_Name##
documentation: ug
---

# Auto Wrap in ##Platform_Name## Tree Grid Component

The auto wrap allows the cell content of the grid to wrap to the next line when it exceeds the boundary of the cell width. The Cell Content wrapping works based on the position of white space between words. To enable auto wrap, set the [`AllowTextWrap`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_AllowTextWrap) property to **true**. 

To configure the auto wrap, use the [`WrapMode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridTextWrapSettings.html#Syncfusion_EJ2_TreeGrid_TreeGridTextWrapSettings_WrapMode) property of [`TextWrapSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridTextWrapSettings.html).

There are three types of `WrapMode`. They are:

* **Both**: Both value is set by default. Auto wrap will be enabled for both the content and the header.
* **Header**: Auto wrap will be enabled only for the header.
* **Content**: Auto wrap will be enabled only for the content.

N> When a column width is not specified, then auto wrap of columns will be adjusted with respect to the tree grid's width.

In the following example, the `WrapMode` is set to **Content**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/auto-wrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autowrap.cs" %}
{% include code-snippet/tree-grid/cell/auto-wrap/autoWrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/auto-wrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autowrap.cs" %}
{% include code-snippet/tree-grid/cell/auto-wrap/autoWrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

