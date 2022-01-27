---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize The Icon For Column Menu of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize The Icon For Column Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the icon for column menu

You can customize the column menu icon by overriding the default grid class **.e-icons.e-columnmenu** with a custom property **content** as mentioned below,

```css

.e-grid .e-columnheader .e-icons.e-columnmenu::before {
      content: "\e969";
}

```

In the below sample, grid is rendered with a customized column menu icon.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="custom-column-menu-icon" %}
{% include_relative code-snippet/how-to/custom-column-menu-icon/column-icon.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="custom-column-menu-icon" %}
{% include_relative code-snippet/how-to/custom-column-menu-icon/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="custom-column-menu-icon" %}
{% include_relative code-snippet/how-to/custom-column-menu-icon/column-icon.cs %}
{% endhighlight %}
{% highlight razor tabtitle="custom-column-menu-icon" %}
{% include_relative code-snippet/how-to/custom-column-menu-icon/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


