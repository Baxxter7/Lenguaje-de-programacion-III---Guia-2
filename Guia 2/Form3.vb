'Nombre: Josue Isaias Martinez
'N° cuenta: 20201002923
'3. Dado un arreglo de 10 posiciones, desarrolle un programa que asigne a cada elemento del 
'arreglo un valor par desde 0 a 20. En otras palabras, su arreglo deberá quedar de la siguiente 
'manera a[2,4,6,8,10,12,14,16,18,20]

Public Class Form3
    Private Sub Accion_Click(sender As Object, e As EventArgs) Handles Accion.Click
        Dim a(9) As Integer
        Dim i As Integer

        For i = 0 To a.Length - 1 Step 1
            a(i) = 2 + (2 * i)
        Next

        'MsgBox(a.Length)
        For i = 0 To a.Length - 1
            MsgBox(a(i))
        Next
    End Sub
End Class