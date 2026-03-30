Imports System

Module Program
    Sub Main(args As String())
        dim alunos As new list (OF string)
        dim quantidade As integer 
        dim nome As string
        console.writeLine(" quantos alunos deseja cadastrar? ")
        quantidade = integer.parse(console.readline())

         for i as integer = 1 to quantidade 
        console.Write("Digite o nome do aluno:") 

        nome = console.readLine()
        alunos.add(nome)
         next

         For each aluno in alunos 
            console.writeline(aluno)
            
         Next 
    End Sub
End Module
