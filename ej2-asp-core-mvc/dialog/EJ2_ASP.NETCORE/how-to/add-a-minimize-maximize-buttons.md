---
layout: post
title: Add min and max buttons to Dialog header | Syncfusion
description: Add minimize and maximize custom buttons to the Syncfusion ##Platform_Name## Dialog header using the headerTemplate property and button click events.
platform: ej2-asp-core-mvc
control: dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# Add min and max buttons to the Dialog header

##Platform_Name## Dialog supports adding custom minimize and maximize buttons to the Dialog header. You can use the `headerTemplate` property to place the buttons next to the close icon and handle their click events.


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

![dialog](../images/min-max.png)
