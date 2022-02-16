---
layout: post
title: Customize The Expand And Collapse Icons in ##Platform_Name## Treeview Component
description: Learn here all about Customize The Expand And Collapse Icons in Syncfusion ##Platform_Name## Treeview component and more.
platform: ej2-asp-core-mvc
control: Customize The Expand And Collapse Icons
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the expand and collapse icons

You can customize TreeView expand and collapse icons by using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TreeView~CssClass.html)&nbsp;property of TreeView.
Refer to the sample to customize expand/collapse icons.

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



Output be like the below.

![TreeView Sample](../images/customise.PNG)