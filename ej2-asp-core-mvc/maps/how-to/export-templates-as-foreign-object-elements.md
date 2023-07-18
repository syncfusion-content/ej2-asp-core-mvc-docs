---
layout: post
title: Export in Syncfusion ##Platform_Name## Maps Component
description: Learn here all about how to export Maps with marker template in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Maps export with marker template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Maps Export in ##Platform_Name## Maps Component

## How to export the OSM Maps with Marker template using ForeignObject

The Maps do not support exporting with marker template. This is because the marker template are intended to render any elements in the Maps such as text, images, or custom elements. Since Maps is a SVG based control, the marker templates can be rendered as **foreignObject** element. However, some web browsers do not support it.  As a workaround, we can achieve the same in the sample level.

The OSM Maps with marker template can be exported in **PNG**, **JPEG**, and **PDF** formats. Similarly, the annotations and tooltip template can be exported as **foreignObject** elements. The example below demonstrates to export the OSM Maps with marker template.

{% if page.publishingplatform == "aspnet-core" %}

> **Sample**: [Export the OSM Maps with annotations](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WebApplication4-1544692993).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Maps
@using Syncfusion.EJ2

@using MapsSample.Controllers

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


@{
    var marker = new List<MapsMarker>
    {
        new MapsMarker{Visible=true, DataSource=ViewBag.markerData, Template="<div><div style=\"font-size:10px;color:black\">${name}</div><div style=\"width:15px;height:15px;margin-left:8px;color:white;border:2px solid black;border-radius:50%\"></div></div>"}
    };
}
    
<ejs-maps id="container" allowPdfExport="true" allowImageExport="true" background="transparent" width="600px" height="500px">
    <e-maps-mapsarea background="transparent"></e-maps-mapsarea>
     <e-maps-layers>
          <e-maps-layer urlTemplate="http://a.tile.openstreetmap.org/level/tileX/tileY.png" markerSettings="marker"></e-maps-layer>
     </e-maps-layers>
</ejs-maps>


