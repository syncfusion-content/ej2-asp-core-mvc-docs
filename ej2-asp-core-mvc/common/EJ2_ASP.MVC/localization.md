---
layout: post
title: Localization in ##Platform_Name## Common Component
description: Learn here all about Localization in Syncfusion ##Platform_Name## Common component and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Localization

Localization library allows you to localize the text content of the Essential JS 2 component.

## Loading translations

To load translation object in your application use `load` function of `L10n` class.

```html
<script>
    ej.base.L10n.load({
        'fr-BE': {
            'Button': {
                'id': 'Numéro de commande',
                'date':'Date de commande'
            }
        }
    });
</script>
```

## Changing current locale

Current locale can be changed for all the Essential JS 2 components in your application by invoking
 `setCulture` function with your desired culture name.

```html
<script>
    ej.base.L10n.load({
        'fr-BE': {
            'Button': {
                'id': 'Numéro de commande',
                'date':'Date de commande'
            }
        }
    });
    ej.base.setCulture('fr-BE');
</script>
```

> Before changing a culture globally, ensure that locale text for the concerned culture is loaded through `L10n.load` function.
