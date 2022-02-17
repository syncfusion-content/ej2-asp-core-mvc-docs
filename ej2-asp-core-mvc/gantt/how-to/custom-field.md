---
layout: post
title: Custom Field in ##Platform_Name## Gantt Component
description: Learn here all about Custom Field in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Custom Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add Custom Fields in the General Tab in Add/Edit Dialog

Generally in Gantt, Custom fields are displayed in the Custom Tab of the Add/Edit dialogs. However, they can be included in the General Tab of Add/Edit Dialog Box using `actionBegin` and `actionComplete` events. These events are used to append the custom field to the dialog box. The following code snippets demonstrate the solution.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/customfield/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customfield.cs" %}
{% include code-snippet/gantt/how-to/customfield/customfield.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/customfield/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customfield.cs" %}
{% include code-snippet/gantt/how-to/customfield/customfield.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

