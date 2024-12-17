---
layout: post
title: Selection and Cropping in ##Platform_Name## ImageEditor Control | Syncfusion
description: Learn here all about Selection and Cropping in Syncfusion ##Platform_Name## ImageEditor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection and Cropping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Selection cropping in the ##Platform_Name## Image Editor control

The cropping feature in the Image Editor allows you to select and crop specific regions of an image. It offers different selection options, including custom shapes, squares, circles, and various aspect ratios such as 2:3, 3:2, 3:4, 4:3, 4:5, 5:4, 5:7, 7:5, 9:16, and 16:9. 

To perform a selection, you can use the `select` method, which allows you to define the desired selection area within the image. Once the selection is made, you can then use the `crop` method to crop the image based on the selected region. This enables you to extract and focus on specific parts of the image while discarding the rest.

## Insert custom / square / circle region 

The `select` method allows to perform selection based on the type of selection. Here, the `select` method is used to perform the selection as custom, circle, or square. The selection region can also be customized using the select method based on the parameters below. 

* type - Specify the type of selection 

* startX - Specify the x-coordinate of the selection region’s starting point 

* startY - Specify the y-coordinate of the selection region’s starting point 

* width - Specify the width of the selection region 

* height - Specify the height of the selection region 

Here is an example of square selection using the `select` method. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/custom/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/custom/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-custom.jpg)

## Insert selection based on aspect ratio 

The `select` method is used to perform the selection with the various aspect ratios such as 2:3, 3:2, 3:4, 4:3, 4:5, 5:4, 5:7, 7:5, 9:16, and 16:9. The selection region can also be customized using the `select` method based on the parameters below. 

* type - Specify the type of selection 

* startX - Specify the x-coordinate of the selection region’s starting point 

* startY - Specify the y-coordinate of the selection region’s starting point 

Here is an example of ratio selection using the `select` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/ratio/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/ratio/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/ratio/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/ratio/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-ratio.jpg)

## Crop an image 

The `crop` method allows cropping based on the selected region. Here is an example of cropping the selection region using the `crop` method. 

Here is an example of circle cropping using the `select` and `crop` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/cropping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/cropping/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/cropping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/cropping/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-cropping.jpg)

## Cropping event 

The [`cropping`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ImageEditor.ImageEditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_Cropping) event is triggered when performing cropping on the image. This event is passed an object that contains information about the cropping event, such as the start and end point of the selection region. And this event uses `CropEventArgs` to handle the cropping action in the image.

The parameter available in the `cropping` event is, 

CroppingEventArgs.startPoint – The x and y coordinates of a start point as ImageEditorPoint of the selection region. 

CroppingEventArgs.endPoint - The x and y coordinates of an end point as ImageEditorPoint of the selection region. 

CroppingEventArgs.cancel - To cancel the cropping action.

## Maintaining original image size during cropping

In the image editor, when an image is cropped, it is usually enlarged or scaled to improve visibility within the user interface. If you want to prevent this scaling and maintain the original cropping size, you can bind to the ‘cropping’ event and set the preventScaling value to true. This not only keeps the image size consistent during cropping but also ensures that the saved image retains its original cropping size without being enlarged.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/maintain-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/maintain-size/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/maintain-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/maintain-size/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-cropping.jpg)

## Locking selection area during cropping

When selecting an area for cropping, users can typically resize the selection from all corners and edges. If you want to prevent the `resizing` of the selection area, you can bind to the resizing event and set cancel to true. This will lock the selection area, preventing any adjustments to its size.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/lock-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/lock-selection/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/lock-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/lock-selection/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-lock-selection.jpg)

## Cropping with custom ratio selection

Users can perform cropping either through the toolbar or by using our public methods. While predefined ratio selections are available in the toolbar, users can also crop with custom ratios using our public method, `select` Regardless of the ratio type used, the selection will adhere to the specified ratio, even when resizing the selection area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/custom-crop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/custom-crop/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/custom-crop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/custom-crop/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-custom-ratio.jpg)
