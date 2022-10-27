---
layout: post
title: Localization in ##Platform_Name## ImageEditor Control | Syncfusion
description: Learn here all about Localization in Syncfusion ##Platform_Name## ImageEditor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization

The `Localization` library allows you to localize the default text content of the Image Editor. The Image Editor has static text that can be changed to other cultures (Arabic, Deutsch, French, etc.) by defining the `locale` value and translation object.

The following list of properties and its values are used in the Image  Editor.

| Locale key words | Text |
| ------------ | ----------------------- |
| Browse  | Browse |
| Crop  | Crop |
| ZoomIn | Zoom In |
| ZoomOut | Zoom Out |
| Transform | Transform |
| Annotation | Annotation |
| Text | Add Text |
| Pen | Pen |
| Reset | Reset |
| Save | Save |
| Select | Select |
| RotateLeft | Rotate Left |
| RotateRight | Rotate Right |
| HorizontalFlip | Horizontal Flip |
| VerticalFlip | Vertical Flip |
| OK | OK |
| Cancel | Cancel |
| FillColor | Fill Color |
| StrokeColor | Stroke Color |
| StrokeWidth | StrokeWidth |
| FontFamily | Font Family |
| FontStyle | Font Style |
| FontSize | Font Size |
| FontColor | Font Color |
| Pan | Pan |
| Move | Move |
| Custom | Custom |
| Square | Square |
| Circle | Circle |
| Rectangle | Rectangle |
| Line | Line |
| Default | Default |
| Bold | Bold |
| Italic | Italic |
| BoldItalic | Bold Italic |
| XSmall | X-Small |
| Small | Small |
| Medium | Medium |
| Large | Large |
| XLarge | X-Large |
| ABC | ABC |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/localization/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/localization/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
