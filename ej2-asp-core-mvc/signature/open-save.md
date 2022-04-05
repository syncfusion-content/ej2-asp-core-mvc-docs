---
layout: post
title: Open and Save in ##Platform_Name## Signature Component
description: Learn here all about Open and Save in Syncfusion ##Platform_Name## Signature component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Open and Save
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open and Save Signature

The Signature component supports to open the signature by using hosted/online URL or base64. And it also supports various save options like image, base64, and blob.

## Open Signature

The signature component opens a pre-drawn signature as either base64 or hosted/ online URL using the `load` method. It supports the PNG, JPEG, and SVG image’s base64.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/signature/open-save/open-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/open-save/open-image/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/signature/open-save/open-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/open-save/open-image/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![Signature Sample](./images/open-image.PNG)

## Save Signature

The Signature control saves the signature as base64, blob, and image like PNG, JPEG, and SVG.

### Save as Base64

The `getSignature` method is used to get the signature as base64 with the PNG, JPEG, and SVG type. This can be loaded to signature using `load` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/signature/open-save/save-base/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/open-save/save-base/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/signature/open-save/save-base/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/open-save/save-base/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![Signature Sample](./images/save-base.PNG)

### Save as Blob

The `saveAsBlob` method is used to saves the signature as Blob. It is defined as the chunk of binary data stored as a single entity in a database system.

### Save as Image

The `save` method is used to saves the signature as an image. And it accepts file name and file type as parameter. The file type parameter supports PNG, JPEG, and SVG and the default file type is PNG.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/signature/open-save/save-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/open-save/save-image/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/signature/open-save/save-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/open-save/save-image/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![Signature Sample](./images/save-image.PNG)

## Save with Background

The [`saveWithBackground`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Signature.html#Syncfusion_EJ2_Inputs_Signature_SaveWithBackground) property is used to saves the signature with its background and its default value is true. So, by default the signature is saved with its background.

In the following sample, the background color is set as ‘rgb(103 58 183)’ and save with background as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/signature/open-save/save-bg/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/open-save/save-bg/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/signature/open-save/save-bg/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/open-save/save-bg/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![Signature Sample](./images/save-bg.PNG)