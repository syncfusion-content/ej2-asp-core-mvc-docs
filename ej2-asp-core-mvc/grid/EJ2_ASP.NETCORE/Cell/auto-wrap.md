---
layout: post
title: Auto Wrap in ##Platform_Name## Grid Component
description: Learn here all about Auto Wrap in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Auto Wrap
publishingplatform: ##Platform_Name##
documentation: ug
---

# Auto Wrap

The auto wrap allows the cell content of the grid to wrap to the next line when it exceeds the boundary of the cell width. The Cell Content wrapping works based on the position of white space between words.
To enable auto wrap, set the [`allowTextWrap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowTextWrap) property to `true`.
You can configure the auto wrap mode by setting the [`wrapMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridTextWrapSettings.html#Syncfusion_EJ2_Grids_GridTextWrapSettings_WrapMode) property of **e-grid-textwrapsettings** tag helper.

There are three types of [`wrapMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridTextWrapSettings.html#Syncfusion_EJ2_Grids_GridTextWrapSettings_WrapMode). They are:

* **Both**: Both value is set by default. Auto wrap will be enabled for both the content and the header.
* **Header**: Auto wrap will be enabled only for the header.
* **Content**: Auto wrap will be enabled only for the content.

> When a column width is not specified, then auto wrap of columns will be adjusted with respect to the grid's width.

In the following example, the [`wrapMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridTextWrapSettings.html#Syncfusion_EJ2_Grids_GridTextWrapSettings_WrapMode) is set to **Content**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/autowrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autowrap.cs" %}
{% include code-snippet/grid/cell/autowrap/autowrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/autowrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autowrap.cs" %}
{% include code-snippet/grid/cell/autowrap/autowrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

