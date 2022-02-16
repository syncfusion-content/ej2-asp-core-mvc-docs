---
layout: post
title: Show Hide Spinner in ##Platform_Name## Document Editor Component
description: Learn here all about Show Hide Spinner in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Show Hide Spinner
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to show and hide spinner while opening document in React Document Editor component

Using [`spinner`](https://ej2.syncfusion.com/aspnetcore/documentation/spinner/getting-started-asp-core/) component, you can show/hide spinner while opening document in DocumentEditor .

Example code snippet to show/hide spinner

```typescript
// showSpinner() will make the spinner visible
showSpinner(document.getElementById('container'));

// hideSpinner() method used hide spinner
hideSpinner(document.getElementById('container'));
```

Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/spinner/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spinner.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/spinner/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spinner.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



> In above example, we have used setInterval to hide spinner, just for demo purpose.
