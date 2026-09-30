# How to enable WaitingGradientEnabled property in ProgressBar cell in WinForms GridControl

This sample demonstrates how to enable the `WaitingGradientEnabled` property for a `ProgressBar` cell in a Syncfusion WinForms `GridControl`.

## Description

In Syncfusion WinForms `GridControl`, a progress bar cell is represented by the `GridProgressBar` control. By default, the waiting gradient animation is disabled. This example shows how to enable it by setting the `WaitingGradientEnabled` property to `true`.

The sample configures the third column as a progress bar cell and then enables the waiting gradient effect for all `GridProgressBar` controls present in the grid.

## Key implementation

```csharp
private void setProgressBar_Click_1(object sender, EventArgs e)
{
    foreach (Control c in this.gridControl1.Controls)
    {
        if (c is GridProgressBar)
        {
            GridProgressBar control = c as GridProgressBar;
            control.WaitingGradientEnabled = true;
        }
    }
}
