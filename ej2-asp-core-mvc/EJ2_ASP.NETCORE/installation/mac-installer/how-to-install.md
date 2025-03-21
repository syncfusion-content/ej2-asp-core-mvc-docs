---
layout: post
title: Installing Syncfusion ##Platform_Name## Mac installer - Syncfusion
description: Learn here about how to install Syncfusion ##Platform_Name## mac installer after downloading from our Syncfusion website.
platform: ej2-asp-core-mvc
control: Installation and Deployment
documentation: ug

---

# Installing Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core EJ2 Mac Installer

The Essential Studio<sup style="font-size:70%">&reg;</sup> ASP.NET Core EJ2 Mac installer allows you to create the ASP.NET Core EJ2 application in Visual Studio for Mac with the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core EJ2 components.

## Steps to resolve the warning message in Catalina OS or later

   While running Essential Studio<sup style="font-size:70%">&reg;</sup> ASP.NET Core - EJ2 Mac Installer on Catalina MacOS or later, the below alert will be displayed.

   ![Alert Image](images/Mac_Catalina_MacOS_Alert1.png)  
     
   If you receive this alert, follow the below steps for the easiest solution.   

   1.	Right-click the downloaded dmg file.
   2.	Select the "Open With" option and choose "DiskImageMounter (Default)". The following pop-up appears.

	    ![pop-up Image](images/Mac_Catalina_MacOS_Alert2.png)

   3.	When you click "Open" the installer window will be opened.

## Step-by-Step Installation

The steps below shows how to install the Essential Studio<sup style="font-size:70%">&reg;</sup> ASP.NET Core - EJ2 Mac installer.

1. Locate the downloaded dmg file and open the file by double click on it.

   ![Welcome wizard](images/Mac_Installer1.png)

2. This action will automatically mount the disk image and create a virtual drive on your desktop or in the Finder sidebar.

   ![License Agreement](images/Mac_Installer2.png)

3. Copy the mounted disk file.

   ![License Agree Confirmation](images/Mac_Installer3.png)

4. And paste it in "Applications" folder shortcut.

   ![License Agree Confirmation](images/Mac_Installer4.png)
   
   N> The Unlock key is not required to install the Mac installer. The Syncfusion<sup style="font-size:70%">&reg;</sup> Essential Studio<sup style="font-size:70%">&reg;</sup> ASP.NET Core - EJ2 Mac installer can be used for development purposes without registering the Unlock key.


5. Now you can open the folder to explore the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential Studio<sup style="font-size:70%">&reg;</sup> Mac installer.

   ![Destination](Images/destination.JPG)

6. To remove the DMG file, Right-click on the virtual drive on your desktop or in the Finder sidebar and select "Eject." Also delete the folder from the Applications.

   ![Install Location](images/Mac_Installer6.png)

## License key registration in samples

After the installation, the license key is required to register the demo source that is included in the Mac installer. To learn about the steps for license registration for the ASP.NET Core - EJ2 Mac installer, please refer to this.

* Register the license key in the [Program.cs](https://ej2.syncfusion.com/aspnetcore/documentation/licensing/how-to-register-in-an-application#for-aspnet-core-application-using-net-60) file if you created the ASP.NET Core web application with Visual Studio 2022 and .NET 6.0.
* Register the license key in Configure method of [Startup.cs](https://ej2.syncfusion.com/aspnetcore/documentation/licensing/how-to-register-in-an-application#for-aspnet-core-application-using-net-50-or-net-31)