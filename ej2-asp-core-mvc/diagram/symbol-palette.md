---
layout: post
title: Symbol Palette in Syncfusion® ##Platform_Name## Diagram Component
description: Learn here all about Symbol Palette in Syncfusion® ##Platform_Name## Diagram component of Syncfusion Essential® JS 2 and more.
platform: ej2-asp-core-mvc
control: Symbol Palette
publishingplatform: ##Platform_Name##
documentation: ug
---


# Symbol Palette in Diagram

The **SymbolPalette** displays a collection of palettes. The palette shows a set of nodes and connectors. It allows to drag and drop the nodes and connectors into the diagram.

## Create symbol palette

The [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_Height) properties of the symbol palette allows to define the size of the symbol palette.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/palette/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Palette.cs" %}
{% include code-snippet/diagram/symbol-palette/palette/palette.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Palette.cs" %}
{% include code-snippet/diagram/symbol-palette/palette/palette.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Add palettes to SymbolPalette

A palette allows to display a group of related symbols and it textually annotates the group with its header. A [`Palettes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_Palettes) can be added as a collection of symbol groups.

The collection of predefined symbols can be added in palettes using the [`symbols`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Symbols) property.

To initialize a palette, define a JSON object with the property [`ID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Id) that is unique ID is set to the palettes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/symbols/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Symbols.cs" %}
{% include code-snippet/diagram/symbol-palette/symbols/symbols.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Symbols.cs" %}
{% include code-snippet/diagram/symbol-palette/symbols/symbols.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Template-based symbols

### HTML and SVG node with content template

The Symbol Palette supports the creation of complex nodes using HTML or SVG templates. This allows developers to incorporate rich, interactive, and visually engaging content within diagram elements.

* For HTML content, set the node's `shape.type` property to **HTML**.
* For SVG content, set the `shape.type` property to **Native**.

Templates can be defined either as strings or functions and assigned to the node's `content` property. Function-based templates offer the flexibility to generate dynamic content based on node-specific properties or external data sources.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/contentTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="palette.cs" %}
{% include code-snippet/diagram/symbol-palette/contentTemplate/palette.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="palette.cs" %}
{% include code-snippet/diagram/symbol-palette/contentTemplate/palette.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customize the palette header

Palettes can be annotated with its header texts.

The [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Title) displayed as the header text of palette.

The [`expanded`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Expanded) property of palette allows to expand/collapse its palette items.

The [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Height) property of palette sets the height of the symbol group.

The [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_IconCss) property sets the content of the symbol group.

The [`description`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_TextOverflow) defines the text to be displayed and how that is to be handled in `getSymbolInfo`.

Also, any HTML element into a palette header can be embedded by defining the `getSymbolInfo` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/symbols/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Symbols.cs" %}
{% include code-snippet/diagram/symbol-palette/symbols/symbols.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Symbols.cs" %}
{% include code-snippet/diagram/symbol-palette/symbols/symbols.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

 function getSymbolInfo(symbol) {
    if (symbol['text'] !== undefined) {
        return {
            width: 75,
            height: 40,
            //Add or Remove the Text for Symbol palette item.
            description: {
                //Defines the symbol description
                text: symbol['text'],
                //Defines how to handle the text when its size exceeds the given symbol size
                overflow: 'Wrap'
            }
        };
    }
    return {
        width: 75,
        height: 40,
        description: {
            text: symbol.shape['shape']
        }
    };
}

```

## Restrict expansion of the palette panel

The symbol palette panel can be restricted from getting expanded. The `cancel` argument of the `paletteExpanding` property defines whether the palette's panel should be expanded or collapsed. By default, the panel is expanded. This restriction can be done for each of the palettes in the symbol palette as desired. In the following code example the basic shapes palette is restricted from getting collapsed whereas the swimlane shapes palette can be expanded or collapsed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/restrict/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Restrict.cs" %}
{% include code-snippet/diagram/symbol-palette/restrict/restrict.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Restrict.cs" %}
{% include code-snippet/diagram/symbol-palette/restrict/restrict.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

 function paletteExpanding(args) {
    if(args.palette.id === 'basic') {
    // Basic shapes panel does not collapse
    args.cancel = true;
    } else {
    // Swimlane shapes panel collapse and expand
    args.cancel = false;
    }
}

```

## Stretch the symbols into the palette

The [`fit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_SymbolInfo) property defines whether the symbol has to be fit inside the size, that is defined by the symbol palette. For example, when you resize the rectangle in the symbol, ratio of the rectangle size has to be maintained rather changing into square shape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/fit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fit.cs" %}
{% include code-snippet/diagram/symbol-palette/fit/fit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Fit.cs" %}
{% include code-snippet/diagram/symbol-palette/fit/fit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

 function getSymbolInfo(symbol) {
        return { fit: true };
    }

```

## Add/Remove symbols to palette at runtime

* Symbols can be added to palette at runtime by using public method, `addPaletteItem`.

* Symbols can be removed from palette at runtime by using public method, `removePaletteItem`.

## Customize the size of symbols

The size of the individual symbol can be customized. The [`symbolWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_SymbolWidth) and  [`symbolHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_SymbolHeight) properties of node enables to define the size of the symbols.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/diagram/symbol-palette/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/diagram/symbol-palette/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The [`symbolMargin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_SymbolMargin) property is used to create the space around elements, outside of any defined borders.

## Symbol preview

The symbol preview size of the palette items can be customized using [`symbolPreview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPaletteSymbolPreview.html). The [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPaletteSymbolPreview.html#Syncfusion_EJ2_Diagrams_SymbolPaletteSymbolPreview_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPaletteSymbolPreview.html#Syncfusion_EJ2_Diagrams_SymbolPaletteSymbolPreview_Height) properties of SymbolPalette enables to define the preview size to all the symbol palette items. The [`offset`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPaletteSymbolPreview.html#Syncfusion_EJ2_Diagrams_SymbolPaletteSymbolPreview_Offset) of the dragging helper relative to the mouse cursor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/preview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Preview.cs" %}
{% include code-snippet/diagram/symbol-palette/preview/preview.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Preview.cs" %}
{% include code-snippet/diagram/symbol-palette/preview/preview.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Default settings

While adding more number of symbols such as nodes and connectors to the palette, define the default settings for those objects through the [`getNodeDefaults`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_GetNodeDefaults) and the [`getConnectorDefaults`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_GetConnectorDefaults) properties of diagram allows to define the default settings for nodes and connectors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/diagram/symbol-palette/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/diagram/symbol-palette/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

 function getNodeDefaults(symbol) {
    if (symbol.id === 'Terminator' || symbol.id === 'Process') {
        symbol.width = 80;
        symbol.height = 40;
    } else if (symbol.id === 'Document' || symbol.id === 'PreDefinedProcess' ||
        symbol.id === 'PaperTap' || symbol.id === 'DirectData') {
        symbol.width = 50;
        symbol.height = 40;
    }
    symbol.style = {
        strokeWidth: 2
    };
}
function getSymbolInfo(symbol) {
    return {
        fit: true
    };
}

```

## Adding symbol description for symbols in the palette

The diagram provides support to add symbol description below each symbol of a palette. This descriptive representation of each symbol will enhance the details of the symbol visually. The height and width of the symbol description can also be set individually.
* The property `getSymbolInfo` can be used to add the symbol description at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/description/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Description.cs" %}
{% include code-snippet/diagram/symbol-palette/description/description.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Description.cs" %}
{% include code-snippet/diagram/symbol-palette/description/description.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

 function getSymbolInfo(symbol) {
    if (symbol['text'] !== undefined) {
        return {
            width: 75,
            height: 40,
            //Add or Remove the Text for Symbol palette item.
            description: {
                //Defines the symbol description
                text: symbol['text'],
                //Defines how to handle the text when its size exceeds the given symbol size
                overflow: 'Wrap'
            }
        };
    }
    return {
        width: 75,
        height: 40,
        description: {
            text: symbol.shape['shape']
        }
    };
}

```
## Tooltip for symbols in symbol palette

The Symbol palette supports displaying tooltips when mouse hovers over the symbols. You can customize the tooltip for each symbol in the symbol palette.

### Default tooltip for symbols

When hovering over symbols in the symbol palette, the default tooltip displays the symbol's ID.
Refer to the image below for an illustration of the tooltip behavior in the symbol palette.


![SymmbolPaletteTooltip](../diagram/images/SymbolPalatteTooltip.gif)

### Custom tooltip for symbols

To customize the tooltips for symbols in the symbol palette, assign a custom tooltip to the 'Tooltip' content property of each symbol. Once you define the custom tooltip, enable the Tooltip constraints for each symbol, ensuring that the tooltips are displayed when users hover over them.

Here, the code provided below demonstrates how to define tooltip content to symbols within a symbol palette.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/symboltooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Description.cs" %}
{% include code-snippet/diagram/symbol-palette/symboltooltip/description.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Description.cs" %}
{% include code-snippet/diagram/symbol-palette/symboltooltip/description.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### How to enable or disable the default tooltip for shapes in the symbol palette

By default, the symbol ID is displayed as a tooltip when hovering over a symbol in the Symbol Palette. To disable this default tooltip, you can use the `showTooltip` property within the `getSymbolInfo` method. The `showTooltip` property is set to **true** by default, which enables the tooltip.

The following example demonstrates how to configure selective tooltip display:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/symbol-palette/defaulttooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Description.cs" %}
{% include code-snippet/diagram/symbol-palette/defaulttooltip/description.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Description.cs" %}
{% include code-snippet/diagram/symbol-palette/defaulttooltip/description.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

```javascript

 function getNodeDefaults(symbol) {
    symbol.style = {
        strokeColor = '#6495ED',
        fill = '#6495ED'
    };
}
 function getSymbolInfo(symbol) {
    return { showTooltip: true };
}

```

N> This property is effective only when tooltip constraints are disabled for the symbol palette element.


### How to provide different tooltip for Symbol palette and diagram elements.

Differentiate the tooltips between symbols in the symbol palette and dropped nodes by utilizing the dragEnter event. When a custom tooltip is defined for a symbol, it will be displayed for both the symbol and the dropped node in the diagram canvas. However, to provide distinct tooltips for symbols in the palette and dropped nodes, capture the dragEnter event and assign specific tooltips dynamically.  

When a symbol is dragged from the symbol palette and enters the diagram canvas, the [`DragEnter`] `IDragEnterEventArgs` event is triggered. Within this event, you can define a new tooltip for the dropped node. By assigning custom tooltip content to the Tooltip property of the node, you can provide a distinct tooltip that is specific to the dropped node.

The following image illustrates the differentiation of tooltips displayed in the Symbol Palette and the Diagram.


![SymmbolPaletteCustomTooltip](../diagram/images/SymbolCustomTooltip.gif)

The following code snippet will demonstrate how to define two different tooltip for symbol in the symbol palette and dropped node in the diagram canvas.

```js
//Initialize the Diagram
 let diagram: Diagram = new Diagram({
            width: '100%', height: '500px',
            connectors: connectors, nodes: nodes,
            //event to change tooltip content while dragging symbols into Diagram
            dragEnter: dragEnter,
        });
 diagram.appendTo('#diagram');

function dragEnter(args:IDragEnterEventArgs)
    {
        //enable tooltip connstraints for the dragged symbol
        args.dragItem.constraints = NodeConstraints.Default | NodeConstraints.Tooltip;

        //change the tooltip content of the dragged symbol
        args.dragItem.tooltip.content='This is Diagram Tooltip';
    }
```

## Palette interaction

Palette interaction notifies the element enter, leave, and dragging of the symbols into the diagram.

## DragEnter

[`DragEnter`] `IDragEnterEventArgs` notifies, when the element enters into the diagram from symbol palette.

## DragLeave

[`DragLeave`] `IDragLeaveEventArgs` notifies, when the element leaves from the diagram.

## DragOver

[`DragOver`] `IDragOverEventArgs` notifies, when an element is dragged over another diagram element.

N> The diagram provides support to cancel the drag and drop operation from the symbol palette to the diagram when the ESC key is pressed.

## See Also

* [How to add the symbol to the diagram](./nodes)