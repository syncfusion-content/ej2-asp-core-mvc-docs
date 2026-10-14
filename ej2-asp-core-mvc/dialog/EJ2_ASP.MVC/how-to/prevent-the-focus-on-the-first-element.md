---
layout: post
title: Prevent focus on first element in dialog | Syncfusion
description: Prevent the Syncfusion ##Platform_Name## Dialog from auto-focusing the first content element by enabling the preventFocus argument in the open event.
platform: ej2-asp-core-mvc
control: Prevent The Focus On The First Element
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to prevent focus on the first element in ##Platform_Name## Dialog

By default, when a Dialog opens, focus automatically shifts to the first focusable element in the content area (such as an input field or button). The [`Open`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Open) event provides a `preventFocus` parameter that allows you to prevent this behavior, keeping focus on the triggering element or implementing custom focus logic.

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

