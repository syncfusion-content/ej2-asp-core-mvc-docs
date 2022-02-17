---
layout: post
title: Rounded Corner in ##Platform_Name## Menu Component
description: Learn here all about Rounded Corner in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Rounded Corner
publishingplatform: ##Platform_Name##
documentation: ug
---

# Menu with rounded corner

The rounded corner can be achieved by using the [`cssClass`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~CssClass.html) property. Add a custom class to the menu component and customize it using the `border-radius` CSS property. For more information, refer to the `styles` specified in the below sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/rounded/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rounded.cs" %}
{% include code-snippet/menu/how-to/rounded/Rounded.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/rounded/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rounded.cs" %}
{% include code-snippet/menu/how-to/rounded/Rounded.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


