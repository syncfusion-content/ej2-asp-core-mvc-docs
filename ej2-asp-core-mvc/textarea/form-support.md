---
layout: post
title: Form Support in ##Platform_Name## TextArea | Syncfusion
description: Integrate the Syncfusion ##Platform_Name## TextArea with HTML forms to enable efficient submission of multiline text content as part of form data.
platform: ej2-asp-core-mvc
control: Form Support
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Form Support in ##Platform_Name## TextArea

The TextArea control seamlessly integrates with HTML forms, enabling efficient submission of longer text data. By including TextArea inputs within HTML forms, users can conveniently input multiline text content and submit it as part of form submissions.

This integration enhances the usability of forms, allowing users to provide detailed feedback, enter lengthy descriptions, or input other multiline text data seamlessly.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/form-support/form/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/form-support/form/form.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/form-support/form/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/form-support/form/form.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![textarea](./images/textarea-form.png)

## Integration of ##Platform_Name## TextArea control with FormValidator component

TextArea control seamlessly integrates with the `FormValidator` component, allowing users to incorporate textarea inputs into form validation processes efficiently.

By integrating TextArea controls with the `FormValidator` component, users can enforce validation rules specific to text inputs, such as required fields, minimum and maximum length constraints, pattern matching, and more. This ensures that user-submitted text data meets specified criteria and maintains data integrity.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/form-support/form-validator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/form-support/form-validator/form-validator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/form-support/form-validator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/form-support/form-validator/form-validator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
