# How To

<!-- markdownlint-disable MD033 -->
<!-- markdownlint-disable MD036 -->

## Customize the header for treemap drilldown

Yon can add a header element as <div> and customize it to show the population of a particular country or
continent on treemap drill-down.

To customize the header for treemap drill-down, follow the given steps:

**Step 1**:

<!-- markdownlint-disable MD031 -->
Initialize the treemap and enable the drill-down option.

```html
 <ejs-treemap id="container" weightValuePath="Population" format="n" palette="palette"
                     useGroupingSeparator="true" enableDrillDown="true">
            <e-treemap-leafitemsettings labelPath="Name" showLabels="false">
            </e-treemap-leafitemsettings>
            <e-treemap-levels>
                <e-treemap-level groupPath="Continent" fill="#336699" border="border">
                </e-treemap-level>
                <e-treemap-level groupPath="Sates" fill="#336699" border="border">
                </e-treemap-level>
                <e-treemap-level groupPath="Region" fill="#336699" border="border">
                </e-treemap-level>
            </e-treemap-levels>
</ejs-treemap>
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

{% aspTab template="treemap/how-to/header-template", sourceFiles="header.cs" %}

{% endaspTab %}

**Sample reference**

[`treemap sample`](http://www.syncfusion.com/downloads/support/directtrac/general/ze/header-648017586).

**Screenshot**

![Screenshot for your reference](./images/header-template.png)

## Add label template with drill down

Yon can add a label template as <div> element to the treemap control when using the label template. To add a label template to the treemap control, you have to hide another labels by setting the `showLabels` property to **false** in `leafItemSettings` to show only the label template.

To add label template to treemap drilldown, follow the given steps:

**Step 1**:

Create a tree map control and enable the drill-down option.

```html
<ejs-treemap id="container" load="load" drillStart="drillStart" weightValuePath="Sales" enableDrillDown="true" palette="palette">
            <e-treemap-leafitemsettings showLabels="false" labelTemplate="#template" templatePosition="Center">
            </e-treemap-leafitemsettings>
            <e-treemap-levels>
                <e-treemap-level groupPath="Continent" border="border">
                </e-treemap-level>
            </e-treemap-levels>
        </ejs-treemap>
```
**Step 2**:

Add the label template in the `leafItemSettings` options, and then set the `showLabels` property to **false** to hide another labels and show only label template.

{% aspTab template="treemap/how-to/label-template", sourceFiles="label.cs" %}

{% endaspTab %}

**Sample reference**

[`treemap sample`](http://www.syncfusion.com/downloads/support/directtrac/general/ze/label-509136921).

**Screenshot**

![Screenshot for your reference](./images/label-template.png)