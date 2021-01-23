Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p1 As New Person With {.Age = 67, .FistName = "Bobby", .LastName = "Focker"}
        Dim p2 As New Person With {.Age = 9, .FistName = "Bill", .LastName = "Niner"}
        Dim p3 As New Person With {.Age = 23, .FistName = "Shane", .LastName = "Sordo"}
        Dim p4 As New Person With {.Age = 45, .FistName = "Rory", .LastName = "Tarantino"}
        Dim p5 As New Person With {.Age = 12, .FistName = "Kathie", .LastName = "Oyster"}
        Dim p6 As New Person With {.Age = 33, .FistName = "Norah", .LastName = "Neen"}
        Dim p7 As New Person With {.Age = 56, .FistName = "Isabella", .LastName = "Smart"}
        Dim p8 As New Person With {.Age = 79, .FistName = "Riata", .LastName = "Ismail"}
        Dim p9 As New Person With {.Age = 15, .FistName = "Queen", .LastName = "Lattifah"}

        Dim personList As New List(Of Person)({p1, p2, p3, p4, p5, p6, p7, p8, p9})

        Dim admission = Function(p As Person) As Single 'Lambda function
                            If p.Age <= 5 Then Return 5
                            If p.Age > 5 And p.Age <= 15 Then Return 7.5
                            If p.Age > 15 And p.Age <= 60 Then Return 15
                            Return 5
                        End Function

        Dim AgeRank = From p As Person In personList 'linq creates collection (here AgeRank)
                      Select Name = p.FistName & " " & p.LastName, Age = p.Age,
                          price = admission(p)
                      Order By Age

        For Each item In AgeRank 'No type declaration beacause linq has got some anonymous type...
            lbAge.Items.Add(item.Name & "," & item.Age & ", " & item.price.ToString("c"))
        Next

        Dim PriceRank = From p As Person In personList 'linq creates collection (here AgeRank)
                        Select Name = p.FistName & " " & p.LastName, Age = p.Age,
                          price = admission(p)
                        Order By price

        For Each item In PriceRank 'No type declaration beacause linq has got some anonymous type...
            lbPrice.Items.Add(item.Name & "," & item.Age & ", " & item.price.ToString("c"))
        Next
    End Sub
End Class
