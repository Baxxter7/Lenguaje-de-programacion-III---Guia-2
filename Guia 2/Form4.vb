'Nombre: Josue Isaias Martinez
'N° cuenta: 20201002923
'4. Dado un arreglo de 10 posiciones, desarrolle un programa que asigne a cada elemento del 
'arreglo un valor impar desde 0 a 20. En otras palabras, su arreglo deberá quedar de la 
'siguiente manera a[1,3,5,7,9,11,13,15,17,19]
Public Class Form4
    Private Sub Accion_Click(sender As Object, e As EventArgs) Handles Accion.Click
        Dim a(9) As Integer
        Dim i As Integer

        For i = 0 To a.Length - 1 Step 1
            a(i) = 1 + (2 * i)
        Next

        'MsgBox(a.Length)
        For i = 0 To a.Length - 1
            MsgBox(a(i))
        Next
    End Sub
End Class