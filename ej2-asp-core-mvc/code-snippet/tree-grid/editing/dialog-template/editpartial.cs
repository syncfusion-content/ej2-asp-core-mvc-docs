@model TestApplication.Models.TreeData

@*//define the model for store the model values*@

@using Syncfusion.EJ2

<div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <div class="e-float-input e-control-wrapper">
                <input asp-for="TaskId" value=@Model.TaskId.ToString() disabled type='text' name="TaskId" />
                <span class="e-float-line"></span>
                <label asp-for="TaskId" class="e-float-text e-label-top">Task ID</label>
            </div>
        </div>
        <div class="form-group col-md-6">
            <div class="e-float-input e-control-wrapper">
                <input asp-for="TaskName" name="TaskName" value=@Model.TaskName />
                <span class="e-float-line"></span>
                <label asp-for="TaskName" class="e-float-text e-label-top">Task Name</label>
            </div>
        </div>
    </div>

    <div class="form-row">
        <div class="form-group col-md-6">
            <ejs-numerictextbox id="Progress" value=@Model.Progress format="C2" placeholder="Progress" floatLabelType="Always"></ejs-numerictextbox>
        </div>
        <div class="form-group col-md-6">
            <ejs-datepicker id="StartDate" value=@Model.StartDate placeholder="Start Date" floatLabelType="Always"></ejs-datepicker>
        </div>
    </div>

    <div class="form-row">
        <div class="form-group col-md-12">
            <ejs-checkbox checked="@Model.Approved" label="Approved" id="Approved"></ejs-checkbox>
        </div>
    </div>
</div>

<ejs-scripts></ejs-scripts>