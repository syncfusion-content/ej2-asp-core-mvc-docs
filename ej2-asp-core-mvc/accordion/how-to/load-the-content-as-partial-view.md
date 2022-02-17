---
layout: post
title: Load The Content As Partial View in ##Platform_Name## Accordion Component
description: Learn here all about Load The Content As Partial View in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: Load The Content As Partial View
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load the content as partial view to Accordion

Since Accordion is a Navigation control, it doesn't have support to load any content directly or using any DataAdaptor. But it is provided with the items support. So to load the content as partial view, you would need to make use of the AJAX or EJ2 Datamanager as described in our [How-To](./load-accordion-with-data-source) section help document.

In the below demo, we have explained on how to create the Accordion items dynamically and then to load the other Syncfusion controls in it from partial views.

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



Output be like the below.

![Alt text](../images/mvc.PNG)

![Alt text](../images/core.PNG)