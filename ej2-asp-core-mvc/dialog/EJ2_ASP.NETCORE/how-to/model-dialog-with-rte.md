---
layout: post
title: Model Dialog With Rte in ##Platform_Name## Dialog Component
description: Learn here all about Model Dialog With Rte in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Model Dialog With Rte
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render model dialog with Rich Text Editor

This section explains how to render model dialog with the Rich Text Editor component. when you render model dialog with the Rich Text Editor component, the first row of the content will be hidden because the dialog container and its wrapper elements are styled with display as none. so, the editor’s toolbar does not get proper offset width and rendered above the edit area container. In this scenario, we could use the `refreshUI` method on the Dialog `open` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/model-dialog-with-rte/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/model-dialog-with-rte/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/model-dialog-with-rte/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/model-dialog-with-rte/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

