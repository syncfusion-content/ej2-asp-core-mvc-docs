---
layout: post
title: Add minimize and maximize buttons to the ##Platform_Name## Dialog header
description: Learn here all about adding minimize and maximize buttons to Syncfusion ##Platform_Name## Dialog component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# Add minimize and maximize buttons to the Dialog header

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
