# Getting Started

This section briefly explains about how to create a simple Chip in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add Chip to the project

To create simple `Chip` add the `ejs-chiplist` tag with id attribute as `element` in your **Index.cshtml** page.

```html

<ejs-chiplist id="chip" text="Janet Leverling"></ejs-chiplist>

```

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of Chip.

{% aspTab template="chips/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Chip Sample](./images/chip.png)
