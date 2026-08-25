---
layout: post
title: Add min and max buttons to ##Platform_Name## Dialog header | Syncfusion
description: Add minimize and maximize custom buttons to the Syncfusion ##Platform_Name## Dialog header using the headerTemplate property and button click events.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# Add dialog min and max buttons to ##Platform_Name## Dialog header

The ##Platform_Name## Dialog supports adding custom minimize and maximize buttons to the Dialog header. You can add these buttons near the close icon in the Dialog header by using the `headerTemplate` property and handling the actions in the button click events, as shown in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dlg-min-max/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dlg-min-max/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dlg-min-max/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dlg-min-max/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![dialog](../images/min-max.png)
