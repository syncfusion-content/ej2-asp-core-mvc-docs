---
layout: post
title: How To in ##Platform_Name## Treemap Component
description: Learn here all about How To in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: How To
publishingplatform: ##Platform_Name##
documentation: ug
---

# How To

<!-- markdownlint-disable MD036 -->

## Customize the header for treemap drilldown

<!-- markdownlint-disable MD033 -->
Yon can add a header element as <div> and customize it to show the population of a particular country or continent on treemap drill-down.

To customize the header for treemap drill-down, follow the given steps:

**Step 1**:

<!-- markdownlint-disable MD031 -->
Initialize the treemap and enable the drill-down option.

```html
 @Html.EJS().TreeMap("container").WeightValuePath("Population").Format("n").UseGroupingSeparator(true).WeightValuePath("Population").Palette(new string[] { "#9999ff", "#CCFF99", "#FFFF99", "#FF9999", "#FF99FF", "#FFCC66" }).LeafItemSettings(leaf =>
          leaf.LabelPath("Name").ShowLabels(false)).EnableDrillDown(true).Levels(level =>
          {
              level.GroupPath("Continent").Fill("#336699").Border(br => br.Color("black").Width(0.5)).Add();
              level.GroupPath("States").Fill("#336699").Border(br => br.Color("black").Width(0.5)).Add();
              level.GroupPath("Region").Fill("#336699").Border(br => br.Color("black").Width(0.5)).Add();
          }).Render()
```

**Step 2**:

Show the population of a particular continent in the treemap `loaded` event. In this event, you can get the header element.

```javascript
    loaded: function (args: ILoadedEventArgs) {
        var header = document.getElementById('header');
        var population = 0;
        for (var i = 0; i < args.treemap.layout.renderItems[0]['parent'].Continent.length; i++) {
            population += +(args.treemap.layout.renderItems[0]['parent'].Continent[i]['data'].Population);
        }
        header.innerHTML = 'Continent - Population : ' + population
    }
```

**Step 3**:

Customize the population for drilled countries or states in the header element when drill-down the treemap. The `drillEnd` event will be triggered when treemap is drilled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/how-to/header-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header.cs" %}
{% include code-snippet/treemap/how-to/header-template/header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/how-to/header-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header.cs" %}
{% include code-snippet/treemap/how-to/header-template/header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Sample reference**

[`treemap sample`](http://www.syncfusion.com/downloads/support/directtrac/general/ze/header-422842907).

**Screenshot**

![Screenshot for your reference](./images/header-template.png)

## Add label template with drill down

Yon can add a label template as <div> element to the treemap control when using the label template. To add a label template to the treemap control, you have to hide another labels by setting the `showLabels` property to **false** in `leafItemSettings` to show only the label template.

To add label template to treemap drilldown, follow the given steps:

**Step 1**:

Create a treemap control and enable the drill-down option.

```html
@Html.EJS().TreeMap("container").Load("load").DrillStart("drillStart").WeightValuePath("Sales").Palette(new string[] { "white"}).LeafItemSettings(leaf =>
          leaf.ShowLabels(false).LabelTemplate("#template").TemplatePosition(Syncfusion.EJ2.TreeMap.LabelPosition.Center)).EnableDrillDown(true).Levels(level =>
          {
              level.GroupPath("Continent").Border(br => br.Color("black").Width(0.5)).Add();
              level.GroupPath("Company").Border(br => br.Color("black").Width(0.5)).Add();
          }).Render()
```
**Step 2**:

Add the label template in the `leafItemSettings` options, and then set the `showLabels` property to **false** to hide another labels and show only label template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/how-to/label-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/treemap/how-to/label-template/label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/how-to/label-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/treemap/how-to/label-template/label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Sample reference**

[`treemap sample`](http://www.syncfusion.com/downloads/support/directtrac/general/ze/labels430533743).

**Screenshot**

![Screenshot for your reference](./images/label-template.png)