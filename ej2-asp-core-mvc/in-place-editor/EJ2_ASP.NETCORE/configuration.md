---
layout: post
title: Configuration in ##Platform_Name## In Place Editor Component
description: Learn here all about Configuration in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Configuration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Configuration

## Rendering modes

This section explains the supported rendering modes of the In-place Editor. Possible Rendering modes are as follows.

    * Popup
    * Inline

> By default, `Popup` mode will be rendered, when opening an editor.

* For `Popup` mode, editable container displays as like tooltip or popover above the element.

* For `Inline` mode, editable container displays as instead of the element. To render `Inline` mode while opening the editor, specify [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Mode) as `Inline`.

In the following sample, the In-place Editor renders with `Inline` mode. You can dynamically switch into another mode by changing the drop-down item value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/modes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/modes/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/modes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/modes/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![Modes](./images/mode.PNG)

### Pop-up customization

In-place Editor popup mode can be customized by using the `title` and `model` properties in [`popupSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_PopupSettings) API.

Popup mode rendered by using the Syncfusion ASP.NET Core Tooltip control, so you can use tooltip properties and events to customize the behavior of popup via the `model` property of `popupSettings` API.

> For more details, refer the tooltip documentation section.

In the following sample, popup `title` and `position` customized using the `popupSettings` property. All possible tooltip position data configured in the drop-down, if we change drop down item, selected value bound to `model` property and applied it to `Tooltip` control. `Tooltip` have following position options.

* TopLeft
* TopCenter
* TopRight
* BottomLeft
* BottomCenter
* BottomRight
* LeftTop
* LeftCenter
* LeftBottom
* RightTop
* RightCenter
* RightBottom

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/popup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/popup/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/popup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/popup/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![Popup](./images/popup.PNG)

## Event actions for editing

The event action of the editor that enable in the edit mode based on the [`editableOn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_EditableOn) property, by default `Click` is assigned, the following options are also supported.

* **`Click`**:  The editor will be opened as single click actions.
* **`DblClick`**: The editor will be opened as double-click actions and it is not applicable for edit icon.
* **`EditIconClick`**: Disables the editing of event action of input and allows user to edit only through edit icon.

> In-place Editor get focus by pressing the `tab` key from previous focusable DOM element and then by pressing `enter` key, the editor will be opened.

In the following sample, when switching drop-down item, the selected value assigned to the `editableOn` property. If you changed to `DblClick`, the editor will open when making a double click on the input.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/editable-on/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/editable-on/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/editable-on/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/editable-on/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![Editable-on](./images/editable-on.PNG)

## Action on focus out

Action to be performed when the user clicks outside the container, that means focusing out of editable content and it can be handled by the [`actionOnBlur`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_ActionOnBlur) property, by default `Submit` assigned. It also has the following options.

* **`Cancel`**: Cancels the editing and resets the old content.
* **`Submit`**: Submits the edited content to the server.
* **`Ignore`**: No action is performed with this type and allows to edit multiple editors.

In the following sample, when switching drop-down item, the selected value assigned to the `actionOnBlur` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/action-on-blur/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/action-on-blur/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/action-on-blur/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/action-on-blur/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![Action-on-blur](./images/action-on-blur.PNG)

## Display modes

By default, In-place Editor input element highlighted with a dotted underline. To remove dotted underline from input element, add `data-underline="false"` attribute at In-place Editor root element.

In the following sample, denotes to indicate intractable and normal display modes with different samples.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/under-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/under-line/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/under-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/under-line/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![Underline](./images/under-line.PNG)