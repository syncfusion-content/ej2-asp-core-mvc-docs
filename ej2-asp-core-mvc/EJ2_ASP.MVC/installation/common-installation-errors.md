---
layout: post
title: Common Installation Errors in ##Platform_Name## Component
description: Learn here all about Common Installation Errors in Syncfusion ##Platform_Name## component and more.
platform: ej2-asp-core-mvc
control: Common Installation Errors
publishingplatform: ##Platform_Name##
documentation: ug
---

# Common Installation Errors

This article describes the most common installation errors, as well as the causes and solutions to those errors.

* [Unlocking the license installer using the trial key](https://ej2.syncfusion.com/aspnetmvc/documentation/installation/common-installation-errors/#unlocking-the-license-installer-using-the-trial-key)

* [License has expired](https://ej2.syncfusion.com/aspnetmvc/documentation/installation/common-installation-errors/#license-has-expired)

* [Unable to find a valid license or trial](https://ej2.syncfusion.com/aspnetmvc/documentation/installation/common-installation-errors/#unable-to-find-a-valid-license-or-trial)

* [Unable to install because of another installation](https://ej2.syncfusion.com/aspnetmvc/documentation/installation/common-installation-errors/#unable-to-install-because-of-another-installation)

* [Unable to install due to controlled folder access](https://ej2.syncfusion.com/aspnetmvc/documentation/installation/common-installation-errors/#unable-to-install-due-to-controlled-folder-access)

## Unlocking the license installer using the trial key

**Error Message:** Sorry,the provided unlock key is a trial unlock key and cannot be used to unlock the licensed version of our Essential Studio for ASP . NET MVC installer.

![Installation Unlock Error](images\installation-error-1.png)

**Reason** <br /> You are attempting to use a Trial unlock key to unlock the licensed installer.

**Suggested solution** <br /> Only a licensed unlock key can unlock a licensed installer. So, to unlock the Licensed installer, use the Licensed unlock key. To generate the licensed unlock key, refer to [this](https://www.syncfusion.com/kb/2326) article.

## License has expired

**Error Message:** Your license for Syncfusion Essential Studio for ASP . NET MVC - EJ2 has been expired since {date}. Please renew your subscription and try again.

***Online Installer***

![Installation License Expired Error](images\installation-error-2.png)

**Reason** <br /> This error message will appear if your license has expired.

**Suggested Solution** <br /> You can choose from the options below.

1. You can renew your subscription [here](https://www.syncfusion.com/account/my-renewals).

2. You can get a new license [here](https://www.syncfusion.com/sales/products).

3. You can reach out to our sales team by emailing [sales@syncfusion.com](mailto:sales@syncfusion.com).

4. You can also extend the 30-day trial period after your trial license has expired.

## Unable to find a valid license or trial

**Error Message:** Sorry, we are unable to find a valid license or trial for Essential Studio for ASP . NET MVC - EJ2 under your account.

***Offline installer***

![Installation Offline Installer Error](images\installation-error-3.png)

***Online installer***

![Installation Online Installer Error](images\installation-error-4.png)

**Reason** <br /> The following are possible causes of this error:

* When your trial period expired.

* When you don't have a license or an active trial.

* You are not the license holder of your license.

* Your account administrator has not yet assigned you a license.

**Suggested solution** <br />

1. You can get a new license [here](https://www.syncfusion.com/sales/products).

2. Contact your account administrator.

3. Send an email to [clientrelations@syncfusion.com](mailto:clientrelations@syncfusion.com) to request a license.

4. You can reach out to our sales team by emailing [sales@syncfusion.com](mailto:sales@syncfusion.com).

## Unable to install because of another installation

**Error Message:** Another installation is in progress. You cannot start this installation without completing all other currently active installations. Click cancel to end this installer or retry to attempt after currently active installation completed to install again.

![Installation Error Another MSI Running](images\installation-error-5.png)

**Reason** <br /> You are trying to install when another installation is already running in your machine.

**Suggested solution** <br /> Open and kill the msiexec process in the task manager and then continue to install Syncfusion. If the problem is still present, restart the computer and try Syncfusion installer.

1. Open the Windows Task Manager.

2. Browse the Details tab.

3. Select the msiexec.exe and click **End Task**.

![Installation Error MSIEXEC Kill](images\installation-error-6.png)

## Unable to install due to controlled folder access

***Offline:***

**Error Message:** Controlled folder access seems to be enabled in your machine. The provided install or samples location (e.g., Public Documents) is protected by the controlled folder access settings.

![Installation Offline Installer Error Controlled Folder Access](images\installation-error-7.png)

***Online:***

**Error Message:** Controlled folder access seems to be enabled in your machine. The provided install, samples, or download location (e.g., Public Documents) is protected by the controlled folder access settings.

![Installation Online Installer Error Controlled Folder Access](images\installation-error-8.png)

**Reason** <br /> You have enabled controlled folder access settings on your computer.

**Suggested Solution** <br /> Select a different location to install or deactivate your machine's controlled folder access settings, and then try installing.