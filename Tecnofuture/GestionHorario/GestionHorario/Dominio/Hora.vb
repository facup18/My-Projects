Public Class Hora
    Private mId As Integer
    Private mTipo_H As String


    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property Tipo_H() As String
        Get
            Return mTipo_H
        End Get
        Set(ByVal value As String)
            mTipo_H = value
        End Set
    End Property

    Public Sub New(ByVal pId As Integer, ByVal pTipo_H As String)

        Id = pId
        Tipo_H = pTipo_H

    End Sub

    Public Sub New()

    End Sub
End Class
