# Annotations

<!-- markdownlint-disable MD013 -->

Annotations are used to mark the specific area of interest in the gauge area with texts, shapes or images. You can add any number of annotations to the gauge.

## Annotation

By using the [`content`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~Content.html) property of [`annotation`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation.html) object, you can either specify the id of the element or specify the code to create a new element, that needs to be displayed in the gauge area.

<!-- markdownlint-disable MD036 -->

{% aspTab template="lineargauge/annotations/annotations", sourceFiles="annotations.cs" %}

{% endaspTab %}

## Annotation Customization

You can customize the annotation using following properties.

* [`zIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~ZIndex.html) - When annotation overlaps with another element, you can use this property to bring annotation to the front or back.
* [`horizontalAlignment`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~HorizontalAlignment.html) - To move annotation horizontally. Possible values are "Center", "Far", "Near", "None"
* [`verticalAlignment`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~VerticalAlignment.html) - To move annotation vertically. Possible values are "Center", "Far", "Near", "None"
* [`x`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~X.html) and [`y`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~Y.html) - To move annotation to the specified location.

**Changing the z-order**

You can change the z-order of the annotation element by using the [`zIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~ZIndex.html) property.

{% aspTab template="lineargauge/annotations/z-order", sourceFiles="z-order.cs" %}

{% endaspTab %}

**Positioning the Annotation**

You can place the annotation anywhere in gauge area by specifying pixel values to the [`x`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~X.html) and [`y`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~Y.html) properties.

{% aspTab template="lineargauge/annotations/animation-position", sourceFiles="animation-position.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

**Alignment of Annotation**

You can align the annotation using [`horizontalAlignment`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~HorizontalAlignment.html)and [`verticalAlignment`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~VerticalAlignment.html) properties.

{% aspTab template="lineargauge/annotations/animation-alignment", sourceFiles="animation-alignment.cs" %}

{% endaspTab %}

## Multiple Annotations

You can add multiple annotations to the gauge as demonstrated below.

{% aspTab template="lineargauge/annotations/multiple-annotations", sourceFiles="multiple-annotations.cs" %}

{% endaspTab %}