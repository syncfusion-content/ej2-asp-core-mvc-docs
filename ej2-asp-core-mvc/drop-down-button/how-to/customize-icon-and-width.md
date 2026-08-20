---
layout: post
title: Customize icon and width in DropDownButton | Syncfusion
description: Customize the Syncfusion ##Platform_Name## DropDownButton icon and width by setting the iconPosition, width, and a custom CSS class via cssClass.
platform: ej2-asp-core-mvc
control: Customize Icon And Width
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize icon and width in ##Platform_Name## DropDownButton

Width of the DropDownButton can be customized by setting required width to the dropdown element.

The following UI can be achieved by setting [`iconPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconPosition) as `Top`, width as `85px` and size of the font icon as `40px` by adding `e-custom` class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/underline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/dropdownbutton/underline/underline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/underline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/dropdownbutton/underline/underline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

