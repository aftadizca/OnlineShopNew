Imports System.Security.Cryptography

Module MyModule

    'status Cart
    '0 - Blm bayar
    '1 - Sdah bayar blm diverifikasi
    '2 - sdah diverifikasi
    '3 - diproses penjual
    '4 - dikirim + resi
    '5 - barang sampai

    '01 - dibatalkan user
    '02 - dibatalkan penjual

    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32

    Public Sub flushMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub



    'get status transaksi
    Public Function getStatus(ByVal key As Integer) As String
        Select Case key
            Case 0
                Return "Unpaid"
            Case 11
                Return "Canceled by Buyyer"
            Case 1
                Return "Waiting for Verification"
            Case 2
                Return "Verification Success"
            Case 3
                Return "Processed by Seller"
            Case 12
                Return "Canceled by Seller"
            Case 4
                Return "Shipped"
            Case 5
                Return "Delivered"
        End Select
    End Function

    Public Function getStatusInt(ByVal status As String) As Integer
        Select Case status
            Case "Unpaid"
                Return 0
            Case "Canceled by Buyyer"
                Return 11
            Case "Waiting for Verification"
                Return 1
            Case "Verification Success"
                Return 2
            Case "Processed by Seller"
                Return 3
            Case "Canceled by Seller"
                Return 12
            Case "Shipped"
                Return 4
            Case "Delivered"
                Return 5
        End Select
    End Function

    'Generate hash password
    Public Function hashPass(ByVal email As String, ByVal password As String) As String
        Dim mysha As SHA256 = New SHA256Managed
        Dim pass = email & password & password & email & password
        Dim result = Convert.ToBase64String(mysha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pass)))
        Return result
    End Function

    'Make Id Buyyer
    Public Function makeIdBuyyer() As String
        Using db As New OnlineShopEntity
            Dim id As String
            Dim result = db.users.Where(Function(i) i.id.Contains("BYR")).ToList()
            id = String.Format("BYR{0:0000000000}", result.Count + 1)
            Return id
        End Using
    End Function

    'Make Id Buyyer
    Public Function makeIdSeller() As String
        Using db As New OnlineShopEntity
            Dim id As String
            Dim result = db.users.Where(Function(i) i.id.Contains("SLR")).ToList()
            id = String.Format("SLR{0:0000000000}", result.Count + 1)
            Return id
        End Using
    End Function

    'Make id Transaction
    Public Function makeIdTransaction() As String
        Using db As New OnlineShopEntity
            Dim id As String
            Dim result = db.transactions.ToList()
            id = String.Format("TR{0:0000000000}", result.Count + 1)
            Return id
        End Using
    End Function

    'Make id Item
    Public Function makeIdItem() As String
        Using db As New OnlineShopEntity
            Dim id As String
            Dim result = db.barangdagangans.ToList()
            id = String.Format("ITEM{0:0000000000}", result.Count + 1)
            Return id
        End Using
    End Function


    'Show Error Validation Form
    Sub addError(ByVal control As Control, ByVal msg As String, ByVal errorProvider As ErrorProvider)
        errorProvider.SetError(control, msg)
        control.BackColor = Color.LightPink
    End Sub

    'Disable Error Validation Form
    Sub clearError(ByVal control As Control, ByVal errorProvider As ErrorProvider)
        errorProvider.SetError(control, "")
        control.BackColor = SystemColors.Control
    End Sub


    'For validation form ( empty form )
    Function validEmpty(ByVal control As Control, ByVal msg As String, ByVal errorProvider As ErrorProvider) As Boolean
        If control.Text.Length = 0 Then
            addError(control, msg, errorProvider)
            Return False
        Else
            clearError(control, errorProvider)
            Return True
        End If
    End Function

    'Format harga
    Public Function formatHarga(ByVal harga As String) As String
        Dim newString As String = ""
        Dim pos = 1

        If harga.Length > 3 Then
            For Index = harga.Length To 1 Step -1
                If pos Mod 3 = 0 And pos <> harga.Length Then
                    newString = newString.Insert(0, "," & GetChar(harga, Index))
                Else
                    newString = newString.Insert(0, GetChar(harga, Index))
                End If
                pos += 1
            Next Index
            Return "Rp. " & newString
        Else
            Return "Rp. " & harga
        End If
    End Function

    'delete cart
    Public Sub deleteCart(ByVal id As String)
        Try
            Using db As New OnlineShopEntity
                Dim name = db.carts.First(Function(i) i.id_barang = id And i.id_pembeli = My.Settings.idUser And i.status = 0 And i.id_transaksi = vbNullString)
                db.carts.Remove(name)
                db.SaveChanges()
            End Using
        Catch ex As Exception
            'BuyPage.retryCon().Start()
        End Try
    End Sub

    'update jumlah cart
    Public Sub updateJmlCart(ByVal jml As Integer, ByVal id As String)
        Try
            Using db As New OnlineShopEntity
                Dim name = db.carts.First(Function(i) i.id_barang = id And i.id_pembeli = My.Settings.idUser And i.status = 0 And i.id_transaksi = vbNullString)
                If name.jumlah >= 1 Then
                    If name.jumlah = 1 And jml <> -1 Then
                        name.jumlah += jml
                    ElseIf name.jumlah > 1 Then
                        name.jumlah += jml
                    End If
                End If
                db.SaveChanges()
            End Using
        Catch ex As Exception
            'BuyPage.retryCon().Start()
        End Try
    End Sub

    'total harga cart
    Public Function getTotalHargaCart(ByVal id_pembeli As String) As String
        Using db As New OnlineShopEntity
            Dim total = 0
            Dim result = (From cr In db.carts
                          From bd In db.barangdagangans
                          Where bd.id_barang = cr.id_barang And cr.status = 0 And cr.id_pembeli = My.Settings.idUser And cr.id_transaksi = vbNullString
                          Select New With {.harga = cr.jumlah * bd.harga}).ToList()

            If result.Count > 0 Then
                total = result.Sum(Function(i) i.harga)
                Return total.ToString
            Else
                Return "0"
            End If
        End Using
    End Function

    'get NAME 
    Public Function getUserName(ByVal id As String) As String
        Using db As New OnlineShopEntity
            Dim result = db.users.First(Function(i) i.id = id)
            Return result.nama_lengkap
        End Using
    End Function

End Module
