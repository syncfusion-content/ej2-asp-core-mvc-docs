---
layout: post
title: Document Management in ##Platform_Name## Document Editor Component
description: Learn here all about Document Management in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Document Management
publishingplatform: ##Platform_Name##
documentation: ug
---


# Document management

Document Editor provides support to restrict editing. When the protected document includes range permission, then unique user or user group only authorized to edit separate text area.

## Set current user

You can use the `currentUser` property to authorize the current document user by name, email, or user group name.

The following code shows how to set currentUser

```typescript
container.documentEditor.currentUser = 'engineer@mycompany.com';
```

## Highlighting the text area

You can highlight the editable region of the current user using the `userColor` property.

The following code shows how to set userColor.

```typescript
container.documentEditor.userColor = '#fff000';
```

## Restrict Editing Pane

Restrict Editing Pane provides the following options to manage the document:
* To apply formatting restrictions to the current document, select the allow formatting check box.
* To apply editing restrictions to the current document, select the read only check box.
* To add users to the current document, select more users option and add user from the popup dialog.
* To include range permission to the current document, select parts of the document and choose users who are allowed to freely edit them from the listed check box.
* To apply the chosen editing restrictions, click the **YES,START ENFORCING PROTECTION** button. A dialog box displays asking for a   password to protect.
* To stop protection, select **STOP PROTECTION** button. A dialog box displays asking for a password to stop protection.