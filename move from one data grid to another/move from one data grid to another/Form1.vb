Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dgvcID As New DataGridViewTextBoxColumn()
        dgvcID.HeaderText = "Id"
        Dim dgvcFn As New DataGridViewTextBoxColumn()
        dgvcFn.HeaderText = "First Name"
        Dim dgvcLn As New DataGridViewTextBoxColumn()
        dgvcLn.HeaderText = "Last Name"
        Dim dgvcCheckBox As New DataGridViewCheckBoxColumn()
        dgvcCheckBox.HeaderText = "Select"

        DataGridView1.Columns.Add(dgvcID)
        DataGridView1.Columns.Add(dgvcFn)
        DataGridView1.Columns.Add(dgvcLn)
        DataGridView1.Columns.Add(dgvcCheckBox)

        DataGridView1.Rows.Add("1", "donald", "trump", False)
        DataGridView1.Rows.Add("2", "doald", "rump", False)
        DataGridView1.Rows.Add("3", "nald", "ump", False)
        DataGridView1.Rows.Add("4", "hhnald", "trmp", False)
        DataGridView1.Rows.Add("5", "oonald", "tump", False)
        DataGridView1.Rows.Add("6", "iinald", "truymp", False)
        DataGridView1.Rows.Add("7", "dttonald", "truymp", False)
        DataGridView1.Rows.Add("8", "dhyonald", "truhymp", False)
        DataGridView1.Rows.Add("9", "donyald", "tryyump", False)
        DataGridView1.Rows.Add("10", "doynald", "tryump", False)
        DataGridView1.Rows.Add("11", "donahyld", "trumyp", False)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToAddRows = False

        Dim dgvcID2 As New DataGridViewTextBoxColumn()
        dgvcID2.HeaderText = "Id"
        Dim dgvcFn2 As New DataGridViewTextBoxColumn()
        dgvcFn2.HeaderText = "First Name"
        Dim dgvcLn2 As New DataGridViewTextBoxColumn()
        dgvcLn2.HeaderText = "Last Name"
        Dim dgvcCheckBox2 As New DataGridViewCheckBoxColumn()
        dgvcCheckBox2.HeaderText = "Select"

        DataGridView2.Columns.Add(dgvcID2)
        DataGridView2.Columns.Add(dgvcFn2)
        DataGridView2.Columns.Add(dgvcLn2)
        DataGridView2.Columns.Add(dgvcCheckBox2)
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AllowUserToAddRows = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            Dim rowAlreadyExist As Boolean = False
            Dim Check As Boolean = DataGridView1.Rows(i).Cells(3).Value

            If Check = True Then

                If DataGridView2.Rows.Count() > 0 Then

                    For j As Integer = 0 To DataGridView2.Rows.Count() - 1 Step +1
                        If row.Cells(0).Value.ToString() = DataGridView2.Rows(j).Cells(0).Value.ToString() Then
                            rowAlreadyExist = True
                            Exit For
                        End If
                    Next

                    If rowAlreadyExist = False Then
                        DataGridView2.Rows.Add(row.Cells(0).Value.ToString(),
                                               row.Cells(1).Value.ToString(),
                                               row.Cells(2).Value.ToString(),
                                               row.Cells(3).Value)
                    End If

                Else
                    DataGridView2.Rows.Add(row.Cells(0).Value.ToString(),
                                            row.Cells(1).Value.ToString(),
                                            row.Cells(2).Value.ToString(),
                                            row.Cells(3).Value)

                End If
            End If


        Next
    End Sub
End Class
