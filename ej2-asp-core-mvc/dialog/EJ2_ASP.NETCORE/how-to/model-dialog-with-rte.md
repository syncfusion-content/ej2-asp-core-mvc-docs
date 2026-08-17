---
layout: post
title: How to render a modal Dialog with Rich Text Editor in ##Platform_Name## Dialog | Syncfusion
description: Render a modal Syncfusion ##Platform_Name## Dialog containing the Rich Text Editor and call refreshUI on the Dialog open event to fix toolbar offset width.
platform: ej2-asp-core-mvc
control: Model Dialog With Rte
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to render a modal Dialog with Rich Text Editor in ##Platform_Name## Dialog

This section explains how to render model dialog with the Rich Text Editor component. When you render model dialog with the Rich Text Editor component, the first row of the content will be hidden because the dialog container and its wrapper elements are styled with display as none. So, the editor’s toolbar does not get proper offset width and rendered above the edit area container. In this scenario, use the `refreshUI` method on the Dialog `open` event.

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