<script>
     
    function mapsExport(formatValue, fileName) {
        var maps = document.getElementById('container').ej2_instances[0];
        var svgParent = document.getElementById('container_Tile_SVG_Parent');
        var svgObject = document.getElementById('container_svg').cloneNode(true);
        var tileSvg = document.getElementById('container_Tile_SVG').cloneNode(true);
        var url = window.URL.createObjectURL(
            new Blob([new XMLSerializer().serializeToString(svgObject)], {
                type: 'image/svg+xml',
            })
        );

        // osm image
        var imageCanvasElement = document.createElement('canvas');
        imageCanvasElement.width = maps.availableSize.width;
        imageCanvasElement.height = maps.availableSize.height;
        var ctxt_1 = imageCanvasElement.getContext('2d');

        var markerTemplateEleCount = document.getElementById(
            'container_LayerIndex_0_Markers_Template_Group'
        ).childElementCount;
        var markerElements = document.getElementById(
            'container_LayerIndex_0_Markers_Template_Group'
        );
        for (var i = 0; i < markerTemplateEleCount; i++) {
            var markerIndex = markerElements.children[i].id
                .split('_MarkerIndex_')[1]
                .split('_')[0];
            var layerIndex = markerElements.children[i].id
                .split('_LayerIndex_')[1]
                .split('_')[0];
            var markerEle = document
                .getElementById(
                    'container_LayerIndex_' + layerIndex + '_Markers_Template_Group'
                )
                .querySelectorAll(
                    '[id*="container_LayerIndex_' +
                    layerIndex +
                    '_MarkerIndex_' +
                    markerIndex +
                    '_dataIndex_"]'
                );
            var marker = markerEle[i];
            var foreign = document.createElementNS(
                'http://www.w3.org/2000/svg',
                'foreignObject'
            );
            foreign.setAttribute(
                'width',
                marker.getBoundingClientRect().width.toString()
            );
            foreign.setAttribute(
                'height',
                marker.getBoundingClientRect().height.toString()
            );
            foreign.setAttribute('x', marker.style.left);
            foreign.setAttribute('y', marker.style.top);
            foreign.innerHTML = marker.innerHTML;
            marker.style.display = 'none';
            var svg = document.querySelector('#container_svg');
            svg.appendChild(foreign);
        }

        var svgXml = new XMLSerializer().serializeToString(svg);
        var img = new Image();
        img.src = 'data:image/svg+xml;base64,' + btoa(svgXml);

        // marker template
        var foreignObjectCanvas = document.createElement('canvas');
        foreignObjectCanvas.width = svg.getBoundingClientRect().width;
        foreignObjectCanvas.height = svg.getBoundingClientRect().height;
        var ctx = foreignObjectCanvas.getContext('2d');

        var svgParentElement = document.getElementById('container_MapAreaBorder');
        var top_1 = parseFloat(svgParentElement.getAttribute('y'));
        var left_1 = parseFloat(svgParentElement.getAttribute('x'));
        var imgxHttp = new XMLHttpRequest();
        var imgTileLength_1 = maps.mapLayerPanel.tiles.length;

        var _loop_1 = function (i) {
            var tile = document.getElementById('container_tile_' + (i - 1));
            var exportTileImg = new Image();
            exportTileImg.crossOrigin = 'Anonymous';
            ctxt_1.fillRect(0, 0, maps.availableSize.width, maps.availableSize.height);
            ctxt_1.font = maps.titleSettings.textStyle.size + ' Arial';
            var titleElement = document.getElementById('container_Map_title');
            if (titleElement != null) {
                ctxt_1.fillStyle = titleElement.getAttribute('fill');
                ctxt_1.fillText(
                    maps.titleSettings.text,
                    parseFloat(titleElement.getAttribute('x')),
                    parseFloat(titleElement.getAttribute('y'))
                );
            }
            exportTileImg.onload = function () {
                if (i === 0 || i === imgTileLength_1 + 1) {
                    if (i === 0) {
                        ctxt_1.setTransform(1, 0, 0, 1, 0, 0);
                        ctxt_1.rect(
                            0,
                            top_1,
                            parseFloat(svgParent.style.width),
                            parseFloat(svgParent.style.height)
                        );
                        ctxt_1.clip();
                    } else {
                        ctxt_1.setTransform(1, 0, 0, 1, left_1, top_1);
                    }
                } else {
                    ctxt_1.setTransform(
                        1,
                        0,
                        0,
                        1,
                        parseFloat(tile.style.left) + left_1,
                        parseFloat(tile.style.top) + top_1
                    );
                }
                ctxt_1.drawImage(exportTileImg, 0, 0);
                if (i === imgTileLength_1 + 1) {
                    let imagedata = imageCanvasElement.toDataURL('image/png');
                    let anchor = document.createElement('a');
                    anchor.download = fileName + '.' + formatValue;
                    anchor.href = imagedata;
                    document.body.appendChild(anchor);
                    anchor.click();
                    maps.isExportInitialTileMap = false;
                }
            };

            img.onload = function () {
                ctx.drawImage(img, 0, 0);
            };

            if (i === 0 || i === imgTileLength_1 + 1) {
                if (i === 0) {
                    exportTileImg.src = url;
                } else {
                    setTimeout(function () {
                        exportTileImg.src = window.URL.createObjectURL(
                            new Blob([new XMLSerializer().serializeToString(tileSvg)], {
                                type: 'image/svg+xml',
                            })
                        );
                        var finalImage = new Image();
                        finalImage.src = foreignObjectCanvas.toDataURL('image/png');
                        document.body.appendChild(finalImage);
                        exportTileImg.src =
                            document.getElementsByTagName('img')[
                                document.getElementsByTagName('img').length - 1
                            ].src;
                    }, 300);
                }
            } else {
                imgxHttp.open('GET', tile.children[0].getAttribute('src'), true);
                imgxHttp.send();
                exportTileImg.src = tile.children[0].getAttribute('src');
            }
        };
        for (var i = 0; i <= imgTileLength_1 + 1; i++) {
            _loop_1(i);
        }
}

    document.getElementById('export').onclick = () => {
        var formatValue = document.getElementById('format').value;
        var fileName = 'MapsOSM';
        mapsExport(formatValue, fileName);
};

