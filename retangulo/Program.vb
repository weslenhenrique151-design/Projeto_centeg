Imports System

Module Program
    Sub Main(args As String())
    Dim base As Double
    Dim altura As Double
    Dim area As Double

    console.writeline("qual é a medida da base:")
    base = console.readline()

    console.writeline("qual é a medida da altura: ")
    altura = console.readline()

    console.writeline("qual é a medida da area:")

    area = base * altura 

    console.writeline(" a medida da area é:" & area)

    End Sub
End Module
