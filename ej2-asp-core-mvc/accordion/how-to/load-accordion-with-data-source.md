---
layout: post
title: Load Accordion With Data Source in ##Platform_Name## Accordion Component
description: Learn here all about Load Accordion With Data Source in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: Load Accordion With Data Source
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load accordion with DataSource

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

