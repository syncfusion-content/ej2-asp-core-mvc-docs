<div class="col-lg-12 control-section e-img-editor-sample">
    @Html.EJS().ImageEditor("image-editor").Created("created").Toolbar(new string[] { }).Render()
</div>
@Html.EJS().Button("matbtnClick").CssClass("e-primary").Content("Chrome").Click("matClick").Render()
@Html.EJS().Button("bevelbtnClick").CssClass("e-primary").Content("Cold").Click("bevelClick").Render()
@Html.EJS().Button("linebtnClick").CssClass("e-primary").Content("Warm").Click("lineClick").Render()
@Html.EJS().Button("insetbtnClick").CssClass("e-primary").Content("GrayScale").Click("insetClick").Render()
@Html.EJS().Button("hookbtnClick").CssClass("e-primary").Content("Hook").Click("hookClick").Render()

<script>
    function created() {
        var imageEditorObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        if (ej.base.Browser.isDevice) {
            imageEditorObj.open('https://ej2.syncfusion.com/demos/src/image-editor/images/flower.png');
        } else {
            imageEditorObj.open('https://ej2.syncfusion.com/demos/src/image-editor/images/bridge.png');
        }
    }

    function matClick() {
        var imgObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        imgObj.drawFrame(FrameType.Mat, 'red', 'blue', 20, 20, 20, 20, 'solid', 1);
    }
    function bevelClick() {
        var imgObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        imgObj.drawFrame(FrameType.Bevel, 'red', 'blue', 20, 20, 20, 20, 'solid', 1);
    }
    function lineClick() {
        var imgObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        imgObj.drawFrame(FrameType.Line, 'red', 'blue', 20, 20, 20, 20, 'solid', 1);
    }
    function insetClick() {
        var imgObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        imgObj.drawFrame(FrameType.Inset, 'red', 'blue', 20, 20, 20, 20, 'solid', 1);
    }
    function hookClick() {
        var imgObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        imgObj.drawFrame(FrameType.Hook, 'red', 'blue', 20, 20, 20, 20, 'solid', 1);
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