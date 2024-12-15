Imports System

Module Program
    Sub Main(args As String())

        ' string[] firstNames = new string[5]
        Dim firstNames As New List(Of String)()

        firstNames.Add("Tim")
        firstNames.Add("Sue")
        firstNames.Add("Bob")
        firstNames.Add("Jane")
        firstNames.Add("Frank")

        Console.WriteLine(firstNames(firstNames.Count - 1))

        Dim ages As New List(Of Integer)()
        ages.Add(1)
        ages.Add(2)
        ages.Add(3)

        ' List(Of T) - generic

        Dim data As String = "Corey,Smith,Jones"
        Dim lastNames As List(Of String) = data.Split(","c).ToList()
        lastNames.Add("Franklin")

    End Sub
End Module
