'Nombre: Josue Isaias Martinez
'N° cuenta: 20201002923
'1. Dado el siguiente arreglo a[4,2,5,6,4,2,5,6], desarrolle un programa que indique si la primera 
'mitad del mismo es igual a la segunda mitad.

Public Class Form1
    Private Sub Accion_Click(sender As Object, e As EventArgs) Handles Accion.Click
        Dim a = {4, 2, 5, 6, 1, 4, 2, 5, 6, 2}
        Dim mitad, i As Integer
        Dim flag As Boolean = False

        mitad = a.Length / 2

        For i = 0 To mitad - 1 Step 1
            If a(i) <> a(mitad + i) Then
                MsgBox("Las mitades no son iguales")
                Exit Sub
            Else
                flag = True
            End If
        Next

        If flag = True Then
            MsgBox("Las mitades son iguales")
        End If
    End Sub
End Class
