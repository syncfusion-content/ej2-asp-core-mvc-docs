---
layout: post
title: Read All The Values From Dialog On Button Click in ##Platform_Name## Dialog Component
description: Learn here all about Read All The Values From Dialog On Button Click in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Read All The Values From Dialog On Button Click
publishingplatform: ##Platform_Name##
documentation: ug
---


# Read all values of Dialog on button click

You can read the dialog element values by binding the action handler to the footer buttons. The [`buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) property provides the options to bind events to the action buttons.
For detailed information about buttons , refer to the [`footer`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) section.
In the below sample, value of input elements within the dialog has been checked in the footer button click event and send the values as the content of confirmation dialog.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/read-all/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/read-all/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/read-all/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/read-all/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

