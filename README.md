<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/874182000/24.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1259172)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# DevExpress Blazor TreeList – Implement batch data editing using Entity Framework Core

This example introduces batch data editing support when using Microsoft [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) in your DevExpress-powered Blazor app.

![Batch Editing in DevExpress Blazor TreeList](/images/batch-editing.gif)

Our sample uses [DbContext](https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext) to obtain and update [DevExpress Blazor TreeList](https://docs.devexpress.com/Blazor/404942/treelist) data. When a user creates a new row or modifies/deletes an existing row, a [DbContext](https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext) instance tracks changes made to underlying data. End users can press **Save** to record all changes made within this context or press **Cancel** to dispose the context and discard accumulated changes.

The [CustomizeElement](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeElement) event handler uses the [DbContext.ChangeTracker](https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.changetracker#microsoft-entityframeworkcore-dbcontext-changetracker) property to identify and highlight modified cells.

## Files to Review

* [Index.razor](./CS/TreeListBatchEditing/Components/Pages/Index.razor)
* [Index.razor.css](./CS/TreeListBatchEditing/Components/Pages/Index.razor.css)

## Documentation

- [Cell Editing in Blazor TreeList](https://docs.devexpress.com/Blazor/405166/components/treelist/editing-and-validation/edit-modes/edit-cell)
- [Edit Model in Blazor TreeList](https://docs.devexpress.com/Blazor/405170/components/treelist/editing-and-validation/edit-model)

## More Examples

- [Getting Started with the Blazor TreeList](https://github.com/DevExpress-Examples/blazor-treelist-get-started)
- [How to bind the component to DevExtreme data source with Entity Framework Core](https://github.com/DevExpress-Examples/blazor-treelist-bind-to-server-side-data)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-treelist-batch-editing&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-treelist-batch-editing&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
