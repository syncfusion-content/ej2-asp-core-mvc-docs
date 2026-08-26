---
layout: post
title: End-User Capabilities in ##Platform_Name## ImageEditor | Syncfusion
description: Explains the core interactive editing features Syncfusion ##Platform_Name## ImageEditor exposes for end users: crop, rotate, flip, zoom, and annotations.
platform: ej2-asp-core-mvc
control: ImageEditor
publishingplatform: ##Platform_Name##
documentation: ug
---

# End-user capabilities in ##Platform_Name## ImageEditor

The following operations are available to end users and are explained briefly in the sections below.

## Opening an image

To open an image in the Image Editor, follow these steps:

* Click the Open icon on the left side of the toolbar.

* The file explorer lists only JPEG, PNG, WEBP, and BMP formats.

* Select the image in the file explorer window to load it.

![Open icon highlighted on the toolbar with the file explorer overlay](images/open.gif)


## Zooming

Use any of the following methods to zoom an image in or out:

* Using the toolbar
* Using pinch zoom on touch-enabled devices
* Using the mouse wheel
* Using a keyboard shortcut

![Zoom toolbar with Zoom In and Zoom Out controls enabled](images/zoom.jpg)

### Using the toolbar

Click the Zoom In or Zoom Out button on the toolbar. The Zoom In / Zoom Out options are enabled only after an image is opened.

### Using pinch

To zoom in or out the image in the image editor, do the following steps. 

* Touch with two fingers to perform zooming. 

* Zoom in and out controlled by touch gestures. 

### Using mouse wheel 

To zoom in or out the image in the image editor, do the following steps. 

* Press the ctrl key and scroll the mouse wheel to perform zooming. 

* The zoom in and out controlled by the mouse wheel. 

### Using keyboard 

To zoom in or out the image in the image editor, do the following steps. 

* Press the ctrl key with ‘+’ button from the keyboard to zoom in an image. 

* Press the ctrl key with ‘-’ button from the keyboard to zoom out an image.

## Panning 

To pan an image in the image editor, do the following steps.  

* Click on the image and do dragging to move or pan the image. 

* Panning option will be enabled in the following two cases. 

    * If the selection is applied for cropping an image. 

    * If the image size exceeds the canvas size while zooming an image.

![Pan gesture shifting a zoomed image within the canvas](images/pan.gif)

## Cropping and image transformation

To crop an image in the image editor, do the following steps. 

* Cropping can be performed based on the selection in an image editor.

* To perform selection, click the crop button in the toolbar which opens the contextual toolbar that shows crop selection options, rotate options, flip options, and straightening options.

* Click the crop selection button and select the type of selection such as custom, circle, square, and ratio selection from the popup.

* Once selection is completed, do panning to move the image to get the cropped region.

![Crop selection drawn over a photo with the action toolbar above](images/crop.jpg){:width="600"}


## Annotations

To add annotations to the image, follow these steps:

* To add annotation, click the annotation button in the toolbar and select the type of annotations such as Line, Rectangle, Ellipse, Path, Arrow, Text, or Freehand drawing to be inserted to the image editor. 

* Once the annotation is added to the image, that can be repositioned by clicking and dragging the annotations using mouse as well as resized by clicking and resizing the selection circle to be placed around the annotations. 

* To rotate annotations, you can simply grab the circle located at the bottom of the annotation. The rotation can be applicable to all the annotations except text annotation. 

* Customize the annotations by changing their color, stroke width, font family, and font size through the contextual toolbar. The contextual toolbar will be enabled whenever the annotations are selected. 

* When annotations are selected in the Image Editor, the quick access toolbar becomes active, providing convenient access to various actions such as duplicating, deleting, or editing text associated with the selected annotation. This toolbar enables users to perform these common operations quickly and efficiently, streamlining their workflow and enhancing the overall editing experience.

![Image annotation](images/annotation.jpg)

## Filtering and fine-tune 

To perform fine-tuning on an image in the image editor, do the following steps. 

* Click the fine-tune button which displays the list of fine-tuning available in the image editor. 

* Click one of the fine-tune options from the list of options which shows a slider to adjust the corresponding filter.  

* Click on the canvas or tick icon at the right corner of the toolbar in the image editor to apply the modifications. 

![Filter and Finetune](images/finetune.jpg)

To apply filters on an image in the image editor, do the following steps. 

* Click the filter button which displays the list of filters available in the image editor. 

* Click the filter from list of options to apply the corresponding filter to an image.  

* Click on the canvas or tick icon at the right corner of the toolbar in the image editor to apply the modifications. 

![Filter and Finetune](images/filter.jpg)

## Undo and redo the operations 

To undo and redo the actions performed in an image editor, do the following steps. 

* The undo button will be enabled once the action is performed in an image editor. 

* The redo button will be enabled once the undo action is performed in an image editor. 

* Click the undo or redo button at the left side of the toolbar to perform undo and redo operation.

* Press <kbd>Ctrl + Z</kbd> to undo or <kbd>Ctrl + Y</kbd> to redo. On macOS use <kbd>⌘ + Z</kbd> and <kbd>⌘ + Shift + Z</kbd>.

![Undo and Redo](images/undo-redo.gif)

## Reset an image 

To revert all the changes done in an image editor, do the following steps. 

* Click the reset button which is located on the right side of the toolbar. 

* This will revert all the changes performed in the image editor.

## Exporting an image

To save the modifications, follow these steps:

* Click the Save Button
    * Locate the Save button on the right side of the toolbar and click it.

* Select the File Format
    * In the export popup, choose your preferred file format (PNG, JPEG, SVG, or WEBP) to save the image with all 
applied modifications.

* Adjust Image Quality (JPEG Format Only)
    * If saving in JPEG, use the Image Quality slider to set the desired quality level (0-100). A higher value retains more detail but increases file size.

* Download the Image
    * Click Download to save the modified image to your device.

* Use Keyboard Shortcut (Ctrl + S)
    * Press Ctrl + S to download the image in the same format as the loaded image without opening the Save dialog. For example, if the loaded image is PNG, it will be saved as PNG.

![Export an image](images/save.jpg)