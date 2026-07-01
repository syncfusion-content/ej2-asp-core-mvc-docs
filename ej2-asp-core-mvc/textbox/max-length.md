---
layout: post
title: Maximum Length with ##Platform_Name## TextBox control | Syncfusion
description: Limiting the maximum number of characters in the ##Platform_Name## TextBox control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Maximum Length
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Maximum Length in ##Platform_Name## TextBox Control

You can enforce a maximum length limit for the text input in the TextBox using the `MaxLength` property. This property allows to define the maximum number of characters that users can input into the TextBox.


* By setting the `MaxLength` property, you can control the length of text input, preventing users from exceeding a specified character limit.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/maxLength/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MaxLength.cs" %}
{% include code-snippet/textbox/maxLength/maxLength.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/maxLength/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MaxLength.cs" %}
{% include code-snippet/textbox/maxLength/maxLength.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![textbox](./images/textbox-maxLength.jpg)

When the user reaches the specified limit, the TextBox prevents further input, ensuring compliance with the defined character limit. This feature helps maintain data integrity and provides users with clear feedback on the allowed input length.
