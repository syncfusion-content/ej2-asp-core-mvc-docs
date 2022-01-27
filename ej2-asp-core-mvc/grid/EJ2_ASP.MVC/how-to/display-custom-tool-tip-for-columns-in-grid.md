---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Display Custom Tool Tip For Columns In Grid of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Display Custom Tool Tip For Columns In Grid
publishingplatform: ##Platform_Name##
documentation: ug
---


# Display custom ToolTip for columns in Grid

To display a custom ToolTip (**EJ2 Tooltip**), you can render the Grid control inside the Tooltip component and set the target as “.e-rowcell”. The tooltip is displayed when hovering the grid cells.

Change the tooltip content for the grid cells by using the following code in the  (**beforeRender**) event.

```typescript

function beforeRender(args) {
        // event triggered before render the tooltip on target element.
        var tooltip = document.getElementById("Tooltip").ej2_instances[0]
        tooltip.content = args.target.closest("td").innerText;
}

```

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="custom-tooltip" %}
{% include_relative code-snippet/how-to/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="custom-tooltip" %}
{% include_relative code-snippet/how-to/custom-tooltip/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="custom-tooltip" %}
{% include_relative code-snippet/how-to/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% highlight razor tabtitle="custom-tooltip" %}
{% include_relative code-snippet/how-to/custom-tooltip/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


