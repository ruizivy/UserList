<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lstUsers = New System.Windows.Forms.ListView()
        Me.clmID = New System.Windows.Forms.ColumnHeader()
        Me.clmLName = New System.Windows.Forms.ColumnHeader()
        Me.clmFName = New System.Windows.Forms.ColumnHeader()
        Me.clmMName = New System.Windows.Forms.ColumnHeader()
        Me.clmAddr = New System.Windows.Forms.ColumnHeader()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name:"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(116, 27)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(208, 27)
        Me.txtLName.TabIndex = 1
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(465, 27)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(208, 27)
        Me.txtFName.TabIndex = 3
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(382, 30)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(87, 20)
        Me.lblFName.TabIndex = 2
        Me.lblFName.Text = "First Name: "
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(800, 27)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(208, 27)
        Me.txtMName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(694, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Middle Name:"
        '
        'txtAddr
        '
        Me.txtAddr.Location = New System.Drawing.Point(116, 88)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(557, 27)
        Me.txtAddr.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Address: "
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(800, 82)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(208, 29)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lstUsers
        '
        Me.lstUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmID, Me.clmLName, Me.clmFName, Me.clmMName, Me.clmAddr})
        Me.lstUsers.FullRowSelect = True
        Me.lstUsers.GridLines = True
        Me.lstUsers.HideSelection = False
        Me.lstUsers.Location = New System.Drawing.Point(28, 192)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(1126, 474)
        Me.lstUsers.TabIndex = 9
        Me.lstUsers.UseCompatibleStateImageBehavior = False
        Me.lstUsers.View = System.Windows.Forms.View.Details
        '
        'clmID
        '
        Me.clmID.Name = "clmID"
        Me.clmID.Text = "ID"
        Me.clmID.Width = 0
        '
        'clmLName
        '
        Me.clmLName.Name = "clmLName"
        Me.clmLName.Text = "Last Name"
        Me.clmLName.Width = 200
        '
        'clmFName
        '
        Me.clmFName.Name = "clmFName"
        Me.clmFName.Text = "First Name"
        Me.clmFName.Width = 200
        '
        'clmMName
        '
        Me.clmMName.Name = "clmMName"
        Me.clmMName.Text = "Middle Name"
        Me.clmMName.Width = 200
        '
        'clmAddr
        '
        Me.clmAddr.Name = "clmAddr"
        Me.clmAddr.Text = "Address"
        Me.clmAddr.Width = 500
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(103, 149)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(208, 27)
        Me.txtSearch.TabIndex = 11
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 687)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUsers"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblFName As Label
    Friend WithEvents txtMName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lstUsers As ListView
    Friend WithEvents clmID As ColumnHeader
    Friend WithEvents clmLName As ColumnHeader
    Friend WithEvents clmFName As ColumnHeader
    Friend WithEvents clmMName As ColumnHeader
    Friend WithEvents clmAddr As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
End Class
