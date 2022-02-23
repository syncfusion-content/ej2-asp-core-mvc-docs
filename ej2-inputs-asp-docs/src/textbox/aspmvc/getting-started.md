---
title: "Getting Started"
component: "TextBox"
description: "Helps to get started with text box component along with its key features such as a floating label, adding icons (input group), and ripple effect."
---

# Getting Started

This section briefly explains about how to include a simple Textbox in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our components.

## Initialize TextBox control to the Application

TextBox control can be rendered by using the `EJS().TextBox()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the TextBox.

{% aspTab template="textbox/getting-started/input", sourceFiles="input.cs" %}

{% endaspTab %}

> Running the above code will display the basic TextBox on the browser.

## Adding icons to the TextBox

You can create a TextBox with icon as a group by creating the parent div element with the class `e-input-group` and add the icon element as span with the class `e-input-group-icon`. For detailed information, refer to the [Groups](./groups/) section.

{% aspTab template="textbox/getting-started/icon", sourceFiles="icon.cs" %}

{% endaspTab %}

Output be like the below.

![textbox](./images/textbox-getting.png)

## Floating label

The floating label TextBox floats the label above the TextBox after focusing, or filled with value in the TextBox. You can create the floating label TextBox by using the [floatLabelType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_FloatLabelType) API

{% aspTab template="textbox/getting-started/textbox-component", sourceFiles="floating.cs" %}

{% endaspTab %}

## See Also

* [How to render TextBox programmatically](./how-to/add-textbox-programmatically)
* [How to add floating label to TextBox programmatically](./how-to/add-floating-label-to-textbox-programmatically)
