---
layout: post
title: Export in ##Platform_Name## Circular Gauge Component
description: Learn here all about Circular Gauge Export with Annotations in Syncfusion ##Platform_Name## Circular Gauge component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Circular Gauge export with annotations
publishingplatform: ##Platform_Name##
documentation: ug
---

# Gauge Export in ##Platform_Name## Circular gauge control

## How to export a Circular Gauge with Annotations using ForeignObject

The Circular Gauge component do not support exporting with annotations. This is because the annotations are intended to render any elements in the Circular Gauge component such as text, images, or custom elements. Since Circular Gauge is a SVG based control, the annotations can be rendered as **foreignObject** element. However, some web browsers do not support it.  As a workaround, we can achieve the same in the sample level.

The Circular Gauge with annotations can be exported in **PNG**, **JPEG**, and **PDF** formats. Similarly, the tooltip template can be exported as **foreignObject** elements. The example below demonstrates to export the Circular Gauge with annotations.

> **Sample**: [Export the Circular Gauge with annotations](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WebApplication4-1544692993).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.CircularGauge
@using Syncfusion.EJ2

@{
    var labelFont = new Syncfusion.EJ2.CircularGauge.CircularGaugeFont { FontFamily = "Segoe UI", Opacity = 1, Size = "12px", FontWeight = "Regular" };
}

<div id="gauge"></div>
<div class="col-md-4 property-section">
    Export Type
    <select id="format">
        <option value="PNG">PNG</option>
        <option value="JPEG">JPEG</option>
        <option value="PDF">PDF</option>
    </select>
    <br />
    <br />
    <button id="export" type="button" width='15%'>Export</button>
</div>

<ejs-circulargauge id="gauge" allowImageExport="true" allowPdfExport="true">
    <e-circulargauge-axes>
        <e-circulargauge-axis startAngle="210" endAngle="150" minimum="0" maximum="120" radius="80%">
            <e-axis-linestyle width="10" color="transparent"></e-axis-linestyle>
            <e-axis-labelstyle position="@Syncfusion.EJ2.CircularGauge.Position.Inside" useRangeColor="false" font="labelFont" />
            <e-axis-majorticks height="10" offset="5"></e-axis-majorticks>
            <e-axis-minorticks height="10" width="0" color="transparent"></e-axis-minorticks>
            <e-circulargauge-annotations>
                <e-circulargauge-annotation content="<div><span style='font-size:14px;font-family:Segoe UI'>Speedometer</span></div>" radius="30%" angle="0" zIndex="1"></e-circulargauge-annotation>
                <e-circulargauge-annotation content="<div><span style='font-size:20px;font-family:Segoe UI'>65 MPH</span></div>" radius="40%" angle="180" zIndex="1"></e-circulargauge-annotation>
            </e-circulargauge-annotations>
            <e-circulargauge-pointers>
                <e-circulargauge-pointer value="65" radius="60%" pointerWidth="8">
                    <e-pointer-cap radius="7"></e-pointer-cap>
                    <e-pointer-needletail length="18%"></e-pointer-needletail>
                </e-circulargauge-pointer>
            </e-circulargauge-pointers>
            <e-circulargauge-ranges>
                <e-circulargauge-range start="0" end="40" color="#30B32D"></e-circulargauge-range>
                <e-circulargauge-range start="40" end="80" color="#FFDD00"></e-circulargauge-range>
                <e-circulargauge-range start="80" end="120" color="#F03E3E"></e-circulargauge-range>
            </e-circulargauge-ranges>
        </e-circulargauge-axis>
    </e-circulargauge-axes>
</ejs-circulargauge>

<script>
   
    function gaugeExport(formatValue, fileName) {
       
        var annotationEle = document
            .getElementById('gauge')
            .querySelectorAll('[id*="gauge_Axis_0_Annotation_"]');

        for (var i = 0; i < annotationEle.length; i++) {
            var annotation = annotationEle[i];

            var foreign = document.createElementNS(
                'http://www.w3.org/2000/svg',
                'foreignObject'
            );

            foreign.setAttribute(
                'width',
                annotation.getBoundingClientRect().width.toString()
            );

            foreign.setAttribute(
                'height',
                annotation.getBoundingClientRect().height.toString()
            );

            foreign.setAttribute('x', annotation.style.left);

            foreign.setAttribute('y', annotation.style.top);

            foreign.innerHTML = annotation.innerHTML;

            annotation.style.display = 'none';

            var svg = document.querySelector('#gauge_svg');

            svg.appendChild(foreign);
        }

        var svgData = new XMLSerializer().serializeToString(svg);

        var canvas = document.createElement('canvas');

        document.body.appendChild(canvas);

        var svgSize = svg.getBoundingClientRect();

        canvas.width = svgSize.width;

        canvas.height = svgSize.height;

        var ctx = canvas.getContext('2d');

        var img = document.createElement('img');

        img.setAttribute('src', 'data:image/svg+xml;base64,' + btoa(svgData));

        img.onload = function () {
            ctx.drawImage(img, 0, 0);
            if (formatValue == 'PNG' || formatValue == 'JPEG') {
                var imagedata = canvas.toDataURL('image/png');

                var anchor = document.createElement('a');

                anchor.download = fileName + '.' + formatValue;

                anchor.href = imagedata;

                document.body.appendChild(anchor);

                anchor.click();
            } else if (formatValue == 'PDF') {
                const document = new ejs.pdfexport.PdfDocument();

                var imageString = canvas
                    .toDataURL('image/jpeg')
                    .replace('image/jpeg', 'image/octet-stream');

                imageString = imageString.slice(imageString.indexOf(',') + 1);

                document.pages
                    .add()
                    .graphics.drawImage(
                        new ejs.pdfexport.PdfBitmap(imageString),
                        0,
                        0,
                        canvas.width,
                        canvas.height
                    );
                if (circulargauge.allowPdfExport) {
                    document.save(fileName + '.' + formatValue);
                    document.destroy();
                }
            }
            canvas.remove();
        };
}

    document.getElementById('export').onclick = () => {
        var formatValue = document.getElementById('format').value;
        var fileName = 'Gauge';
        gaugeExport(formatValue, fileName);
    };

</script>

{% endhighlight %}
{% endtabs %}

**Screenshot**

![Screenshot for your reference](../images/circulargauge-with-annotations.png)