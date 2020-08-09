Public Class butt_list
    Dim _path As String
    Dim _tital As String
    Dim _artest As String
    Dim _id As Integer
    Dim _buttname As String
    Dim _butt_text As String
    Dim _colour As String

    Public Property Path As String
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property

    Public Property Tital As String
        Get
            Return _tital
        End Get
        Set(value As String)
            _tital = value
        End Set
    End Property

    Public Property Artest As String
        Get
            Return _artest
        End Get
        Set(value As String)
            _artest = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Buttname As String
        Get
            Return _buttname
        End Get
        Set(value As String)
            _buttname = value
        End Set
    End Property

    Public Property Butt_text As String
        Get
            Return _butt_text
        End Get
        Set(value As String)
            _butt_text = value
        End Set
    End Property

    Public Property Colour As String
        Get
            Return _colour
        End Get
        Set(value As String)
            _colour = value
        End Set
    End Property
End Class
