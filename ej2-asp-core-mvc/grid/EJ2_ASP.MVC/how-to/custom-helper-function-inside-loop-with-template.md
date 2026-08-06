---
layout: post
title: ##Platform_Name## Grid Custom Column Templates | Syncfusion
description: Learn how to create custom column templates in ##Platform_Name## Data Grid using helper functions, template loops, and dynamic rendering for customized cell content.
platform: ej2-asp-core-mvc
control: Use custom helper inside the loop with templates 
documentation: ug
domainurl: ##DomainURL##
---

# Custom Column Templates in ASP.NET MVC Data Grid

The Syncfusion ASP.NET MVC Grid allows you to use custom helpers inside the loop with `Template` property of a column. This feature enables you to create complex templates that can incorporate additional helper functions.

The **Customer Rating** column includes a custom template defined using `Template`. Inside this template, iterates through the **item** array and generates <span> tag, displayed as stars using the CSS below:

```css
.e-grid .rating .star:before {
    content: '★';
}

.e-grid .rating .star {
    font-size: 132%;
    color: lightgrey;
}
```

The class is dynamically assigned based on the rating value, highlighting the stars using the CSS below:

```css
.e-grid .rating .star.checked {
    color: #ffa600;
}
```

This is demonstrated in the following example:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/custom-helper/razor %}
{% endhighlight %}
{% highlight c# tabtitle="custom-helper.cs" %}
{% include code-snippet/grid/how-to/custom-helper/custom-helper.cs %}
{% endhighlight %}
{% endtabs %}

![custom helper](../images/customer-loop.png)