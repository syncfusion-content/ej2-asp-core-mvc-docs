---
layout: post
title: Icons in ##Platform_Name## Component
description: Learn here all about Icons in Syncfusion ##Platform_Name## component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Icons
publishingplatform: ##Platform_Name##
documentation: ug
---

# Icons Library

The Syncfusion Essential JS 2 provides the set of `base64` formatted font icons, that can be utilized in the ASP.NET Core application.

## Steps to Use Icon

1. Add a class `e-icons` to the HTML element that shows the icon. This class contains the font-family and common property of the font icons.

2. Add the icon class with corresponding icon content from the [available icons](#available-icons). For example, the below code snippet represents the search icon class.

{% tabs %}
{% highlight c# tabtitle="CSS" %}

    .e-search:before{
        content:'\e993';
    }

{% endhighlight %}
{% endtabs %}

3. Add `e-icons` and `e-search` class to the HTML element.

{% tabs %}
{% highlight c# tabtitle="CSS" %}

    <span class="e-icons e-search"></span>

{% endhighlight %}
{% endtabs %}

    The below code snippet represents the complete example of icon usage.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

    <!doctype html>
    <html>
        <head>
            <title>Essential JS 2 </title>
            <meta name="viewport" content="width=device-width, initial-scale=1.0" charset="utf-8"  />
            <link href="./node_modules/@syncfusion/ej2/material.css" rel="stylesheet" />
            <style>
                .e-search:before{
                    content:'\e993';
                }
                .e-upload:before{
                    content: '\e725';
                }
                .e-font:before{
                    content: '\e34c';
                }
            </style>
        </head>

        <body>
            <div class="icons">
                <ul>
                    <li><span class="e-icons e-search"></span></li>
                    <li><span class="e-icons e-settings"></span></li>
                    <li><span class="e-icons e-upload"></span></li>
                    <li><span class="e-icons e-font"></span></li>
                </ul>
            </div>
        </body>
    </html>

{% endhighlight %}
{% endtabs %}

## Icons Size

You can change the icon size by adding `e-small`, `e-medium` and `e-large` class in the HTML element.

* When icon size set to Small, the font size will be `8px`.
* When icon size set to Medium, the font size will be `16px`.
* When icon size set to Large, the font size will be `24px`.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<p>Smaller icons</p>
<span class="e-icons e-cut e-small"></span>
<span class="e-icons e-copy e-small"></span>
<span class="e-icons e-paste e-small"></span>
<span class="e-icons e-bold e-small"></span>
<span class="e-icons e-underline e-small"></span>
<span class="e-icons e-italic e-small"></span>

<p>Medium icons</p>
<span class="e-icons e-cut e-medium"></span>
<span class="e-icons e-copy e-medium"></span>
<span class="e-icons e-paste e-medium"></span>
<span class="e-icons e-bold e-medium"></span>
<span class="e-icons e-underline e-medium"></span>
<span class="e-icons e-italic e-medium"></span>

<p>Larger icons</p>
<span class="e-icons e-cut e-large"></span>
<span class="e-icons e-copy e-large"></span>
<span class="e-icons e-paste e-large"></span>
<span class="e-icons e-bold e-large"></span>
<span class="e-icons e-underline e-large"></span>
<span class="e-icons e-italic e-large"></span>

{% endhighlight %}
{% endtabs %}

![Icon size customization](./images/icons/icon-size.png)

## Tooltip for icons

`title` attribute is used to improve accessibility with screen readers and shows a tooltip on mouseover. The following example code displays tooltip text for appropriate icons.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<span class="e-icons e-upload-1" title="Upload"></span>
<span class="e-icons e-download" title="Download"></span>
<span class="e-icons e-undo" title="Undo"></span>
<span class="e-icons e-redo" title="Redo"></span>
<span class="e-icons e-align-top" title="AlignTop"></span>
<span class="e-icons e-align-bottom" title="AlignBottom"></span>
<span class="e-icons e-align-middle" title="AlignMiddle"></span>

{% endhighlight %}
{% endtabs %}

![ToolTip for Icon](./images/icons/icon-title.png)

## Icon appearance customization 

You can customize color and size by overriding the `e-icons` class. The following example code demonstrates the custom font-size and color for icons.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<span class="e-icons e-align-top"></span>
<span class="e-icons e-align-bottom"></span>
<span class="e-icons e-align-middle"></span>
<span class="e-icons e-justify"></span>
<span class="e-icons e-decrease-indent"></span>
<span class="e-icons e-increase-indent"></span>

<style>
    .e-icons{
        color: #ff0000;
        font-size: 26px !important;
    }
</style>

{% endhighlight %}
{% endtabs %}

![Icon Customization](./images/icons/custom-icon.png)

## Third party icons integration

The Syncfusion ASP.NET core Toolbar component supports to render custom font icons using the [prefixIcon](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html#Syncfusion_EJ2_Navigations_ToolbarItem_PrefixIcon) property. To render custom font icons define the required font CSS that provides the required font name, font size, and content for the icon.

The following code explains how to render `open-iconic` icons using `prefixIcon` property.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

    <ejs-toolbar id="defaultToolbar">
        <e-toolbar-items>
            <e-toolbar-item prefixIcon="oi oi-list-rich"></e-toolbar-item>
            <e-toolbar-item prefixIcon="oi oi-account-login"></e-toolbar-item>
            <e-toolbar-item prefixIcon="oi oi-account-logout"></e-toolbar-item>
            <e-toolbar-item prefixIcon="oi oi-action-redo"></e-toolbar-item>
            <e-toolbar-item prefixIcon="oi oi-action-undo"></e-toolbar-item>
            <e-toolbar-item prefixIcon="oi oi-clock"></e-toolbar-item>
            <e-toolbar-item prefixIcon="oi oi-audio"></e-toolbar-item>
            <e-toolbar-item prefixIcon="oi oi-bluetooth"></e-toolbar-item>
        </e-toolbar-items>
    </ejs-toolbar>

{% endhighlight %}
{% endtabs %}

![Load custom icon in Icon](./images/icons/icon-css.png)

## HTML attribute support

You can add the additional HTML attributes to the Syncfusion ASP.NET Core Button using [HtmlAttributes](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_HtmlAttributes) property. All syncfusion ASP.NET Core components support HTML attribute.

The following example shows the font size customization using `HtmlAttributes` directive.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

@{IDictionary<string, object> customAttribute = new Dictionary<string, object>()
    {
       { "style", "font-size: 20px" }
    };
}

<ejs-button id="button" iconCss="e-icons e-copy" HtmlAttributes="customAttribute"></ejs-button>

{% endhighlight %}
{% endtabs %}

## Using icons directly in HTML element

The built-in Syncfusion icons can be rendered directly in the HTML element by defining `e-icons` class that contains the font-family and common property of font icons, and defining the [available icon's](#icons-list) class with `e-` prefix. 

The following code example explains the direct rendering of Syncfusion `download` icon in the span element.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<span class="e-icons e-download"></span>

{% endhighlight %}
{% endtabs %}

## Icons list

The complete pack of Syncfusion ASP.NET Core icons is listed in the following table. The corresponding icon content can be referred to the content section.

<!-- markdownlint-disable MD033 -->

### Bootstrap 5

<iframe class="doc-sample-frame" src="https://ej2.syncfusion.com/products/icons/bootstrap5/demo.html" style="height:1000px;width:100%;"></iframe>

### Bootstrap 4

<iframe class="doc-sample-frame" src="https://ej2.syncfusion.com/products/icons/bootstrap4/demo.html" style="height:1000px;width:100%;"></iframe>

### Bootstrap

<iframe class="doc-sample-frame" src="https://ej2.syncfusion.com/products/icons/bootstrap/demo.html" style="height:1000px;width:100%;"></iframe>

### Material

<iframe class="doc-sample-frame" src="https://ej2.syncfusion.com/products/icons/material/demo.html" style="height:1000px;width:100%;"></iframe>

### Tailwind CSS

<iframe class="doc-sample-frame" src="https://ej2.syncfusion.com/products/icons/tailwind/demo.html" style="height:1000px;width:100%;"></iframe>

### Office Fabric

<iframe class="doc-sample-frame" src="https://ej2.syncfusion.com/products/icons/fabric/demo.html" style="height:1000px;width:100%;"></iframe>

### High Contrast

<iframe class="doc-sample-frame" src="https://ej2.syncfusion.com/products/icons/highcontrast/demo.html" style="height:1000px;width:100%;"></iframe>
