---
layout: post
title: Types in ##Platform_Name## Avatar Control | Syncfusion
description: Learn here all about Types in Syncfusion ##Platform_Name## Avatar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Types
publishingplatform: ##Platform_Name##
documentation: ug
---


# Types and Styles in ##Platform_Name## Avatar Control

This section explains different types of Avatar.

## Avatar size

The Essential<sup style="font-size:70%">&reg;</sup> JS 2 Avatar has the following predefined sizes that can be used with the `.e-avatar` class to change the appearance of the Avatar.

| Class Name | Description |
| ------------- | ------------- |
| e-avatar-xlarge    | Displays xlarge size Avatar. |
| e-avatar-large     | Displays apply large size Avatar. |
| e-avatar           | Displays apply default size Avatar. |
| e-avatar-small     | Displays apply small size Avatar. |
| e-avatar-xsmall    | Displays apply xsmall size Avatar. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/size/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/size/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Avatar Size](./images/size.png)

## Avatar types

The types of Essential<sup style="font-size:70%">&reg;</sup> JS 2 Avatar are:

* Default
* Circle

### Default

The default style of the Avatar is rectangular shape with rounded corners, which can be applied from adding the modifier class `.e-avatar` to the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/default/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/default/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Avatar Default](./images/types.PNG)

### Circle

The circle Avatar style can be applied by adding the modifier class `.e-avatar-circle` to the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/circle/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/circle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/circle/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Avatar Circle](./images/circle.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Avatar/AvatarUGSample).