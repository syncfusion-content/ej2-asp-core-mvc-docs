# Internationalization

Circular gauge provide supports for internationalization for below gauge elements.

* Axis label.
* Tooltip.

For more information about number formatter you can refer
[`internationalization`](http://ej2.syncfusion.com/aspnet/documentation/base/intl.html).

<!-- markdownlint-disable MD036 -->
**Globalization**

Globalization is the process of designing and developing a component that works in different cultures/locales.
Internationalization library is used to globalize number in CircularGauge component
using [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Format) property in [`labelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html).

<!-- markdownlint-disable MD036 -->
**Numeric Format**

In the below example axis labels are `globalized` to EUR.

{% aspTab template="circulargauge/internationalization", sourceFiles="internationalization.cs" %}

{% endaspTab %}