---
layout: post
title: Ribbon Gallery Items in ##Platform_Name## Ribbon Control | Syncfusion
description: Checkout and learn about Gallery Items with ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Gallery Items in ASP.NET MVC Ribbon control

The Ribbon supports Gallery view which allows users to perform specific actions by displaying a collection of related items, including icons, content, or images. You can render the gallery item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `Gallery` and customize it by using the [RibbonGallerySettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html), which provides options such as `Groups`, `ItemCount`, `PopupHeight`, `PopupWidth` and more.

## Groups

You can render the groups inside the gallery items by using [Groups](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_Groups) property and customize the groups using [RibbonGalleryGroup](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryGroup.html), which provides options such as `Items`, `CssClass`, `Header` and more.

### Adding items

You can render the gallery items by using [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryGroup.html#Syncfusion_EJ2_Ribbon_RibbonGalleryGroup_Items) property and customize using the [RibbonGalleryItem](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryItem.html), which provides options such as `Content`, `IconCss`, `Disabled` and more.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/galleryItems/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery items](./images/ribbon-gallery-items.png)

#### Adding content

You can use the [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryItem.html#Syncfusion_EJ2_Ribbon_RibbonGalleryItem_Content) property to define the text content for the gallery item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/itemContent/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery content](./images/ribbon-gallery-content.png)

#### Adding icons

You can use the [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryItem.html#Syncfusion_EJ2_Ribbon_RibbonGalleryItem_IconCss) property to define the icons for the gallery item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/galleryIcon/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery icons](./images/ribbon-gallery-icons.png)

#### Adding html attributes

You can use the [HtmlAttributes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryItem.html#Syncfusion_EJ2_Ribbon_RibbonGalleryItem_HtmlAttributes) property to add HTML attributes to the Ribbon gallery item.

The following sample showcases how to add title attribute to the gallery item using `HtmlAttributes` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/htmlAttributes/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Html attributes](./images/ribbon-gallery-attribute.png)

#### Css class

You can use the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryItem.html#Syncfusion_EJ2_Ribbon_RibbonGalleryItem_CssClass) property to customize the gallery item.

The following sample showcases how to customize the appearance of each gallery item using the `CssClass` property .

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/classCustomization/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery item Cssclass](./images/ribbon-gallery-item-cssclass.png)

#### Disabled

You can use the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryItem.html#Syncfusion_EJ2_Ribbon_RibbonGalleryItem_Disabled) property to disable the Ribbon gallery item. It prevents the user interaction when set to `true`. By default, the value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/disabledItem/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery item disabled](./images/ribbon-gallery-item-disabled.png)

### Custom header

You can use the [Header](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryGroup.html#Syncfusion_EJ2_Ribbon_RibbonGalleryGroup_Header) property to set header for the group items in the Ribbon gallery popup.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/galleryItems/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery group header](./images/ribbon-gallery-items.png)

### Setting item width

You can use the [ItemWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryGroup.html#Syncfusion_EJ2_Ribbon_RibbonGalleryGroup_ItemWidth) property to specify the width of gallery items.

### Setting item height

You can use the [ItemHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryGroup.html#Syncfusion_EJ2_Ribbon_RibbonGalleryGroup_ItemHeight) property to set the height of the gallery items. If the `ItemHeight` of the gallery item is smaller the remaining gallery items are aligned based on the [ItemCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_ItemCount) specified.

The provided example demonstrates how to customize gallery items using the `ItemWidth` and `ItemHeight` properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/itemHeightWidth/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery items width and height](./images/ribbon-gallery-item-styles.png)

### Group styling

You can use the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGalleryGroup.html#Syncfusion_EJ2_Ribbon_RibbonGalleryGroup_CssClass) property to customize the appearance of gallery groups.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/groupCustomization/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery group css](./images/ribbon-gallery-group-cssclass.png)

## Setting item count

You can customize the number if items to be displayed in Ribbon gallery by using the [ItemCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_ItemCount) property. By default the `ItemCount` will be `3`.

The following example showcases the utilization of the `ItemCount` property, displaying a ribbon gallery with `4` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/itemCount/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery items count](./images/ribbon-gallery-item-count.png)

## Setting selected item

You can use the [SelectedItemIndex](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_SelectedItemIndex) property to define the currently selected item in the Ribbon gallery items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/selectedItemIndex/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery selected item index](./images/ribbon-gallery-selected-index.png)

## Setting popup height

You can specify the height of the gallery popup by using the [PopupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_PopupHeight) property.

## Setting popup width

you can specify the width of the gallery popup by using the [PopupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_PopupWidth) propery.

The example demonstrates the customization of popup with `PopupHeight` and `PopupWidth` properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/popupHeightWidth/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery popup width and height](./images/ribbon-gallery-popup-styles.png)

## Template

You can customize the default appearance and content of Ribbon gallery items by using the [Template](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_Template) property.

### Popup Template

You can customize the appearance of Ribbon gallery popup by using the [PopupTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_PopupTemplate) property.

The below example demonstrates the customization of both the `Template` and `PopupTemplate` properties:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/gallery/galleryTemplate/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with gallery template](./images/ribbon-gallery-template.png)

> To know more about the built-in Ribbon items, please refer to the [Ribbon Items](./items) section.