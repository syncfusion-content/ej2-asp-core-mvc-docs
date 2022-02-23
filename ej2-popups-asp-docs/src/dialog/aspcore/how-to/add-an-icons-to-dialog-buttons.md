---
title: "Add icons to Dialog buttons"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Add icons to Dialog buttons

You can add icons to the dialog buttons using the [`buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) property or [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) property . For detailed information about dialog buttons, refer to the documentation section.

In the following sample, dialog footer buttons are customized with icons using `buttons` property.

{% aspTab template="dialog/how-to/template-button", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![dialog](../images/dialog-btn-icon.png)

In the following sample, dialog footer buttons are customized with icons using `footerTemplate` property.

{% aspTab template="dialog/how-to/template-footer", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![dialog](../images/dialog-btn-icon.png)