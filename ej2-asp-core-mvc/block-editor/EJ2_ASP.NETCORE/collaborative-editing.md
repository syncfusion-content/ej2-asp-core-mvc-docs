---
layout: post
title: Collaborative Editing in ASP.NET Core Block Editor | Syncfusion
description: Checkout and learn about Collaborative Editing with Syncfusion Essential ASP.NET Core BlockEditor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Collaborative Editing in ASP.NET Core Block Editor control

The Block Editor supports real-time collaborative editing, enabling multiple users to work on the same document simultaneously. Collaboration is powered by **Yjs**, a Conflict-free Replicated Data Type (CRDT) framework that synchronizes document changes across all connected users and automatically resolves conflicts.

With collaboration enabled, users can:

* Edit the same document in real time.
* View remote user cursors and selections.
* Track active collaborators.
* Perform collaboration-aware undo and redo operations.
* Create, restore, compare, export, and import document versions.

## Prerequisites

Before enabling collaboration, install the `yjs` library and a Yjs provider. See [Yjs Providers](https://docs.yjs.dev/ecosystem/connection-provider) to choose the right provider for your use case.

## Yjs Providers

A Yjs provider handles the transport of document updates between connected users. Choose a provider based on your deployment requirements.

| Provider | Type | Use Case |
| -------- | ---- | -------- |
| `y-websocket` | Self-hosted | Production deployments with your own WebSocket server. |
| `y-webrtc` | Peer-to-peer | Quick local testing and development; no server required. |
| `y-indexeddb` | Local storage | Offline persistence within a single browser. |
| [Hocuspocus](https://tiptap.dev/docs/hocuspocus/getting-started/overview) | Open-source server | Scalable Node.js server with pluggable storage and Redis support. |
| [Liveblocks](https://liveblocks.io/) | Fully managed | Hosted WebSocket infrastructure with REST API and DevTools. |
| [PartyKit](https://www.partykit.io/) | Serverless | Serverless provider on Cloudflare; ideal for prototyping. |

> **Note:** For development and testing, `y-webrtc` or PartyKit allow you to get started without a server. For production, use `y-websocket` or a managed provider such as Liveblocks or Hocuspocus for reliable, persistent synchronization.

## Configure collaboration settings

Use the `collaborationSettings` property of type `CollaborationSettingsModel` to configure collaboration settings for your Block Editor. It provides the following properties that allow you to customize the collaboration behavior:

| Property | Type | Description |
| -------- | ---- | ----------- |
| `provider` | `any` | Real-time transport used to synchronize document changes. |
| `enableAwareness` | `boolean` | Enables user presence, remote cursors, and text selection overlays. |
| `adapter` | `CollaborationAdapter` | Provides the Yjs runtime and shared XML fragment. |
| `versionHistory` | `VersionHistorySettingsModel` | Configures document version history support. |

## Getting Started

The following steps will help you set up real-time collaboration in the Block Editor using `Yjs`.

### Step 1: Create a Yjs document

Create a shared Yjs document and XML fragment.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    // Create a shared Yjs document and fragment
    var yDoc = new Y.Doc();
    var yFragment = yDoc.getXmlFragment('blockeditor');
</script>

{% endhighlight %}
{% endtabs %}

### Step 2: Create a Yjs adapter

Create an adapter that provides the Yjs runtime and the shared fragment to the Block Editor.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    var adapter = new ej.blockeditor.YjsAdapter({
        yRuntime: Y,
        yXmlFragment: yFragment
    });
</script>

{% endhighlight %}
{% endtabs %}

### Step 3: Configure a provider

Create a provider that connects users to the same shared document. The following example uses `y-websocket` for production use. For local development, replace it with `y-webrtc` or a PartyKit provider — no server setup is required.

**Production (y-websocket):**

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    var provider = new WebsocketProvider(
        'wss://your-server-url',
        'document-room-id',
        yDoc
    );
</script>

{% endhighlight %}
{% endtabs %}

**Development (y-webrtc):**

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    var provider = new WebrtcProvider('document-room-id', yDoc);
</script>

{% endhighlight %}
{% endtabs %}

### Step 4: Enable Collaboration

Pass the adapter and provider to the Block Editor through the `collaborationSettings` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-collaborationsettings adapter="adapter" provider="provider">
        </e-blockeditor-collaborationsettings>
    </ejs-blockeditor>
</div>

{% endhighlight %}
{% endtabs %}

## User presence and remote cursors

The Block Editor can display remote cursors, text selection overlays, and user details on hover. To enable these user presence features, set `enableAwareness` to `true` in `collaborationSettings` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-collaborationsettings adapter="adapter" provider="provider" enableAwareness="true">
        </e-blockeditor-collaborationsettings>
    </ejs-blockeditor>
</div>

{% endhighlight %}
{% endtabs %}

## Configure the current user

Set the current user's display name and cursor highlight color using the `users` and `currentUserId` properties. The `avatarBgColor` value is used for that user's remote cursor and text selection overlay.

The following properties are available when configuring users via the `users` property.

| Property | Type | Description |
| -------- | ---- | ----------- |
| `id` | `string` | Unique identifier for the user. |
| `user` | `string` | Display name shown on remote cursors and presence indicators. |
| `avatarBgColor` | `string` | Hex color used for this user's remote cursor and selection highlight. |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor" created="onCreated"></ejs-blockeditor>
</div>

<script>
    var blockEditorObj;

    function onCreated() {
        blockEditorObj = ej.base.getComponent(document.getElementById('block-editor'), 'blockeditor');
        blockEditorObj.users = [{ id: 'user-1', user: 'John Doe', avatarBgColor: '#e74c3c' }];
        blockEditorObj.currentUserId = 'user-1';
    }
</script>

{% endhighlight %}
{% endtabs %}

N> When using the ASP.NET Core Tag Helper, the `users` collection and `currentUserId` can also be passed from the PageModel via `users="@Model.ViewModel.Users"` and `currentUserId="@Model.ViewModel.CurrentUserId"`, or set directly on the client-side instance as shown above.

### Get active users

Retrieve all currently connected users using the `users` property in the block editor.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    var users = blockEditorObj.users;
</script>

{% endhighlight %}
{% endtabs %}

## Version history

`Version History` allows you to capture document snapshots and restore earlier versions. This is a built-in capability of the Block Editor and does not require a third-party service.

### Enable version history

Configure the `versionHistory` property under `collaborationSettings` property by passing the storage instance and snapshot interval as attributes, similar to the `adapter` and `provider` properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-collaborationsettings adapter="adapter" provider="provider" versionHistory="versionHistorySettings">
        </e-blockeditor-collaborationsettings>
    </ejs-blockeditor>
</div>

<script>
    var myStorage = new CustomVersionStorage('blockeditor-' + uniqueId);

    var versionHistorySettings = {
        storage: myStorage,
        snapshotInterval: 3000
    };
</script>

{% endhighlight %}
{% endtabs %}

### Access the version history instance

After the Block Editor initializes, retrieve the version history instance and wait for snapshot data to load before calling any version history methods.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    var versionHistory = blockEditorObj.getVersionHistory();
    versionHistory.whenReady().then(function () {
        // Snapshots are now loaded and ready to use
    });
</script>

{% endhighlight %}
{% endtabs %}

### Configure snapshot storage

Version snapshots need to be persisted to enable version history across browser sessions. Implement the `IVersionStorage` interface to provide a custom storage backend for managing snapshots. You can use IndexedDB, a backend database, or any other storage solution suitable for your deployment.

The `IVersionStorage` interface defines the following methods:

| Method | Signature | Description |
| ------ | --------- | ----------- |
| `saveSnapshot` | `(snapshot: VersionSnapshot): Promise<void>` | Persist a snapshot. |
| `loadAllSnapshots` | `(): Promise<VersionSnapshot[]>` | Load all persisted snapshots, ordered by timestamp ascending. |
| `loadSnapshot` | `(id: string): Promise<VersionSnapshot \| null>` | Load a single snapshot by id. |
| `deleteSnapshot` | `(id: string): Promise<void>` | Permanently remove a snapshot by id. |
| `clearAll` | `(): Promise<void>` | Remove all snapshots from storage. |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    /**
     * Simple IndexedDB-based storage for version snapshots.
     * Implements IVersionStorage for persistence across browser sessions.
     */
    class CustomVersionStorage {
        // Implement the IVersionStorage interface methods
    }
</script>

{% endhighlight %}
{% endtabs %}

### Methods

#### Create a snapshot

Creates a new snapshot of the current document state with an optional label and metadata.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    versionHistory.createSnapshot({
        label: 'Before major update',
        modifiedBy: currentUserId
    }).then(function (snapshot) {
        console.log(snapshot.id);
    });
</script>

{% endhighlight %}
{% endtabs %}

#### List snapshots

Retrieves all saved snapshots or a paginated subset. Snapshots are returned in chronological order.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    // Retrieve all snapshots
    var snapshots = versionHistory.getSnapshots();

    // Retrieve a paginated subset — getSnapshots(skip, take)
    var snapshots = versionHistory.getSnapshots(20, 40);
</script>

{% endhighlight %}
{% endtabs %}

#### Rename a snapshot

Updates the label or metadata of an existing snapshot without modifying its content.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    versionHistory.renameSnapshot(snapshotId, 'Release Candidate').then(function () {
        // Snapshot renamed
    });
</script>

{% endhighlight %}
{% endtabs %}

#### Restore a snapshot

Reverts the document to a previously saved snapshot state. The current document state is automatically backed up before restoration.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    versionHistory.restoreSnapshot(snapshotId).then(function () {
        // Snapshot restored
    });
</script>

{% endhighlight %}
{% endtabs %}

> **Note:** When a snapshot is restored, the current document state is automatically backed up before the restore operation is applied.

#### Compare versions

Compares two snapshots to identify differences such as added, removed, or modified content.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    var diff = versionHistory.compareVersions(snapshotIdA, snapshotIdB);
</script>

{% endhighlight %}
{% endtabs %}

The returned `VersionDiff` object provides a summary of the differences between the two selected versions.

#### Export a snapshot

Serializes a snapshot into a portable format that can be stored externally or transferred between systems.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    versionHistory.exportSnapshot(snapshotId).then(function (exported) {
        // Store externally or transfer between systems
    });
</script>

{% endhighlight %}
{% endtabs %}

Exported snapshots can be stored externally or transferred between systems.

#### Import a snapshot

Imports a previously exported snapshot back into the version history storage.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    versionHistory.importSnapshot(exported).then(function (imported) {
        // Snapshot imported
    });
</script>

{% endhighlight %}
{% endtabs %}

### Events

Use the following event callbacks in `versionHistory` settings to respond to snapshot lifecycle events.

#### snapshotCreated

Triggered when a new snapshot is created.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-collaborationsettings versionHistory="versionHistorySettings">
        </e-blockeditor-collaborationsettings>
    </ejs-blockeditor>
</div>

<script>

    var versionHistorySettings = {
        storage: myStorage,
        snapshotCreated: onSnapshotCreated
    };

    function onSnapshotCreated(args) {
        var snapshot = args.snapshot;
        console.log(snapshot.id);
    }
</script>

{% endhighlight %}
{% endtabs %}

#### snapshotRestored

Triggered when a snapshot is restored.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-collaborationsettings versionHistory="versionHistorySettings">
        </e-blockeditor-collaborationsettings>
    </ejs-blockeditor>
</div>

<script>

    var versionHistorySettings = {
        storage: myStorage,
        snapshotRestored: onSnapshotRestored
    };

    function onSnapshotRestored(args) {
        var snapshot = args.snapshot;
        var backupSnapshot = args.backupSnapshot;
        console.log(snapshot.label);
    }
</script>

{% endhighlight %}
{% endtabs %}

## Best Practices

* **Use WebRTC or PartyKit for development** — These providers require no server setup and are ideal for local testing and prototyping before moving to a production provider.
* **Use WebSocket-based providers in production** — `y-websocket`, Hocuspocus, or a managed service like Liveblocks provides reliable, low-latency, persistent synchronization at scale.
* **Use stable room identifiers** — Use a unique document ID as the collaboration room name to prevent unintended document sharing between different documents.
* **Persist snapshots externally** — Store snapshots in a database or cloud storage to preserve version history across sessions.
* **Enable awareness selectively** — Disable `enableAwareness` when user presence information is not required to reduce network and processing overhead.

## Troubleshooting

### Changes Are Not Synchronizing

Verify the following:

* All users are connected to the same collaboration room.
* The provider connection is active.
* The shared Yjs document is correctly configured.

### Remote Cursors Are Not Visible

Verify the following:

* `enableAwareness` is set to `true`.
* The configured provider supports the Yjs awareness protocol.
* User information is set via the `users` and `currentUserId` properties.
* Each user has a unique `id` value.

### Remote User Names Are Not Appearing on Cursors

Verify the following:

* The `user` field is populated for all entries in the `users` array.

### Version History Is Not Available

Verify the following:

* A valid `IVersionStorage` implementation is provided through the `versionHistory` settings.
* `whenReady()` has been awaited before accessing snapshots.