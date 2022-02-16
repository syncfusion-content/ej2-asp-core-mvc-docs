---
layout: post
title: Popup Items in ##Platform_Name## Drop Down Button Component
description: Learn here all about Popup Items in Syncfusion ##Platform_Name## Drop Down Button component and more.
platform: ej2-asp-core-mvc
control: Popup Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Popup items

## Icons

The popup action item have an icon or image to provide visual representation of the action. To place the icon on a popup item,
set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconCss) property to `e-icons` with the required icon CSS. By default, the icon is
positioned to the left side of the popup action item.

In the following sample, the icons for edit, delete, mark as read  and like message menu items are
added using the iconCss property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popupicons.cs" %}
{% include code-snippet/dropdownbutton/popup-items/icons/popupicons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popupicons.cs" %}
{% include code-snippet/dropdownbutton/popup-items/icons/popupicons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Navigations

Actions in DropDownButton can be used to navigate to the other web
page when action item is clicked. This can be achieved by
Popup items can be customized using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeItemRender) event. The item render event
providing link to the action item using `url` property.

In the following sample, navigation URL for Flipkart, Amazon, and
Snapdeal action items are added using the `url` property:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/navigation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Navigation.cs" %}
{% include code-snippet/dropdownbutton/popup-items/navigation/navigation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/navigation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Navigation.cs" %}
{% include code-snippet/dropdownbutton/popup-items/navigation/navigation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Template

### Item templating

Popup items can be customized using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeItemRender) event. The item render event
triggers while rendering each popup action item. The event argument will be used to identify the action item and
customize based on the requirement.

In the following example, the icons in each li items is right aligned by appending span element in li rendering:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/item-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/dropdownbutton/popup-items/item-template/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/item-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/dropdownbutton/popup-items/item-template/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Popup Templating

The whole popup can be customized as per the requirement. In the following example, the popup can be
customized by handling it in [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Target) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/popup-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popuptemplate.cs" %}
{% include code-snippet/dropdownbutton/popup-items/popup-template/popuptemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/popup-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popuptemplate.cs" %}
{% include code-snippet/dropdownbutton/popup-items/popup-template/popuptemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Integration with ListView component](./how-to/group-popup-items-with-listview-component)
