Module Module1

    Sub LeggiVettore(ByRef V() As Integer, ByVal lungh As Integer)
        Dim i As Integer
        For i = 0 To lungh - 1
            V(i) = InputBox("Inserisci un elemento del vettore")
        Next
    End Sub

    Sub StampaVettore(ByVal V() As Integer, ByVal lungh As Integer)
        Dim i As Integer
        For i = 0 To lungh - 1
            Console.WriteLine(V(i))
        Next
    End Sub

    Function Minimo(ByVal V() As Integer, ByVal lungh As Integer)
        Dim m As Integer
        m = V(0)
        For i = 1 To lungh - 1
            If V(i) < m Then
                m = V(i)
            End If
        Next
        Return m
    End Function

    Function SommaRicorsiva(ByVal V() As Integer, ByVal N As Integer)
        Dim sum As Integer
        sum = 0
        If N = 0 Then
            Return sum
        Else
            Return V(N - 1) + SommaRicorsiva(V, N - 1)
        End If
    End Function

    Sub Main()

        Dim V() As Integer
        Dim N, min, S As Integer
        N = InputBox("Quanti elementi?")
        ReDim V(N - 1)
        LeggiVettore(V, N)
        StampaVettore(V, N)
        min = Minimo(V, N)
        Console.WriteLine("Il minimo vale: " & min)
        S = SommaRicorsiva(V, N)
        Console.WriteLine("la somma vale: " & S)
        Console.ReadKey()
    End Sub

End Module
