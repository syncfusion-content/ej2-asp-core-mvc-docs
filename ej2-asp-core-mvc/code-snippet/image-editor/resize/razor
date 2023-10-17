<div class="col-lg-12 control-section e-img-editor-sample">
    @Html.EJS().ImageEditor("image-editor").Created("created").Toolbar(new string[] { }).Render()
</div>
@Html.EJS().Button("aspectbtnClick").CssClass("e-primary").Content("Aspect ratio").Click("aspectClick").Render()
@Html.EJS().Button("nonaspectbtnClick").CssClass("e-primary").Content("Non Aspect Ratio").Click("nonaspectClick").Render()

<script>
    function created() {
        var imageEditorObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        if (ej.base.Browser.isDevice) {
            imageEditorObj.open('https://ej2.syncfusion.com/demos/src/image-editor/images/flower.png');
        } else {
            imageEditorObj.open('https://ej2.syncfusion.com/demos/src/image-editor/images/bridge.png');
        }
    }

    function aspectClick() {
        var imgObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        imgObj.resize(300, 400, true);
    }
    function nonaspectClick() {
        var imgObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        imgObj.resize(300, 400, false);
    }

</script>

<style>
    .image-editor {
        margin: 0 auto;
    }

    .e-img-editor-sample {
        height: 80vh;
        width: 100%;
    }

    @@media only screen and (max-width: 700px) {
        .e-img-editor-sample {
            height: 75vh;
            width: 100%;
        }
    }

    .control-wrapper {
        height: 100%;
    }
</style>