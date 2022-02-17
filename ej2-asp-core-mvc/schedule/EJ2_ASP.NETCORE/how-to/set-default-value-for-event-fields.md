---
layout: post
title: Set Default Value For Event Fields in ##Platform_Name## Schedule Component
description: Learn here all about Set Default Value For Event Fields in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Set Default Value For Event Fields
publishingplatform: ##Platform_Name##
documentation: ug
---

# Set Default Value for Event Fields

Event window default fields name like Title, Location, etc.. can be customized and default value can be set to Subject field using `default` property which will be added if an appointment is created with empty subject.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/default-subject/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/default-subject/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/default-subject/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/default-subject/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

