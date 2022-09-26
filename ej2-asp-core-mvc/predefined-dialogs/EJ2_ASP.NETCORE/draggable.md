---
layout: post
title: Draggable in ##Platform_Name## Predefined Dialogs
description: Learn here all about Draggable in Syncfusion ##Platform_Name## Predefined Dialogs of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Draggable
publishingplatform: ##Platform_Name##
documentation: ug
---

# Draggable in Predefined Dialogs

The predefined dialogs supports dragging within its target container by grabbing the dialog header, which allows the user to reposition the dialog dynamically by using the isDraggable property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/draggable/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/draggable/confirm/tagHelper %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/predefined-dialogs/draggable/alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/getting-started/confirm-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}
