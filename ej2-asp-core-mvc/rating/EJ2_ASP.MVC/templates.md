---
layout: post
title: Templates in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Templates in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in Asp.Net MVC Rating Control

The Asp.Net MVC Rating component allows you to customize the appearance of the rating items using templates. You can use templates to specify a custom layout for the rating items, which can include any content you want. This allows you to create a more customized and interactive rating experience for the user.

The rating component supports below templates for item customization.

* [EmptyTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_EmptyTemplate)
* [FullTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_FullTemplate)

## Empty (unrated) symbol template

To customize the appearance of **unrated** items, you can use the `EmptyTemplate` tag directive. It allows you to specify the desired custom content for the unrated items.
The `value` and `index` are available in the template context for accessing information about the un-rated item.
If the `FullTemplate` is not defined, the `EmptyTemplate` will be used as the default for both rated and unrated items. You can apply custom styles to differentiate between the rated and unrated states of the items.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/empty-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EmptyTemplate.cs" %}
{% include code-snippet/rating/templates/empty-template/emptytemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with EmptyTemplate](./images/rating-empty-template.png)

N> The current value of the rating item available in the template context as `value` and in the rating item element as CSS Variable (`--rating-value`) can be used to support precision in templates.

## Full (rated) symbol template

To customize the appearance of **rated** items in the Syncfusion Asp.Net MVC rating component, you can use the `FullTemplate` tag directive. This directive allows you to specify a custom layout for the rated items, which can include any content you desire.
The `value` and `index` are available in the template context for accessing information about the rated item.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/full-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FullTemplate.cs" %}
{% include code-snippet/rating/templates/full-template/fulltemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with FullTemplate](./images/rating-full-template.png)

## Using Emoji icon as rating symbol

You can use emojis of your choice as rating symbol by specifying them as template content within the `EmptyTemplate` tag directive.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/emoji-icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EmojiIcon.cs" %}
{% include code-snippet/rating/templates/emoji-icon/emoji_icon.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Emoji Icon](./images/rating-emoji-icon.png)

## Using SVG icon as rating symbol

You can use SVG icons of your choice as rating symbol by specifying them as template content within the `EmptyTemplate` and `FullTemplate` tag directives.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/svg-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SVGTemplate.cs" %}
{% include code-snippet/rating/templates/svg-template/svgtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with SVG Icon](./images/rating-svg-icon.png)

## Using PNG image as rating symbol

You can use PNG images of your choice as rating symbol by specifying them as template content within the `EmptyTemplate` and `FullTemplate` tag directives.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/png-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PNGTemplate.cs" %}
{% include code-snippet/rating/templates/png-template/pngtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with PNG Icon](./images/rating-png.png)