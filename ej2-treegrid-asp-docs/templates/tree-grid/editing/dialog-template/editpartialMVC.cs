@model MVCApplication.Models.TreeGridData
@*//define the model for store the model values*@

@using Syncfusion.EJ2
@using Syncfusion.EJ2.DropDowns

<div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <div class="e-float-input e-control-wrapper">
                <input value=@Model.TaskId name="TaskId" disabled type='text' />
                <span class="e-float-line"></span>
                <label asp-for="TaskId" class="e-float-text e-label-top">Task ID</label>
            </div>
        </div>
        <div class="form-group col-md-6">
            <div class="e-float-input e-control-wrapper">
                <input name="TaskName" value=@Model.TaskName.ToString() />
                <span class="e-float-line"></span>
                <label asp-for="TaskName" class="e-float-text e-label-top">Task Name</label>
            </div>
        </div>
    </div>

    <div class="form-row">
        <div class="form-group col-md-6">
            @Html.EJS().NumericTextBox("Progress").Value(Model.Progress).Format("C2").Placeholder("Progress").Render()
        </div>
        <div class="form-group col-md-6">
            @Html.EJS().DatePicker("StartDate").Value(Model.StartDate).Placeholder("Start Date").Render()
        </div>
    </div>

    <div class="form-row">
        <div class="form-group col-md-12">
            @Html.EJS().CheckBox("Approved").Checked(Model.Approved).Label("Approved").Render()
        </div>
    </div>
</div>

@Html.EJS().ScriptManager()