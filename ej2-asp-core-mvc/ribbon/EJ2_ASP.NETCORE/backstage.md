---
layout: post
title: Ribbon Backstage in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Ribbon Backstage in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-Core
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ribbon Backstage

The Ribbon supports backstage view which is an addition to the traditional file menu. It displays information like application settings, user details, etc. The backstage view can be enabled by setting the `backStageMenu` property.

The backstage view options are displayed on the left, while the content of each option is shown on the right.

## Adding backstage items

The menu items can be added to the backstage view by using the `items` property. You can show the backstage view by setting the `visible` property to `true`. By default, the backstage view is hidden.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/backstage/items/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with backstage menu items](images/ribbon-backstage.png)

## Adding footer items

You can use the `isFooter` property in the `items` collection to add the backstage view footer items. By default, the value is false.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/backstage/footer-items/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with backstage menu footer items](images/ribbon-footer-items.png)

## Adding separator

The separators are horizontal lines used to separate the backstage view items. You can use the `separator` property to split the menu items.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/backstage/separator/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with backstage items separator](images/ribbon-backstage-separator.png)

## Back button

You can use the `backButton` property to customize the text and icon of the close button using the `text` and `iconCss` property. You can show the back button by setting the `visible` property to `true`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/backstage/back-button/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with back button in backstage](images/ribbon-back-button.png)

## Backstage target

The `target` property specifies the element selector in which backstage will be displayed. The target element should have the position as relative, else the backstage will be positioned nearest to the relative element. By default, the backstage is positioned to ribbon element.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/backstage/target/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with backstage target](images/ribbon-backstage-target.png)

## Template

You can use the `template` property to modify the backstage view menu items and their contents.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/backstage/template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with backstage template](images/ribbon-backstage-template.png)

## Setting width and height

You can customize the height and width of the backstage view using the `height` and `width` property. By default, dimensions are set based on the content added.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/backstage/customization/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control wiht backstage customization](images/ribbon-backstage-customization.png)

> [Adding Backstage events](./events#backStageItemClick)