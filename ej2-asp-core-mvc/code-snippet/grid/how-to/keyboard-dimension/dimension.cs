@Html.EJS().Grid("Grid").DataSource((IEnumerable<object>)ViewBag.DataSource).AllowPaging().Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width(100).IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width(120).Add();
    col.Field("Freight").HeaderText("Freight").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width(120).Format("C2").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width(150).Add();
}).Load("load").EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Batch); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()

<script>
    function load(args) {
        var instance = document.getElementById('Grid').ej2_instances[0];
        instance.element.addEventListener('mouseup', function (e) {
            if (e.target.classList.contains("e-rowcell")) {
                var index = parseInt(e.target.getAttribute("Index"));
                var colindex = parseInt(e.target.getAttribute("aria-colindex"));
                var field = instance.getColumns()[colindex].field;
                instance.editModule.editCell(index, field);
            };
        });
    }   
</script>