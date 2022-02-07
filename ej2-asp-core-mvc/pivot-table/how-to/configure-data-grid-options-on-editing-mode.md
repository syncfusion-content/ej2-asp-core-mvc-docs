---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Configure Data Grid Options On Editing Mode of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Configure Data Grid Options On Editing Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Configure data grid options on editing mode

You can access the data grid options such as sort, group, filter on editing mode using the `beginDrillThrough` event in the pivot table. The event occurs in every value cell on double click and provides the data grid information before display the drill through grid pop-up.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomEditing.cs" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/CustomEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomEditing.cs" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/CustomEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


