---
layout: post
title: Enable Disable Toolbar Item in ##Platform_Name## File Manager Component
description: Learn here all about how to enable or disable toolbar item in Syncfusion ##Platform_Name## File Manager component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Enable Disable Toolbar Item
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to enable/disable toolbar item/items

The toolbar items can be enabled or disabled by specifying the items in `enableToolbarItems` or `disableToolbarItems` methods respectively.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/toolbar-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/toolbar-items/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/toolbar-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/toolbar-items/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below when toolbar item is enabled.

![FileManager enable toolbar items ](../images/enable_toolbar_items.PNG)

Output be like the below when toolbar item is disabled.

![FileManager disable toolbar items ](../images/disable_toolbar_items.PNG)