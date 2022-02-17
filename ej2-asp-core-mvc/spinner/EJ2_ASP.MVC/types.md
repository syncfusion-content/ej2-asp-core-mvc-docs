---
layout: post
title: Types in ##Platform_Name## Spinner Component
description: Learn here all about Types in Syncfusion ##Platform_Name## Spinner component and more.
platform: ej2-asp-core-mvc
control: Types
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change the type of the Spinner

By default, the Spinner is loaded in the applicable Essential JS 2 component based on the theme imported into the page. Based on the theme, the type is set to the Spinner.
The available types are:
* Material
* Fabric
* Bootstrap

You can change the Essential JS 2 component spinner type by passing the type of the spinner as parameter to the `setSpinner` method like as below.

```typescript
// Specify the type of the Spinner to be displayed

setSpinner({ type: 'Bootstrap'});
```

> After Essential JS 2 component creation only, you can change the Essential JS 2 component spinner type.

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

