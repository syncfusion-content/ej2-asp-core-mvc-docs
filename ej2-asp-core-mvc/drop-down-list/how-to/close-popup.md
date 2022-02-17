---
layout: post
title: Close Popup in ##Platform_Name## Drop Down List Component
description: Learn here all about Close Popup in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Close Popup
publishingplatform: ##Platform_Name##
documentation: ug
---


# Close the popup on scroll

By using the `hidePopup` method in DropDownList, you can close the popup on scroll when triggered the windows scroll event.

The following example demonstrate about how to close the popup on scroll.

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

