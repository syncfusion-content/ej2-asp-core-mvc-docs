---
layout: post
title: Read dialog values on button click | Syncfusion
description: Read all input values from the Syncfusion ##Platform_Name## Dialog by binding an action handler to the footer buttons via the Buttons property.
platform: ej2-asp-core-mvc
control: Read All The Values From Dialog On Button Click
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to read Dialog values on button click in ASP.NET MVC Dialog

You can read and validate dialog element values by binding an action handler to the footer buttons. When a user clicks a footer button, you can retrieve the input values from form fields within the dialog and display them in a confirmation dialog. The [`Buttons`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) property provides options to bind click events to action buttons. For detailed information about button configuration, refer to the [`footer`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) documentation. The code sample below demonstrates how to validate input values in the footer button click event and send the collected values as the content of a confirmation dialog.

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

