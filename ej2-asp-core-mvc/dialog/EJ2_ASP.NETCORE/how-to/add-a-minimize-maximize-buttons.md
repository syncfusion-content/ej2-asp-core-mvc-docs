---
layout: post
title: How to add min and max buttons to Dialog header in ##Platform_Name## Dialog | Syncfusion
description: Add minimize and maximize custom buttons to the Syncfusion ##Platform_Name## Dialog header using the headerTemplate property and button click events.
platform: ej2-asp-core-mvc
control: dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add min and max buttons to Dialog header in ##Platform_Name## Dialog

##Platform_Name## Dialog allows end users to either minimize or maximize the Dialog component. You can add minimize and maximize custom buttons near the close icon in the Dialog header using the `headerTemplate` property, and handle the actions in the button click events.


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
