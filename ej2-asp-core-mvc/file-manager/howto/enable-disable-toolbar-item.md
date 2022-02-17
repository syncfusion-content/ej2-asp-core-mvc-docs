---
layout: post
title: Enable Disable Toolbar Item in ##Platform_Name## File Manager Component
description: Learn here all about Enable Disable Toolbar Item in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Enable Disable Toolbar Item
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to enable/disable toolbar item/items

The toolbar items can be enabled/disabled by specifying the items in `enableToolbarItems` or `disableToolbarItems` methods respectively.

The following example shows enabling and disabling toolbar items on button click.

The new toolbar button is added using [toolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarSettings.html). The [toolbarClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarClick.html) event is used to add an event handler to the new toolbar button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/how-to/toolbar/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/how-to/toolbar/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below when enable toolbar item.

![FileManager enable toolbar items ](../images/enable_toolbar_items.PNG)

Output be like the below when enable toolbar item.

![FileManager disable toolbar items ](../images/disable_toolbar_items.PNG)