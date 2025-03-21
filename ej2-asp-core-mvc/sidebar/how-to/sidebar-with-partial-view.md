---
layout: post
title: Partial View with Syncfusion ##Platform_Name## Sidebar control
description: Learn here all about Sidebar With Partial View in Syncfusion ##Platform_Name## Sidebar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sidebar With Partial View
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sidebar with partial view

The example below demonstrates how to render the Sidebar using a partial view. The Sidebar element is included inside the **RenderPartialView.cshtml** file and is referenced in the layout page. The Accordion control is rendered inside the Sidebar.

{% if page.publishingplatform == "aspnet-core" %}

Additionally, you can use this [`link`](https://ej2.syncfusion.com/aspnetcore/documentation/accordion/style) for more Accordion control styles.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/partial-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TextBox.cshtml" %}
{% include code-snippet/sidebar/partial-view/TextBox.cshtml %}
{% endhighlight %}
{% highlight c# tabtitle="_RenderPartialView_core.cshtml" %}
{% include code-snippet/sidebar/partial-view/_RenderPartialView_core.cshtml %}
{% endhighlight %}
{% highlight c# tabtitle="style" %}
{% include code-snippet/sidebar/partial-view/styles.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Additionally, you can use this [`link`](https://ej2.syncfusion.com/aspnetmvc/documentation/accordion/style) for more Accordion control styles.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/partial-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextBox.cshtml" %}
{% include code-snippet/sidebar/partial-view/TextBox.cshtml %}
{% endhighlight %}
{% highlight c# tabtitle="_RenderPartialView_mvc.cshtml" %}
{% include code-snippet/sidebar/partial-view/_RenderPartialView_mvc.cshtml %}
{% endhighlight %}
{% highlight c# tabtitle="style" %}
{% include code-snippet/sidebar/partial-view/styles.css %}
{% endhighlight %}
{% endtabs %}

{% endif %}



Output be like the below in layout page.

![Sidebar Sample](../images/layout_page.png)
