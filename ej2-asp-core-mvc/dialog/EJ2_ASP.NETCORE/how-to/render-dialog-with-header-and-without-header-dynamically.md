---
layout: post
title: Dynamically render dialog with and without headers
description: The dialog header can be dynamically shown or hidden using header properties, beforeOpen, and close events.
platform: ej2-asp-core-mvc
control: Dynamically render the dialog header
publishingplatform: ##Platform_Name##
documentation: ug
---

# Dynamically render the dialog header

Dynamically show or hide the dialog header by using the beforeOpen and close events. The dialog header content is changed dynamically based on the button click in the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dlg-width-without-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dlg-width-without-header/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dlg-width-without-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dlg-width-without-header/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}