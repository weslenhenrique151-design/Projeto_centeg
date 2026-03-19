Imports System

Module Program
    Sub Main(args As String())
       Dim valor As double

       Dim conta As double

       console.writeLine(" digite um valor rm mb")
     
       valor = console.readLine ()
     
       conta = valor / 1024
     
       console.writeLine("o valor em gb é " & conta) 
    End Sub
End Module
