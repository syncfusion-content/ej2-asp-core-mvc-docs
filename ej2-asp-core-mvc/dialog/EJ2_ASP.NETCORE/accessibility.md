---
layout: post
title: Accessibility in ##Platform_Name## Dialog Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Dialog component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The Dialog characterized with complete ARIA Accessibility support helps to be accessible by on-screen readers and other assistive technology devices. This component is designed with the reference of the guidelines document given in [WAI ARAI Accessibility Practices](https://www.w3.org/TR/wai-aria-practices-1.1/#dialog_modal).

The Dialog control uses the `Dialog` role and following ARIA properties to its element based on its state.

| **Property** | **Functionalities** |
| --- | --- |
| aria-describedby | It indicates the Dialog content description that is notified to the user through assistive technologies. |
| aria-labelledby | The Dialog title is notified to the user through assistive technologies. |
| aria-modal | For modal dialog its value is true and for non-modal dialog its value is false. |
| aria-grabbed | Enables the draggable Dialog and starts dragging its value is true and stopping the drag its value is false. |

## Keyboard interaction

Keyboard interaction of Dialog control has been designed based on [WAI-ARIA Practices](https://www.w3.org/TR/wai-aria-practices-1.1/#dialog_modal) described for Dialog. User can use the following shortcut keys to interact with the Dialog.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
<b>Keyboard shortcuts</b></td><td>
<b>Actions</b></td></tr>
<tr>
<td>
<kbd>Esc</kbd></td><td>
Closes the Dialog. This functionality can be controlled by using
<a href="https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Popups.Dialog~CloseOnEscape.html" target="_blank"> `closeOnEscape`</a> </td></tr>
<tr>
<td>
<kbd>Enter</kbd></td><td>
When the Dialog button or any input (except text area) is in focus state, when pressing the Enter key, the click event associated with the primary button or button will trigger. Enter key is not working when the Dialog content contains any text area with initial focus.</td></tr>
<tr>
<td>
<kbd>Ctrl + Enter</kbd></td><td>
When the Dialog content contains text area and it is in focus state, and press the Ctrl + Enter key to call the click event function associated with primary button.</td></tr>
<tr>
<td>
<kbd>Tab</kbd></td><td>
Focus will be changed within the Dialog elements</td></tr>
<tr>
<td>
<kbd>Shift + Tab</kbd></td><td>
The Focus will be changed previous focusable element within the Dialog elements. When focusing a first focusable element in the Dialog, then press the shift + tab key, it will change the focus to last focusable element.</td></tr>
</table>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/accessibility/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/accessibility/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Show dialog with full-screen](./how-to/show-dialog-with-full-screen)
