---
layout: post
title: Customize Expand Collapse Actions in ##Platform_Name## Accordion Component
description: Learn here all about how to customize expand collapse actions in Syncfusion ##Platform_Name## Accordion component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize Expand Collapse Actions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize Accordion expand or collapse animation behavior

Accordion component supports customizing the expand or collapse animation action behavior. You can manually adjust the expand animation action that occurs after the collapse animation operation is performed on the already expanded pane, When the expand icons are clicked.

By default, the Accordion component pane is expanded or collapsed, while clicking the expand or collapse icon. It is not affected on already expanded pane.

The following sample demonstrates, how to expand the collapsed Accordion item after collapse animation is performed on the expanded Accordion item using `created`, `expanding`, and `expanded` event. In the Expanding event, get the previously expanded item index and prevent the expanding behavior using `args.cancel` option. Expand the Accordion item dynamically based on the specified `index` value using the `expandItem` public method and `expanded` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/actions/tagHelper %}
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


![Customize Accordion expand or collapse animation behavior](../images/actions.PNG)