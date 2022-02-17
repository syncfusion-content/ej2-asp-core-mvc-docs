---
layout: post
title: Symbol Palette in ##Platform_Name## Diagram Component
description: Learn here all about Symbol Palette in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Symbol Palette
publishingplatform: ##Platform_Name##
documentation: ug
---


# Symbol Palette

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

A palette allows to display a group of related symbols and it textually annotates the group with its header.
A [`Palettes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_Palettes) can be added as a collection of symbol groups.

The collection of predefined symbols can be added in palettes using the [`symbols`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Symbols) property.

To initialize a palette, define a JSON object with the property [`ID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Id) that is unique ID is set to the palettes.

The following code example illustrates how to define a palette and how its added to symbol palette.

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



## Customize the palette header

Palettes can be annotated with its header texts.

The [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Title) displayed as the header text of palette.

The [`expanded`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Expanded) property of palette allows to expand/collapse its palette items.

The [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_Height) property of palette sets the height of the symbol group.

The [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalettePalette.html#Syncfusion_EJ2_Diagrams_SymbolPalettePalette_IconCss) property sets the content of the symbol group.

The [`description`](https://ej2.syncfusion.com/documentation/api/diagram/symbolDescription) defines the text to be displayed and how that is to be handled in `getSymbolInfo`.

Also, any HTML element into a palette header can be embedded by defining the `getSymbolInfo` property.
The following code example illustrates how to customize palette headers.

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

The symbol palette panel can be restricted from getting expanded. The `cancel` argument of the `paletteExpanding` property defines whether the palette's panel should be expanded or collapsed. By default, the panel is expanded. This restriction can be done for each of the palettes in the symbol palette as desired.
In the following code example the basic shapes palette is restricted from getting collapsed whereas the swimlane shapes palette can be expanded or collapsed.

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

The [`fit`](https://ej2.syncfusion.com/documentation/api/diagram/symbolInfo#fit) property defines whether the symbol has to be fit inside the size, that is defined by the symbol palette. For example, when you resize the rectangle in the symbol, ratio of the rectangle size has to be maintained rather changing into square shape. The following code example illustrates how to customize the symbol size.

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

The size of the individual symbol can be customized. The [`symbolWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_SymbolWidth) and  [`symbolHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_SymbolHeight) properties of node enables you to define the size of the symbols. The following code example illustrates how to change the size of a symbol.

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



The [`symbolMargin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html#Syncfusion_EJ2_Diagrams_SymbolPalette_SymbolMargin) property is used to create the space around
elements, outside of any defined borders.

## Symbol preview

The symbol preview size of the palette items can be customized using [`symbolPreview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPaletteSymbolPreview.html).
The [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPaletteSymbolPreview.html#Syncfusion_EJ2_Diagrams_SymbolPaletteSymbolPreview_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPaletteSymbolPreview.html#Syncfusion_EJ2_Diagrams_SymbolPaletteSymbolPreview_Height) properties of SymbolPalette enables you to define the preview size to all the symbol palette items.
The [`offset`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPaletteSymbolPreview.html#Syncfusion_EJ2_Diagrams_SymbolPaletteSymbolPreview_Offset) of the dragging helper relative to the mouse cursor.

The following code example illustrates how to change the preview size of a palette item.

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
* The property `getSymbolInfo`, can be used to add the symbol description at runtime.
 The following code is an example to set a symbol description for symbols in the palette.

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

## Palette interaction

Palette interaction notifies the element enter, leave, and dragging of the symbols into the diagram.

## DragEnter

[`DragEnter`] `IDragEnterEventArgs` notifies, when the element enter into the diagram from symbol palette.

## DragLeave

[`DragLeave`] `IDragLeaveEventArgs` notifies, when the element leaves from  the diagram.

## DragOver

[`DragOver`] `IDragOverEventArgs` notifies, when an element drag over another diagram element.

> The diagram provides support to cancel the drag and drop operation from the symbol palette to the diagram when the ESC key is pressed.

## See Also

* [How to add the symbol to the diagram](./nodes)