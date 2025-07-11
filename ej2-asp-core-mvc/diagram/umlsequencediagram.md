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

A UML sequence diagram is an interaction diagram that demonstrates how objects interact with each other and the order of these interactions. The Syncfusion® diagram control provides comprehensive support for creating and visualizing UML sequence diagrams through the `UmlSequenceDiagramModel`. To enable this functionality, assign the `UmlSequenceDiagramModel` to the `Model` property of the diagram control.

## UML Sequence Diagram Elements

A sequence diagram contains several key elements, such as participants, messages, activation boxes, and fragments. Let's discuss how to implement these components using the diagram control.

### Participants

`UmlSequenceParticipantModel` in a sequence diagram represent the entities that interact with each other, appearing at the top of the diagram with lifelines extending vertically downward.

#### UmlSequenceParticipantModel Properties

| Property | Type | Description |
|---|---|---|
| id | string \| number | A unique identifier for the participant |
| content | string | The display text for the participant |
| isActor | boolean | Specifies whether the participant is displayed as an actor (true) or an object (false) |
| showDestructionMarker | boolean | Indicates whether a destruction marker (X) is shown at the end of the lifeline |
| activationBoxes | UmlSequenceActivationBoxModel[] | A collection of activation boxes associated with the participant |

The following code example illustrates how to create participants.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/participants/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/participants/umlseq.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/participants/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/participants/umlseq.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![participants](./images/umlsequencediagrams/Participants.png)

### Messages

`UmlSequenceMessageModel` represents communication between participants and are displayed as arrows connecting lifelines.

#### Types of Messages

| Message Type | Description | Example |
|---|---|---|
| Synchronous | The sender waits for a response | ![Synchronous Message](./images/umlsequencediagrams/Synchronous.png) |
| Asynchronous | The sender continues without waiting | ![Asynchronous Message](./images/umlsequencediagrams/Asynchronous.png) |
| Reply | A response to a previous message | ![Reply Message](./images/umlsequencediagrams/Reply.png) |
| Create | Creates a new participant | ![Create Message](./images/umlsequencediagrams/Create.png) |
| Delete | Terminates a participant | ![Delete Message](./images/umlsequencediagrams/Delete.png) |
| Self | A message from a participant to itself | ![Self Message](./images/umlsequencediagrams/Self.png) |

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
{% include code-snippet/diagram/umlsequencediagram/messages/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/messages/umlseq.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/messages/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/messages/umlseq.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![messages](./images/umlsequencediagrams/msg.png)

### Activation Boxes

`UmlSequenceActivationBoxModel` represents periods when a participant is active and processing a message. They appear as thin rectangles on participant lifelines.

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
{% include code-snippet/diagram/umlsequencediagram/activations/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/activations/umlseq.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/activations/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/activations/umlseq.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![activations](./images/umlsequencediagrams/activations.png)

### Fragments

`UmlSequenceFragmentModel` groups a set of messages based on specific conditions in a sequence diagram. They are displayed as rectangular enclosures that visually separate conditional or looping interactions.

#### Types of Fragments

The [UmlSequenceFragmentType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.UmlSequenceFragmentType) enum defines the following fragment types:

| Fragment Type  | Description  | Example  |  
|---------------|-------------|--------|  
| Optional  | Represents a sequence that is executed only if a specified condition is met; otherwise, it is skipped. | ![Optional Fragment](./images/umlsequencediagrams/OptFragment.png) |  
| Alternative | Represents multiple conditional paths (if-else structure), where only one path executes based on the condition. | ![Alternative Fragment](./images/umlsequencediagrams/AltFragment.png) |  
| Loop | Represents a repeating sequence of interactions that continues based on a loop condition. | ![Loop Fragment](./images/umlsequencediagrams/LoopFragment.png) |  

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
{% include code-snippet/diagram/umlsequencediagram/fragments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/fragments/umlseq.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/umlsequencediagram/fragments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Model.cs" %}
{% include code-snippet/diagram/umlsequencediagram/fragments/umlseq.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![fragments](./images/umlsequencediagrams/fragment.png)

### Customizing Participant Spacing in Sequence Diagram 

The `SpaceBetweenParticipants` property in `UmlSequenceDiagramModel` controls the horizontal spacing between participants. The default value is 100, and it can be adjusted based on your layout requirements.
