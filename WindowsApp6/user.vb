'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class user
    Public Property id As String
    Public Property password As String
    Public Property nama_lengkap As String
    Public Property jenis_kelamin As String
    Public Property email As String
    Public Property alamat As String
    Public Property nama_rekening As String
    Public Property no_rekening As String
    Public Property bank_rekening As String
    Public Property tipe As String
    Public Property timestamp As Date

    Public Overridable Property barangdagangans As ICollection(Of barangdagangan) = New HashSet(Of barangdagangan)
    Public Overridable Property carts As ICollection(Of cart) = New HashSet(Of cart)

End Class
