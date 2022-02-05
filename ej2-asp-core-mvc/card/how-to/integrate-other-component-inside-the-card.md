---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Integrate Other Component Inside The Card of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Integrate Other Component Inside The Card
publishingplatform: ##Platform_Name##
documentation: ug
---


# Integrate other component inside the card

You can integrate any component inside the card element. Here ListView component is placed inside the card for showcasing the To-Do list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/card/card_with_list/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card_with_list/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/card/card_with_list/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card_with_list/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](./../images/card-other.PNG)