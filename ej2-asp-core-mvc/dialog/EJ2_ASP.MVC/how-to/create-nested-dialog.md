---
layout: post
title: How to create nested Dialog in ##Platform_Name## Dialog | Syncfusion
description: Nest a Dialog inside another Syncfusion ##Platform_Name## Dialog by initializing the inner Dialog with the outer Dialog as its target.
platform: ej2-asp-core-mvc
control: Create Nested Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to create nested Dialog in ##Platform_Name## Dialog

A Dialog can be nested within another Dialog. The following sample demonstrates a nested Dialog, containing an outer (parent) Dialog and an inner (child) Dialog.

## Implementation Steps

**Step 1**:

Create two div elements with ids `#dialog` and `#innerDialog`.

**Step 2**:

Initialize the Dialog as mentioned in the below sample.

**Step 3**:

Set the inner Dialog's [`target`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.popups.dialog.html#Syncfusion_EJ2_Popups_Dialog_Target) property to `"#dialog"` (the ID of the parent Dialog element).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/nested-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/nested-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/nested-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/nested-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![dialog](../images/dialog-nested.png)