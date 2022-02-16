---
layout: post
title: How To in ##Platform_Name## Accordion Component
description: Learn here all about How To in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: How To
publishingplatform: ##Platform_Name##
documentation: ug
---


# How-To

## Set the nested Accordion

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

![Accordion Control with nested structure](./images/nested.PNG)

## Load content through Ajax

Accordion supports to load external contents through `AJAX` library. Refer the below steps.

* Import the `Ajax` module from `ej2-base` and initialize with URL path.

* Get data from the Ajax Success event to initialize Accordion with retrieved external path data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/ajax/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ajax.cs" %}
{% include code-snippet/accordion/how-to/ajax/ajax.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/ajax/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ajax.cs" %}
{% include code-snippet/accordion/how-to/ajax/ajax.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## To keep single pane open always

By default, all Accordion panels are collapsible. You can customize the Accordion to keep one panel as expanded state always. This is applicable for `Single` expand mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/openalways/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Openalways.cs" %}
{% include code-snippet/accordion/how-to/openalways/openalways.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/openalways/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Openalways.cs" %}
{% include code-snippet/accordion/how-to/openalways/openalways.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Load accordion with DataSource

You can bind any data object to Accordion items, by mapping it to [header](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.AccordionAccordionItem~Header.html) and [content](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.AccordionAccordionItem~Content.html)&nbsp; property.

In the below demo, Data is fetched from an `OData` service using `DataManager`. The result data is formatted as a JSON object with `header` and `content` fields, which is set to items property of Accordion.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/accordion/how-to/datasource/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/datasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/accordion/how-to/datasource/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

