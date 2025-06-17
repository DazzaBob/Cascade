' Added just for readablity sake, the main class gets confusing to read with all the UI elements.
Namespace ModelDevelopment
    Partial Class FORM_MODELDEVELOPMENT
        Private Sub CMS_TC_MAIN_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMS_TC_MAIN.Opening
            If e.Cancel Then Return
            If Me.TC_Main.SelectedTab Is Nothing Then e.Cancel = True : Return
            Me.CMSTabControl_SaveThis.Text = "Save " & Me.TC_Main.SelectedTab.Text
            Me.CMSTabControl_CloseAllButThis.Text = "Close all but " & Me.TC_Main.SelectedTab.Text
            Me.CMSTabControl_Close.Text = "Close " & Me.TC_Main.SelectedTab.Text
        End Sub
        Private Sub CMS_TC_MAIN_Close_Click(sender As Object, e As EventArgs) Handles CMSTabControl_Close.Click
            Me.Cursor = Cursors.WaitCursor
            Dim TP As UserControls.TabPage = Me.TC_Main.SelectedTab
            Me.TC_Main.TabPages.Remove(TP)
            TP.Dispose() : TP = Nothing
            '
            If Me.TC_Main.TabPages.Count > 0 Then Me.TC_Main.SelectedTab = Me.TC_Main.TabPages(0)
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_TC_MAIN_CloseAllModels_Click(sender As Object, e As EventArgs) Handles CMSTabControlCloseAll.Click
            Me.Cursor = Cursors.WaitCursor
            '
            For Each TabPage As TabPage In Me.TC_Main.TabPages
                TabPage.Controls(0).Dispose()
                Me.TC_Main.TabPages.Remove(TabPage)
                TabPage.Dispose() : TabPage = Nothing
            Next
            Me.TV_MODELS.SelectedNode = Me.TV_MODELS.Nodes(0)
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_TC_MAIN_CloseAllButThis_Click(sender As Object, e As EventArgs) Handles CMSTabControl_CloseAllButThis.Click
            Me.Cursor = Cursors.WaitCursor
            '
            For Each TabPage As UserControls.TabPage In Me.TC_Main.TabPages
                If TabPage Is Me.TC_Main.SelectedTab Then Continue For
                '
                Me.TC_Main.TabPages.Remove(TabPage)
                TabPage.Dispose() : TabPage = Nothing
            Next
            '
            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace