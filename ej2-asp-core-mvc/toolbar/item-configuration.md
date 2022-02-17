---
layout: post
title: Item Configuration in ##Platform_Name## Toolbar Component
description: Learn here all about Item Configuration in Syncfusion ##Platform_Name## Toolbar component and more.
platform: ej2-asp-core-mvc
control: Item Configuration
publishingplatform: ##Platform_Name##
documentation: ug
---

  text       | The text to be displayed for button.
 id         | The ID of the button to be rendered. If the ID is not given, auto ID is generated.
  prefixIcon | Defines the class used to specify an icon for the button. The icon is `positioned before` the text if text is available or the icon alone button is rendered.
suffixIcon | Defines the class used to specify an icon for the button. The icon is `positioned after` the text if text is available. If both `prefixIcon` and `suffixIcon` are specified, only `prefixIcon` is considered.
  width      | Used to set the width of the button.

## Separator

The `Separator` type adds a vertical separation between the Toolbar's single/multiple commands.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/toolbar/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/toolbar/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If `Separator` is added as the first or the last item, it will not be visible.

## Input

The `Input` type is only applicable for adding `template` elements when the  `template` property is defined as an `object`. Input type creates an `input element` internally that acts as the container for `Syncfusion` input based components.

### NumericTextBox

* The `NumericTextBox` component can be included by importing the `NumericTextBox` module from `ej2-inputs`.

* Initialize the `NumericTextBox` in template property, where the Toolbar item type is set as `Input`.

* Related `NumericTextBox` component properties can also be configured as given below.

```javascript

<ejs-numerictextbox format="n2"></ejs-numerictextbox>

```

### DropDownList

* The `DropDownList` component can be included by importing the `DropDownList` module from `ej2-dropdowns`.

* Initialize the `DropDownList` in template property, where the Toolbar item type is set as `Input`.

* Related `DropDownList` component properties can also be configured as given below.

```javascript

<ejs-dropdownlist width="100"></ejs-dropdownlist>

```

### RadioButton

* The `RadioButton` component can be included by importing the `RadioButton` module from `ej2-buttons`.

* Initialize the `RadioButton` in template property, where the Toolbar item type is set as `Input`.

* Related `RadioButton` component properties can also be configured as given below.

```javascript

<ejs-radiobutton label="Option 1" name="default"></ejs-radiobutton>

```

Output be like the below.

![Toolbar Control with item configuration](./images/toolbar_tempalte.PNG)

## See Also

* [How to set item wise custom template](./how-to/set-item-wise-custom-template)