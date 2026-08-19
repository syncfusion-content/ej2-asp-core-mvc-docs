---
layout: post
title: Reverse in ASP.NET Core Timeline | Syncfusion
description: Display Syncfusion ASP.NET Core Timeline items in reverse order for different alignments using the `reverse` property for better user interaction.
platform: ej2-asp-core-mvc
control: Reverse
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reverse in ASP.NET Core Timeline

You can display the Timeline items in reverse order, for different alignments by using the [reverse](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Timeline.html#Syncfusion_EJ2_Layouts_Timeline_Reverse) property which provides adaptability and improves user interaction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/reverse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/reverse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Reverse](images/reverse.png)
