---
layout: post
title: Groups in ##Platform_Name## Textbox Component
description: Learn here all about Groups in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Groups
publishingplatform: ##Platform_Name##
documentation: ug
---


# Groups

The following section explains you the steps required to create TextBox with `icon` and `floating label`.

**TextBox:**

* Create a parent div element with the class `e-input-group`

* Place input element with the class `e-input` inside the parent div element.

```html
      <div class="e-input-group">
            <input class="e-input" name='input' type="text" placeholder="Enter Date"/>
      </div>
```

**Floating label:**

* Add the `e-float-input` class to the parent div element.

* Remove the e-input class and add `required` attribute to the input element.

* Place the span element with class `e-float-line` after the input element.

* Place the label element with class `e-float-text` after the above created span element. When you focus or filled with value in the TextBox, the label floats above the TextBox.

> Creating the Floating label TextBox, you have to set the `required` attribute to the Input element to achieve the floating label functionality which is used for validating the value existence in TextBox. If you want to render the Floating label TextBox without
`required` attribute then refer to the [Floating label without required attribute](#floating-label-without-required-attribute) section.

```html
        <div class="e-float-input e-input-group">
            <input type="text" required/>
            <span class="e-float-line"></span>
            <label class="e-float-text">Enter Name </label>
        </div>
```

And refer to the following sections to add the icons to the TextBox.

## With icon and floating label

Create an icon element as a span with the class `e-input-group-icon`, and the user can place the icon in either side of TextBox by adding the created icon element before/after the input.

For the floating label enabled TextBox add the icon element as first or last element inside the TextBox wrapper,and based on the element position it will act as prefix or suffix icon.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/textbox/groups/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/textbox/groups/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](./images/textbox-icon.png)

## With clear button and floating label

The clear button is added to the input for clearing the value given in the TextBox.
It is shown only when the input field has a value, otherwise not shown.

You can add the clear button to the TextBox by enabling `showClearButton` API.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/clear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textbox/groups/clear/clear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/clear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textbox/groups/clear/clear.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](./images/textbox-clear.png)

## Floating label without required attribute

You can render the `Floating label TextBox` without `required` attribute by manually
float the label above of the TextBox using input events.
You can manually float the label above of the TextBox by adding the below list of
classes to the floating label element. The classes are:

Class Name        | Description
------------------| -------------
  e-label-top     | Floats the label above of the TextBox.
  e-label-bottom  | Label to be placed as placeholder for the TextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/floating/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Floating.cs" %}
{% include code-snippet/textbox/groups/floating/floating.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/floating/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Floating.cs" %}
{% include code-snippet/textbox/groups/floating/floating.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multi-line input with floating label

Add the HTML`textarea` element with the `e-input` class to create default multi-line input.

Add the floating label support to the `multi-line input` by creating the floating label structure as defined in the initial section.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/multi-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiline.cs" %}
{% include code-snippet/textbox/groups/multi-line/multiline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/multi-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiline.cs" %}
{% include code-snippet/textbox/groups/multi-line/multiline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to add floating label to TextBox programmatically](./how-to/add-floating-label-to-textbox-programmatically)
* [Change the floating label color of the TextBox](./how-to/change-the-floating-label-color-of-the-textbox)
* [Change the color of the TextBox based on its value](./how-to/change-the-color-of-the-textbox-based-on-its-value)
