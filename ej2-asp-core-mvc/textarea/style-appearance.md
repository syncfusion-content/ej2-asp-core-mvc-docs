---
layout: post
title: Style and appearance in ##Platform_Name## TextArea control | Syncfusion
description: Learn here all about Style and appearance in Syncfusion ##Platform_Name## TextArea control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Style and Appearance 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Sizing in ##Platform_Name## TextArea control

you can adjust the size of the TextArea by applying specific classes:

| Property  | Description |
| -- | -- |
| Small  | Add the `e-small` class to the input element or its container to render a smaller-sized TextArea. |
| Bigger | Add the `e-bigger` class to the input element or its container to render a larger-sized TextArea. |

By applying these classes, users can easily customize the appearance of the TextArea to better fit their application's design requirements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/sizing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/sizing/sizing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/sizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/sizing/sizing.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Output be like the below.

![textarea](./images/textarea-sizing.png)

## Filled and Outline mode

The Filled and Outline modes can be enabled in the TextArea component by adding the `e-outline` or `e-filled` class to the [CssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_CssClass) API.
By adding these classes, users can choose between a filled or outline appearance for the TextArea component, aligning with the design aesthetics of their application.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/filled-outlined/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/filled-outlined/filled-outlined.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/filled-outlined/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/filled-outlined/filled-outlined.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Output be like the below.

![textarea](./images/textarea-filledOutlined.png)

>Note: Filled and Outline theme customization are available only with Material themes.

## Custom styling with cssClass API in TextArea

The `CssClass` Api provides a powerful way to apply custom styling to the TextArea component, allowing users to customize its appearance and layout according to their design requirements.

By utilizing the `CssClass` API, users can apply custom CSS classes to the TextArea component's container, enabling control over its styling properties such as color, padding, margins, borders, and more.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/cssClass/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/cssClass/cssClass.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/cssClass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/cssClass/cssClass.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Setting the disabled state in TextArea

To disable the TextArea, you can utilize the [Enabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Enabled) property. When set to `false`, the TextArea becomes disabled, preventing user interaction.

{% if page.publishingplatform == "aspnet-core" %}
```html
<ejs-textarea id="default" enabled=false></ejs-daterangepicker>
```

{% elsif page.publishingplatform == "aspnet-mvc" %}
```html
@Html.EJS().TextArea("default").Enabled(false).Render()
```
{% endif %}

## Set the readonly TextArea

To make the TextArea read-only , you can use the [Readonly](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Readonly) property. When set to `true`, it prevents users from editing the content of the TextArea.

{% if page.publishingplatform == "aspnet-core" %}
```html
<ejs-textarea id="default" value="Readonly" readonly=true></ejs-daterangepicker>
```

{% elsif page.publishingplatform == "aspnet-mvc" %}
```html
@Html.EJS().TextArea("default").Readonly(true).Value("Readonly").Render()
```
{% endif %}

## Set the rounded corner in TextArea

Render the TextArea with `rounded corner` by adding the `e-corner` class to the input parent element.

>This rounded corner is visible only in box model input component

```html

<div class="e-input-group e-corner">
    <textarea class="e-input" placeholder="Enter your comments"></textarea>
</div>

```

## Static Clear Button in TextArea

To display a static clear button in the TextArea component, you can add the `e-static-clear` class to the `CssClass` property. This class ensures that the clear button remains visible at all times, providing users with the ability to easily clear the TextArea content without needing to focus on the control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/static-clear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/static-clear/static-clear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/static-clear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/static-clear/static-clear.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Output be like the below.

![textarea](./images/textarea-static-clear.png)

## Customize the TextArea background color and text color

You can customize the TextArea styles such as background-color, text-color and border-color by overriding its default styles to achieve the desired appearance for the TextArea.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/textarea-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/textarea-color/textarea-color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/textarea-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/textarea-color/textarea-color.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Output be like the below.

![textarea](./images/textarea-color.png)

## Change the floating label color of the TextArea

You can change the floating label color of the TextArea for both `success` and `warning` validation states by applying the following CSS styles.

```css

    /* For Success state */
    .e-float-input.e-success label.e-float-text,
    .e-float-input.e-success input:focus ~ label.e-float-text,
    .e-float-input.e-success input:valid ~ label.e-float-text {
      color: #22b24b;
    }

    /* For Warning state */
    .e-float-input.e-warning label.e-float-text,
    .e-float-input.e-warning input:focus ~ label.e-float-text,
    .e-float-input.e-warning input:valid ~ label.e-float-text {
      color: #ffca1c;
    }

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/floatLabel-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/floatLabel-color/floatLabel-color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/floatLabel-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/floatLabel-color/floatLabel-color.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Output be like the below.

![textarea](./images/textarea-floatLabel-color.png)

## Adding mandatory asterisk to placeholder

To add a mandatory asterisk (*) to the placeholder in the TextArea component, you can utilize CSS to append the asterisk after the placeholder text.

```css

/* To add asterick to float label in textarea */ 
.e-float-input.e-control-wrapper .e-float-text::after {
  content: '*'; /* Add asterisk after the placeholder */
  color: red; /* Customize asterisk color */
}

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/asterisk/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/asterisk/asterisk.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/style-appearance/asterisk/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/style-appearance/asterisk/asterisk.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Output be like the below.

![textarea](./images/textarea-asterisk.png)
