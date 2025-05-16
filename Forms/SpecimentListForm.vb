Public Class SpecimentListForm
    Private Sub timerNowTime_Tick(sender As Object, e As EventArgs) Handles timerNowTime.Tick
        lblNowTime.Text = DateTime.Now.ToString("HH.mm.ss WITA")
    End Sub

    Private Sub GuestHomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNowTime.Text = DateTime.Now.ToString("HH.mm.ss WITA")
        'AddHandler ItemSpecimentControl.Click, AddressOf UserControl_Click
    End Sub
    'Private Sub UserControl_Click(sender As Object, e As EventArgs)
    '    MessageBox.Show("UserControl diklik!")
    'End Sub

End Class