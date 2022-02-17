---
layout: post
title: Add Dynamic Template in ##Platform_Name## Toast Component
description: Learn here all about Add Dynamic Template in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Add Dynamic Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add dynamic template

Toast supports to change templates dynamically with displaying in multiple toasts. You can change the toast properties while calling in the `show` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/dynamic-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/dynamic-template/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/dynamic-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/dynamic-template/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

