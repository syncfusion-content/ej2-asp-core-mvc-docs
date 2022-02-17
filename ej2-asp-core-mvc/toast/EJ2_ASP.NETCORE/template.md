---
layout: post
title: Template in ##Platform_Name## Toast Component
description: Learn here all about Template in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Template

The [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Template) property can be given as the `HTML element`; this can be either a `string` or `query selector`.

The HTML element tag can be given as a string for the Template property.

```typescript
template: "<div>Toast Content</div>"

```

The Template property allows getting the template content using the query `selector`. Here, the element 'ID' attribute is specified in the template.

```typescript
template: "#Template"

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/template/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/template/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Toast template](./images/toast-temp.PNG)

## See Also

* [How to add dynamic template](./how-to/add-dynamic-template/)

* [How to play an audio before open the toast](./how-to/play-an-audio-before-open-the-toast/)