---
layout: post
title: Drag And Drop in ##Platform_Name## Uploader Component
description: Learn here all about Drag And Drop in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and drop

The uploader component allows you to drag and drop the files to upload.
You can drag the files from file explorer and drop into the drop area.
By default, the uploader component act as drop area element. The drop area gets highlighted when you drag the files over drop area.

## Custom drop area

The uploader component allows you to set external target element as drop area using the [dropArea](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Inputs.Uploader~DropArea.html) property. The element can be represented as HTML element or element’s id.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/custom-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/custom-drop/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/custom-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/custom-drop/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize drop area

You can customize the appearance of drop area by overriding the default drop area styles.
The class “” and “” is available to handle this customization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/customize-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-drop.cs" %}
{% include code-snippet/uploader/customize-drop/customize-drop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/customize-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-drop.cs" %}
{% include code-snippet/uploader/customize-drop/customize-drop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


