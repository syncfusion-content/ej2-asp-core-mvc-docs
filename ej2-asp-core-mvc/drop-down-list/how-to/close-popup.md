---
layout: post
title: How to close ##Platform_Name## DropDownList popup on scroll | Syncfusion
description: Close Syncfusion ##Platform_Name## DropDownList popup on window scroll by invoking the hidePopup method within a window scroll event handler.
platform: ej2-asp-core-mvc
control: Close Popup
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to close popup on scroll in ##Platform_Name## DropDownList

By using the `hidePopup` method in DropDownList, you can close the popup on scroll when triggered the windows scroll event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/close-popup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Closepopup.cs" %}
{% include code-snippet/dropdownlist/how-to/close-popup/closepopup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/close-popup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Closepopup.cs" %}
{% include code-snippet/dropdownlist/how-to/close-popup/closepopup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

