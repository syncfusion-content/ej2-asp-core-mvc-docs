---
layout: post
title: Umldiagram in ##Platform_Name## Diagram Component
description: Learn here all about Umldiagram in Syncfusion® ##Platform_Name## Diagram component of Syncfusion Essential® JS 2 and more.
platform: ej2-asp-core-mvc
control: Umldiagram
publishingplatform: ##Platform_Name##
documentation: ug
---


# UML Diagram Shapes

## UML Class Diagram

A class diagram visually depicts the static structure of an application and is extensively employed in modeling object-oriented systems. It holds a unique position in UML diagrams, as it directly aligns with object-oriented languages. The diagram also facilitates automatic generation of class diagram shapes based on business logic, streamlining the translation from conceptual models to practical implementation.

## Uml Class Diagram Shapes

The UML class diagram shapes are explained as follows.

### Class

* A class defines a group of objects that share common specifications, features, constraints, and semantics. To create a class object, the classifier should be defined using the [`class`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassifierShapeModel#classshape) notation. This notation serves as a foundational element in object-oriented programming, encapsulating the essential characteristics and behavior that objects belonging to the class will exhibit.

* Also, define the [`name`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassModel#name), [`attributes`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassModel#attributes), and [`methods`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassModel#methods) of the class using the class property of node.

* The attribute’s [`name`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassAttributeModel#name), [`type`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassAttributeModel#type), and [`scope`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassAttributeModel#scope) properties allows to define the name, data type, and visibility of the attribute.

* The method’s [`name`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassMethodModel#name), [`parameters`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassMethodModel#parameters), [`type`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassMethodModel#type), and [`scope`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassMethodModel#scope) properties allows to define the name, parameter, return type, and visibility of the methods.

* The method parameters object properties allows to define the name and type of the parameter.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/class/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Class.cs" %}
{% include code-snippet/diagram/umldiagramshapes/class/class.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/class/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Class.cs" %}
{% include code-snippet/diagram/umldiagramshapes/class/class.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Interface

* An interface is a specific type of classifier that signifies a declaration of a cohesive set of public features and obligations. When creating an interface, it involves defining the classifier property using the [`interface`](https://ej2.syncfusion.com/documentation/api/diagram/umlClassifierShapeModel#interfaceshape) notation. This essential concept in object-oriented programming outlines a contract for classes to adhere to, specifying the required methods and behaviors without delving into the implementation details.

* Also, define the [`name`](https://ej2.syncfusion.com/documentation/api/diagram/umlInterfaceModel#name), [`attributes`](https://ej2.syncfusion.com/documentation/api/diagram/umlInterfaceModel#attributes), and [`methods`](https://ej2.syncfusion.com/documentation/api/diagram/umlInterfaceModel#methods) of the interface using the interface property of the node.

* The attribute’s name, type, and scope properties allows to define the name, data type, and visibility of the attribute.

* The method’s name, parameter, type, and scope properties allows to define the name, parameter, return type, and visibility of the methods.

* The method parameter object properties of name and type allows to define the name and type of the parameter.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/interface/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Interface.cs" %}
{% include code-snippet/diagram/umldiagramshapes/interface/interface.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/interface/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Interface.cs" %}
{% include code-snippet/diagram/umldiagramshapes/interface/interface.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Enumeration

* To establish an enumeration, designate the classifier property of the node as [enumeration](https://ej2.syncfusion.com/documentation/api/diagram/umlClassifierShapeModel#enumerationshape). Additionally, define the name and enumerate the members of the enumeration using the appropriate enumeration property of the node. This process encapsulates a set of distinct values within the enumeration, allowing for a clear representation of specific, named constants within a system.

* You can set a name for the enumeration members collection using the name property of members collection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/enumeration/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enumeration.cs" %}
{% include code-snippet/diagram/umldiagramshapes/enumeration/enumeration.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/enumeration/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enumeration.cs" %}
{% include code-snippet/diagram/umldiagramshapes/enumeration/enumeration.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## UML Class Relationships

* A class may be involved in one or more relationships with other classes. A relationship can be one of the following types:

| Shape       | Image                                |
| ----------- | ------------------------------------ |
| Association | ![Association](images/Association.png) |
| Aggregation | ![Aggregation](images/Aggregation.png)  |
| Composition | ![Composition](images/Composition.png) |
| Inheritance | ![Inheritance](images/Inheritance.png)   |
| Dependency  | ![Dependency](images/Dependency.png) |

### Association

Association is basically a set of links that connects elements of an UML model. The type of association are as follows.

1. Directional
2. BiDirectional

The association property allows to define the type of association. The default value of association is “Directional”.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/association/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Association.cs" %}
{% include code-snippet/diagram/umldiagramshapes/association/association.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/association/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Association.cs" %}
{% include code-snippet/diagram/umldiagramshapes/association/association.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Aggregation

Aggregation is a binary association between a property and one or more composite objects which group together a set of instances. Aggregation is decorated with a hollow diamond. To create an aggregation shape, define the relationship as “aggregation”.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/aggregation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregation.cs" %}
{% include code-snippet/diagram/umldiagramshapes/aggregation/aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/aggregation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregation.cs" %}
{% include code-snippet/diagram/umldiagramshapes/aggregation/aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Composition

Composition is a “strong” form of “aggregation”. Composition is decorated with a black diamond. To create a composition shape, define the relationship property of connector as “composition”.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/composition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Composition.cs" %}
{% include code-snippet/diagram/umldiagramshapes/composition/composition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/composition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Composition.cs" %}
{% include code-snippet/diagram/umldiagramshapes/composition/composition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Dependency

Dependency is a directed relationship, which is used to show that some UML elements needs or depends on other model elements for specifications. Dependency is shown as dashed line with opened arrow. To create a dependency, define the relationship property of connector as “dependency”.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/dependency/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dependency.cs" %}
{% include code-snippet/diagram/umldiagramshapes/dependency/dependency.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/dependency/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dependency.cs" %}
{% include code-snippet/diagram/umldiagramshapes/dependency/dependency.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Inheritance

Inheritance is also called as “generalization”. Inheritance is a binary taxonomic directed relationship between a more general classifier (super class) and a more specific classifier (subclass). Inheritance is shown as a line with hollow triangle.

To create an inheritance, define the relationship as “inheritance”.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/inheritance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inheritance.cs" %}
{% include code-snippet/diagram/umldiagramshapes/inheritance/inheritance.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/inheritance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inheritance.cs" %}
{% include code-snippet/diagram/umldiagramshapes/inheritance/inheritance.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Multiplicity

Multiplicity is a definition of an inclusive interval of non-negative integers to specify the allowable number of instances of described element. The type of multiplicity are as follows.

1. OneToOne
2. ManyToOne
3. OneToMany
4. ManyToMany

* By default the multiplicity will be considered as “OneToOne”.

* The multiplicity property in UML allows to specify large number of elements or some collection of elements.

* The shape multiplicity’s source property is used to set the source label to connector and the target property is used to set the target label to connector.

* To set an optionality or cardinality for the connector source label, use optional property.

* The [`lowerBounds`](https://ej2.syncfusion.com/documentation/api/diagram/multiplicityLabelModel#lowerbounds) and [`upperBounds`](https://ej2.syncfusion.com/documentation/api/diagram/multiplicityLabelModel#upperbounds) could be natural constants or constant expressions evaluated to natural (non negative) number. Upper bound could be also specified as asterisk ‘\*’ which denotes unlimited number of elements. Upper bound should be greater than or equal to the lower bound.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/multiplicity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiplicity.cs" %}
{% include code-snippet/diagram/umldiagramshapes/multiplicity/multiplicity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/multiplicity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiplicity.cs" %}
{% include code-snippet/diagram/umldiagramshapes/multiplicity/multiplicity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## How to add UML child at runtime

In UML nodes, child elements such as member, method and attribute can be added either programmatically or interactively.

### Adding UML child through code

The [addChildToUmlNode](https://ej2.syncfusion.com/documentation/api/diagram#addchildtoumlnode) method is employed for dynamically adding a child to the UML node during runtime, providing flexibility in modifying the diagram structure programmatically.

The following code illustrates how to add methods to UML nodes in diagram.

```ts
let node = diagram.selectedItems.nodes[0];
let methods = { name: 'getHistory', style: { color: "red", }, parameters: [{ name: 'Date', style: {} }], type: 'History' };
diagram.addChildToUmlNode(node, methods, 'Methods');

```

The following code illustrates how to add attributes to UML nodes in diagram.

```ts
let node = diagram.selectedItems.nodes[0];
let attributes = { name: 'accepted', type: 'Date', style: { color: "red", } };
diagram.addChildToUmlNode(node, attributes, "Attributes");

```

The following code illustrates how to add members to UML nodes in diagram.

```ts
let node = diagram.selectedItems.nodes[0];
let members = { name: 'Checking new', style: { color: "red", }, isSeparator: true };
diagram.addChildToUmlNode(node, members, "Members");

```


### Adding UML child through user interaction

To include a child, select a node, move the mouse outside it, and position the pointer near the right side. A highlighter emerges between the two child elements. Click the highlighter to add a child type to the chosen UML node seamlessly. The following gif illustrates how to add Child through user interaction.

![UML child](images/UMLChild.gif)


## Adding UML Nodes in Symbol palette

UML built-in shapes are efficiently rendered in a symbol palette. The `symbols` property is utilized to define UML symbols with the necessary classes and methods. By incorporating this feature, you can seamlessly augment the palette with a curated collection of predefined UML symbols, thereby enhancing the versatility of your UML diagramming application.

The following code example showcases the rendering of UML built-in shapes in a symbol palette.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/uml/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Umlclass.cs" %}
{% include code-snippet/diagram/umldiagramshapes/uml/umlclass.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/uml/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Umlclass.cs" %}
{% include code-snippet/diagram/umldiagramshapes/uml/umlclass.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Editing

You can edit the name, attributes, and methods of the class diagram shapes just double clicking, similar to editing a node annotation.

![Editing Class Diagram](images/ClassEdit.png)


## UML Activity diagram

An Activity diagram functions as a visual flowchart, illustrating the progression from one activity to the next within a system. Each activity corresponds to a system operation, providing a clear depiction of the sequential flow in a dynamic process..

The purpose of an activity diagram can be described as follows.

    1. Draw the activity flow of a system.

    2. Describe the sequence from one activity to another.

    3. Describe the parallel, branched, and concurrent flow of the system.
    
## UML Activity diagram Shapes

To create a UmlActivity, define type as "UmlActivity" and the list of built-in shapes as demonstrated as follows and it should be set in the "shape" property.

| Shape          | Image                                    |
| -------------- | ---------------------------------------- |
| Action         | ![Action](images/Action.png)          |
| Decision       | ![Decision](images/Decision.png)         |
| MergeNode      | ![MergeNode](images/MergeNode.png)       |
| InitialNode    | ![InitialNode](images/InitialNode.png)       |
| FinalNode      | ![FinalNode](images/FinalNode.png)      |
| ForkNode       | ![ForkNode](images/ForkNode.png)       |
| JoinNode       | ![JoinNode](images/JoinNode.png)       |
| TimeEvent      | ![TimeEvent](images/TimeEvent.png)      |
| AcceptingEvent | ![AcceptingEvent](images/AcceptingEvent.png) |
| SendSignal     | ![SendSignal](images/SendSignal.png)     |
| ReceiveSignal  | ![ReceiveSignal](images/ReceiveSignal.png)  |
| StructuredNode | ![StructuredNode](images/StructuredNode.png) |
| Note           | ![Note](images/Note.png)           |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/UmlActivity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UmlActivity.cs" %}
{% include code-snippet/diagram/umldiagramshapes/UmlActivity/UmlActivity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/UmlActivity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UmlActivity.cs" %}
{% include code-snippet/diagram/umldiagramshapes/UmlActivity/UmlActivity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### UmlActivity connector

To create an UmlActivity connector, define the type as "UmlActivity" and flow as either "Exception" or "Control" or "Object".

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/UmlActivityConnector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UmlActivityConnector.cs" %}
{% include code-snippet/diagram/umldiagramshapes/UmlActivityConnector/UmlActivityConnector.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umldiagramshapes/UmlActivityConnector/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UmlActivityConnector.cs" %}
{% include code-snippet/diagram/umldiagramshapes/UmlActivityConnector/UmlActivityConnector.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}