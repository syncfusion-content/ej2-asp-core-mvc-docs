---
layout: post
title: Collaborative Editing in ASP.NET MVC Block Editor Control | Syncfusion
description: Checkout and learn about Collaborative Editing with Syncfusion Essential ASP.NET MVC BlockEditor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Collaborative Editing in ASP.NET MVC Block Editor control

The Block Editor supports real-time collaborative editing, allowing multiple users to work on the same document simultaneously.

Collaboration is powered by **Yjs**, a Conflict-free Replicated Data Type (CRDT) framework that synchronizes document changes across connected users while automatically resolving conflicts.

With collaboration enabled, users can:

* Edit the same document in real time.
* View remote user cursors and selections.
* Track active collaborators.
* Perform collaborative undo and redo operations.
* Create, restore, compare, export, and import document versions.

## Prerequisites

To use collaboration, install the `yjs` library and any one of the provider such as:

* `y-websocket`
* `y-webrtc`
* Any custom provider compatible with Yjs

You must inject the Collaboration module into the Block Editor.

```cshtml
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Render()
</div>

<script>
    ej.blockeditor.BlockEditor.Inject(ej.blockeditor.Collaboration);
</script>
```

## Getting Started

### Create a Yjs Document

Create a shared Yjs document and fragment.

```cshtml
<script>
    // Create a shared Yjs document and fragment
    var yDoc = new Y.Doc();
    var yFragment = yDoc.getXmlFragment('blockeditor');
</script>
```

### Create a Yjs Adapter

Create an adapter that provides the Yjs runtime and shared fragment.

```cshtml
<script>
    var adapter = new ej.blockeditor.YjsAdapter({
        YRuntime: Y,
        yXmlFragment: yFragment
    });
</script>
```

### Configure a Provider

Create a provider that connects users to the same shared document.

```cshtml
<script>
    var provider = new WebsocketProvider(
        'wss://your-server-url',
        'document-room-id',
        yDoc
    );
</script>
```

### Enable Collaboration

Configure the Block Editor with collaboration settings.

```cshtml
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("onCreated").Render()
</div>

<script>
    var blockEditorObj;

    function onCreated() {
        blockEditorObj = ej.base.getComponent(document.getElementById('block-editor'), 'blockeditor');
        blockEditorObj.collaborationSettings = {
            adapter: adapter,
            provider: provider
        };
    }
</script>
```

## User Presence and Remote Cursors

The Block Editor can display remote cursors, text selection overlays and modified user details on hover.

To enable user presence features, set `enableAwareness` to `true`.

```cshtml
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("onCreated").Render()
</div>

<script>
    var blockEditorObj;

    function onCreated() {
        blockEditorObj = ej.base.getComponent(document.getElementById('block-editor'), 'blockeditor');
        blockEditorObj.collaborationSettings = {
            adapter: adapter,
            provider: provider,
            enableAwareness: true
        };
    }
</script>
```

### Configure the Current User

Set information about the current user.

```cshtml
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Users(ViewBag.Users).CurrentUserId("user-1").Created("onCreated").Render()
</div>

<script>
    var blockEditorObj;

    function onCreated() {
        blockEditorObj = ej.base.getComponent(document.getElementById('block-editor'), 'blockeditor');
        // Users and current user id can also be set through the instance
        blockEditorObj.users = [{ id: 'user-1', user: 'John Doe' }];
        blockEditorObj.currentUserId = 'user-1';
    }
</script>
```

N> The `users` collection can be supplied from the server through `ViewBag.Users` (a list of anonymous objects with `id` and `user` properties), or set directly on the client-side instance as shown above.

### Get Active Users

Retrieve all currently connected users.

```cshtml
<script>
    var users = blockEditorObj.users;
</script>
```

## Collaborative Undo and Redo

Undo and redo operations are collaboration-aware.

Only changes made by the current user are included in that user's undo history. Undoing an action does not revert edits made by other collaborators.

## Version History

Version History allows you to capture document snapshots and restore previous versions.

### Configure Snapshot Storage

You need to provide your own custom storage implementation for persisting snapshots by implementing the `IVersionStorage` interface.

```cshtml
<script>
    /**
     * Simple IndexedDB-based storage for version snapshots.
     * Implements IVersionStorage for persistence across browser sessions.
     */
    class CustomVersionStorage {
        // Implement the IVersionStorage interface methods
    }
</script>
```

### Enable Version History

```cshtml
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("onCreated").Render()
</div>

<script>
    var blockEditorObj;
    var myStorage = new CustomVersionStorage('blockeditor-' + uniqueId);

    function onCreated() {
        blockEditorObj = ej.base.getComponent(document.getElementById('block-editor'), 'blockeditor');
        blockEditorObj.collaborationSettings = {
            adapter: adapter,
            provider: provider,
            versionHistory: {
                storage: myStorage,
                snapshotInterval: 3000 // 3 seconds debounce
            }
        };
    }
</script>
```

You must inject the VersionHistory module into the Block Editor.

