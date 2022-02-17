---
layout: post
title: Priority in ##Platform_Name## Kanban Component
description: Learn here all about Priority in Syncfusion ##Platform_Name## Kanban component and more.
platform: ej2-asp-core-mvc
control: Priority
publishingplatform: ##Platform_Name##
documentation: ug
---


# Card Order

By default, the Kanban cards are initially placed and drop the card inside the columns based on JSON data orders.

Cards are placed in a particular position in the columns when you drop the cards by specifying the `Priority` property, which is mapped from the datasource. This property allows the users to drop the cards in the Kanban board where exactly created on dropped clone. It is also helpful to render the cards based on the `Priority` property value.

The following cases are dynamically changed their `Priority` value when drop the cards.

* If the cell has no cards, the dropped card `Priority` value does not change.

* If the cell has one card and dropped a card to last position or previous/next cards that do not have continuous order, then the dropped card `Priority` value changed based on their previous card value.

* If the cell has one card and dropped a card on previous position, then compare both values and the dropped card `Priority` value is changed if the cards have continuous order otherwise not changed their value.

* When the previous and next cards does not have continuous order, the dropped card `Priority` value changed based on the previous card value.

* When previous and next cards have continuous order or odd/even value, then the dropped card followed by next all cards up to **continuous value** are dynamically changed their `Priority` value based on the **previous** card value.

For Example,
**Continuous Order** -
Column A having Card A with priority value `1`, Card B with priority value `2` and Card C with priority value `3`.
Column B having Card D with priority value `5`. Dropped Card D between Card A and Card B. Now, Card D, B and C dynamically changed their priority value to `2, 3, 4`.

**Odd/Even order** -
Column A having Card A with priority value `1`, Card B with priority value `3` and Card C with priority value `5`.
Column B having Card D with priority value `5`. Dropped Card D between Card A and Card B. Now, Card D, B and C dynamically changed their priority value to `2, 3, 5`.

> The `Priority` property mapping key value must be `number` format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/priority/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/priority/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/priority/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/priority/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/priority.PNG)
