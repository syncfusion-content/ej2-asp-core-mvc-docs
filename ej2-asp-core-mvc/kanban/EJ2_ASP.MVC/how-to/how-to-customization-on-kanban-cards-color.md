---
layout: post
title: Set the cards' left colour in Syncfusion ##Platform_Name## Kanban Component
description: This section explains how to set the card's left border colour in Syncfusion ##Platform_Name## Kanban component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Set the card colour
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to set the cards' left border colour in the Kanban component

You can customize the Kanban cards' left border colour in the following two ways:

## Default Card

You can map the data source fields to [`grabberField`](../../api/KanbanCardSettings#grabberfield) inside the `e-kanban-cardsettings` property. It will show the cards' left border colour based on data source mapping fields.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/how-to/custom-card-template/default-card/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/how-to/custom-card-template/default-card/controller.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/how-to/custom-card-template/default-card/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/how-to/custom-card-template/default-card/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/how-to/custom-card-template/default-card/controller.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/how-to/custom-card-template/default-card/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Template Card

If you are using a card template, you can define the class name based on the cards and add your custom styles using CSS. In the following sample, class name is added to each card based on data source mapping fields using the [`cardRendered`](../../api/kanban#cardrendered) event and added the styles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/how-to/custom-card-template/template-card/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/how-to/custom-card-template/template-card/controller.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/how-to/custom-card-template/template-card/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/how-to/custom-card-template/template-card/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/how-to/custom-card-template/template-card/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/how-to/custom-card-template/template-card/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
