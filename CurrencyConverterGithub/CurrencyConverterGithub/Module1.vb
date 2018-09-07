Module Module1

    Sub Main(args As String())
        Dim AmountGBP As Decimal
        Dim Currency As String
        Dim EUR, PLN, USD As Decimal
        Dim Answer As Decimal
        EUR = 1.1
        PLN = 4.8
        USD = 1.6
        Console.WriteLine("Please Enter An Amount In GBP:")
        AmountGBP = Console.ReadLine()
        Console.WriteLine("Please Enter The Currency You Want To Convert To:")
        Currency = Console.ReadLine()
        If Currency = "EUR" Then
            Answer = AmountGBP * EUR
        ElseIf Currency = "PLN" Then
            Answer = AmountGBP * PLN
        ElseIf Currency = "USD" Then
            Answer = AmountGBP * USD
        Else
            Answer = 0
            Console.WriteLine("Please Try Again")
        End If
        Console.WriteLine("£ " & AmountGBP & " Is " & Answer & " " & Currency & "")
        Console.ReadLine()

    End Sub

End Module
