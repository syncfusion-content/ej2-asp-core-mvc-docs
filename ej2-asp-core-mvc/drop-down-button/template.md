---
layout: post
title: Item Template in ##Platform_Name## DropDownButton | Syncfusion
description: Define custom templates for Syncfusion ##Platform_Name## DropDownButton items via the ItemTemplate property to render icons, formatted text, or other UI.
platform: ej2-asp-core-mvc
control: ItemTempalte
publishingplatform: ##Platform_Name##
documentation: ug
---

# Item Template in ##Platform_Name## DropDownButton

The [`ItemTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_ItemTemplate) property in the DropDownButton component allows for the definition of custom templates to display dropdown items. This feature is especially useful for customizing the appearance and layout of dropdown items beyond the default options provided. By utilizing this property, diverse content such as icons, formatted text, and other visual elements can be integrated into the dropdown items for a more engaging and tailored user interface.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="template.cs" %}
{% include code-snippet/dropdownbutton/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="template.cs" %}
{% include code-snippet/dropdownbutton/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Drop Down Button template](images/drop-down-menu-template.png)