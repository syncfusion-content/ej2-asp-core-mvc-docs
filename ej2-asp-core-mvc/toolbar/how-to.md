---
layout: post
title: How To in ##Platform_Name## Toolbar Component
description: Learn here all about How To in Syncfusion ##Platform_Name## Toolbar component and more.
platform: ej2-asp-core-mvc
control: How To
publishingplatform: ##Platform_Name##
documentation: ug
---


# How To

## Set command customization

The `htmlAttributes` property of the Toolbar item is used to set the HTML attributes ('ID', 'class', 'style' ,'role') for the commands.

When style attributes are added, if the same attributes were already present, they will be replaced. This is not so in the case of `class` attribute. Classes will be added to the element instead of replacing the existing ones.

Single or multiple CSS classes can be added to the Toolbar commands using the Toolbar item `cssClass` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/toolbar/how-to/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/toolbar/how-to/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Toolbar Control with customized commands](./images/toolbar_command.PNG)

## Set Essential JS 2 Tooltip to the commands

The `tooltipText` property of the Toolbar item is used to set the HTML Tooltip to the commands that can be viewed as hint texts on mouse hover.

To change the `tooltipText` to ej2-tooltip component:

* Import the `Tooltip` module from `ej2-popups`,and initialize the Tooltip with the Toolbar target. Refer to the following code example:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/toolbar/how-to/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/toolbar/how-to/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Toolbar Control with tooltip support](./images/toolbar_tooltip.PNG)

## Set item-wise custom template

The Toolbar supports adding template commands using the  `template` property. Template property can be given as the `HTML element` that is either a `string`  or a `query selector`.

### As a string

The HTML element tag can be given as a string for the template property. Here, the checkbox is rendered as a HTML template.

```typescript
template: "<div><input type='checkbox' id='check1' checked=''>Accept</input></div>"

```

### As a selector

The template property also allows getting template content through query `selector`. Here, checkbox 'ID' attribute is specified in the template.

```typescript
template: "#Template"

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/selector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selector.cs" %}
{% include code-snippet/toolbar/how-to/selector/selector.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/selector/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selector.cs" %}
{% include code-snippet/toolbar/how-to/selector/selector.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add Toggle Button

Toolbar supports to add a toggle Button by using the template property. Refer below steps

* By using Toolbar template property, pass required HTML String to render toggle button.

```typescript
    template='<button class="e-btn" id="media_btn"></button>'
```

* Now render the toggle Button into the targeted element in Toolbar created event handler and bind click event for it.
On clicking the toggle Button, change the required icon and content based on current active state.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/togglebutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Togglebutton.cs" %}
{% include code-snippet/toolbar/how-to/togglebutton/togglebutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/togglebutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Togglebutton.cs" %}
{% include code-snippet/toolbar/how-to/togglebutton/togglebutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to customize toolbar scrollStep

Toolbar supports to customize the scrolling distance when you click the left and right side navigation icons. Through `beforeCreate` event we can customize `scrollStep` property for scrolling distance. Please Refer below steps

* By using Toolbar scrollStep property, pass a required value to customize toolbar scrollStep.

```typescript
    function beforeCreate(e) {
        e.scrollStep = 50;
    }
```

* Now customize the scrollStep value in Toolbar beforeCreate event handler.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/scrollstep/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollstep.cs" %}
{% include code-snippet/toolbar/how-to/scrollstep/scrollstep.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/scrollstep/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollstep.cs" %}
{% include code-snippet/toolbar/how-to/scrollstep/scrollstep.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

