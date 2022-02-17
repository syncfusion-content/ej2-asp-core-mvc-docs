---
layout: post
title: Popup Items in ##Platform_Name## Split Button Component
description: Learn here all about Popup Items in Syncfusion ##Platform_Name## Split Button component and more.
platform: ej2-asp-core-mvc
control: Popup Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Popup Items

## Icons

The Popup action item have an icon or image to provide visual representation of the action. To place the icon on a popup
item, set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_IconCss) property to `e-icons` with the required icon CSS. By default, the icon is positioned to the left side of the popup action item.

In the following sample, the icons for Cut, Copy, Paste, Undo and Redo menu items are
added using the iconCss property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/popup-items/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popupicons.cs" %}
{% include code-snippet/split-button/popup-items/icons/popupicons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/popup-items/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popupicons.cs" %}
{% include code-snippet/split-button/popup-items/icons/popupicons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Template

### Item Templating

Popup items can be customized by using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_BeforeItemRender) event. The item render event triggers while rendering each Popup
action item. The event argument will be used to identify the action item and customize it based on the requirement.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/popup-items/item-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/split-button/popup-items/item-template/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/popup-items/item-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/split-button/popup-items/item-template/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Popup Templating

The whole popup can be customized as per the requirement. In the following example, the popup can be
customized by handling it in [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_Target) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/popup-items/popup-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popuptemplate.cs" %}
{% include code-snippet/split-button/popup-items/popup-template/popuptemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/popup-items/popup-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popuptemplate.cs" %}
{% include code-snippet/split-button/popup-items/popup-template/popuptemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Popup items grouping](./how-to/group-items-in-popup)