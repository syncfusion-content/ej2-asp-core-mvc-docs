---
layout: post
title: Load Accordion With Data Source in ##Platform_Name## Accordion Control | Syncfusion
description: Learn here all about Load Accordion With Data Source in Syncfusion ##Platform_Name## Accordion control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load Accordion With Data Source
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load accordion with DataSource

You can bind any data object to Accordion items, by mapping it to [header](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.AccordionAccordionItem.html#Syncfusion_EJ2_Navigations_AccordionAccordionItem_Header) and [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.AccordionAccordionItem.html#Syncfusion_EJ2_Navigations_AccordionAccordionItem_Content)&nbsp; property.

In the below demo, Data is fetched from an `OData` service using `DataManager`. The result data is formatted as a JSON object with [header](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.AccordionAccordionItem.html#Syncfusion_EJ2_Navigations_AccordionAccordionItem_Header) and [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.AccordionAccordionItem.html#Syncfusion_EJ2_Navigations_AccordionAccordionItem_Content) fields, which is set to items property of Accordion.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/datasource/tagHelper %}
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

