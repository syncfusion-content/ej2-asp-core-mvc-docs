---
layout: post
title: Close Dialog While Click On Outside Of Dialog in ##Platform_Name## Dialog Component
description: Learn here all about Close Dialog While Click On Outside Of Dialog in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Close Dialog While Click On Outside Of Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Close Dialog when click outside of its region

By default, dialog can be closed by pressing Esc key and clicking the close icon on the right of dialog header. It can also be closed by clicking outside of the dialog using hide method.
Set the [`closeOnEscape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_CloseOnEscape) property value to false to prevent closing of the dialog when pressing Esc key.

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