```cshtml
<script>
    ej.blockeditor.BlockEditor.Inject(ej.blockeditor.VersionHistory);
</script>
```

### Wait for Initialization

Once BlockEditor has been initialized, you can get the version history instance from the editor.

```cshtml
<script>
    var versionHistory = blockEditorObj.getVersionHistory();
</script>
```

Snapshots are loaded asynchronously from the configured storage.

```cshtml
<script>
    versionHistory.whenReady().then(function () {
        // Snapshots are now loaded and ready to use
    });
</script>
```

### Version history methods

#### Creating a Snapshot

```cshtml
<script>
    versionHistory.createSnapshot({
        label: 'Before major update',
        modifiedBy: currentUserId
    }).then(function (snapshot) {
        console.log(snapshot.id);
    });
</script>
```

#### Listing Snapshots

```cshtml
<script>
    var snapshots = versionHistory.getSnapshots();
</script>
```

For large histories:

```cshtml
<script>
    var snapshots = versionHistory.getSnapshots(20, 40);
</script>
```

#### Renaming a Snapshot

```cshtml
<script>
    versionHistory.renameSnapshot(snapshotId, 'Release Candidate').then(function () {
        // Snapshot renamed
    });
</script>
```

#### Restoring a Snapshot

```cshtml
<script>
    versionHistory.restoreSnapshot(snapshotId).then(function () {
        // Snapshot restored
    });
</script>
```

When a snapshot is restored, the current document state is automatically backed up before the restore operation is applied.

#### Comparing Versions

```cshtml
<script>
    var diff = versionHistory.compareVersions(snapshotIdA, snapshotIdB);
</script>
```

The returned `VersionDiff` object provides a summary of the differences between the selected versions.

#### Exporting a Snapshot

```cshtml
<script>
    versionHistory.exportSnapshot(snapshotId).then(function (exported) {
        // Store externally or transfer between systems
    });
</script>
```

Exported snapshots can be stored externally or transferred between systems.

#### Importing a Snapshot

```cshtml
<script>
    versionHistory.importSnapshot(exported).then(function (imported) {
        // Snapshot imported
    });
</script>
```

### Snapshot Events

You can respond to version history events through the version history settings.

#### Snapshot Created

```cshtml
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("onCreated").Render()
</div>

<script>
    var blockEditorObj;
    var myStorage = new CustomVersionStorage('blockeditor-' + uniqueId);

    function onCreated() {
        blockEditorObj = ej.base.getComponent(document.getElementById('block-editor'), 'blockeditor');
        blockEditorObj.collaborationSettings = {
            versionHistory: {
                storage: myStorage,
                snapshotCreated: function (args) {
                    var snapshot = args.snapshot;
                    console.log(snapshot.id);
                }
            }
        };
    }
</script>
```

#### Snapshot Restored

```cshtml
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("onCreated").Render()
</div>

<script>
    var blockEditorObj;
    var myStorage = new CustomVersionStorage('blockeditor-' + uniqueId);

    function onCreated() {
        blockEditorObj = ej.base.getComponent(document.getElementById('block-editor'), 'blockeditor');
        blockEditorObj.collaborationSettings = {
            versionHistory: {
                storage: myStorage,
                snapshotRestored: function (args) {
                    var snapshot = args.snapshot;
                    var backupSnapshot = args.backupSnapshot;
                    console.log(snapshot.label);
                }
            }
        };
    }
</script>
```

## Collaboration Settings

The following properties are available in `CollaborationSettingsModel`.

| Property          | Type                          | Description                                               |
| ----------------- | ----------------------------- | --------------------------------------------------------- |
| `adapter`         | `CollaborationAdapter`        | Provides the Yjs runtime and shared fragment.             |
| `provider`        | `any`                         | Real-time transport used to synchronize document changes. |
| `enableAwareness` | `boolean`                     | Enables user presence, remote cursors, and selections.    |
| `versionHistory`  | `VersionHistorySettingsModel` | Enables document version history support.                 |

## Best Practices

### Use Stable Room Identifiers

Use a unique document identifier as the collaboration room name.

```cshtml
<script>
    var roomName = documentId;
</script>
```

### Persist Snapshots

Store snapshots in a database or cloud storage to preserve version history across sessions.

### Enable Awareness Only When Needed

Disable awareness features when user presence information is not required.

### Use WebSocket-Based Providers in Production

WebSocket providers offer reliable synchronization and are recommended for production deployments.

## Troubleshooting

### Changes Are Not Synchronizing

Verify that:

* All users are connected to the same room.
* The provider connection is active.
* The shared Yjs document is correctly configured.

### Remote Cursors Are Not Visible

Verify that:

* `enableAwareness` is enabled.
* The provider supports awareness.
* User information has been configured in the editor.

### Version History Is Not Available

Verify that:

* VersionHistory Module is injected into the editor.
* A valid storage implementation is configured.
* Snapshot initialization has completed by calling `whenReady()`.
