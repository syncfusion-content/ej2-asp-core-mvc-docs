---
layout: post
title: Open Add Edit Dialog in ##Platform_Name## Gantt Component
description: Learn here all about Open Add Edit Dialog in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Open Add Edit Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open add/edit dialog dynamically

Gantt add and edit dialogs can be opened dynamically by using `openAddDialog` and `openEditDialog` methods. The following code example shows how to open add and dialog on separate button click actions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/openEditAddDialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OpenEditAddDialog.cs" %}
{% include code-snippet/gantt/editing/openEditAddDialog/openEditAddDialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/openEditAddDialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OpenEditAddDialog.cs" %}
{% include code-snippet/gantt/editing/openEditAddDialog/openEditAddDialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> We should select any one of the row in Gantt to open the edit dialog.