# Ranges

You can categorize the axis values using [`start`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~Start.html) and [`end`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~End.html) property in the [`ranges`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange.html). You can add any number of range for an axis by using array of range objects.

{% aspTab template="lineargauge/ranges/ranges", sourceFiles="ranges.cs" %}

{% endaspTab %}

## Ranges Customization

Ranges can be customized using the following properties.

* [`startWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~StartWidth.html) - Specifies start width of the range
* [`endWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~EndWidth.html) - Specifies end width of the range
* [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~Color.html) - Specifies color of the range
* `position` - Specifies the range bar position. Its possible values are 'inside' and 'outside'
* `Offset` - Specifies offset value from its default position
* `LinearGaugeRangeBorder` - Specifies range bar border color and width.

{% aspTab template="lineargauge/ranges/range-customization", sourceFiles="range-customization.cs" %}

{% endaspTab %}

## Multiple Ranges

You can add multiple ranges to an axis as demonstrated below.

{% aspTab template="lineargauge/ranges/multiple-ranges", sourceFiles="multiple-ranges.cs" %}

{% endaspTab %}