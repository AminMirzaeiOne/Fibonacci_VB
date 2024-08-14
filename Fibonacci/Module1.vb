Imports System

Module Module1

    Sub Main()
        ' Declare variables to store the number of terms, and the first three Fibonacci numbers
        Dim numberOfTerms As Long
        Dim firstTerm As Long = 1, secondTerm As Long = 1, nextTerm As Long

        System.Console.ForegroundColor = ConsoleColor.Cyan
        ' Prompt the user to enter the desired number of terms
        System.Console.Write("Enter the number of terms: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        numberOfTerms = System.Console.ReadLine()
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ResetColor()

        System.Console.ForegroundColor = ConsoleColor.Blue
        ' Print the first two terms
        System.Console.WriteLine("Fibonacci Sequence:")
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.BackgroundColor = ConsoleColor.DarkCyan
        System.Console.Write("{0}, {1}", firstTerm, secondTerm)


        ' Calculate and print the remaining terms using a loop
        For i As Long = 3 To numberOfTerms
            ' Calculate the next term by adding the previous two terms
            nextTerm = firstTerm + secondTerm

            ' Print the next term
            System.Console.Write(", {0}", nextTerm)

            ' Shift the first two terms for the next iteration
            firstTerm = secondTerm
            secondTerm = nextTerm
        Next
        System.Console.ResetColor()
        System.Console.WriteLine()
        'Programmer Information and GitHub ID
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Pause the console to view the output
        System.Console.ReadKey()
    End Sub

End Module
