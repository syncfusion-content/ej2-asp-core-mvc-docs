# Getting Started

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Preparing ASP.NET MVC application

The following steps to create ASP.NET MVC Application.

**Step 1:** Create ASP.NET MVC Application with default template project in Visual Studio.

![Default Template](./images/default-template.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using `NuGet Package Manager`.

Open the `NuGet` package manager.

![Solution Explorer](./images/solution-Explorer.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo.png)

After installation complete, this will be included in the project. You can refer it from the Project Assembly Reference.

**Note:** We need to install **NewtonSoft.JSON** as a dependency, since **Syncfusion.EJ2** dependent to `NewtonSoft.JSON` package.

**Step 3:** Add Syncfusion.EJ2 namespace reference in `Web.Config`.

```javascript

<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>

```

```javascript

<system.web>
    <compilation>
      <assemblies>
        <add assembly="Syncfusion.EJ2, Version=15.3400.0.27, Culture=neutral, PublicKeyToken=31BF3856AD364E35"  />
      </assemblies>
    </compilation>
  </system.web>

```

**Step 4:** Add client side resources through [`CDN`](http://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **_Layout.cshtml.**

```cs
@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>

```

**Step 5:** Add Script Manager and namespace in layout page **_Layout.cshtml.**

```cs

@using Syncfusion.EJ2;

    . . .
    . . .
<body>
    . . .
    . . .
    @Html.EJS().ScriptManager()
</body>

```

**Step 6:** Now, we can add Syncfusion Essential JS 2 for ASP.Net Core components in any page you want.

We are going to render `TreeMap` component in **Index.cshtml** page.

```cs

<h2> Essential JS 2 for ASP.NET MVC TreeMap </h2>

<div id="container">
    @Html.EJS().TreeMap("container").Load("load").WeightValuePath("Count").LeafItemSettings(leaf=>leaf.LabelPath("State")).Render()
</div>
<script>
    function load(args)
    {
        var data = [
            { Title: 'State wise International Airport count in South America', State: "Brazil", Count: 25 },
            { Title: 'State wise International Airport count in South America', State: "Colombia", Count: 12 },
            { Title: 'State wise International Airport count in South America', State: "Argentina", Count: 9 },
            { Title: 'State wise International Airport count in South America', State: "Ecuador", Count: 7 },
            { Title: 'State wise International Airport count in South America', State: "Chile", Count: 6 },
            { Title: 'State wise International Airport count in South America', State: "Peru", Count: 3 },
            { Title: 'State wise International Airport count in South America', State: "Venezuela", Count: 3 },
            { Title: 'State wise International Airport count in South America', State: "Bolivia", Count: 2 },
            { Title: 'State wise International Airport count in South America', State: "Paraguay", Count: 2 },
            { Title: 'State wise International Airport count in South America', State: "Uruguay", Count: 2 },
            { Title: 'State wise International Airport count in South America', State: "Falkland Islands", Count: 1 },
            { Title: 'State wise International Airport count in South America', State: "French Guiana", Count: 1 },
            { Title: 'State wise International Airport count in South America', State: "Guyana", Count: 1 },
            { Title: 'State wise International Airport count in South America', State: "Suriname", Count: 1 },
        ];
        args.treemap.dataSource = data;
    }
</script>
```
