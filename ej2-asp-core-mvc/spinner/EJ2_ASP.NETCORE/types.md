---
layout: post
title: Change the Type of the Spinner in ##Platform_Name## Spinner | Syncfusion
description: Change the Syncfusion ##Platform_Name## Spinner type by using the setSpinner method to switch between Material, Fabric, and Bootstrap spinner styles.
platform: ej2-asp-core-mvc
control: Types
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change the Type of the Spinner in ##Platform_Name## Spinner

By default, the Spinner is loaded in the applicable Essential<sup style="font-size:70%">&reg;</sup> JS 2 component based on the theme imported into the page. Based on the theme, the type is set to the Spinner.
The available types are:
* Material
* Fabric
* Bootstrap

You can change the Essential<sup style="font-size:70%">&reg;</sup> JS 2 component spinner type by passing the type of the spinner as parameter to the `setSpinner` method like as below.

```typescript
// Specify the type of the Spinner to be displayed

setSpinner({ type: 'Bootstrap'});
```

N> After Essential<sup style="font-size:70%">&reg;</sup> JS 2 component creation only, you can change the Essential<sup style="font-size:70%">&reg;</sup> JS 2 component spinner type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spinner/type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Type.cs" %}
{% include code-snippet/spinner/type/type.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spinner/type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Type.cs" %}
{% include code-snippet/spinner/type/type.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

