<!-- Converted from: sankey/EJ2_ASP.MVC/getting-started.md -->

---
layout: post
title: Getting started with ##Platform_Name## Sankey Chart Component
description: Checkout and learn about Getting started with ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Getting started
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Getting started with React Sankey Chart component

This section describes how to integrate the Syncfusion React Sankey Chart component into a new React application. You'll learn about dependencies, installation steps, and how to create your first Sankey Chart visualization.

## Prerequisites

- Node.js version 14 or later
- Basic knowledge of React and TypeScript (recommended)
- A code editor like Visual Studio Code

## Dependencies

Below is the list of minimum dependencies required to use the Sankey Chart component.

```

|-- @syncfusion/ej2-react-charts
    |-- @syncfusion/ej2-base
    |-- @syncfusion/ej2-data
    |-- @syncfusion/ej2-charts
    |-- @syncfusion/ej2-react-base
    |-- @syncfusion/ej2-pdf-export
    |-- @syncfusion/ej2-file-utils
    |-- @syncfusion/ej2-compression
    |-- @syncfusion/ej2-svg-base

```

## Installation and Configuration

### Setting Up the React Development Environment

To easily set up a React application, use the Vite CLI (`npm create vite`), which provides:

- Faster development environment with instant hot module replacement (HMR)
- Smaller bundle sizes
- Optimized production builds
- Better performance compared to traditional tools like `create-react-app`

For detailed steps, refer to the Vite [installation instructions](https://vitejs.dev/guide). Vite sets up your environment using JavaScript and optimizes your application for production.

> **Note:** To create a React application using `create-react-app` instead, refer to this [documentation](https://ej2.syncfusion.com/react/documentation/getting-started/create-app) for more details.

To create a new React application, run the following command.

```bash
npm create vite@latest my-app
```

This command will prompt you for a few settings for the new project, such as selecting a framework and a variant.

![Initial_setup](../images/Initial-setup.jpg)

To set up a React application in TypeScript environment, run the following command.

```bash
npm create vite@latest my-app -- --template react-ts
cd my-app
npm run dev
```

To set up a React application in JavaScript environment, run the following command.

```bash
npm create vite@latest my-app -- --template react
cd my-app
npm run dev
```

### Install Syncfusion<sup style="font-size:70%">&reg;</sup> Sankey Chart Package

All the available Essential<sup style="font-size:70%">&reg;</sup> JS 2 packages are published in the [`npmjs.com`](https://www.npmjs.com/~syncfusionorg) public registry.
Project

Add the Sankey Chart component to your React application's main component file (`src/App.tsx` or `src/App.jsx`) using the following code. This creates a basic Sankey Chart with sample data:
```bash
npm install @syncfusion/ej2-react-charts --save
```

> The –save will instruct NPM to include the Sankey Chart package inside of the dependencies section of the package.json.

## Add Sankey Chart to the project

Add the Sankey Chart component to `src/App.tsx` using the following code.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/getting-started/initial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial.cs" %}
{% include code-snippet/sankey/getting-started/initial/initial.cs %}
{% endhighlight %}
{% endtabs %}

### Run the Development Server

Now run the `npm run dev` command in the console to start the development server. This command compiles your code and serves the application locally in your browser:

```
npm run dev
```

## Add data to Sankey Chart

Now you can add data to the Sankey Chart component by defining nodes and links. Nodes represent the categories, and links represent the flow between them.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/getting-started/initial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial.cs" %}
{% include code-snippet/sankey/getting-started/initial/initial.cs %}
{% endhighlight %}
{% endtabs %}

## Module injection

Sankey Chart component provides support for tooltip and legend interactions. To enable these features, you need to inject the required modules into the component.

* `SankeyTooltip` - Inject this module to enable tooltip feature.
* `SankeyLegend` - Inject this module to enable legend feature.

Import the above-mentioned modules from the chart package and inject them into the component as follows.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/getting-started/module-injection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Module-injection.cs" %}
{% include code-snippet/sankey/getting-started/module-injection/module-injection.cs %}
{% endhighlight %}
{% endtabs %}
