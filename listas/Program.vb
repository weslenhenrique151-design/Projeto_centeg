Imports System

Module Program
    Sub Main(args As String())
      dim materias  As new list(Of String)
        materias.Add("Matemática")
        materias.Add("Português")
        materias.Add("História")    
            
          For each dado in materias 
        Console.writeLine(dado) 
          Next 



    End Sub
End Module
