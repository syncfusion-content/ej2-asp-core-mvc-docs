---
layout: post
title: Filter in ##Platform_Name## Image editor control | Syncfusion
description: Learn here all about Filter in Syncfusion ##Platform_Name## Image editor control of Syncfusion Essential JS 2 and more.
platform: ej2-react
control: Filter 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Filter in React Image editor control

Filters are pre-defined effects that can be applied to an image to alter its appearance or mood. Image filters can be used to add visual interest or to enhance certain features of the image. Some common types of image filters include cold, warm, chrome, sepia, and invert. This can be done by either using the toolbar or the [`applyImageFilter`] method which takes a single parameter: the filter applied to an image.

## Apply filter effect 

The [`applyImageFilter`] method is used to perform filtering by specifying the type of filter as ImageFilterOption and send it a first parameter of the method. 

Here is an example of filtering using the [`applyImageFilter`] method.


### Image filtering event 

The [`imageFiltering`] event is triggered when applying filtering on the image. This event is passed an object that contains information about the filtering event, such as the type of filtering. 

The parameter available in the [`ImageFilterEventArgs`](https://helpej2.syncfusion.com/react/documentation/api/image-editor/imageFilterEventArgs/) event is, 

ImageFilterEventArgs.filter - The type of filtering as ImageFilterOption to be applied in the image editor. 

ImageFilterEventArgs.cancel – Specifies to cancel the filtering action. 