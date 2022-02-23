---
title: "Grid Scaffolding | ASP.NET MVC"
component: "Grid"
description: "Scaffolding provides an easier way to create Views and Controller action methods for Syncfusion ASP.NET MVC DataGrid control."
---

# Scaffolding

Syncfusion provides the **Visual Studio Scaffolding** for the Syncfusion ASP.NET MVC platform to quickly add code that interacts with data models and reduce the amount of time to develop with data operation in your project. Scaffolding provides an easier way to create Views and Controller action methods for Syncfusion ASP.NET MVC DataGrid controls.

> Note: The Syncfusion ASP.NET MVC UI Scaffolder is available from **v16.4.0.40**.

## Add a Scaffolded Item

The following steps direct you to add a Scaffolded item to your ASP.NET MVC Web Application.

* Right-click on Controller folder in the Solution Explorer and select **Add → New Scaffolded Item.**

![Alt text](./images/common-template.PNG)

* You will see the Add Scaffold dialog. Select **Syncfusion ASP.NET MVC UI Scaffolder** and click ‘Add’ button, which will display the Syncfusion UI Scaffolding dialog.

![Alt text](./images/ui-scaffolder.PNG)

* Select the DataGrid control to perform Scaffolding and click **Next**.

![Alt text](./images/control-template.PNG)

* Syncfusion UI Scaffolding for the selected control dialog will be opened. Enter the **Controller and View** names as per the application requirement. Also, select the required **Model Class** of the active project and its relevant **Data Context Class** and then Click **Next**.

![Alt text](./images/scaffold-template.PNG)

* Syncfusion UI Scaffolding for the DataGrid control feature dialog will be opened. Select the required features and Click **Add**. Use the **back arrow** if you want to modify the already provided Controller or View name, and to change the **selected Model Class and Data Context Class**.

![Alt text](./images/feature.PNG)

select the corresponding DataGrid features from option.

* The **Controller** and the corresponding **View** files are now generated with the selected features code snippet.

![Alt text](./images/explorer-mvc.PNG)

**Note** :

* Ensure at least one Entity Framework model has been exists and the application compiled once.

* If no Entity Framework model exists in your application, refer to the [`documentation`](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/database-first-development/creating-the-web-application#generate-the-models) to generate the Entity Framework model. Once model file added, ensure required DBContext and properties are added. Now, build the application and try scaffolding. If any changes done in model properties later, compile the application once before perform scaffolding.

## How to render Syncfusion Control'?'

Refer to the following UG links to render Syncfusion control after performed scaffolding.

**MVC4:** [`Configure Essential JS 2 using Syncfusion.EJ2.MVC4 package`](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/visual-studio-2017/#configure-essential-js-2-in-the-application-1)
**MVC5:** [`Configure Essential JS 2 using Syncfusion.EJ2.MVC5 package`](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/visual-studio-2017/#configure-essential-js-2-in-the-application)
