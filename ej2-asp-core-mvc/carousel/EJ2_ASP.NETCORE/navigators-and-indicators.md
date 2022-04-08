---
layout: post
title: Navigations and Indicators in ##Platform_Name## Carousel Control
description: Checkout and learn about Navigations and Indicators in ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Navigations and Indicators
publishingplatform: ##Platform_Name##
documentation: ug
---

# Navigators and Indicators

The navigators and indicators are used to transition the slides manually.

## Navigators

### Show or hide previous and next button

In navigators, the previous and next slide transition buttons are used to perform slide transitions manually. We had provided options to show/hide the navigators using the `buttonsVisibility` property. The possible property values are as follows:

    1. Hidden – the navigator’s buttons are not visible.
    2. Visible – the navigator’s buttons are visible.
    3. VisibleOnHover – the navigator’s buttons are visible only when hovering over the carousel.

The following example depicts the code to show/hide the navigators in the carousel.

{% tab template= "carousel/default", sourceFiles="app.ts,index.html,styles.css",
 es5Template="button-visibility-template", isDefaultActive=true %}

```typescript
import { Carousel } from '@syncfusion/ej2-navigations';

const carouselObj: Carousel = new Carousel({
    items: [
        { template: '<div class="fs-5">Slide 1</div>' },
        { template: '<div class="fs-5">Slide 2</div>' },
        { template: '<div class="fs-5">Slide 3</div>' },
        { template: '<div class="fs-5">Slide 4</div>' },
        { template: '<div class="fs-5">Slide 5</div>' }
    ],
    buttonsVisibility: 'Visible'
});
carouselObj.appendTo('#carousel');
```

{% endtab %}

### Show previous and next button on hover

In the carousel, we can able to show the previous and next buttons only on mouse hover using the `buttonsVisibility` property. The following example depicts the code to show the navigators on mouse hover in the carousel.

{% tab template= "carousel/default", sourceFiles="app.ts,index.html,styles.css", es5Template="hover-template", isDefaultActive=true %}

```typescript
import { Carousel } from '@syncfusion/ej2-navigations';

const carouselObj: Carousel = new Carousel({
    items: [
        { template: '<div class="fs-5">Slide 1</div>' },
        { template: '<div class="fs-5">Slide 2</div>' },
        { template: '<div class="fs-5">Slide 3</div>' },
        { template: '<div class="fs-5">Slide 4</div>' },
        { template: '<div class="fs-5">Slide 5</div>' }
    ],
    buttonsVisibility: 'VisibleOnHover'
});
carouselObj.appendTo('#carousel');
```

{% endtab %}

### Previous and next button Template

We had provided template options to customize the previous button using `previousButtonTemplate` and the next button using `nextButtonTemplate`. The following example depicts the code for applying the template to previous and next buttons in the carousel.

{% tab template= "carousel/default", sourceFiles="app.ts,index.html,styles.css", es5Template="navigator-template", isDefaultActive=true %}

```typescript
import { Carousel } from '@syncfusion/ej2-navigations';
import { Button } from '@syncfusion/ej2-buttons';

const carouselObj: Carousel = new Carousel({
    items: [
        { template: '<div class="fs-5">Slide 1</div>' },
        { template: '<div class="fs-5">Slide 2</div>' },
        { template: '<div class="fs-5">Slide 3</div>' },
        { template: '<div class="fs-5">Slide 4</div>' },
        { template: '<div class="fs-5">Slide 5</div>' }
    ],
    previousButtonTemplate: '<button id="previous"></button>',
    nextButtonTemplate: '<button id="next"></button>',
});
carouselObj.appendTo('#carousel');

const prevBtn: Button = new Button({ cssClass: 'e-flat e-round', iconCss: 'e-icons e-chevron-left-double' });
prevBtn.appendTo('#previous');

const nextBtn: Button = new Button({ cssClass: 'e-flat e-round', iconCss: 'e-icons e-chevron-right-double' });
nextBtn.appendTo('#next');
```

{% endtab %}

## Indicators

### Show or hide indicators

In indicators, the total slides and current slide state has been depicted. We had provided options to show/hide the indicators using the `showIndicators` property. The following example depicts the code to show/hide the indicators in the carousel.

{% tab template= "carousel/default", sourceFiles="app.ts,index.html,styles.css", es5Template="indicator-template", isDefaultActive=true %}

```typescript
import { Carousel } from '@syncfusion/ej2-navigations';

const carouselObj: Carousel = new Carousel({
    items: [
        { template: '<div class="fs-5">Slide 1</div>' },
        { template: '<div class="fs-5">Slide 2</div>' },
        { template: '<div class="fs-5">Slide 3</div>' },
        { template: '<div class="fs-5">Slide 4</div>' },
        { template: '<div class="fs-5">Slide 5</div>' }
    ],
    showIndicators: true
});
carouselObj.appendTo('#carousel');
```

