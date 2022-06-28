---
layout: post
title: Localization in ##Platform_Name## Common control
description: Checkout the documentation and learn about localization in Syncfusion ##Platform_Name## Common control and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Localization (Multi-Language) support in ASP.NET Core

Localization (L10N) is the process of adapting application controls and content to the desired language with its corresponding region. This page shows, how to use the Localization feature in the ASP.NET Core application.

## Localization of Syncfusion ASP.NET Core Controls

Syncfusion controls can be localized using the culture based JSON files. You can find the default and culture based localization files in the following GitHub repository.

> You can get default and culture based JSON files from [GitHub](https://github.com/syncfusion/ej2-locale).

### Adding culture based JSON files

Syncfusion [locale data](https://www.npmjs.com/package/@syncfusion/ej2-locale) is also available as npm package. So, you can install it through the below command in the application root directory. Once the package is installed, you can find the culture specific JSON data under the location `node_modules\@syncfusion\ej2-locale\src`.

{% tabs %}
{% highlight c# tabtitle="CMD" %}

npm i @syncfusion/ej2-locale

{% endhighlight %}
{% endtabs %}

Once the `ej2-locale` package has installed, create a folder `locale` inside the `wwwroot` folder. Then copy the specific culture files from `node_modules\@syncfusion\ej2-locale\src` location and paste it inside the `wwwroot/locale` folder like below. The culture file contains all Syncfusion ASP.NET Core controls locale text.

![Moved locale data to ASP.NET Core app](images/moved-locale-data.png)

## Statically set the culture

If you don't want to change culture dynamically, you can specify the static culture using `load` function of `L10n` class in **~/Pages/Shared/_Layout.cshtml** file as in the below code.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <script>
        var ajax = new ej.base.Ajax(location.origin + '/../../locale/de.json', 'GET', false);   //load the de json culture file 
        ajax.send().then((e) => {
            var loader = JSON.parse(e);
            ej.base.L10n.load(
                loader
            );
            ej.base.setCulture('de');      //Set the culture for the ASP.NET Core controls 
        });
    </script>
</body>

{% endhighlight %}
{% endtabs %}

Now, you can add the Syncfusion ASP.NET Core control in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<ejs-grid id="Grid" allowPaging="true" allowGrouping="true">
    <e-data-manager url="https://services.odata.org/V4/Northwind/Northwind.svc/Orders/" adaptor="ODataV4Adaptor" crossdomain="true"></e-data-manager>
    <e-grid-pagesettings pageCount="6"></e-grid-pagesettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" isPrimaryKey="true" width="120"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer Name" width="150"></e-grid-column>
        <e-grid-column field="Freight" headerText="Freight" format="C2" width="120"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="170"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

![Static culture](images/grid-locale.png)

> [View sample in GitHub](https://github.com/SyncfusionExamples/asp-net-core-localization/tree/main/Localization-with-static-culture)

## Dynamically set the culture

The culture can be set dynamically based on user's preference. The following example demonstrates how to dynamically change the culture in the ASP.NET Core application.

Modify the **~/Pages/Shared/_Layout.cshtml** page with the below code to implement a culture change dynamically using the dropdown in the application.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

@model IndexModel
<!DOCTYPE html>
<html lang="en">
<body>
<header>
    ...
    <div>
        <ejs-dropdownlist id="culture-swtich" dataSource="@Model.Cultures" index="0" change="onCultureChange" floatLabelType="Always">
        <e-dropdownlist-fields text="Text" value="ID"></e-dropdownlist-fields>
        </ejs-dropdownlist>
    </div>
</header>

<script>
    function onCultureChange(e) {
        var culture = e.value;
        var ajax = new ej.base.Ajax(location.origin + '/../../locale/' + culture + '.json' , 'GET', false);   //load the json culture file 
        ajax.send().then((e) => {
            var loader = JSON.parse(e);
            ej.base.L10n.load(
                loader
            );
            ej.base.setCulture(culture);      //Set the culture for the ASP.NET Core controls 
        });
    }
</script>
<body>
</html>
{% endhighlight %}
{% endtabs %}

Add the following code for dropdown data in the **~/Pages/Index.cshtml.cs** model page.

{% tabs %}
{% highlight c# tabtitle="~/Index.cshtml.cs" %}

public List<CultureDetails> Cultures = new List<CultureDetails>() 
{
    new CultureDetails(){ ID = "en-US", Text = "English" },
    new CultureDetails(){ ID = "de", Text = "Germany" },
    new CultureDetails(){ ID = "fr", Text = "French" },
    new CultureDetails(){ ID = "zh", Text = "Chinese" }
};

public class CultureDetails
{
    public string ID { get; set; }
    public string Text { get; set; }
}

{% endhighlight %}
{% endtabs %}

![Change culture dynamically](images/dynamic-culture-switch.png)

> [View sample in GitHub](https://github.com/SyncfusionExamples/asp-net-core-localization/tree/main/Localization-with-dynamic-culture)

## Changing current locale

Current locale can be changed for all the Syncfusion ASP.NET Core controls in the application by invoking `setCulture` function with the desired culture name and set locale property. You can change the different culture in Syncfusion ASP.NET Core controls by setting [locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Locale) property with culture codes.

The following example demonstrates the Grid in Deutsch culture.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<ejs-grid id="Grid" allowPaging="true" locale="de-DE" allowGrouping="true">
    <e-data-manager url="https://services.odata.org/V4/Northwind/Northwind.svc/Orders/" adaptor="ODataV4Adaptor" crossdomain="true"></e-data-manager>
    <e-grid-pagesettings pageCount="6"></e-grid-pagesettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" isPrimaryKey="true" width="120"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer Name" width="150"></e-grid-column>
        <e-grid-column field="Freight" headerText="Freight" format="C2" width="120"></e-grid-column>
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
                'nextPagerTooltip': 'Gehen Sie zu den nächsten Pager-Elementen',
                'previousPagerTooltip': 'Gehen Sie zu vorherigen Pager-Elementen'
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
