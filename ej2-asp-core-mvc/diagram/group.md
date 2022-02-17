---
layout: post
title: Group in ##Platform_Name## Diagram Component
description: Learn here all about Group in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Group
publishingplatform: ##Platform_Name##
documentation: ug
---


# Group

Group is used to cluster multiple nodes and connectors into a single element. It acts like a container for its children (nodes, groups, and connectors). Every change made to the group also affects the children. Child elements can be edited individually.

## Create group

## Add group when initializing diagram

A group can be added to the diagram model through [`nodes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html) collection. To define an object as group, add the child objects to the [`children`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_Children) collection of the group. The following code illustrates how to create a group node.

* While creating group, its child node need to be declared before the group declaration.

* Add a node to the existing group child by using the `diagram.group` method.

* The group’s `diagram.unGroup` method is used to define whether the group can be ungrouped or not.

* A group can be added into a child of another group.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/group/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/diagram/group/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/diagram/group/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagram = document.getElementById("container").ej2_instances[0];
diagram.selectAll();
// Adding the third node into the existing group
diagram.group();

```

The following code illustrates how a ungroup  at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/group/ungroup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ungroup.cs" %}
{% include code-snippet/diagram/group/ungroup/ungroup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Ungroup.cs" %}
{% include code-snippet/diagram/group/ungroup/ungroup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
diagram.selectAll();
// Ungroup the selected group into nodes
diagram.unGroup();

```

## Add group at runtime

A group node can be added at runtime by using the client-side method `diagram.add`.

The following code illustrates how a group node is added at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/group/run/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Run.cs" %}
{% include code-snippet/diagram/group/run/run.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Run.cs" %}
{% include code-snippet/diagram/group/run/run.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
var group= {
    id: 'group2',
    children: ['node1', 'node2']
};
// Add the group into the diagram
diagram.add(group);

```

## Container

Containers are used to automatically measure and arrange the size and position of the child elements in a predefined manner.
There are two types of containers available.

## Canvas

* The canvas panel supports absolute positioning and provides the least layout functionality to its contained diagram elements.

* Canvas allows you to position its contained elements by using the margin and alignment properties.

* Rendering alone possible in canvas container.

* It allows elements to be either vertically or horizontally aligned.

* Child can be defined with the collection `canvas.children` property.

* Basic element can be defined with the collection of `basicElements`.

## Stack

* Stack panel is used to arrange its children in a single line or stack order, either vertically or horizontally.

* It controls spacing by setting margin properties of child and padding properties of group. By default, a stack panel’s [`orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.html) is vertical.

The following code illustrates how to add a stack panel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/group/stack/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stack.cs" %}
{% include code-snippet/diagram/group/stack/stack.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Stack.cs" %}
{% include code-snippet/diagram/group/stack/stack.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

function getTextElement(text)  {
    let textElement: TextElement = new TextElement();
    textElement.width = 50;
    textElement.height = 20;
    textElement.content = text;
    return textElement;
}

function addRows (column) {
    column.children.push(getTextElement('Row1'));
    column.children.push(getTextElement('Row2'));
    column.children.push(getTextElement('Row3'));
    column.children.push(getTextElement('Row4'));
}

  function getNodeDefaults (node) {
        node.height = 100;
        node.width = 100;
        node.style.fill = '#6BA5D7';
        node.style.strokeColor = 'white';
        return node;
    },
    function setNodeTemplate(obj, diagram) {
        if (obj.id.indexOf('node5') !== -1) {
            // It will be replaced with grid panel
            var table = new StackPanel();
            table.orientation = 'Horizontal';
            table.padding.left

            var column1 = new StackPanel();
            column1.children = [];
            column1.children.push(getTextElement('Column1'));
            addRows(column1);

            var column2 = new StackPanel();
            column2.children = [];
            column2.children.push(getTextElement('Column2'));
            addRows(column2);

            table.children = [column1, column2];
            return table;
        }
        return null;
    }
```

## Difference between a basic group and containers

| Group | Container |
| -------- | -------- |
| It arranges the child elements based on the child elements position and size properties. | Each container has a predefined behavior to measure and arrange its child elements. Canvas and stack containers are supported in the diagram. |
| The Padding, Min, and Max Size properties are not applicable for basic group. | It is applicable for container. |
| The Children’s margin and alignment properties are not applicable for basic group. |  It is applicable for container. |

## Interaction

You can edit the group and its children at runtime. For more information about how to interact with a group, refer to `Edit Groups`.

## See Also

* [How to add annotations to the node](./labels)
* [How to add ports to the node](./ports)
* [How to enable/disable the behavior of the node](./constraints)
* [How to add nodes to the symbol palette](./symbol-palette)
* [How to create diagram nodes using drawing tools](./tools)
* [How to perform the interaction on the group](./interaction#selection)