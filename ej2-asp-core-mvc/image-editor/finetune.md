---
layout: post
title: Finetune in ##Platform_Name## Image editor control | Syncfusion
description: Learn here all about Finetune in Syncfusion Image Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Finetune 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Finetune in the ##Platform_Name## Image Editor control

Fine-tuning involves making precise adjustments to the settings of an image filter in order to achieve a specific desired effect. It provides control over the intensity and specific aspects of the filter's impact on the image. For example, fine-tuning allows you to modify parameters like brightness, saturation, or other relevant properties to fine-tune the level or quality of the filter's effect. This level of control enables you to achieve the exact look or outcome you want for your image.

## Adjust the brightness, contrast, and saturation

The `finetuneImage` method is designed to facilitate fine-tuning operations on an image. It accepts two parameters: the first parameter is `ImageFinetuneOption` which determines the type of fine-tuning to be applied (brightness, contrast, and saturation), and the second parameter represents the fine-tuning value, indicating the degree or intensity of the adjustment. This method allows for convenient adjustment of brightness, contrast, and saturation by specifying the desired type and corresponding value.

The `finetuneImage` method is used to perform brightness, contrast, and saturation fine-tuning by specifying this type as a first parameter and specifying the fine-tuning value as the second parameter of the method. 

Here is an example of brightness, contrast, and saturation fine-tuning using the `finetuneImage` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/finetune/brightness/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/finetune/brightness/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/finetune/brightness/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/finetune/brightness/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-brightness.jpg)

## Adjust the hue, exposure, blur, and opacity

The `finetuneImage` method is designed to facilitate fine-tuning operations on an image. It accepts two parameters: the first parameter is `ImageFinetuneOption` which determines the type of fine-tuning to be applied (hue, exposure, blur, and opacity), and the second parameter represents the fine-tuning value, indicating the degree or intensity of the adjustment. This method allows for convenient adjustment of hue, exposure, blur, and opacity by specifying the desired type and corresponding value.

Here is an example of hue, exposure, blur, and opacity fine-tuning using the `finetuneImage` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/finetune/blur/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/finetune/blur/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/finetune/blur/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/finetune/blur/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-blur.jpg)

## Finetune value changing event 

The [`finetuneValueChanging`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ImageEditor.ImageEditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_FinetuneValueChanging) event is triggered when performing fine-tuning on the image. This event is passed an object that contains information about the fine-tuning event, such as the type of fine-tuning and the value of fine-tuning performed. 

The parameter available in the `FinetuneEventArgs` event is, 

FinetuneEventArgs.finetune - The type of fine-tuning as ImageFinetuneOption to be applied in the image editor. 

FinetuneEventArgs.value - The fine-tuning value to be applied in the image editor. 

FinetuneEventArgs.cancel – Specifies a boolean value to cancel the fine-tuning action. 
