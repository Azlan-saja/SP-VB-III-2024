<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_data_mahasiswa
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
        Me.tb_nirm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_jenis_kelamin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_nomor_whatsapp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.b_create = New System.Windows.Forms.Button()
        Me.b_update = New System.Windows.Forms.Button()
        Me.b_delete = New System.Windows.Forms.Button()
        Me.b_cancel = New System.Windows.Forms.Button()
        Me.lv_mahasiswa = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_cari = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIRM"
        '
        'tb_nirm
        '
        Me.tb_nirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nirm.Location = New System.Drawing.Point(267, 20)
        Me.tb_nirm.Name = "tb_nirm"
        Me.tb_nirm.Size = New System.Drawing.Size(387, 38)
        Me.tb_nirm.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'tb_nama
        '
        Me.tb_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nama.Location = New System.Drawing.Point(267, 83)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(768, 38)
        Me.tb_nama.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Kelamin"
        '
        'cb_jenis_kelamin
        '
        Me.cb_jenis_kelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jenis_kelamin.FormattingEnabled = True
        Me.cb_jenis_kelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cb_jenis_kelamin.Location = New System.Drawing.Point(268, 145)
        Me.cb_jenis_kelamin.Name = "cb_jenis_kelamin"
        Me.cb_jenis_kelamin.Size = New System.Drawing.Size(231, 39)
        Me.cb_jenis_kelamin.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nomor Whatsapp"
        '
        'tb_nomor_whatsapp
        '
        Me.tb_nomor_whatsapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nomor_whatsapp.Location = New System.Drawing.Point(267, 204)
        Me.tb_nomor_whatsapp.Name = "tb_nomor_whatsapp"
        Me.tb_nomor_whatsapp.Size = New System.Drawing.Size(312, 38)
        Me.tb_nomor_whatsapp.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Alamat"
        '
        'tb_alamat
        '
        Me.tb_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_alamat.Location = New System.Drawing.Point(268, 259)
        Me.tb_alamat.Multiline = True
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(588, 144)
        Me.tb_alamat.TabIndex = 1
        '
        'b_create
        '
        Me.b_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_create.Location = New System.Drawing.Point(267, 433)
        Me.b_create.Name = "b_create"
        Me.b_create.Size = New System.Drawing.Size(132, 44)
        Me.b_create.TabIndex = 3
        Me.b_create.Text = "Create"
        Me.b_create.UseVisualStyleBackColor = True
        '
        'b_update
        '
        Me.b_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_update.Location = New System.Drawing.Point(405, 433)
        Me.b_update.Name = "b_update"
        Me.b_update.Size = New System.Drawing.Size(132, 44)
        Me.b_update.TabIndex = 3
        Me.b_update.Text = "Update"
        Me.b_update.UseVisualStyleBackColor = True
        '
        'b_delete
        '
        Me.b_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_delete.Location = New System.Drawing.Point(703, 433)
        Me.b_delete.Name = "b_delete"
        Me.b_delete.Size = New System.Drawing.Size(132, 44)
        Me.b_delete.TabIndex = 3
        Me.b_delete.Text = "Delete"
        Me.b_delete.UseVisualStyleBackColor = True
        '
        'b_cancel
        '
        Me.b_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_cancel.Location = New System.Drawing.Point(903, 433)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(132, 44)
        Me.b_cancel.TabIndex = 3
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'lv_mahasiswa
        '
        Me.lv_mahasiswa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv_mahasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_mahasiswa.FullRowSelect = True
        Me.lv_mahasiswa.GridLines = True
        Me.lv_mahasiswa.Location = New System.Drawing.Point(19, 546)
        Me.lv_mahasiswa.Name = "lv_mahasiswa"
        Me.lv_mahasiswa.Size = New System.Drawing.Size(1016, 176)
        Me.lv_mahasiswa.TabIndex = 4
        Me.lv_mahasiswa.UseCompatibleStateImageBehavior = False
        Me.lv_mahasiswa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NIRM"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama"
        Me.ColumnHeader3.Width = 500
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(262, 493)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(297, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cari Nirm atau Nama"
        '
        'tb_cari
        '
        Me.tb_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cari.Location = New System.Drawing.Point(577, 493)
        Me.tb_cari.Name = "tb_cari"
        Me.tb_cari.Size = New System.Drawing.Size(458, 38)
        Me.tb_cari.TabIndex = 1
        '
        'f_data_mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 734)
        Me.Controls.Add(Me.lv_mahasiswa)
        Me.Controls.Add(Me.b_cancel)
        Me.Controls.Add(Me.b_delete)
        Me.Controls.Add(Me.b_update)
        Me.Controls.Add(Me.b_create)
        Me.Controls.Add(Me.cb_jenis_kelamin)
        Me.Controls.Add(Me.tb_cari)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_nomor_whatsapp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_nirm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f_data_mahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_nirm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_jenis_kelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_nomor_whatsapp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_alamat As System.Windows.Forms.TextBox
    Friend WithEvents b_create As System.Windows.Forms.Button
    Friend WithEvents b_update As System.Windows.Forms.Button
    Friend WithEvents b_delete As System.Windows.Forms.Button
    Friend WithEvents b_cancel As System.Windows.Forms.Button
    Friend WithEvents lv_mahasiswa As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_cari As System.Windows.Forms.TextBox

End Class
