---
layout: post
title: Types And Styles in ##Platform_Name## Button Component
description: Learn here all about Types And Styles in Syncfusion ##Platform_Name## Button component and more.
platform: ej2-asp-core-mvc
control: Types And Styles
publishingplatform: ##Platform_Name##
documentation: ug
---


# Types and Styles

This section explains the different styles and types of Buttons.

## Button styles

The Essential JS 2 Button has the following predefined styles that can be defined using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass) property.

| Class | Description |
| -------- | -------- |
| e-primary | Used to represent a primary action. |
| e-success | Used to represent a positive action. |
| e-info |  Used to represent an informative action. |
| e-warning | Used to represent an action with caution. |
| e-danger | Used to represent a negative action. |
| e-link |  Changes the appearance of the Button like a hyperlink. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/styles/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/button/styles/styles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/styles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/button/styles/styles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Predefined Button styles provide only the visual indication. So,
Button content should define the Button style for the users of assistive technologies such as screen readers.

## Button types

The types of Essential JS 2 Button are as follows:

* Basic types
* Flat Button
* Outline Button
* Round Button
* Toggle Button

### Basic types

The basic Button types are explained below.

| Type | Description |
| -------- | -------- |
| Button | Defines a click Button. |
| Submit | This Button submits the form data to the server. |
| Reset |  This Button resets all the controls to their initial values. |

In the following sample, `type` attribute of the Submit button is set using tag helper and Reset button is set using
`htmlAttribute`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/types/basic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Basicbutton.cs" %}
{% include code-snippet/button/types/basic/basicbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/types/basic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Basicbutton.cs" %}
{% include code-snippet/button/types/basic/basicbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Flat Button

The Flat Button is styled with no background color. To create a flat Button,
set the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass) property to `e-flat`.

### Outline Button

An outline Button has a border with transparent background. To create an outline Button,
set the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass) property to `e-outline`.

### Round Button

A round Button is shaped like a circle. Usually, it contains an icon representing its action. To create a round Button,
set the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass) property to `e-round`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/types/other-types/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Buttontypes.cs" %}
{% include code-snippet/button/types/other-types/buttontypes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/types/other-types/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Buttontypes.cs" %}
{% include code-snippet/button/types/other-types/buttontypes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Toggle Button

A toggle Button allows you to change between the two states. The Button is active in toggled state and can be recognized through the `e-active` class.
The functionality of the toggle Button is handled by click event. To create a toggle Button,
set the [`isToggle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_IsToggle) property to `true`. In the following code snippet,
the toggle Button text changes to play/pause based on the state of the Button with the use of click event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/toggle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Togglebutton.cs" %}
{% include code-snippet/button/toggle/togglebutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/toggle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Togglebutton.cs" %}
{% include code-snippet/button/toggle/togglebutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Icons

### Button with font icons

The Button can have an icon to provide the visual representation of the action. To place the icon on a Button,
set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_IconCss)
property to `e-icons` with the required icon CSS. By default, the icon is positioned to the left side of the Button.
You can customize the icon's position by using the [`iconPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_IconPosition) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Buttonicon.cs" %}
{% include code-snippet/button/icon/buttonicon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Buttonicon.cs" %}
{% include code-snippet/button/icon/buttonicon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The Essential JS 2 provides a set of icons that can be loaded by applying `e-icons` class name to the element.
You can also use third party icons on the Button using the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_IconCss) property.

### Button with SVG image

SVG image can be added to the Button using [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_IconCss)
property.

In the following example, SVG image is added using the iconCss class `e-search-icon` by setting `height` and `width` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/svg/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Buttonsvg.cs" %}
{% include code-snippet/button/svg/buttonsvg.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/svg/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Buttonsvg.cs" %}
{% include code-snippet/button/svg/buttonsvg.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Button size

The two types of Button sizes are default and small. To change the size of the default Button to small Button,
set the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass) property to `e-small`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/button/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/button/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Customize Button appearance](./how-to/customize-button-appearance)
* [How to create block button](./how-to/create-a-block-button)
* [How to create repeat button](./how-to/repeat-button)