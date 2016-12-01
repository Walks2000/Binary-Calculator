Module Module1
    Public MenuValue As String
    Public User1 As String
    Public User2 As String
    Sub Main()
        Console.Clear()
        Console.WriteLine("Please choose from one of the following:")
        Console.WriteLine("1. Addition")
        Console.WriteLine("2. Subtraction")
        Console.WriteLine("3. Multiplication")
        MenuValue = Console.ReadLine
        Select Case MenuValue
            Case 1
                Input()
            Case 2
                Input()
            Case 3
                Input()
            Case Else
                Main()
        End Select
    End Sub
    Sub Input()
        Input1()
        Input2()
        Select Case MenuValue
            Case 1
                Add()
            Case 2
                Subtract()
            Case 3
                Mult()
            Case Else
                Invalid()
                Main()
        End Select
    End Sub
    Sub Input1()
        Console.Clear()
        Console.WriteLine("Enter your first 8 bit binary value now.")
        User1 = Console.ReadLine()
        If User1.Length <> 8 Then
            Invalid()
            Input1()
        End If
        If Not User1.Contains("0" Or "1") Then
            Invalid()
            Input1()
        End If
    End Sub
    Sub Input2()
        Console.Clear()
        Console.WriteLine("Enter your second 8 bit binary value now.")
        User2 = Console.ReadLine()
        If User2.Length <> 8 Then
            Invalid()
            Input1()
        End If
        If Not User2.Contains("0" Or "1") Then
            Invalid()
            Input1()
        End If
    End Sub
    Sub Add()
        Console.Clear()
        Dim User1Dec As Integer
        Dim User2Dec As Integer
        Dim UserAnsDec As Integer
        Dim UserAns As String
        User1Dec = Convert.ToInt32(User1, 2)
        User2Dec = Convert.ToInt32(User2, 2)
        UserAnsDec = User1Dec + User2Dec
        UserAns = Convert.ToString(UserAnsDec, 2)
        Console.WriteLine("The answer to {0} + {1} = {2}", User1, User2, UserAns.PadLeft(8, "0"))
        Console.ReadLine()
        GoHome()
    End Sub
    Sub Subtract()
        Console.Clear()
        Dim User1Dec As Integer
        Dim User2Dec As Integer
        Dim UserAnsDec As Integer
        Dim UserAns As String
        User1Dec = Convert.ToInt32(User1, 2)
        User2Dec = Convert.ToInt32(User2, 2)
        UserAnsDec = User1Dec - User2Dec
        UserAns = Convert.ToString(UserAnsDec, 2)
        Console.WriteLine("The answer to {0} + {1} = {2}", User1, User2, UserAns.PadLeft(8, "0"))
        Console.ReadLine()
        GoHome()
    End Sub
    Sub Mult()
        Console.Clear()
        Dim User1Dec As Integer
        Dim User2Dec As Integer
        Dim UserAnsDec As Integer
        Dim UserAns As String
        User1Dec = Convert.ToInt32(User1, 2)
        User2Dec = Convert.ToInt32(User2, 2)
        UserAnsDec = User1Dec * User2Dec
        UserAns = Convert.ToString(UserAnsDec, 2)
        Console.WriteLine("The answer to {0} + {1} = {2}", User1, User2, UserAns.PadLeft(8, "0"))
        Console.ReadLine()
        GoHome()
    End Sub
    Sub GoHome()
        Dim Home As String = 0
        Console.Clear()
        Console.WriteLine("Do you wish to go home now?")
        Console.WriteLine("1. Yes")
        Console.WriteLine("2. No (Closes Program)")
        Home = Console.ReadLine()
        Select Case Home
            Case 1
                Main()
            Case 2
                End
            Case Else
                Invalid()
                GoHome()
        End Select
    End Sub
    Sub Invalid()
        Console.WriteLine("Sorry, that input is invalid. Try again. Press enter to continue.")
        Console.ReadLine()
    End Sub
End Module
