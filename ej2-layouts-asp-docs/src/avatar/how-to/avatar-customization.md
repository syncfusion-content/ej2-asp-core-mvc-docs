# Avatar Customization

## Colour customization

The avatar comes with default background colour (grey). This can be easily customized to desired colour by adding
custom class or directly selecting the avatar class from the CSS.

{% aspTab template="avatar/color", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Avatar Color](../images/color.PNG)

## Customize avatar sizes

Even though the avatar comes with five predefined sizes, sometimes it's not enough. So, the avatar is designed in such
a way that the width and height will be relative to font-size. By changing the `font-size` of the avatar element, you can
change the width and height automatically.

{% aspTab template="avatar/custom-size", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Avatar Size](../images/customization.PNG)

## Use various media in avatar

Avatars can be used with a wide variety of media formats like SVG, font-icons, images, letters, words, etc. Some of them are given below.

{% aspTab template="avatar/media-formats", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Media Format](../images/media.PNG)
