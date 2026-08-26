---
layout: post
title: How to set custom template in ##Platform_Name## Toolbar | Syncfusion
description: Add a custom template to a Syncfusion ##Platform_Name## Toolbar item by passing an HTML element string or query selector to the `template` property.
platform: ej2-asp-core-mvc
control: Set Item Wise Custom Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to set custom template in ##Platform_Name## Toolbar

The Toolbar supports adding custom templates to items using the `template` property, which accepts HTML as either an inline string or a query selector. 

## As a string

You can provide the HTML element as a string for the template property. In this example, a checkbox is rendered as an inline HTML template.

```typescript
template: "<div><input type='checkbox' id='check1' checked=''>Accept</input></div>"

```

## As a selector

The template property also allows you to reference template content through a query selector. Here, the checkbox ID attribute is specified in the template.

```typescript
template: "#Template"

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/selector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selector.cs" %}
{% include code-snippet/toolbar/how-to/selector/selector.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/selector/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selector.cs" %}
{% include code-snippet/toolbar/how-to/selector/selector.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

