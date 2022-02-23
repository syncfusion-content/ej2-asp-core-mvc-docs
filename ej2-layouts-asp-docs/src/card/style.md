---
title: "Style"
component: "Card"
description: Checkout and learn here all about Style and Appearance in Essential JS 2 Card component and more.
---

# Style and Appearance of Card Component

The following content provides the exact CSS structure that can be used to modify the control’s appearance based on user preference.

## Customizing the card

Use the following CSS to customize the card properties.

```css
.e-card {
    background-color: aqua;
    padding-left: 20px;
    margin-bottom: 20px;
}
```

## Customizing the Header element

Use the following CSS to customize the Header element properties.

```css
.e-card .e-card-header {
    font-family: cursive;
    font-style: italic;
}
```

## Customizing the card content

Use the following CSS to customize the card content properties.

```css
.e-card .e-card-content {
    font-size: 20px;
    color: gray;
    line-height: initial;
    font-weight: normal;
}
```

## Divider used to separate the elements inside the card

Use the following CSS to customize the Divider used to separate the elements inside the card properties.

```css
.e-card .e-card-separator {
   padding-bottom: 30px;
}
```

## Including image within card element

Use the following CSS to Include image within card element.

```css
.e-card .e-card-image {
    background-image: url(images.png);
    background-color: yellow;
    height: 160px;
}
```

## Including a title or caption for the image

Use the following CSS to Include a title or caption for the image.

```css
.e-card .e-card-image .e-card-title {
    font-family: cursive;
    font-style: italic;
}
```

## To include heading image within the header

Use the following CSS to Include heading image within the header.

```css
.e-card .e-card-header .e-card-header-image  {
    height: 48px;
    width: 48px;
}
```

## Customizing the Header main title

Use the following CSS to Customize the Header main title.

```css
.e-card .e-card-header .e-card-header-caption .e-card-header-title  {
    font-size: large;
    color: aquamarine;
}
```

## Customizing the Header subtitle

Use the following CSS to Customize the Header subtitle.

```css
.e-card .e-card-header .e-card-header-caption .e-card-sub-title  {
    font-size: 20px;
    font-variant: all-petite-caps;
}
```

## Including action buttons or anchor tags

Use the following CSS to Include action buttons or anchor tags.

```css
.e-card .e-card-actions .e-card-btn  {
    padding-left: 20px;
    background-color: wheat;
}
```

## To align card elements horizontally

Use the following CSS to align card elements horizontally.

```css
.e-card .e-card-horizontal  {
    margin: auto;
    width: inherit;
}
```

## To align elements vertically within the horizontal layout

Use the following CSS to align elements vertically within the horizontal layout.

```css
.e-card .e-card-horizontal .e-card-stacked  {
    justify-content: flex-start;
    margin: initial;
}
```