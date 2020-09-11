@ModelType ModelLayer.MELUser
@Code
    ViewData("Title") = "UserDetails"
End Code

<h2>UserDetails</h2>

<div>
    <h4>MELUser</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.UserID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Password)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

    </dl>
</div>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
