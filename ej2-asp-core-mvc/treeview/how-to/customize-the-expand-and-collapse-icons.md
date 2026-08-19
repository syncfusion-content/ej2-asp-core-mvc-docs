---
layout: post
title: How to customize the expand and collapse icons in ##Platform_Name## TreeView | Syncfusion
description: Customize the expand and collapse icons in the Syncfusion ##Platform_Name## TreeView using the cssClass property and theme or font-icon styling.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize the expand and collapse icons in ##Platform_Name## TreeView

You can customize the TreeView's expand and collapse icons by using the `cssClass` property of TreeView. Refer to the following sample to see how to customize expand/collapse icons.

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
{% include code-snippet/treeview/how-to/customize/customize-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](../images/customise.PNG)