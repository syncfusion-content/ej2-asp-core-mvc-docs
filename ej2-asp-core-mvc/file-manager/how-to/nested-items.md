---
layout: post
title: Nested Items in ##Platform_Name## File Manager Control | Syncfusion
description: Learn here all about Nested Items in Syncfusion ##Platform_Name## File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Nested Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Nested FileManager

FileManager can be rendered inside other controls like Tab, Dialog, and more.

* [Adding File Manager inside the dialog](#adding-file-manager-inside-the-dialog)
* [Adding  File Manager inside the tab](#adding-file-manager-inside-the-tab)

## Adding File Manager inside the dialog

The following example shows the File Manager control rendered inside the dialog. Click the browse button in the Uploader element to open the File Manager inside the Dialog control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/file-dialog/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/file-dialog/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


The initial output will look like the image below.

![FileManager upload ](../images/file_upload.PNG)

After clicking the file browser button, the File Manager is rendered within a dialog. The output will look like the image below.

![FileManager inside dialog ](../images/file_dialog.PNG)

## Adding File Manager inside the tab

The following example demonstrates the File Manager control placed inside the content area of a tab element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-tab/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/file-tab/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-tab/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/file-tab/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The initial view output will look like the image below.

![FileManager inside tab ](../images/file_tab.PNG)

The output will look like the image below when the File Manager is placed inside the tab.

![FileManager inside tab ](../images/file_tab_item.PNG)