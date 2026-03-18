<!-- Converted from: sankey/EJ2_ASP.MVC/print-and-export.md -->

---
layout: post
title: Print and Export in ##Platform_Name## Sankey Chart Component
description: Learn here all about Print and Export in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Print and Export
publishingplatform: ##Platform_Name##
documentation: ug
---

# Print and Export in ##Platform_Name## Sankey Chart component

The Sankey Chart provides comprehensive print and export functionality, enabling users to generate static files in multiple formats (PNG, JPEG, SVG, PDF) or print the diagram directly. This is useful for reports, documentation, sharing, and offline access.

This guide covers printing the chart and exporting to various formats with customization options.

## Print

Print the Sankey Chart directly to paper or PDF using the `print()` method. This opens the browser's print dialog, allowing users to select printer settings and output format:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/print-export/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/sankey/print-export/print/print.cs %}
{% endhighlight %}
{% endtabs %}

## Export

Export the Sankey Chart to various file formats using the `export()` method. This allows you to generate standalone files suitable for sharing, archiving, or embedding in documents.

### Export Formats

The Sankey Chart supports exporting to the following formats:

- **PNG** - Portable Network Graphics (raster format, good for web)
- **JPEG** - Joint Photographic Experts Group (compressed raster, smaller file size)
- **SVG** - Scalable Vector Graphics (vector format, scalable without quality loss)
- **PDF** - Portable Document Format (ideal for printing and archiving)

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/print-export/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/sankey/print-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}

## Export with Custom Options

Export the chart with a custom filename and format selection to control output file names and type:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/print-export/export-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-custom.cs" %}
{% include code-snippet/sankey/print-export/export-custom/export-custom.cs %}
{% endhighlight %}
{% endtabs %}

## Export Events

### Before Export Event

Use the `beforeExport` event to customize the export process before the file is generated. This allows you to modify chart properties, add watermarks, or perform pre-export calculation

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/print-export/before-export-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Before-export-event.cs" %}
{% include code-snippet/sankey/print-export/before-export-event/before-export-event.cs %}
{% endhighlight %}
{% endtabs %}

## Export Completed Event

Handle the completion of export using the `exportCompleted` event:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/print-export/export-completed-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-completed-event.cs" %}
{% include code-snippet/sankey/print-export/export-completed-event/export-completed-event.cs %}
{% endhighlight %}
{% endtabs %}

## Export Format Comparison

| Format | Use Case | Quality | File Size |
|--------|----------|---------|-----------|
| PNG | Web sharing, presentations | Raster (good quality) | Medium |
| JPEG | Web images, email | Raster (good quality) | Small |
| SVG | Scalable graphics, printing | Vector (scalable) | Medium |
| PDF | Documents, archival | Vector (scalable) | Medium |

## Best Practices

- **PNG/JPEG**: Best for quick sharing and web usage
- **SVG**: Best for scalable, print-ready exports
- **PDF**: Best for formal documents and archival purposes
- Choose format based on your distribution and usage requirements
- Test exports in different formats to ensure quality meets your needs
