---
title: "Breadcrumb Templates"
component: "Breadcrumb"
description: "Breadcrumb section explain how to customize the item template and separator template to the breadcrumb items."
---

# Templates in Breadcrumb

The Breadcrumb component provides a way to customize the items using `itemTemplate` and the separators using `separatorTemplate` properties.

## Item Template

In the following example, Shopping Cart details are used as breadcrumb Items and the items are customized by the chips component using `itemTemplate`.

{% aspTab template="breadcrumb/item-template", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/item-template.PNG)

## Separator Template

In the  following example, the separators are customized with icons using `separatorTemplate`.

{% aspTab template="breadcrumb/separator-template", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/separator-template.PNG)