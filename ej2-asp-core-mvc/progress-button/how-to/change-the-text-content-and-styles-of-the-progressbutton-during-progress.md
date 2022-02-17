---
layout: post
title: Change The Text Content And Styles Of The Progressbutton During Progress in ##Platform_Name## Progress Button Component
description: Learn here all about Change The Text Content And Styles Of The Progressbutton During Progress in Syncfusion ##Platform_Name## Progress Button component and more.
platform: ej2-asp-core-mvc
control: Change The Text Content And Styles Of The Progressbutton During Progress
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change the text content and styles of the ProgressButton during progress

You can change the text content and styles of the ProgressButton during progress state by changing the text content and the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_CssClass) property at
the [`begin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_Begin) and [`end`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_End) events.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/change-content/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/change-content/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/change-content/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/change-content/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

