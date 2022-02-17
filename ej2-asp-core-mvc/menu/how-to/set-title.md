---
layout: post
title: Set Title in ##Platform_Name## Menu Component
description: Learn here all about Set Title in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Set Title
publishingplatform: ##Platform_Name##
documentation: ug
---

# Set title for Menu Items

In this sample , the title for settings icon  can be achievable by using `beforeItemRender`  client-side event in Menu component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/menu/how-to/title/Title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/menu/how-to/title/Title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

