﻿Imports System

Module Module1

    Sub Main()
        ' Declare variables to store the number of terms, and the first three Fibonacci numbers
        Dim numberOfTerms As Integer
        Dim firstTerm As Integer = 1, secondTerm As Integer = 1, nextTerm As Integer

        ' Prompt the user to enter the desired number of terms
        System.Console.Write("Enter the number of terms: ")
        numberOfTerms = System.Console.ReadLine()

        ' Print the first two terms
        System.Console.WriteLine("Fibonacci Sequence:")
        System.Console.Write("{0}, {1}", firstTerm, secondTerm)

        ' Calculate and print the remaining terms using a loop
        For i As Integer = 3 To numberOfTerms
            ' Calculate the next term by adding the previous two terms
            nextTerm = firstTerm + secondTerm

            ' Print the next term
            System.Console.Write(", {0}", nextTerm)

            ' Shift the first two terms for the next iteration
            firstTerm = secondTerm
            secondTerm = nextTerm
        Next

        ' Pause the console to view the output
        System.Console.ReadKey()
    End Sub

End Module
