---
layout: post
title: Customize Expand Collapse Actions in ##Platform_Name## Accordion Component
description: Learn here all about Customize Expand Collapse Actions in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: Customize Expand Collapse Actions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize Accordion expand or collapse animation behavior

Accordion component supports customizing the expand or collapse animation action behavior. You can manually change the expand animation action performed after the collapse animation operation performed on already expand pane when the expand icons are clicked.

By default, the Accordion component pane is expanded or collapsed, when click the expand or collapse icon. It is not affected on already expand pane.

The following sample demonstrates, how to expand the collapsed Accordion item after collapse animation performed on the expanded Accordion item using `created`, `expanding`, and `expanded` event. In the Expanding event, get the previously expanded item index and prevent the expanding behavior using `args.cancel` option. Expand the Accordion item dynamically based on specifying the `index` value using the `expandItem` public method and `expanded` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/actions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Actions.cs" %}
{% include code-snippet/accordion/how-to/actions/actions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/actions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Actions.cs" %}
{% include code-snippet/accordion/how-to/actions/actions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Customize Accordion expand or collapse animation behavior](../images/actions.PNG)