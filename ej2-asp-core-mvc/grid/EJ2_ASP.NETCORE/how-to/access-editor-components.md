---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Access Editor Components of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Access Editor Components
publishingplatform: ##Platform_Name##
documentation: ug
---


# Access Editor components

You can access the component instance from the component element using the **ej2_instances** property.

In the below demo, you can access the Editor component instance while adding or editing actions in the [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="access-editor" %}
{% include_relative code-snippet/how-to/access-editor/access-editor.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/access-editor/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="access-editor" %}
{% include_relative code-snippet/how-to/access-editor/access-editor.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/access-editor/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

