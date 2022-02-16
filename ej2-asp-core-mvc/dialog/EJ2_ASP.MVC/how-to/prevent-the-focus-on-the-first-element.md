---
layout: post
title: Prevent The Focus On The First Element in ##Platform_Name## Dialog Component
description: Learn here all about Prevent The Focus On The First Element in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Prevent The Focus On The First Element
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent the focus on the first element

By default, the dialog focuses on the first elements of the content area which can be active and focusable. You can prevent this default focusing behavior using the [`Open`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Open) event and by enabling the `preventFocus` argument.

Bind the open event and enable the preventFocus argument within an event like the below example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dlg-focus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dlg-focus/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dlg-focus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dlg-focus/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

