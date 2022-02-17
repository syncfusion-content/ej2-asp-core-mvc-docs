---
layout: post
title: Multiline in ##Platform_Name## Textbox Component
description: Learn here all about Multiline in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Multiline
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multiline TextBox

This feature allows the textbox to accept one or more lines of text like address, description, comments, and more.

## Create multiline textbox

You can convert the default textbox into the multiline textbox by setting the [multiline](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_Multiline) API value as true or pass HTML5 textarea as element to the textbox.

> The multiline textbox allows you to resize it in vertical direction alone.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/textarea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Textarea.cs" %}
{% include code-snippet/textbox/multiline/textarea/textarea.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/textarea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Textarea.cs" %}
{% include code-snippet/textbox/multiline/textarea/textarea.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](./images/textarea.png)

## Implementing floating label

You can achieve the floating label behavior in the multiline textbox by setting [floatLabelType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_FloatLabelType) as 'Auto'. The placeholder text act as floating label to the multiline textbox. You can provide the placeholder text to the multiline textbox either by using the [placeholder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_Placeholder) property or placeholder attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/float/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Float.cs" %}
{% include code-snippet/textbox/multiline/float/float.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/float/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Float.cs" %}
{% include code-snippet/textbox/multiline/float/float.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](./images/float.png)

## Auto resizing

By default, you can manually resize the multiline textbox. But you can also create an `auto resizing` multiline textbox with both the initial and dynamic value change. It can be done by calculating the height of the textarea in the created event for initial value update and in the input event for dynamic value update of the auto resize multiline textbox, as explained in the following code sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/auto-resize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-resize.cs" %}
{% include code-snippet/textbox/multiline/auto-resize/auto-resize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/auto-resize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-resize.cs" %}
{% include code-snippet/textbox/multiline/auto-resize/auto-resize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Disable resizing

By default, the multiline textbox is rendered with resizable. You can disable the resize of the multiline textbox by applying the following CSS styles.

```CSS
    textarea.e-input,
    .e-float-input textarea,
    .e-float-input.e-control-wrapper textarea,
    .e-input-group textarea,
    .e-input-group.e-control-wrapper textarea {
        resize: none;
    }

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% include code-snippet/textbox/multiline/disable/disable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% include code-snippet/textbox/multiline/disable/disable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](./images/disable.png)

## Limit the text length

By default, the text length of the multiline textbox is unlimited. You can limit the text length by setting the `maxLength` attribute using the `addAttributes` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/maxlength/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Maxlength.cs" %}
{% include code-snippet/textbox/multiline/maxlength/maxlength.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/maxlength/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Maxlength.cs" %}
{% include code-snippet/textbox/multiline/maxlength/maxlength.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Count characters

You can show the number of characters entered inside the textarea by calculating the character count in the input event of multiline textbox. The character count is updated while entering or deleting any character inside the textarea. The character count shows how many characters can be entered or left to be entered.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Count.cs" %}
{% include code-snippet/textbox/multiline/count/count.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/multiline/count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Count.cs" %}
{% include code-snippet/textbox/multiline/count/count.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](./images/count.png)