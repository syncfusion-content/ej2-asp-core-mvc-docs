---
title: "Images and Divider"
component: "Card"
description: "This section explains how to create the Essential JS 2 Card component with different images, title, and divider."
---

# Images and Divider

## Images

The Card supports to include images within the elements, you can add image as direct element anywhere inside card root by adding the `e-card-image` class to `div` element. Using the class defined, you can write CSS styles to load images to that element.

> By default, card images occupies full width of its parent element.

```html
    <div class = "e-card">
        <div class="e-card-image">
        </div>
    </div>
```

### Title

Card image is supported to include a title or caption for the image. By default, Title is placed over the image on left-bottom position with overlay.

```html
    <div class = "e-card">
        <div class="e-card-image">
            <div class="e-card-title"></div>
        </div>
    </div>
```

{% aspTab template="card/card_img", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![CSS Card Control with images and divider](./images/card-image.PNG)

## Divider

Divider used to separate the elements inside the card. You can add divider inside the card elements to separate it.

* Place the `div` element with `e-card-separator` class inside the card element for adding a divider.

{% aspTab template="card/card_sep", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![CSS Card Control with images and divider](./images/card-divider.PNG)

## See Also

* [How to customize the card image title position](./how-to/customize-the-card-image-title-position)