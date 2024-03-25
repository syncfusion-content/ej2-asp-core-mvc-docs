---
layout: post
title: Methods in ##Platform_Name## TextArea control | Syncfusion
description: Checkout and learn about methods in the ##Platform_Name## TextArea control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Methods 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Methods in ##Platform_Name## TextArea Control

This section outlines the methods available for interacting with the TextArea control.

## FocusIn method

The [focusIn](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_focusIn) method in the TextArea, is used to set focus to the textarea element, enabling user interaction.

By calling the `focusIn` method, you can programmatically set focus to the TextArea control, allowing users to interact with it via keyboard input or other means.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/methods-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/methods-cs1/methods1.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/methods-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/methods-cs1/methods1.cs %}
{% endhighlight %}
{% endtabs %}
{% previewsample "page.domainurl/code-snippet/textarea/methods-cs1" %}
{% endif %}

## FocusOut method

The [focusOut](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_focusOut) method in the TextArea control is used to remove focus from the textarea element, ending user interaction.
This method is beneficial for scenarios where user need to programmatically remove focus from the TextArea control, such as after completing a specific task or when navigating to another element in the application.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/methods-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/methods-cs2/methods2.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/methods-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/methods-cs2/methods2.cs %}
{% endhighlight %}
{% endtabs %}
{% previewsample "page.domainurl/code-snippet/textarea/methods-cs2" %}
{% endif %}

## GetPersistData method

The [getPersistData](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_getPersistData) method in the TextArea control retrieves the properties that need to be maintained in the persisted state.
This method returns an object containing the properties to be persisted, which can include various configuration options and state information of the TextArea control. 


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/methods-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/methods-cs3/methods3.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/methods-cs3/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/methods-cs3/methods3.cs %}
{% endhighlight %}
{% endtabs %}
{% previewsample "page.domainurl/code-snippet/textarea/methods-cs3" %}
{% endif %}