{% endtab %}

### Indicators Template

We had provided template options to customize the indicators by using the `indicatorTemplate` property. The following example depicts the code for applying a template to indicators in the carousel.

{% tab template= "carousel/indicator", sourceFiles="app.ts,index.html,styles.css", es5Template="indicator-template", isDefaultActive=true %}

```typescript
import { Carousel } from '@syncfusion/ej2-navigations';

const carouselObj: Carousel = new Carousel({
    items: [
        { template: '<div class="fs-5">Slide 1</div>' },
        { template: '<div class="fs-5">Slide 2</div>' },
        { template: '<div class="fs-5">Slide 3</div>' },
        { template: '<div class="fs-5">Slide 4</div>' },
        { template: '<div class="fs-5">Slide 5</div>' }
    ],
    indicatorsTemplate: '#indicatorTemplate'
});
carouselObj.appendTo('#carousel');
```

{% endtab %}

### Showing preview of slide in indicator

We can able to customize the indicators by showing the preview image of each slide using the `indicatorTemplate` property. The following example depicts the code for showing the preview image using a template for indicators in the carousel.

{% tab template= "carousel/indicator-preview", sourceFiles="app.ts,index.html,styles.css", es5Template="indicator-template", isDefaultActive=true %}

```typescript
import { Carousel } from '@syncfusion/ej2-navigations';

(window as TemplateFunction).getContent = (index: number) => {
    const slides: string[] = ['Slide 1', 'Slide 2', 'Slide 3', 'Slide 4', 'Slide 5'];
    return slides[index];
};
interface TemplateFunction extends Window {
    getContent?: Function;
}

const carouselObj: Carousel = new Carousel({
    items: [
        { template: '<div class="fs-5">Slide 1</div>' },
        { template: '<div class="fs-5">Slide 2</div>' },
        { template: '<div class="fs-5">Slide 3</div>' },
        { template: '<div class="fs-5">Slide 4</div>' },
        { template: '<div class="fs-5">Slide 5</div>' }
    ],
    indicatorsTemplate: '#indicatorTemplate'
});
carouselObj.appendTo('#carousel');
```

{% endtab %}

## Play button

### Show or hide the play button

In the carousel, `autoplay` actions have been controlled by using the `showPlayButton` property in the user interface. When we enable this property, the slide transitions have been controlled using this play and pause button. This property depends on the `buttonVisibility` property. The following example depicts the code to show the play button in the carousel.

{% tab template= "carousel/default", sourceFiles="app.ts,index.html,styles.css", es5Template="play-template", isDefaultActive=true %}

```typescript
import { Carousel } from '@syncfusion/ej2-navigations';

const carouselObj: Carousel = new Carousel({
    items: [
        { template: '<div class="fs-5">Slide 1</div>' },
        { template: '<div class="fs-5">Slide 2</div>' },
        { template: '<div class="fs-5">Slide 3</div>' },
        { template: '<div class="fs-5">Slide 4</div>' },
        { template: '<div class="fs-5">Slide 5</div>' }
    ],
    showPlayButton: true
});
carouselObj.appendTo('#carousel');
```

{% endtab %}

### Play button template

We had provided template options to customize the play button by using the `playButtonTemplate` property. The following example depicts the code for applying a template to play Button in the carousel.

{% tab template= "carousel/play-button", sourceFiles="app.ts,index.html,styles.css", es5Template="play-button-template", isDefaultActive=true %}

```typescript
import { Carousel } from '@syncfusion/ej2-navigations';
import { Button } from '@syncfusion/ej2-buttons';

const carouselObj: Carousel = new Carousel({
    items: [
        { template: '<div class="fs-5">Slide 1</div>' },
        { template: '<div class="fs-5">Slide 2</div>' },
        { template: '<div class="fs-5">Slide 3</div>' },
        { template: '<div class="fs-5">Slide 4</div>' },
        { template: '<div class="fs-5">Slide 5</div>' }
    ],
    showPlayButton: true,
    playButtonTemplate: '<div id="play"></div>'
});
carouselObj.appendTo('#carousel');

const button: Button = new Button({ cssClass: 'e-info', content: "Pause" });
button.appendTo('#play');
button.element.onclick = (): void => {
    if (carouselObj.autoPlay) {
        button.content = "Play";
        carouselObj.autoPlay = false;
    } else {
        button.content = "Pause";
        carouselObj.autoPlay = true;
    }
};
```

{% endtab %}
