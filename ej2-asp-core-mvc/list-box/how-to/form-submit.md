---
layout: post
title: Form Submit in ##Platform_Name## List Box Component
description: Learn here all about Form Submit in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Form Submit
publishingplatform: ##Platform_Name##
documentation: ug
---


# Form submit to the list box

In the following code snippet, the value that is in selected state will be sent on form submit.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/form-submit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formsubmit.cs" %}
{% include code-snippet/listbox/form-submit/formsubmit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/form-submit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formsubmit.cs" %}
{% include code-snippet/listbox/form-submit/formsubmit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

