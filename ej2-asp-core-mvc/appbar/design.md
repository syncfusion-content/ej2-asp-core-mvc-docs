---
layout: post
title: Design User Interface with ##Platform_Name## AppBar Control | Syncfusion
description: Check out and learn about Design User Interface with the ##Platform_Name## AppBar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Design
publishingplatform: ##Platform_Name##
documentation: ug
---

# Design User Interface with ##Platform_Name## AppBar Control

## Spacer

`Spacer` is used to provide spacing between the AppBar contents which gives additional space to the content layout.

The following example depicts the code to provide spacing between the home and pan buttons in the AppBar:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/spacer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spacer.cs" %}
{% include code-snippet/appbar/design/spacer/spacer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/spacer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spacer.cs" %}
{% include code-snippet/appbar/design/spacer/spacer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Spacer](images/spacer_appbar.png)

## Separator

`Separator` shows a vertical line to visually group or separate the AppBar contents.

The following example depicts the code to provide a vertical line between a group of buttons in the AppBar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/appbar/design/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/appbar/design/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Separator](images/separator_appbar.png)

## Media Query

Media Query is used to adjusting the AppBar for different screen sizes. Resize the screen to observe the responsive layout of the AppBar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/media/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Media.cs" %}
{% include code-snippet/appbar/design/media/media.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/media/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Media.cs" %}
{% include code-snippet/appbar/design/media/media.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Media Query](images/media_appbar.png)

## Designing AppBar with Menu

AppBar is rendered with a Menu component in its AppBar header area. Menu component's styles are inherited from the AppBar component using the `e-inherit` CSS class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Menu.cs" %}
{% include code-snippet/appbar/design/menu/menu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Menu.cs" %}
{% include code-snippet/appbar/design/menu/menu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Menu](images/menu_appbar.png)

## Designing AppBar with Buttons

The AppBar is rendered with a Button and DropDownButton component in its AppBar header area. Button and DropDownButton components’ styles are inherited from the AppBar component using the `e-inherit` CSS class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/buttons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Button.cs" %}
{% include code-snippet/appbar/design/buttons/buttons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/buttons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Button.cs" %}
{% include code-snippet/appbar/design/buttons/buttons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Buttons](images/buttons_appbar.png)

## Designing AppBar with SideBar

The AppBar is rendered with the SideBar component below the AppBar. Click on the menu icon to expand/collapse the Sidebar. In the following sample, the `toggle` method has been used to show or hide the Sidebar on the AppBar button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/sidebar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sidebar.cs" %}
{% include code-snippet/appbar/design/sidebar/sidebar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/design/sidebar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sidebar.cs" %}
{% include code-snippet/appbar/design/sidebar/sidebar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with SideBar](images/sidebar_appbar.png)