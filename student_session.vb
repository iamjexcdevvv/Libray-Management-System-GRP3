Module student_session
    Public NotInheritable Class StudentSession
        Private Shared _instance As StudentSession
        Private _studentID As Integer
        Private _studentUserName As String
        Private Sub New()
        End Sub
        Public Shared ReadOnly Property Instance As StudentSession
            Get
                If _instance Is Nothing Then
                    _instance = New StudentSession()
                End If
                Return _instance
            End Get
        End Property
        Public Property StudentID As Integer
            Get
                Return _studentID
            End Get
            Set(value As Integer)
                _studentID = value
            End Set
        End Property
        Public Property StudentUserName As String
            Get
                Return _studentUserName
            End Get
            Set(value As String)
                _studentUserName = value
            End Set
        End Property
    End Class
End Module
