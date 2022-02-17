---
layout: post
title: Template in ##Platform_Name## Spinner Component
description: Learn here all about Template in Syncfusion ##Platform_Name## Spinner component and more.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the template to the Spinner

You can use custom templates on the Spinner instead of the default Spinner by specifying the template in the `setSpinner` method.

The following steps explains you on how to define template for Spinner.

* Pass your custom template to the `setSpinner` method like as below.

```typescript
// Specify the template content to be displayed in the Spinner

setSpinner({ template: '<div style="width:100%;height:100%" class="custom-rolling"><div></div></div>'});
```

> You should set the template to the Spinner before creating the respective Essential JS 2 component. Also,until we replace `setSpinner` template, the further Essential JS 2 component rendering is created with given template only.

* Now, render the Essential JS 2 component. It's render the Spinner with the template specified in the `setSpinner` method.

> In the below sample, we have rendered the Grid component with custom Spinner using `setSpinner` method. You have to define the styles for the template in style section.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spinner/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/spinner/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spinner/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/spinner/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

