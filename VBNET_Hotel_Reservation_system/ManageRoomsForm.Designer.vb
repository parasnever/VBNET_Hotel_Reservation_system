<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageRoomsForm
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
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        ButtonEdit = New Button()
        ButtonRemove = New Button()
        TextBoxPhone = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        ButtonAdd = New Button()
        TextBoxNumber = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        ComboBoxType = New ComboBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(ComboBoxType)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(ButtonEdit)
        Panel1.Controls.Add(ButtonRemove)
        Panel1.Controls.Add(TextBoxPhone)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ButtonAdd)
        Panel1.Controls.Add(TextBoxNumber)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1337, 700)
        Panel1.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.LightGray
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(621, 175)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(704, 503)
        DataGridView1.TabIndex = 16
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.BackColor = Color.BlueViolet
        ButtonEdit.Cursor = Cursors.Hand
        ButtonEdit.FlatStyle = FlatStyle.Flat
        ButtonEdit.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonEdit.ForeColor = Color.White
        ButtonEdit.Location = New Point(201, 544)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(166, 62)
        ButtonEdit.TabIndex = 15
        ButtonEdit.Text = "Edit"
        ButtonEdit.UseVisualStyleBackColor = False
        ' 
        ' ButtonRemove
        ' 
        ButtonRemove.BackColor = Color.BlueViolet
        ButtonRemove.Cursor = Cursors.Hand
        ButtonRemove.FlatStyle = FlatStyle.Flat
        ButtonRemove.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonRemove.ForeColor = Color.White
        ButtonRemove.Location = New Point(386, 544)
        ButtonRemove.Name = "ButtonRemove"
        ButtonRemove.Size = New Size(166, 62)
        ButtonRemove.TabIndex = 14
        ButtonRemove.Text = "Remove"
        ButtonRemove.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPhone.Location = New Point(167, 291)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(385, 34)
        TextBoxPhone.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(72, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 29)
        Label5.TabIndex = 10
        Label5.Text = "Phone:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(87, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 29)
        Label4.TabIndex = 8
        Label4.Text = "Type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 358)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 29)
        Label3.TabIndex = 6
        Label3.Text = "Reserved:"
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.BackColor = Color.BlueViolet
        ButtonAdd.Cursor = Cursors.Hand
        ButtonAdd.FlatStyle = FlatStyle.Flat
        ButtonAdd.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonAdd.ForeColor = Color.White
        ButtonAdd.Location = New Point(31, 544)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(154, 62)
        ButtonAdd.TabIndex = 5
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNumber
        ' 
        TextBoxNumber.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxNumber.Location = New Point(167, 175)
        TextBoxNumber.Name = "TextBoxNumber"
        TextBoxNumber.ReadOnly = True
        TextBoxNumber.Size = New Size(385, 34)
        TextBoxNumber.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(55, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 29)
        Label2.TabIndex = 1
        Label2.Text = "Number:"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1337, 148)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Gold
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft Sans Serif", 43.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1337, 148)
        Label1.TabIndex = 0
        Label1.Text = "Manage Rooms"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBoxType
        ' 
        ComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxType.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxType.FormattingEnabled = True
        ComboBoxType.Location = New Point(167, 236)
        ComboBoxType.Name = "ComboBoxType"
        ComboBoxType.Size = New Size(385, 37)
        ComboBoxType.TabIndex = 17
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.White
        RadioButton1.FlatStyle = FlatStyle.Flat
        RadioButton1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.ForeColor = Color.Green
        RadioButton1.Location = New Point(167, 356)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 33)
        RadioButton1.TabIndex = 18
        RadioButton1.TabStop = True
        RadioButton1.Text = "Yes"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.White
        RadioButton2.FlatStyle = FlatStyle.Flat
        RadioButton2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.ForeColor = Color.Red
        RadioButton2.Location = New Point(274, 356)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(65, 33)
        RadioButton2.TabIndex = 19
        RadioButton2.TabStop = True
        RadioButton2.Text = "No"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' ManageRoomsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1337, 700)
        Controls.Add(Panel1)
        Name = "ManageRoomsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageRoomsForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxType As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
