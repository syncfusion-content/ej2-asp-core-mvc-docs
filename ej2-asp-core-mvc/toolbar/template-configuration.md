---
layout: post
title: Template Configuration in ##Platform_Name## Toolbar Component
description: Learn here all about Template Configuration in Syncfusion ##Platform_Name## Toolbar component and more.
platform: ej2-asp-core-mvc
control: Template Configuration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Template Configuration

The Toolbar can be rendered by item based collection and by HTML elements.  To render it based on the given HTML element, use `id` as the `target` property. To render the Toolbar, follow the below structure of the HTML elements:

```html
  <div id='template_toolbar'>   --> Root Toolbar Element
    <div>      --> Toolbar Items Container
       <div>   --> Toolbar Item Element
       </div>
    </div>
  </div>
```

Here, the template ID, `#template_toolbar` is directly appended to the Toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/template-configuration/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/toolbar/template-configuration/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/template-configuration/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/toolbar/template-configuration/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Popup customization

`Popup` is one of the supported responsive modes of the Toolbar. The Toolbar commands, popup mode priority and button text mode customizations are
achieved in the item based rendering through property declaration. For more information on popup mode, refer [here](./responsive-mode/)

The above behavior can also be achieved with template rendering by defining `equivalent class` names instead of property declaration.

Equivalent class names listed below are needed to add the Toolbar items' `div` element.

### Priority

Class              | Description
------------       | -------------
  e-overflow-show  | Commands are always displayed on the `Toolbar with primary` priority.
  e-overflow-hide  | Commands are always displayed in the `popup with secondary` priority.

### Button text mode

  Class         | Description
------------       | -------------
  e-popup-text     | Button text is only  visible in the `Popup`.
  e-toolbar-text   | Button text is only visible on the `Toolbar`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/template-configuration/buttontext/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Buttontext.cs" %}
{% include code-snippet/toolbar/template-configuration/buttontext/buttontext.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/template-configuration/buttontext/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Buttontext.cs" %}
{% include code-snippet/toolbar/template-configuration/buttontext/buttontext.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

