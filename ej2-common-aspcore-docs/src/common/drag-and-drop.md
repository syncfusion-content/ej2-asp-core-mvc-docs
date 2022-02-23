# Drag and Drop

Drag and Drop is supported through two libraries of Essential JS 2. Those are [`Draggable`](https://ej2.syncfusion.com/documentation/api/base/draggable/) and [`Droppable`](https://ej2.syncfusion.com/documentation/api/base/droppable/). Draggable makes DOM to be dragged using mouse or touch gestures and Droppable mark required DOM as droppable zone.

## Initializing Draggable

You can make any element draggable by passing the element to Draggable constructor. Refer the following code snippet to enable draggable for DOM element.

 ```typescript
 import {Draggable} from  '@syncfusion/ej2-base';

 let dragElement: HTMLElement = document.getElementById('element1');
 let draggable:Draggable = new Draggable(dragElement,{clone: false});
 ```

## Creating Droppable zone

You can convert any DOM element as a droppable zone, which accepts the draggable elements. Refer the following code snippet to enable droppable zone.

 ```typescript
 import { Droppable} from  '@syncfusion/ej2-base';

 let droppable: Droppable = new Droppable(document.getElementById('droppable'));
 ```

## Defining Drop Action

To define drop action set [`drop`](https://ej2.syncfusion.com/documentation/api/base/droppable/#drop) callback function during droppable object creation. You can get details of dropped element through dropped element property in event argument. Refer the following code snippet to use basic drag and drop action.

 ```typescript
 import { Draggable, Droppable, DropEventArgs } from '@syncfusion/ej2-base';

let draggable: Draggable = new Draggable(document.getElementById('element1'), {
    clone: false
});
let droppable: Droppable = new Droppable(document.getElementById('droppable'), {
    drop: (e: DropEventArgs) => {
        e.droppedElement.querySelector('.drag-text').textContent = 'Dropped';
    }
});
 ```

## See Also

[`Define handle element for Draggable`](https://ej2.syncfusion.com/documentation/api/base/draggable/#handle)<br/>
[`Restricting Draggable within conainer`](https://ej2.syncfusion.com/documentation/api/base/draggable/#dragarea)<br>
[`Visual feedback of draggable element`](https://ej2.syncfusion.com/documentation/api/base/draggable/#clone)<br>
[`Accepting specific drag element in droppable`](https://ej2.syncfusion.com/documentation/api/base/droppable/#accept)