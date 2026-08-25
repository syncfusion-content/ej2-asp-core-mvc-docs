---
layout: post
title: Close Dialog on Outside Click in ##Platform_Name## Dialog | Syncfusion
description: Close the Syncfusion ##Platform_Name## Dialog when the user clicks outside its region by calling the hide method on the outside click event.
platform: ej2-asp-core-mvc
control: Close Dialog While Click On Outside Of Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Close Dialog on Outside Click in ##Platform_Name## Dialog

By default, Dialog can be closed by pressing Esc key and clicking the close icon on the right of Dialog header. It can also be closed by clicking outside of the Dialog using `hide` method. Set the [`closeOnEscape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_CloseOnEscape) property value to `false` to prevent closing of the Dialog when pressing Esc key.

In the following sample, dialog is closed when clicking outside the dialog area using `hide` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/outside-click/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/outside-click/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/outside-click/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/outside-click/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

