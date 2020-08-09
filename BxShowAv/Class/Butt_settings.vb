Public Class Butt_settings
    Private _group1 As Boolean
    Private _group2 As Boolean
    Private _group3 As Boolean
    Private _group4 As Boolean

#Region "Group 1 Button matrix"
    Private _group1button1 As String = "D:\icyzt\Music\Download\Konosuba ED (Miraie Remix).mp3"
#End Region

    Public Property Group1 As Boolean
        Get
            Return _group1
        End Get
        Set(value As Boolean)
            _group1 = value
        End Set
    End Property

    Public Property Group2 As Boolean
        Get
            Return _group2
        End Get
        Set(value As Boolean)
            _group2 = value
        End Set
    End Property

    Public Property Group3 As Boolean
        Get
            Return _group3
        End Get
        Set(value As Boolean)
            _group3 = value
        End Set
    End Property

    Public Property Group4 As Boolean
        Get
            Return _group4
        End Get
        Set(value As Boolean)
            _group4 = value
        End Set
    End Property

    Public Property Group1button1 As String
        Get
            Return _group1button1
        End Get
        Set(value As String)
            _group1button1 = value
        End Set
    End Property
End Class
