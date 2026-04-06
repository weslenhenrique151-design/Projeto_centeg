Imports System

Module Program
 


    Function somar(a As integer ,  b As integer ) As integer
        return a + b 
    end Function    






    Sub Main(args As String())
      
        Dim n1, n2, resultado As integer
        
        console.writeLine("digite o primeiro numero")
        n1 = console.readLine() 
        
        console.writeLine("digite o segundo numero")
        n2 = console.readLine()
        
        resultado = somar(n1, n2 ) 

        console.writeLine(resultado) 
       
    End Sub
End Module
