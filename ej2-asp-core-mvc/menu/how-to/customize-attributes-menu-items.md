---
layout: post
title: Customize HTML Attributes for Menu Items in ##Platform_Name## Menu Component | Syncfusion
description: Learn here all about Customize HTML Attributes for Menu Items in Syncfusion ##Platform_Name## Menu component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Create Mnemonic Ui In Menuitem
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize HTML Attributes for Menu Items in ##Platform_Name## Menu control

The [htmlAttributes](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_HtmlAttributes) property in the Context Menu component allows you to add custom HTML attributes to the root element of the menu. This feature is particularly useful for enhancing accessibility, adding custom data attributes, or including any additional properties that can be leveraged for styling or functionality.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/htmlAttributes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeMenuItems.cs" %}
{% include code-snippet/menu/how-to/htmlAttributes/CustomizeMenuItems.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/htmlAttributes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeMenuItems.cs" %}
{% include code-snippet/menu/how-to/htmlAttributes/CustomizeMenuItems.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}