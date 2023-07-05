---
layout: post
title: Code Behind in ##Platform_Name## Circular Gauge Component
description: Learn here all about Circular Gauge Export with Annotations in Syncfusion ##Platform_Name## Circular Gauge component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Code Behind
publishingplatform: ##Platform_Name##
documentation: ug
---

# Gauge Export in ##Platform_Name## Circular gauge control

## How to export a Circular Gauge with Annotations using ForeignObject

The Circular Gauge component do not support exporting with annotations. This is because the annotations are intended to render any elements in the Circular Gauge component such as text, images, or custom elements. Since Circular Gauge is a SVG based control, the annotations can be rendered as **foreignObject** element. However, some web browsers do not support it.  As a workaround, we can achieve the same in the sample level.

The Circular Gauge with annotations can be exported in **PNG**, **JPEG**, and **PDF** formats. Similarly, the tooltip template can be exported as **foreignObject** elements. The example below demonstrates to export the Circular Gauge with annotations.

```cs
@using Syncfusion.EJ2.LinearGauge
@using Syncfusion.EJ2;

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

@Html.EJS().CircularGauge("gauge").Width("500px").Height("500px").AllowImageExport(true).AllowPdfExport(true).Axes(axes => axes.LineStyle(ls => ls.Color("transparent").Width(10))
.MajorTicks(majortick => majortick.Height(10).Offset(5))
.MinorTicks(minortick => minortick.Height(0))
.LabelStyle(labels => labels.Position(Syncfusion.EJ2.CircularGauge.Position.Inside).UseRangeColor(false)).Annotations(annotation =>

{
    annotation.Content("#templateone").Angle(0).Radius("30%").ZIndex("1").Add();
    annotation.Content("#templatetwo").Angle(180).Radius("40%").ZIndex("1").Add();
})
.Pointers(pointer => pointer.Value(50).Add()).Ranges(range =>
{
    range.Start(0).End(40).Color("#30B32D").Add();
    range.Start(40).End(80).Color("#FFDD00").Add();
    range.Start(80).End(100).Color("#F03E3E").Add();
}).Add()).Render()

<script id='templateone' type="text/x-template">
    <div id='templateWrap'>
        <div class='des'>
            <div><span style="font-size:14px; font-family:Segoe UI">Speedometer</span></div>
        </div>
    </div>
</script>

<script id='templatetwo' type="text/x-template">
    <div id='templateWrap'>
        <div class='des'>
            <div><span style="font-size:20px; font-family:Segoe UI">65 MPH</span></div>
        </div>
    </div>
</script>

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
                    document.save(fileName + '.' + formatValue);
                    document.destroy();
                
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
```

> **Sample**: [Export the Circular Gauge with annotations](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WebApplication4-1544692993).

**Screenshot**

![Screenshot for your reference](../images/circulargauge-with-annotations.png)