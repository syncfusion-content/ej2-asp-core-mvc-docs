---
layout: post
title: Save in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Save in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Save
publishingplatform: ##Platform_Name##
documentation: ug
---


# Save Rich Text Editor content in a file in the server

Rich Text Editor content can be passed from view to controller through `XMLHttpRequest` post. Content
will be sent to the corresponding method into the controller and this value can be saved in a text
file or any other format using `streamWriter`. Refer to the following given code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/savefile/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Savefile.cs" %}
{% include code-snippet/rich-text-editor/how-to/savefile/savefile.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/savefile/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Savefile.cs" %}
{% include code-snippet/rich-text-editor/how-to/savefile/savefile.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

