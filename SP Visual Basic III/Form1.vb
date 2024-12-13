Imports System.Data.OleDb

Public Class f_data_mahasiswa

    Dim perintah_koneksi As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_SP.accdb;"
    Dim koneksi As OleDbConnection = New OleDbConnection(perintah_koneksi)
    Dim perintahSQL As String
    Dim eksekusi As New OleDbCommand
    Dim baca As OleDbDataReader


    Sub clear()
        tb_nirm.Clear()
        tb_nama.Clear()
        cb_jenis_kelamin.Text = ""
        tb_nomor_whatsapp.Clear()
        tb_alamat.Clear()
        Call aturAwal(True, False, False, False, True, True)
        Call tampilTabel()
    End Sub
    Sub aturAwal(ByVal t1 As Boolean, ByVal t2 As Boolean, ByVal t3 As Boolean, ByVal t4 As Boolean, ByVal i1 As Boolean, ByVal i2 As Boolean)
        b_create.Enabled = t1
        b_update.Enabled = t2
        b_delete.Enabled = t3
        b_cancel.Enabled = t4
        tb_nirm.Enabled = i1
        tb_nama.Enabled = i2
        cb_jenis_kelamin.Enabled = i2
        tb_nomor_whatsapp.Enabled = i2
        tb_alamat.Enabled = i2
    End Sub

    

    Private Sub b_create_Click(sender As Object, e As EventArgs) Handles b_create.Click
        Try

            perintahSQL = "Insert into mahasiswas (nirm, nama, jenis_kelamin, nomor_whatsapp, alamat) " & _
                          "values (@nirm, @nama, @jenis_kelamin, @nomor_whatsapp, @alamat)"
            eksekusi = New OleDbCommand(perintahSQL, koneksi)
            eksekusi.Parameters.AddWithValue("@nirm", tb_nirm.Text)
            eksekusi.Parameters.AddWithValue("@nama", tb_nama.Text)
            eksekusi.Parameters.AddWithValue("@jenis_kelamin", cb_jenis_kelamin.Text)
            eksekusi.Parameters.AddWithValue("@nomor_whatsapp", tb_nomor_whatsapp.Text)
            eksekusi.Parameters.AddWithValue("@alamat", tb_alamat.Text)
            eksekusi.ExecuteNonQuery()
            MsgBox("Tambah Baru Berhasil", vbOKOnly, "Create Success")
            Call clear()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Create Error")
     
        End Try
       
    End Sub

    Private Sub f_data_mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Call clear()
    End Sub

    Sub tampilTabel()
        Try

            perintahSQL = "Select *from mahasiswas"
            eksekusi = New OleDbCommand(perintahSQL, koneksi)
            baca = eksekusi.ExecuteReader
            Dim no As Integer = 1
            While baca.Read
                Dim lv As New ListViewItem
                lv.Text = no
                lv.SubItems.Add(baca("nirm"))
                lv.SubItems.Add(baca("nama"))
                lv_mahasiswa.Items.Add(lv)
                no += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Read Error")
        End Try
    End Sub
End Class
