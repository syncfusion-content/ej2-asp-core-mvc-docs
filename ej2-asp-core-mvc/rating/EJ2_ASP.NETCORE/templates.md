---
layout: post
title: Templates in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Templates in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in ASP.NET Core Rating Control

The ASP.NET Core Rating control allows you to customize the appearance of the rating items using templates. You can use templates to specify a custom layout for the rating items, which can include any content you want. This allows you to create a more customized and interactive rating experience for the user.

The rating control supports below templates for item customization.

* [emptyTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_EmptyTemplate)
* [fullTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_FullTemplate)

## Empty (unrated) symbol template

To customize the appearance of **unrated** items, you can use the `emptyTemplate` tag directive. It allows you to specify the desired custom content for the unrated items.
The `value` and `index` are available in the template context for accessing information about the un-rated item.
If the `fullTemplate` is not defined, the `emptyTemplate` will be used as the default for both rated and unrated items. You can apply custom styles to differentiate between the rated and unrated states of the items.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/empty-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with EmptyTemplate](./images/rating-empty-template.png)

N> The current value of the rating item available in the template context as `value` and in the rating item element as CSS Variable (`--rating-value`) can be used to support precision in templates.

## Full (rated) symbol template

To customize the appearance of **rated** items in the Syncfusion ASP.NET Core rating control, you can use the `fullTemplate` tag directive. This directive allows you to specify a custom layout for the rated items, which can include any content you desire.
The `value` and `index` are available in the template context for accessing information about the rated item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/full-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with FullTemplate](./images/rating-full-template.png)

## Using Emoji icon as rating symbol

You can use emojis of your choice as rating symbol by specifying them as template content within the `emptyTemplate` tag directive.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/emoji-icon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with Emoji Icon](./images/rating-emoji-icon.png)

## Using SVG icon as rating symbol

You can use SVG icons of your choice as rating symbol by specifying them as template content within the `emptyTemplate` and `fullTemplate` tag directives.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/svg-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with SVG Icon](./images/rating-svg-icon.png)

## Using PNG image as rating symbol

You can use PNG images of your choice as rating symbol by specifying them as template content within the `emptyTemplate` and `fullTemplate` tag directives.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/templates/png-image/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with PNG Icon](./images/rating-png.png)