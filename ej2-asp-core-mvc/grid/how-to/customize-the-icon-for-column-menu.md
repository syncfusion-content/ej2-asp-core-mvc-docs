---
layout: post
title: Customize The Icon For Column Menu in ##Platform_Name## Grid Component
description: Learn here all about Customize The Icon For Column Menu in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Customize The Icon For Column Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the icon for column menu

You can customize the column menu icon by overriding the default grid class **.e-icons.e-columnmenu** with a custom property **content** as mentioned below,

```css
.e-grid .e-columnheader .e-icons.e-columnmenu::before {
      content: "\e941";
}
```

In the below sample, grid is rendered with a customized column menu icon.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/custom-column-menu-icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-icon.cs" %}
{% include code-snippet/grid/how-to/custom-column-menu-icon/column-icon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/custom-column-menu-icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-icon.cs" %}
{% include code-snippet/grid/how-to/custom-column-menu-icon/column-icon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


