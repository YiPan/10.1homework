Module Module1

    Sub Main()
        Dim n, sum, i As Integer
        Console.WriteLine("=求1到100可以被n整除的整數=")
        Console.WriteLine()
        Console.Write("請輸入1到100的整數n:")
        n = Console.ReadLine
        If n >= 1 And n <= 100 Then
            Do While sum + n <= 100
                sum += n
                Console.Write("{0},", sum)
                i += 1
                If i Mod 5 = 0 Then
                    Console.WriteLine()
                End If
            Loop
            Console.WriteLine()
            Console.WriteLine("由1到100有{0}個整數可以被n整除!", i, n)
        Else
            Console.WriteLine("輸入的資料有誤!")
        End If
        Console.ReadLine()


    End Sub

End Module
