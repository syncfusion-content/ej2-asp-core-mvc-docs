---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Template Configuration of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Template Configuration
publishingplatform: ##Platform_Name##
documentation: ug
---

  e-popup-text     | Button text is only  visible in the `Popup`.
  e-toolbar-text   | Button text is only visible on the `Toolbar`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/template-configuration/buttontext/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Buttontext.cs" %}
{% include code-snippet/toolbar/template-configuration/buttontext/buttontext.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/template-configuration/buttontext/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Buttontext.cs" %}
{% include code-snippet/toolbar/template-configuration/buttontext/buttontext.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

