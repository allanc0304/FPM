Public Class AddCollectionList

    Private Sub btnLoad_Click(sender As Object, e As EventArgs)
        'Dim con As New SqlConnection("Data Source=databasename; User ID=username; Password=******")
        'Dim comm As New SqlCommand("select * from Loan_Info", con)
        'Dim sd As New SqlDataAdapter(comm)
        'Dim dt As New DataTable
        'sd.Fill(dt)
        'DataGridView1.DataSource.dt
    End Sub
    Private headerChk As CheckBox = New CheckBox()
    Private Sub AddCollectionList_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim headerlocation As Point = DataGridView1.GetCellDisplayRectangle(0, -1, True).Location
        headerChk.Location = New Point(headerlocation.X + 18, headerlocation.Y + 2)
        headerChk.Size = New Size(15, 15)
        headerChk.BackColor = Color.White
        AddHandler headerChk.Click, AddressOf HeaderChk_Clicked
        DataGridView1.Controls.Add(headerChk)

    End Sub

    Private Sub HeaderChk_Clicked(sender As Object, e As EventArgs)
        For Each Row As DataGridViewRow In DataGridView1.Rows
            Dim chkbox As DataGridViewCheckBoxCell = (TryCast(Row.Cells("chk"), DataGridViewCheckBoxCell))
            chkbox.Value = headerChk.Checked
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyyy       hh:mm:ss tt")
    End Sub

End Class