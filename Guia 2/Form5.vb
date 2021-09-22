'Nombre: Josue Isaias Martinez
'N° cuenta: 20201002923
'3. Dada la matriz M  
'           1 2 8 9
'           2 1 0 9
'           7 6 1 2
'     ----------      8 9 4 1
'Desarrolle un programa que indique si los valores de la diagonal son todos 1

Public Class Form5
    Private Sub Accion_Click(sender As Object, e As EventArgs) Handles Accion.Click
        'Dim a = {{1, 2, 4}, {2, 1, 0}, {7, 6, 1}}
        'Dim a = {{1, 2, 4, 9}, {2, 1, 0, 9}, {7, 6, 1, 2}, {8, 9, 4, 1}}
        Dim a = {{1, 2, 4, 9}, {2, 1, 0, 9}, {7, 6, 1, 2}}

        Dim i As Integer

        For i = 0 To a.GetUpperBound(0)

            If a(i, i) <> 1 Then
                MsgBox("No son unos en diagonales")
                Exit Sub
            End If
        Next

        'MsgBox("Son 1s en diagonales")
        'a.GetUpperBound(0) --- Devuelve el numero de filas
        'a.GetUpperBound(0) --- Devuelve el numero de columnas
        'Para obtener el valor correcto debemos sumar 1 al valor que nos devuelva este metodo
        MsgBox(Str(a.GetUpperBound(0) + 1) + " Filas")
        MsgBox(Str(a.GetUpperBound(1) + 1) + " Columnas")
    End Sub
End Class