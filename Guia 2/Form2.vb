'Nombre: Josue Isaias Martinez
'N° cuenta: 20201002923
'2. Dado el siguiente arreglo a[2,7,4,9,0,5,0,9,4,7,2], desarrolle un programa que indique si se lee 
'igual de izquierda a derecha que de derecha a izquierda.
Public Class Form2
    Private Sub Accion_Click(sender As Object, e As EventArgs) Handles Accion.Click
        Dim a = {1, 2, 7, 4, 9, 0, 5, 0, 9, 4, 7, 2, 1}
        Dim mitad, i As Integer
        Dim flag As Boolean = False


        mitad = ((a.Length - 1) / 2)

        For i = 0 To mitad - 1 Step 1
            If a(i) = a((a.Length - 1) - i) Then
                MsgBox(Str(a(i)) + " --- " + Str(a((a.Length - 1) - i)))
                flag = True
            Else
                MsgBox(Str(a(i)) + " --- " + Str(a((a.Length - 1) - i)))
                MsgBox("NO se leen igual de izquierda a derecha, NI de derecha a izquierda.")
                Exit Sub
            End If
        Next

        If flag = True Then
            MsgBox("Se leen igual de izquierda a derecha, que de derecha a izquierda.")
        End If
    End Sub
End Class