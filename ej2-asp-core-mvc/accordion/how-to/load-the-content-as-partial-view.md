---
layout: post
title: Load The Content As Partial View in ##Platform_Name## Accordion Component
description: Learn here all about how to load the content as partial view in Syncfusion ##Platform_Name## Accordion component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load The Content As Partial View
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load the content as partial view to Accordion

Since Accordion is a Navigation control, it doesn't have support to load any content directly or using any DataAdaptor. But it is provided with the items support. So to load the content as partial view, you would need to make use of the AJAX or EJ2 Datamanager as described in [How-To](./load-accordion-with-data-source) section help document.

The below demo explains how to create the Accordion items dynamically and then to load the other Syncfusion controls in it from partial views.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/partial-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Partialview.cs" %}
{% include code-snippet/accordion/how-to/partial-view/partialview.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/partial-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Partialview.cs" %}
{% include code-snippet/accordion/how-to/partial-view/partialview.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Alt text](../images/mvc.PNG)

![Alt text](../images/core.PNG)