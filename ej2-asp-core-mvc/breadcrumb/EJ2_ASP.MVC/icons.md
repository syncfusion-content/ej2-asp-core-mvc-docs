---
layout: post
title: Icons in ##Platform_Name## Breadcrumb Component | Syncfusion
description: Learn here all about Icons in Syncfusion ##Platform_Name## Breadcrumb component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Icons
publishingplatform: ##Platform_Name##
documentation: ug
---


# Icons in ASP.NET MVC Breadcrumb Control

The Breadcrumb contains an icon/image to provide a visual representation of an item.

## Loading icon in BreadcrumbItem

To load the icon on the breadcrumb item, set the [`IconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.BreadcrumbItem.html#Syncfusion_EJ2_Navigations_BreadcrumbItem_IconCss) property.

### Breadcrumb with Font Icon

To place the font icon on the breadcrumb item, set the [`IconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.BreadcrumbItem.html#Syncfusion_EJ2_Navigations_BreadcrumbItem_IconCss) property to `e-icons` with the required icon CSS. By default, the icon is positioned to the left side of the item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/items.PNG)

### Breadcrumb with Image

In the Breadcrumb, images can be added for the items using the [`IconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.BreadcrumbItem.html#Syncfusion_EJ2_Navigations_BreadcrumbItem_IconCss) property. In the following example, an image was added to the breadcrumb item by using the iconCss class `e-image` and specifying height and width.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/icon/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/icon/image/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/icon/image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/icon/image/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/image.PNG)

### Breadcrumb with SVG Image

In the Breadcrumb, SVG image can be added for the items using the [`IconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.BreadcrumbItem.html#Syncfusion_EJ2_Navigations_BreadcrumbItem_IconCss) property. In the following example, SVG image was added to the breadcrumb item by using the iconCss class `e-image` and specifying height and width.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/icon/svg/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/icon/svg/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/icon/svg/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/icon/svg/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/svg.PNG)

## Icon Position

By default, the icon is positioned to the left side of the item in the Breadcrumb. If you need to add the icon right to the breadcrumb item, add the `e-icon-right` class to the required item. In the following example, the `e-icon-right` class was added to the breadcrumb items using the `BeforeItemRender` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/icon/icon-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/icon/icon-position/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/icon/icon-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/icon/icon-position/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/icons-position.PNG)

## Icon Only

To display only icons for the items, add icons using the [`IconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.BreadcrumbItem.html#Syncfusion_EJ2_Navigations_BreadcrumbItem_IconCss) property. In the following example, breadcrumb items were demonstrated with only icons by providing the `iconCss` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/icon/icon-only/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/icon/icon-only/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/icon/icon-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/icon/icon-only/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/icon-only.PNG)

## Show icon only for first item

To show icon only for the first item in the Breadcrumb, add icons to the first item using the [`IconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.BreadcrumbItem.html#Syncfusion_EJ2_Navigations_BreadcrumbItem_IconCss) property. In the following example, the icon was provided only for the first item by setting the `iconCss` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/items.PNG)