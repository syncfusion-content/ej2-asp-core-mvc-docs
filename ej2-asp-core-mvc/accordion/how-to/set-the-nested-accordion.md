---
layout: post
title: Set The Nested Accordion in ##Platform_Name## Accordion Component
description: Learn here all about Set The Nested Accordion in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: Set The Nested Accordion
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the nested Accordion

Accordion supports to render `nested` level of Accordion by using content property. You can give nested Accordion content inside the parent Accordion content property by using `id` of nested element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/nested/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nested.cs" %}
{% include code-snippet/accordion/how-to/nested/nested.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/nested/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nested.cs" %}
{% include code-snippet/accordion/how-to/nested/nested.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](../images/nested.PNG)