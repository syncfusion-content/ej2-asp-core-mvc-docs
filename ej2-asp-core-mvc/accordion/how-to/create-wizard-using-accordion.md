---
layout: post
title: Create Wizard Using Accordion in ##Platform_Name## Accordion Component
description: Learn here all about Create Wizard Using Accordion in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: Create Wizard Using Accordion
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create wizard using Accordion

Accordion items can be disabled dynamically by passing the index and boolean value with the enableItem method.

In the below demo, designed for simple payment module that enable/disable Accordion based on sequential validation of each Accordion content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/wizard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Wizard.cs" %}
{% include code-snippet/accordion/how-to/wizard/wizard.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/wizard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Wizard.cs" %}
{% include code-snippet/accordion/how-to/wizard/wizard.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

