Attribute VB_Name = "Módulo1"
Function CONVERTIRNUM(Numero As Double, Optional CentimosEnLetra As Boolean) As String

Dim Moneda As String
Dim Monedas As String
Dim Centimo As String
Dim Centimos As String
Dim Preposicion As String
Dim NumCentimos As Double
Dim Letra As String
Const Maximo = 1999999999.99

'************************************************************
' Parámetros
'************************************************************
Moneda = "Peso"         'Nombre de Moneda (Singular)
Monedas = "Pesos"       'Nombre de Moneda (Plural)
Centimo = "Centavo"     'Nombre de Céntimos (Singular)
Centimos = "Centavos"   'Nombre de Céntimos (Plural)
Preposicion = "Con"     'Preposición entre Moneda y Céntimos
'************************************************************

'Validar que el Numero está dentro de los límites
If (Numero >= 0) And (Numero <= Maximo) Then

    
    Letra = NUMERORECURSIVO((Fix(Numero)))              'Convertir el Numero en letras
    
    'Si Numero = 1 agregar leyenda Moneda (Singular)
    If (Numero = 1) Then
        Letra = Letra & " " & Moneda
    'De lo contrario agregar leyenda Monedas (Plural)
    Else
        Letra = Letra & " " & Monedas
    End If
    
    
    NumCentimos = Round((Numero - Fix(Numero)) * 100)   'Obtener los centimos del Numero
    
    'Si NumCentimos es mayor a cero inicar la conversión
    If NumCentimos >= 0 Then
        'Si el parámetro CentimosEnLetra es VERDADERO obtener letras para los céntimos
        If CentimosEnLetra Then
            Letra = Letra & " " & Preposicion & " " & NUMERORECURSIVO(Fix(NumCentimos)) 'Convertir los céntimos en letra
                
            'Si NumCentimos = 1 agregar leyenda Centimos (Singular)
            If (NumCentimos = 1) Then
                Letra = Letra & " " & Centimo
            'De lo contrario agregar leyenda Centimos (Plural)
            Else
                Letra = Letra & " " & Centimos
            End If
         'De lo contrario mostrar los céntimos como número
         Else
            If NumCentimos < 10 Then
                Letra = Letra & " 0" & NumCentimos & "/100"
            Else
                Letra = Letra & " " & NumCentimos & "/100"
            End If
         End If
    End If

    'Regresar el resultado final de la conversión
    CONVERTIRNUM = Letra

Else
    'Si el Numero no está dentro de los límites, entivar un mensaje de error
    CONVERTIRNUM = "ERROR: El número excede los límites."
End If

End Function

Function NUMERORECURSIVO(Numero As Long) As String

Dim Unidades, Decenas, Centenas
Dim Resultado As String

'**************************************************
' Nombre de los números
'**************************************************
Unidades = Array("", "Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorece", "Quince", "Dieciséis", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte", "Veintiuno", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve")
Decenas = Array("", "Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa", "Cien")
Centenas = Array("", "Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos")
'**************************************************

Select Case Numero
    Case 0
        Resultado = "Cero"
    Case 1 To 29
        Resultado = Unidades(Numero)
    Case 30 To 100
        Resultado = Decenas(Numero \ 10) + IIf(Numero Mod 10 <> 0, " y " + NUMERORECURSIVO(Numero Mod 10), "")
    Case 101 To 999
        Resultado = Centenas(Numero \ 100) + IIf(Numero Mod 100 <> 0, " " + NUMERORECURSIVO(Numero Mod 100), "")
    Case 1000 To 1999
        Resultado = "Mil" + IIf(Numero Mod 1000 <> 0, " " + NUMERORECURSIVO(Numero Mod 1000), "")
    Case 2000 To 999999
        Resultado = NUMERORECURSIVO(Numero \ 1000) + " Mil" + IIf(Numero Mod 1000 <> 0, " " + NUMERORECURSIVO(Numero Mod 1000), "")
    Case 1000000 To 1999999
        Resultado = "Un Millón" + IIf(Numero Mod 1000000 <> 0, " " + NUMERORECURSIVO(Numero Mod 1000000), "")
    Case 2000000 To 1999999999
        Resultado = NUMERORECURSIVO(Numero \ 1000000) + " Millones" + IIf(Numero Mod 1000000 <> 0, " " + NUMERORECURSIVO(Numero Mod 1000000), "")
End Select

NUMERORECURSIVO = Resultado

End Function