</script>

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2;

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

@using Syncfusion.EJ2.Maps;

@Html.EJS().Maps("container").AllowPdfExport(true).AllowImageExport(true).Background("transparent").MapsArea(Ma=>Ma.Background("Transparent")).Width("600px").Height("500px").Layers(l =>
{
    l.UrlTemplate("http://a.tile.openstreetmap.org/level/tileX/tileY.png").MarkerSettings(marker =>
       {
           marker.Visible(true).DataSource(ViewBag.markerData).Template("<div><div style=\"font-size:10px;color:black\">${name}</div><div style=\"width:15px;height:15px;margin-left:8px;color:white;border:2px solid black;border-radius:50%\"></div></div>").Add();
       }).Add();
}).Render()


<script>
    function mapsExport(formatValue, fileName) {
        var maps = document.getElementById('container').ej2_instances[0];
        var svgParent = document.getElementById('container_Tile_SVG_Parent');
        var svgObject = document.getElementById('container_svg').cloneNode(true);
        var tileSvg = document.getElementById('container_Tile_SVG').cloneNode(true);
        var url = window.URL.createObjectURL(
            new Blob([new XMLSerializer().serializeToString(svgObject)], {
                type: 'image/svg+xml',
            })
        );

        // osm image
        var imageCanvasElement = document.createElement('canvas');
        imageCanvasElement.width = maps.availableSize.width;
        imageCanvasElement.height = maps.availableSize.height;
        var ctxt_1 = imageCanvasElement.getContext('2d');

        var markerTemplateEleCount = document.getElementById(
            'container_LayerIndex_0_Markers_Template_Group'
        ).childElementCount;
        var markerElements = document.getElementById(
            'container_LayerIndex_0_Markers_Template_Group'
        );
        for (var i = 0; i < markerTemplateEleCount; i++) {
            var markerIndex = markerElements.children[i].id
                .split('_MarkerIndex_')[1]
                .split('_')[0];
            var layerIndex = markerElements.children[i].id
                .split('_LayerIndex_')[1]
                .split('_')[0];
            var markerEle = document
                .getElementById(
                    'container_LayerIndex_' + layerIndex + '_Markers_Template_Group'
                )
                .querySelectorAll(
                    '[id*="container_LayerIndex_' +
                    layerIndex +
                    '_MarkerIndex_' +
                    markerIndex +
                    '_dataIndex_"]'
                );
            var marker = markerEle[i];
            var foreign = document.createElementNS(
                'http://www.w3.org/2000/svg',
                'foreignObject'
            );
            foreign.setAttribute(
                'width',
                marker.getBoundingClientRect().width.toString()
            );
            foreign.setAttribute(
                'height',
                marker.getBoundingClientRect().height.toString()
            );
            foreign.setAttribute('x', marker.style.left);
            foreign.setAttribute('y', marker.style.top);
            foreign.innerHTML = marker.innerHTML;
            marker.style.display = 'none';
            var svg = document.querySelector('#container_svg');
            svg.appendChild(foreign);
        }

        var svgXml = new XMLSerializer().serializeToString(svg);
        var img = new Image();
        img.src = 'data:image/svg+xml;base64,' + btoa(svgXml);

        // marker template
        var foreignObjectCanvas = document.createElement('canvas');
        foreignObjectCanvas.width = svg.getBoundingClientRect().width;
        foreignObjectCanvas.height = svg.getBoundingClientRect().height;
        var ctx = foreignObjectCanvas.getContext('2d');

        var svgParentElement = document.getElementById('container_MapAreaBorder');
        var top_1 = parseFloat(svgParentElement.getAttribute('y'));
        var left_1 = parseFloat(svgParentElement.getAttribute('x'));
        var imgxHttp = new XMLHttpRequest();
        var imgTileLength_1 = maps.mapLayerPanel.tiles.length;

        var _loop_1 = function (i) {
            var tile = document.getElementById('container_tile_' + (i - 1));
            var exportTileImg = new Image();
            exportTileImg.crossOrigin = 'Anonymous';
            ctxt_1.fillRect(0, 0, maps.availableSize.width, maps.availableSize.height);
            ctxt_1.font = maps.titleSettings.textStyle.size + ' Arial';
            var titleElement = document.getElementById('container_Map_title');
            if (titleElement != null) {
                ctxt_1.fillStyle = titleElement.getAttribute('fill');
                ctxt_1.fillText(
                    maps.titleSettings.text,
                    parseFloat(titleElement.getAttribute('x')),
                    parseFloat(titleElement.getAttribute('y'))
                );
            }
            exportTileImg.onload = function () {
                if (i === 0 || i === imgTileLength_1 + 1) {
                    if (i === 0) {
                        ctxt_1.setTransform(1, 0, 0, 1, 0, 0);
                        ctxt_1.rect(
                            0,
                            top_1,
                            parseFloat(svgParent.style.width),
                            parseFloat(svgParent.style.height)
                        );
                        ctxt_1.clip();
                    } else {
                        ctxt_1.setTransform(1, 0, 0, 1, left_1, top_1);
                    }
                } else {
                    ctxt_1.setTransform(
                        1,
                        0,
                        0,
                        1,
                        parseFloat(tile.style.left) + left_1,
                        parseFloat(tile.style.top) + top_1
                    );
                }
                ctxt_1.drawImage(exportTileImg, 0, 0);
                if (i === imgTileLength_1 + 1) {
                    let imagedata = imageCanvasElement.toDataURL('image/png');
                    let anchor = document.createElement('a');
                    anchor.download = fileName + '.' + formatValue;
                    anchor.href = imagedata;
                    document.body.appendChild(anchor);
                    anchor.click();
                    maps.isExportInitialTileMap = false;
                }
            };

            img.onload = function () {
                ctx.drawImage(img, 0, 0);
            };

            if (i === 0 || i === imgTileLength_1 + 1) {
                if (i === 0) {
                    exportTileImg.src = url;
                } else {
                    setTimeout(function () {
                        exportTileImg.src = window.URL.createObjectURL(
                            new Blob([new XMLSerializer().serializeToString(tileSvg)], {
                                type: 'image/svg+xml',
                            })
                        );
                        var finalImage = new Image();
                        finalImage.src = foreignObjectCanvas.toDataURL('image/png');
                        document.body.appendChild(finalImage);
                        exportTileImg.src =
                            document.getElementsByTagName('img')[
                                document.getElementsByTagName('img').length - 1
                            ].src;
                    }, 300);
                }
            } else {
                imgxHttp.open('GET', tile.children[0].getAttribute('src'), true);
                imgxHttp.send();
                exportTileImg.src = tile.children[0].getAttribute('src');
            }
        };
        for (var i = 0; i <= imgTileLength_1 + 1; i++) {
            _loop_1(i);
        }
    }

    document.getElementById('export').onclick = () => {
        var formatValue = document.getElementById('format').value;
        var fileName = 'MapsOSM';
        mapsExport(formatValue, fileName);
    };
</script>

{% endhighlight %}
{% endtabs %}

{% endif %}

**Screenshot**

![Screenshot for your reference](../images/how-to/osm-maps-with-marker-template.png)