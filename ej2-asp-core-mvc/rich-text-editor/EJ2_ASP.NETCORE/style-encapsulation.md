---
layout: post
title: Style Encapsulation in ##Platform_Name## Rich Text Editor Component | Syncfusion
description: Learn here all about Style Encapsulation in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Style Encapsulation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style Encapsulation in ##Platform_Name## Rich Text Editor Control

Style encapsulation determines how styles are applied within the Syncfusion ASP.NET Core **Rich Text Editor**. This feature helps control whether the component's content inherits global styles from the application or remains isolated. 

## Encapsulation modes

The Rich Text Editor offers two rendering modes for controlling style encapsulation:

1. **Encapsulated Mode (Iframe Mode)**  
   - When enabled, the Rich Text Editor is rendered inside an `<iframe>`.  
   - The application's global CSS rules will **not** affect the content inside the editor.  
   - This ensures that the editor's content remains styled independently.  
   - **Usage:** `<e-richtexteditor-iframesettings enable="true" />`

2. **Non-Encapsulated Mode (Default)**  
   - The Rich Text Editor is rendered **without an `<iframe>`**.  
   - The application's global CSS **will apply** to the content inside the editor.  
   - This mode allows seamless integration with existing styles.  
   - **Usage:** `<e-richtexteditor-iframesettings enable="false" />`

### Default behavior

By default, the Rich Text Editor uses **non-encapsulated mode** (`<e-richtexteditor-iframesettings enable="false" />`), allowing the application's styles to affect the editor's content.

Below is a sample implementation of both **encapsulated** and **non-encapsulated** modes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/style-encapsulation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/style-encapsulation/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/style-encapsulation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/style-encapsulation/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}