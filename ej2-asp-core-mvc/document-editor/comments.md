---
layout: post
title: Comments in ##Platform_Name## Document Editor Component
description: Learn here all about Comments in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Comments
publishingplatform: ##Platform_Name##
documentation: ug
---


# Comments

Document editor allows you to add comments to documents. You can add, navigate and remove comments in code and from the UI.

## Add a new comment

Comments can be inserted to the selected text.

```typescript
documentEditor.editor.insertComment("Test comment");
```

## Comment navigation

Next and previous comments can be navigated using the below code snippet.

```typescript
//Navigate to next comment
documentEditor.selection.navigateNextComment();

//Navigate to previous comment
documentEditor.selection.navigatePreviousComment();
```

## Delete comment

Current comment can be be deleted using the below code snippet.

```typescript
documentEditor.editor.deleteComment();
```

## Delete all comment

All the comments in the document can be deleted using the below code snippet.

```typescript
documentEditor.editor.deleteAllComments();
```
