Public Class Person
    Dim _Age As Integer
    Public Event invalidAge()
    Public Property FistName As String
    Public Property LastName As String

    Public Property Age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            If value < 0 Or value > 120 Then
                RaiseEvent invalidAge()
            Else
                _Age = value
            End If

        End Set
    End Property

    Private Sub Person_invalidAge() Handles Me.invalidAge
        MessageBox.Show("Invalid Age")
        Return
    End Sub
End Class
