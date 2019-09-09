Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class frmEndGame
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = False
        Dim arr2 As frmSnake.Score_table()
        Using fstream As FileStream = File.OpenRead("test.dat")
            Dim bf As New BinaryFormatter
            arr2 = bf.Deserialize(fstream)
        End Using

        Label2.Text = "Набрано очков: " + arr2(0).Score.ToString
    End Sub

    Private Sub FrmEndGame_ParentChanged(sender As Object, e As EventArgs) Handles MyBase.ParentChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class