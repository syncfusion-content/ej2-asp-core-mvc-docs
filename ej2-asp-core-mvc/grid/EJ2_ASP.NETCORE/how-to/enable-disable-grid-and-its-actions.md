---
layout: post
title: Enable Disable Grid And Its Actions in ##Platform_Name## Grid Component
description: Learn here all about Enable Disable Grid And Its Actions in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Enable Disable Grid And Its Actions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable/Disable Grid and its actions

You can enable/disable the Grid and its actions by applying/removing corresponding CSS styles.

To enable/disable the grid and its actions, follow the given steps:

**Step 1**:

Create CSS class with custom style to override the default style of Grid.

```css
    .disablegrid {
        pointer-events: none;
        opacity: 0.4;
    }
    .wrapper {
        cursor: not-allowed;
    }

```

**Step 2**:

Add/Remove the custom CSS class to the Grid in the click event handler of Button.

```typescript
    <script>
        document.getElementById('element').onclick = function () {
            var gridInst = document.getElementById("Grid").ej2_instances[0];
            if (gridInst.element.classList.contains('disablegrid')) {
                gridInst.element.classList.remove('disablegrid');
                document.getElementById("GridParent").classList.remove('wrapper');
            }
            else {
                gridInst.element.classList.add('disablegrid');
                document.getElementById("GridParent").classList.add('wrapper');
            }
        }
    </script>

```

In the below demo, the button click will enable/disable the Grid and its actions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disablegrid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disablegrid.cs" %}
{% include code-snippet/grid/how-to/disablegrid/disablegrid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disablegrid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disablegrid.cs" %}
{% include code-snippet/grid/how-to/disablegrid/disablegrid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


