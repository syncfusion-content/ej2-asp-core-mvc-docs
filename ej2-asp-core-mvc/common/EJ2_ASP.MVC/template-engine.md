---
layout: post
title: Template Engine in ##Platform_Name## Common Component
description: Learn here all about Template Engine in Syncfusion ##Platform_Name## Common component and more.
platform: ej2-asp-core-mvc
control: Template Engine
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template Engine

Syncfusion ASP.NET MVC (Essential JS 2) has built-in template engine which provides options to compile
template string into a executable function. Then the generated executable function can
be used for rendering DOM element using desired data.

## Compiling

`compile` method from `ej2-base` can be used to convert our template strings into
executable functions.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
{% include code-snippet/common/template-engine/compiling/razor %}
{% endhighlight %}{% endtabs %}

## Available Template Syntax

| Name | Syntax | Description |
| --- | --- | --- | --- |
| Expression | `<div>${name}</div>`  | We have expression evolution as like ES6 expression string literals. |
| Dot Variable Access | `<div>${person.info.name}</div>` | Access the json variable with dot notation. |
| Variable Function | `<div>${name.toUpperCase()}</div>` | Utilize the variable function example, `name.toUpperCase()` |
| Window Function | `<div>${getCurrentTime()}div>` | Use window function inside template. > Here, `getCurrentTime()` is a function that defined in the window object. |
| Custom Helper Function | `<div>${covertToCurrency()}div>` | Use function that passed in [helper](#custom-helper) function. |
| IF Else Statement | `<div>` <br/> `${if(gender===”male”)}` <br/> `<span class=’ico-male’>Male</span>` <br/> `${else}` <br/> `<span class=’ico-female’>Female</span>` <br/> `${/if}` <br/> `</div>` | Branching statement in Template. |
| For Statement | `<div>` <br/> `${for(mark of marks)}` <br/> `<span>${mark}</span>` <br/> `${/for}` <br/> `</div>` | Use for looping inside template. |
| For Index value access | `<div>` <br/> `${for(mark of marks)}` <br/> `<span>${markIndex}</span>` <br/> `${/for}` <br/> `</div>` | Get the index value of item while using for statement. Use the variable `Index` that suffixed with loop item name. |

## Custom Helper

Custom helper function can be defined and passed to `compile` function. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Custom-helper.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
{% include code-snippet/common/template-engine/custom-helper/razor %}
{% endhighlight %}{% endtabs %}
{% endif %}


