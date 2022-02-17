---
layout: post
title: Set Item Wise Custom Template in ##Platform_Name## Toolbar Component
description: Learn here all about Set Item Wise Custom Template in Syncfusion ##Platform_Name## Toolbar component and more.
platform: ej2-asp-core-mvc
control: Set Item Wise Custom Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set item-wise custom template

The Toolbar supports adding template commands using the  `template` property. Template property can be given as the `HTML element` that is either a `string`  or a `query selector`.

## As a string

The HTML element tag can be given as a string for the template property. Here, the checkbox is rendered as a HTML template.

```typescript
template: "<div><input type='checkbox' id='check1' checked=''>Accept</input></div>"

```

## As a selector

The template property also allows getting template content through query `selector`. Here, checkbox 'ID' attribute is specified in the template.

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

