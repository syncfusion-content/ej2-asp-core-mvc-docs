---
layout: post
title: Icons And Templates in ##Platform_Name## List Box Component
description: Learn here all about Icons And Templates in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Icons And Templates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Icons and Customization

## Icons

To place the icon on a list box, set the [`iconCss`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~IconCss.html) property to `e-icons` with the required icon CSS. By default, the icon is positioned to the left side of the list.

In the following sample, icon classes are mapped with `iconCss` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/icons-template/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/listbox/icons-template/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/icons-template/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/listbox/icons-template/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Templates

ListBox items can be customized according to the requirement using [`itemTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~ItemTemplate.html) property.

In the following sample, the items in the cart are displayed using list box template,

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/icons-template/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/listbox/icons-template/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/icons-template/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/listbox/icons-template/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

