---
layout: post
title: Groups in ##Platform_Name## Textbox Component
description: Learn here all about Groups in Syncfusion ##Platform_Name## Textbox component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Groups
publishingplatform: ##Platform_Name##
documentation: ug
---


# Groups

The following section explains you the steps required to create TextBox with `icon` and `floating label`.

**TextBox:**

```html
      <div class="e-input-group">
           <ejs-textbox id="icon-textbox" placeholder="Enter Date"></ejs-textbox>
      </div>
```

**Floating label:**

Use the [FloatLabelType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_FloatLabelType) property to add a floating label to the TextBox. This property controls the behavior of the placeholder text, allowing it to float above the TextBox based on the following values:

* Never: The placeholder text never floats.
* Always: The placeholder text always floats above the TextBox.
* Auto: The placeholder text floats above the TextBox when focused or when a value is entered.

```html
      <ejs-textbox id="float-icon-textbox" placeholder="Enter Name" floatLabelType="Auto"></ejs-textbox>
```

And refer to the following sections to add the icons to the TextBox.

## With icon and floating label

Create an icon in the TextBox using the [addIcon]() method and enable the float label using the [FloatLabelType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_FloatLabelType) property. The user can place the icon on either side of the TextBox by specifying "append" or "prepend" in the [addIcon]() method.

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


## Multi-line input with floating label

To create a multi-line input field, use the [multiline](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_Multiline) property. This will turn the input into a TextArea component, allowing you to resize the number of rows as needed.

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
