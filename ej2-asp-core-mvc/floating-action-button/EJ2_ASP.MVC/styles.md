---
layout: post
title: Styles in ##Platform_Name## FloatingActionButton Component
description: Learn here all about Styles in Syncfusion ##Platform_Name## FloatingActionButton component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Styles
publishingplatform: ##Platform_Name##
documentation: ug
---

# Styles in Asp.Net MVC Floating Action Button Component

This section explains the different styles of Floating Action Button.

## Floating Action Button styles

The Asp.Net MVC Floating Action Button has the following predefined styles that can be defined using the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_CssClass)property for represent primary action we have [IsPrimary](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_IsPrimary)property.

| Class | Description |
| -------- | -------- |
| e-success | Used to represent a positive action. |
| e-info |  Used to represent an informative action. |
| e-warning | Used to represent an action with caution. |
| e-danger | Used to represent a negative action. |
| e-link |  Changes the appearance of the Button like a hyperlink. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/styles/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/styles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabStyles.cs" %}
{% include code-snippet/floating-action-button/styles/fabstyles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net MVC Floating Action Button Component with different Styles](images/css-styles.png)

## Styles Customization

To modify the Floating Action Button appearance, you need to override the default CSS of Floating Action Button component. Please find the list of CSS classes and its corresponding section in Floating Action Button component.

|CSS Class | Purpose of Class |
|-----|----- |
|.e-btn|To customize the button.|
|.e-btn:hover|To customize the button on hover.|
|.e-btn:focus|To customize the button on focus.|
|.e-btn:active|To customize the button on active.|
|.e-fab .e-icon-btn|To customize the fab button icons.|