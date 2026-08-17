---
layout: post
title: How to create nested Dialog in ASP.NET MVC Dialog | Syncfusion
description: Nest a Dialog inside another Syncfusion ASP.NET MVC Dialog by initializing the inner Dialog with the outer Dialog as its target.
platform: ej2-asp-core-mvc
control: Create Nested Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to create nested Dialog in ASP.NET MVC Dialog

A Dialog can be nested within another Dialog. The below sample contains parent and child Dialog (inner Dialog).

**Step 1**:

Create two div elements with id `#dialog` and `#innerDialog`.

**Step 2**:

Initialize the Dialog as mentioned in the below sample.

**Step 3**:

Set the inner Dialog target as `#dialog`.

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