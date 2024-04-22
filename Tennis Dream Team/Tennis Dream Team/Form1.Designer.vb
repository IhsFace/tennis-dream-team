<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        txtBirthDate = New TextBox()
        txtCountry = New TextBox()
        txtName = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btnSave = New Button()
        btnClear = New Button()
        Label7 = New Label()
        btnShow = New Button()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        lstNames = New ListBox()
        lstCountries = New ListBox()
        lstBirthDates = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(849, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(392, 59)
        Label1.TabIndex = 0
        Label1.Text = "Tennis Dream Team"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(345, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(286, 51)
        Label2.TabIndex = 1
        Label2.Text = "Add New Player"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtBirthDate)
        GroupBox1.Controls.Add(txtCountry)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(80, 178)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(824, 339)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter Player Details"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(540, 255)
        Label6.Name = "Label6"
        Label6.Size = New Size(243, 32)
        Label6.TabIndex = 6
        Label6.Text = "Enter as dd-mm-yyyy"
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.Location = New Point(228, 255)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.Size = New Size(306, 39)
        txtBirthDate.TabIndex = 5
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(228, 165)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(555, 39)
        txtCountry.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(228, 67)
        txtName.Name = "txtName"
        txtName.Size = New Size(555, 39)
        txtName.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(44, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 32)
        Label5.TabIndex = 2
        Label5.Text = "Birth Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(44, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 32)
        Label4.TabIndex = 1
        Label4.Text = "Country"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 32)
        Label3.TabIndex = 0
        Label3.Text = "Player Name"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(565, 563)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 46)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(754, 563)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14F)
        Label7.Location = New Point(1332, 94)
        Label7.Name = "Label7"
        Label7.Size = New Size(355, 51)
        Label7.TabIndex = 5
        Label7.Text = "Players - SUMMARY"
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(1438, 563)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(150, 46)
        btnShow.TabIndex = 6
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lstBirthDates)
        GroupBox2.Controls.Add(lstCountries)
        GroupBox2.Controls.Add(lstNames)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Location = New Point(1145, 204)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(765, 336)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Summary"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(78, 52)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 32)
        Label8.TabIndex = 0
        Label8.Text = "NAME"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(304, 52)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 32)
        Label9.TabIndex = 1
        Label9.Text = "COUNTRY"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(546, 52)
        Label10.Name = "Label10"
        Label10.Size = New Size(131, 32)
        Label10.TabIndex = 2
        Label10.Text = "BIRTHDATE"
        ' 
        ' lstNames
        ' 
        lstNames.FormattingEnabled = True
        lstNames.Location = New Point(6, 104)
        lstNames.Name = "lstNames"
        lstNames.Size = New Size(240, 164)
        lstNames.TabIndex = 3
        ' 
        ' lstCountries
        ' 
        lstCountries.FormattingEnabled = True
        lstCountries.Location = New Point(264, 104)
        lstCountries.Name = "lstCountries"
        lstCountries.Size = New Size(240, 164)
        lstCountries.TabIndex = 4
        ' 
        ' lstBirthDates
        ' 
        lstBirthDates.FormattingEnabled = True
        lstBirthDates.Location = New Point(525, 104)
        lstBirthDates.Name = "lstBirthDates"
        lstBirthDates.Size = New Size(240, 164)
        lstBirthDates.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1974, 729)
        Controls.Add(GroupBox2)
        Controls.Add(btnShow)
        Controls.Add(Label7)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Tennis Dream Team"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBirthDate As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstBirthDates As ListBox
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents lstNames As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label

End Class
