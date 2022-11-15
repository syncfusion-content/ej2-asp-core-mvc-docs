---
layout: post
title: Styles in ##Platform_Name## Floating Action Button Control | Syncfusion
description: Learn here all about Styles in Syncfusion ##Platform_Name## Floating Action Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Styles
publishingplatform: ##Platform_Name##
documentation: ug
---

# Styles in Asp.Net Core Floating Action Button Control

This section explains the different styles of Floating Action Button.

## FAB styles

The Asp.Net Core Floating Action Button supports the following predefined styles that can be defined using the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_CssClass) property. You can customize by replacing the `cssClass` property with the below defined class.

| Class | Description |
| -------- | -------- |
| e-success | Used to represent a positive action. |
| e-outline |  Used to represent an appearance of button with outline. |
| e-info |  Used to represent an informative action. |
| e-warning | Used to represent an action with caution. |
| e-danger | Used to represent a negative action. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/styles/fab-styles/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Floating Action Button Control with different Styles](images/Style.png)

> Predefined Floating Action Button styles provide only the visual indication. So, Floating Action Button [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Content) property should define the Floating Action Button style for the users of assistive technologies such as screen readers.

## Styles Customization

To modify the Floating Action Button appearance, you need to override the default CSS of Floating Action Button component. Find the list of CSS classes and its corresponding section in Floating Action Button component. Also, you have an option to create your own custom theme for the controls using our [Theme Studio](https://blazor.syncfusion.com/themestudio/).

| CSS Class | Purpose of Class |
|-----|----- |
|.e-fab.e-btn|To customize the FAB.|
|.e-fab.e-btn:hover|To customize the FAB on hover.|
|.e-fab.e-btn:focus|To customize the FAB on focus.|
|.e-fab.e-btn:active|To customize the FAB on active.|
|.e-fab.e-btn-icon|To customize the style of FAB icon.|

## Show text on hover

By using `cssClass`, you can customize the Floating Action Button to show text on hover with applied transition effect.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/styles/onhover/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Floating Action Button control with Hover](images/onhover.png)
