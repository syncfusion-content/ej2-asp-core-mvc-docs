---
layout: post
title: How to add TextBox programmatically in ##Platform_Name## TextBox | Syncfusion
description: Add a Syncfusion ##Platform_Name## TextBox programmatically by importing the `Input` module from `ej2-inputs` and passing the HTML input element to `createInput`.
platform: ej2-asp-core-mvc
control: Add Textbox Programmatically
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add TextBox programmatically in ##Platform_Name## TextBox

* Create a TypeScript file and import the `Input` modules from `ej2-inputs` library as shown below.

```typescript
import {Input} from '@syncfusion/ej2-inputs';
```

* Pass the `HTML Input` element as parameter to the `createInput` method.

* You can also add the `icons` on the input by passing `buttons` property value with the class name `e-input-group-icon` as parameter to the `createInput` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/textbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Textbox.cs" %}
{% include code-snippet/textbox/how-to/textbox/textbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/textbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Textbox.cs" %}
{% include code-snippet/textbox/how-to/textbox/textbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

