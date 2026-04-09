Imports System

Module Program
  
  
  public class celular 

  public marca As string 
  public cor As string 

  public sub ligar()
    console.writeline("ligando...")
  end sub

end class
  
  
  

  
  
  Sub Main(args As String())
     
    Dim celular1 As New celular()

      celular1.marca = "samsung"
      celular1.cor = "preto"

      console.writeLine(celular1.marca)
      console.writeLine(celular1.cor)

      celular1.ligar()

    End Sub
End Module
