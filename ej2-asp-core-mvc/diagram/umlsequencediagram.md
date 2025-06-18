---
layout: post
title: UmlSequenceDiagram in Syncfusion® ##Platform_Name## Diagram Component
description: Learn here all about UmlSequenceDiagram in Syncfusion® ##Platform_Name## Diagram component of Syncfusion Essential® JS 2 and more.
platform: ej2-asp-core-mvc
control: UmlSequenceDiagram
publishingplatform: ##Platform_Name##
documentation: ug
---

# UML Sequence Diagram Model in Diagram

A UML sequence diagram is an interaction diagram that demonstrates how objects interact with each other and the order of these interactions. The Syncfusion® diagram control provides comprehensive support for creating and visualizing UML sequence diagrams through the [UmlSequenceDiagramModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramUmlSequenceDiagramModel). Assign the `UmlSequenceDiagramModel` to the [Model](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_Model) property of the diagram control to enable this functionality.

## UML Sequence Diagram Elements

A sequence diagram contains several key elements, such as participants, messages, activation boxes, and fragments. Let's discuss how to implement these components using the diagram control.

### Participants

[UmlSequenceParticipantModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramUmlSequenceParticipant) in a sequence diagram represent the entities that interact with each other, appearing at the top of the diagram with lifelines extending vertically downward.

#### UmlSequenceParticipantModel Properties

| Property | Type | Description |
|---|---|---|
| id | string \| number | A unique identifier for the participant |
| content | string | The display text for the participant |
| isActor | boolean | Determines if the participant is displayed as an actor (true) or object (false) |
| showDestructionMarker | boolean | Determines if a destruction marker (X) is shown at the end of the lifeline |
| activationBoxes | UmlSequenceActivationBoxModel[] | Collection of activation boxes for this participant |

The following code example illustrates how to create participants.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-1/umlseq.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-1/umlseq.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![participants](./images/umlSequenceDiagram-images/participants.png)

### Messages

[UmlSequenceMessageModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramUmlSequenceMessage.html) represents communication between participants and are displayed as arrows connecting lifelines.

#### Types of Messages

| Message Type | Description | Example |
|---|---|---|
| Synchronous | The sender waits for a response | ![Synchronous Message](./images/umlSequenceDiagram-images/Synchronous.png) |
| Asynchronous | The sender continues without waiting | ![Asynchronous Message](./images/umlSequenceDiagram-images/Asynchronous.png) |
| Reply | A response to a previous message | ![Reply Message](./images/umlSequenceDiagram-images/Reply.png) |
| Create | Creates a new participant | ![Create Message](./images/umlSequenceDiagram-images/Create.png) |
| Delete | Terminates a participant | ![Delete Message](./images/umlSequenceDiagram-images/Delete.png) |
| Self | A message from a participant to itself | ![Self Message](./images/umlSequenceDiagram-images/Self.png) |

#### UmlSequenceMessageModel Properties

| Property | Type | Description |
|---|---|---|
| id | string \| number | A unique identifier for the message |
| content | string | The display text for the message |
| fromParticipantID | string \| number | ID of the participant sending the message |
| toParticipantID | string \| number | ID of the participant receiving the message |
| type | UmlSequenceMessageType | Type of the message (Synchronous, Asynchronous, Reply, Create, Delete, Self) |

The following code example illustrates how to create messages:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-2/umlseq.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-2/umlseq.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![messages](./images/umlSequenceDiagram-images/messages.png)

### Activation Boxes

[UmlSequenceActivationBoxModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramUmlSequenceActivationBox.html) represents periods when a participant is active and processing a message. They appear as thin rectangles on participant lifelines.

#### UmlSequenceActivationBoxModel Properties

| Property | Type | Description |
|---|---|---|
| id | string \| number | A unique identifier for the activation box |
| startMessageID | string \| number | ID of the message that initiates the activation |
| endMessageID | string \| number | ID of the message that terminates the activation |

The following code example illustrates how to create activation boxes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-3/umlseq.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-3/umlseq.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
![activations](./images/umlSequenceDiagram-images/activations.png)

### Fragments

[UmlSequenceFragmentModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramUmlSequenceFragment.html) groups a set of messages based on specific conditions in a sequence diagram. They are displayed as rectangular enclosures that visually separate conditional or looping interactions.

#### Types of Fragments

The [UmlSequenceFragmentType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.UmlSequenceFragmentType) enum defines the following fragment types:

| Fragment Type  | Description  | Example  |  
|---------------|-------------|--------|  
| Optional  | Represents a sequence that is executed only if a specified condition is met; otherwise, it is skipped. | ![Optional Fragment](./images/umlSequenceDiagram-images/OptFragment.png) |  
| Alternative | Represents multiple conditional paths (if-else structure), where only one path executes based on the condition. | ![Alternative Fragment](./images/umlSequenceDiagram-images/AltFragment.png) |  
| Loop | Represents a repeating sequence of interactions that continues based on a loop condition. | ![Loop Fragment](./images/umlSequenceDiagram-images/LoopFragment.png) |  

#### UmlSequenceFragmentModel Properties

| Property | Type | Description |
|---|---|---|
| id | string \| number | A unique identifier for the fragment |
| type | UmlSequenceFragmentType | Type of the fragment (Optional, Loop, Alternative) |
| conditions | UmlSequenceFragmentConditionModel[] | Collection of conditions for the fragment |

#### UmlSequenceFragmentConditionModel Properties

| Property | Type | Description |
|---|---|---|
| content | string | Text describing the condition or parameter |
| messageIds | (string \| number)[] | Collection of message IDs included in this condition section |
| fragmentIds | string[] | Collection of nested fragments ids (for complex structures) |

The following code example illustrates how to create fragments.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-4/umlseq.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/umlsequencediagram-4/umlseq.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![fragments](./images/umlSequenceDiagram-images/fragments.png)

### Customizing Participant Spacing in Sequence Diagram 

The [SpaceBetweenParticipants](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramUmlSequenceDiagramModel.html#Syncfusion_EJ2_Diagrams_DiagramUmlSequenceDiagramModel_SpaceBetweenParticipants) property in `UmlSequenceDiagramModel` controls the horizontal gap between participants. The default value is 100, but you can adjust it as needed.
