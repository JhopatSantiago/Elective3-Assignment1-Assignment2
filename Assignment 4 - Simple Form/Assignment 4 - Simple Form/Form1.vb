Imports System.IO
Imports System.Xml

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles name_export.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub export_text_Click(sender As Object, e As EventArgs) Handles export_text.Click
        Dim sw1 As StreamWriter
        If fullname.Text <> "" Or age.Text <> "" Or address.Text <> "" Then
            SW1 = File.AppendText("D:\Documents\School Stuff\Fifth Year\2nd Sem\Electives 3\Assignment 4 - Simple Form\txt file\Information.txt")
            SW1.WriteLine("-----------------------------------------")
            SW1.WriteLine("Name: " & fullname.Text)
            SW1.WriteLine("Age: " & age.Text)
            SW1.WriteLine("Address: " & address.Text)
            MsgBox("You have address information in a text file", MsgBoxStyle.Information, "Saved")
            SW1.Close()
        Else
            MsgBox("Please input necessary data in the field", MsgBoxStyle.Critical, "Input data")



        End If
    End Sub

    Private Sub name_TextChanged(sender As Object, e As EventArgs) Handles fullname.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles xml_export.Click
        Dim writer As New XmlTextWriter("Information.xml", System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)

    End Sub
End Class
