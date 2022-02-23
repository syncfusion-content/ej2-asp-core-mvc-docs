---
title: "Title and Subtitle"
component: "Smith Chart"
description: "Title and subtitle support in smith chart"
---

# Title and Subtitle

## Enable title

Title and subtitle is used to depicts the information about the data plotted in the smithchart. You can set the title and subtitle of the smithchart using the [`text`] property in title and subtitle. By default visibility of the title as well as subtitle is enabled. You need to set simply text for title and subtitle in your sample as like below.

{% aspTab template="smithchart/title/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Title trim

Both title and subtitle of the smithchart can be trimmed if it exceeds the certain length. Trimming is enabled using [`enableTrim`] for title as well as subtitle. This length can be changed using the property [`maximumWidth`]. Also [`font`], [`textAlignment`] and [`visibility`] can be customized for title as well as subtitle.

{% aspTab template="smithchart/title/title-trim", sourceFiles="title-trim.cs" %}

{% endaspTab %}