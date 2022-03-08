---
layout: post
title: Localization in ##Platform_Name## Common control
description: Learn here all about Localization in Syncfusion ##Platform_Name## Common control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Localization (Multi-Language) support in Syncfusion ASP.NET Core Controls

Localization (L10N) is the process of adapting application controls and content to the desired language with its corresponding region. This page shows you how to use the Localization feature in your application.

## Loading translations

To load translation object in your application use `load` function of `L10n` class.

You can change the different culture in Syncfusion ASP.NET Core controls by setting [locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Locale) property with culture codes. The following example demonstrates the Grid in Deutsch culture.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<ejs-grid id="Grid" allowPaging="true" locale="de-DE" allowGrouping="true">
    <e-data-manager url="https://services.odata.org/V4/Northwind/Northwind.svc/Orders/" adaptor="ODataV4Adaptor" crossdomain="true"></e-data-manager>
    <e-grid-pagesettings pageCount="6"></e-grid-pagesettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" isPrimaryKey="true" width="120"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer Name" width="150"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="170"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

<script>
    ej.base.L10n.load({
        'de-DE': {
            'grid': {
                'EmptyRecord': 'Keine Aufzeichnungen angezeigt',
                'GroupDropArea': 'Ziehen Sie einen Spaltenkopf hier, um die Gruppe ihre Spalte',
                'UnGroup': 'Klicken Sie hier, um die Gruppierung aufheben',
                'EmptyDataSourceError': 'DataSource darf bei der Erstauslastung nicht leer sein, da Spalten aus der dataSource im AutoGenerate Spaltenraster',
                'Item': 'Artikel',
                'Items': 'Artikel'
            },
            'pager': {
                'currentPageInfo': '{0} von {1} Seiten',
                'totalItemsInfo': '({0} Beiträge)',
                'firstPageTooltip': 'Zur ersten Seite',
                'lastPageTooltip': 'Zur letzten Seite',
                'nextPageTooltip': 'Zur nächsten Seite',
                'previousPageTooltip': 'Zurück zur letzten Seit',
                'nextPagerTooltip': 'Zum nächsten Pager',
                'previousPagerTooltip': 'Zum vorherigen Pager'
            }
        }
    });
</script>

{% endhighlight %}
{% endtabs %}

## Changing current locale

Current locale can be changed for all the Syncfusion ASP.NET Core controls in your application by invoking `setCulture` function with your desired culture name. The following example demonstrates the Grid in Deutsch culture.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<ejs-grid id="Grid" allowPaging="true" locale="de-DE" allowGrouping="true">
    <e-data-manager url="https://services.odata.org/V4/Northwind/Northwind.svc/Orders/" adaptor="ODataV4Adaptor" crossdomain="true"></e-data-manager>
    <e-grid-pagesettings pageCount="6"></e-grid-pagesettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" isPrimaryKey="true" width="120"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer Name" width="150"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="170"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

<script>
    ej.base.L10n.load({
        'de-DE': {
            'grid': {
                'EmptyRecord': 'Keine Aufzeichnungen angezeigt',
                'GroupDropArea': 'Ziehen Sie einen Spaltenkopf hier, um die Gruppe ihre Spalte',
                'UnGroup': 'Klicken Sie hier, um die Gruppierung aufheben',
                'EmptyDataSourceError': 'DataSource darf bei der Erstauslastung nicht leer sein, da Spalten aus der dataSource im AutoGenerate Spaltenraster',
                'Item': 'Artikel',
                'Items': 'Artikel'
            },
            'pager': {
                'currentPageInfo': '{0} von {1} Seiten',
                'totalItemsInfo': '({0} Beiträge)',
                'firstPageTooltip': 'Zur ersten Seite',
                'lastPageTooltip': 'Zur letzten Seite',
                'nextPageTooltip': 'Zur nächsten Seite',
                'previousPageTooltip': 'Zurück zur letzten Seit',
                'nextPagerTooltip': 'Zum nächsten Pager',
                'previousPagerTooltip': 'Zum vorherigen Pager'
            }
        }
    });
    ej.base.setCulture('de');
</script>

{% endhighlight %}
{% endtabs %}

> Before changing a culture globally, ensure that locale text for the concerned culture is loaded through `L10n.load` function. 

## See also

* [Globalization](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization)