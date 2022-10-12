---
layout: post
title: Items with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about Items with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Items in Asp.Net MVC Speed Dial Control

## Icons

SpeedDial control can be visually represented with the use of [OpenIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpenIconCss) property and [CloseIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CloseIconCss) property.

OpenIconCss will be visible when the Speed Dial items are hidden and CloseIconCss will be visible when the Speed Dial items are shown.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/icons/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/speeddial/items/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial with Open Icon](images/OpenIcon.png)
![ASP.NET MVC Speed Dial with Close Icon](images/SDItemonly.png)

## Customization

For customization below types are available:

* Icon Only
* Icon with Text
* Text Only

## Speed Dial Item with Icon Only

Use IconCss property to display the icon. Speed Dial can have an icon to provide the visual representation of the action. To place the icon on a Speed Dial item, set the [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_IconCss) property to `e-icons` with the required icon CSS.

In the following example, Speed Dial Item is demonstrated with only icons by providing the IconCss property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/icon-only/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/icon-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/speeddial/items/customization/icon-only/icon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial with Icon](images/SDItemonly.png)

## Speed Dial Item with Icon and Text

Use [Text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Text) property and [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_IconCss) property to display the icon and text in Speed Dial Items.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/icon-with-text/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/icon-with-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextIcon.cs" %}
{% include code-snippet/speeddial/items/customization/icon-with-text/texticon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial with Icon and Text](images/SDItemwithtext.png)

## Speed Dial Item with Text Only

Use [Text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Text) property to display the text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/text-only/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/text-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/speeddial/items/customization/text-only/text.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial with Text only](images/SDTextonly.png)

## Animation

Animation provides options to customize the animation applied while opening and closing the popup. Use [Effect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialAnimationSettings.html#Syncfusion_EJ2_Buttons_SpeedDialAnimationSettings_Effect) property to customize animation effects. Animation effect applied when open and close the speed dial items.

| List of Effects |  |  | 
| --- | --- | --- | 
| Fade | FadeZoom | FlipLeftDown | 
| FlipLeftUp | FlipRightDown| FlipRightUp|
| FlipXDown | FlipXUp | FlipYLeft |
| FlipYRight | SlideBottom | SlideLeft |
| SlideRight | SlideTop | Zoom |

In the following example, Speed Dial Item is demonstrated with Effect property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/animation/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/speeddial/items/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial Animation](images/Animation.png)

## Template

Types of Template
*Item Template
*PopUp Template

## Item Template

It defines the template content for the speed dial item. The [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_ItemTemplate) property is used to define custom template for speed dial item.

## PopUp Template

It can display a menu of related actions `SpeedDialItems` or a custom content. The [PopupTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_PopupTemplate) property is used to defines a template content for popup of SpeedDial.

> [To learn more about Templates](https://ej2.syncfusion.com/aspnetmvc/documentation/speeddial/template)