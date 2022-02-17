---
layout: post
title: Undo Redo in ##Platform_Name## Diagram Component
description: Learn here all about Undo Redo in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Undo Redo
publishingplatform: ##Platform_Name##
documentation: ug
---


# History List

Diagram tracks the history of actions that are performed after initializing the diagram and provides support to reverse and restore those changes.

## Undo and redo

Diagram provides built-in support to track the changes that are made through interaction and through public APIs. The changes can be reverted or restored either through shortcut keys or through commands.

## Undo/redo through shortcut keys

Undo/redo commands can be executed through shortcut keys. Shortcut key for undo is Ctrl+z and shortcut key for redo is Ctrl+y.

## Undo/redo through public APIs

The client-side methods [`undo`](../api/diagram) and [`redo`](../api/diagram) help you to revert/restore the changes. The following code example illustrates how to undo/redo the changes through script.

``` javascript
var diagram = document.getElementById("diagram").ej2_instances[0];

// Reverts the last action performed
diagram.undo();

// Restores the last undone action
diagram.redo();
```

When a change in the diagram is reverted or restored (undo/redo), the historyChange event gets triggered.

### Group multiple changes

History list allows to revert or restore multiple changes through a single undo/redo command. For example, revert/restore the fill color change of multiple elements at a time.

The client-side method [`startGroupAction`](../api/diagram) is used  to notify the diagram to start grouping the changes. The client-side method [`endGroupAction`](../api/diagram) is used to notify to stop grouping the changes. The following code illustrates how to undo/redo fillColor change of multiple elements at a time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/undoRedo/undoRedo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UndoRedo.cs" %}
{% include code-snippet/diagram/undoRedo/undoRedo/undoRedo.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/undoRedo/undoRedo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UndoRedo.cs" %}
{% include code-snippet/diagram/undoRedo/undoRedo/undoRedo.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagram = document.getElementById('container').ej2_instances[0];
    diagram.startGroupAction();

    //Makes the changes
    var color = ['black', 'red', 'green', 'yellow']
    for (var i = 0; i < color.length; i++) {
        // Updates the fillColor for all the child elements.
        diagram.nodes[0].style.fill = color[i];
        diagram.dataBind();
    }

    //Ends grouping the changes
    diagram.endGroupAction();
```

### Track custom changes

Diagram provides options to track the changes that are made to custom properties. For example, in case of an employee relationship diagram, track the changes in the employee information. The historyList of the diagram enables you to track such changes.
The following example illustrates how to track such custom property changes.

Before changing the employee information, save the existing information to historyList by using the client-side method push of historyList.
The historyList canLog method can be used which takes a history entry as argument and returns whether the specific entry can be added or not.

The following code example illustrates how to save the existing property values.

```javascript

var diagram = document.getElementById('container').ej2_instances[0];
//Creates a custom entry
var entry = {
    undoObject: diagram.nodes[0];
};
// adds that to history list
diagram.historyList.push(entry);
diagram.dataBind();
```

## canLog

canLog in the history list, which takes a history entry as argument and returns whether the specific entry can be added or not.

```javascript

var diagram = document.getElementById('container').ej2_instances[0];

diagram.historyList.canLog = function(entry) {
    entry.cancel = true;
    return entry;
}

```

### Track undo/redo actions

The historyList undoStack property is used to get the collection of undo actions which should be performed in the diagram.
The undoStack/redoStack is the read-only property.

```javascript

var diagram = document.getElementById('container').ej2_instances[0];

//get the collection of undoStack objects
let undoStack = diagram.historyList.undoStack;
//get the collection of redoStack objects
let redoStack = diagram.historyList.redoStack;
```

## History change event

The [`historyChange`](../api/diagram) event triggers, whenever the interaction of the node and connector is take place.

```javascript

var diagram = document.getElementById('container').ej2_instances[0];

// history change event
diagram.historyChange = (arg) => {
    //causes of history change
    let cause: string = arg.cause;
}

```

## Retain Selection

You can retain a selection at undo/redo operation by using the client-side API Method called `updateSelection`.  Using this method, we can select a diagram objects.

```typescript
let diagramInstance: DiagramComponent;
ReactDOM.render( < DiagramComponent id = "diagram" ref={diagram => diagramInstance = diagram}
        width = {
            '100%'
        }
        height = {
            '600px'
        }
        nodes = {
            nodes
        }
        />,   document.getElementById("diagram") );
        // history change event
        diagramInstance.updateSelection: (object: NodeModel, diagram: Diagram) => {
                    let selArr = [];
                    selArr.push(object)
                    diagram.select(selArr);
                },

```
