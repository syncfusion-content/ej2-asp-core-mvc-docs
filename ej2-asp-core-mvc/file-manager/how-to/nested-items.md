---
layout: post
title: Nested Items in ##Platform_Name## File Manager Component
description: Learn here all about Nested Items in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Nested Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Nested FileManager

FileManager can be rendered inside the other components like Tab, Dialog, and more.

* [Adding file manager inside the dialog](#adding-file-manager-inside-the-dialog)
* [Adding  file manager inside the tab](#adding-file-manager-inside-the-tab)

## Adding file manager inside the dialog

The following example shows the file manager component rendered inside the dialog. Click the browse button in the Uploader element to open the File Manager inside the Dialog control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/file-dialog/HomeController_core.cs %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/file-dialog/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/file-dialog/HomeController_core.cs %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/file-dialog/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Initially output be like the below.

![FileManager upload ](../images/file_upload.PNG)

After clicking the file browser button, file manager is rendered with dialog. Output be like the below.

![FileManager inside dialog ](../images/file_dialog.PNG)

## Adding file manager inside the tab

The following example demonstrate that the file manager component is placed inside the content area of tab element.

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



Output be like the below for initial view.

![FileManager inside tab ](../images/file_tab.PNG)

Output be like the below, when file manager is placed inside the tab

![FileManager inside tab ](../images/file_tab_item.PNG)