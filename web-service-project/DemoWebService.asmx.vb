Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class SQLQuery

    'Shared alternativeConnection As String = "Data Source=ASUS-FX553;Initial Catalog=MegaData_TEST;Integrated Security=True;Persist Security Info=True"
    Private Shared ReadOnly connectionString As String = "Provider=SQLOLEDB;Data Source=YAZILIM4\MEGA;Initial Catalog=MegaData_TEST;Integrated Security=SSPI;Persist Security Info=True;User ID=sa"
    Private Shared ReadOnly oleConnection As New OleDbConnection(connectionString)
    Private commandString As String = String.Empty
    Private ReadOnly oleCommand As New OleDbCommand(commandString, oleConnection)
    Private ReadOnly oleDataAdapter As New OleDbDataAdapter(oleCommand)

    Public Sub New(commandString As String)
        Me.commandString = commandString
    End Sub

    Public Function cmdDataTable(dataTable As DataTable) As DataTable

        Try
            If oleConnection.State = ConnectionState.Closed Then
                oleConnection.Open()
            End If
            oleDataAdapter.Fill(dataTable)
            Return dataTable
        Catch ex As Exception
            Throw
        End Try

        oleConnection.Close()

        Return Nothing
    End Function

    Public Function cmdFirstData()

        Try
            If oleConnection.State = ConnectionState.Closed Then
                oleConnection.Open()
            End If
            Return oleCommand.ExecuteScalar()
            oleCommand.Dispose()
        Catch ex As Exception
            Throw
        End Try

        oleConnection.Close()

        Return Nothing
    End Function

End Class

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class DemoWebService
    Inherits WebService

    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod()>
    Public Function CariListesi() As DataTable
        Dim cariDT As New DataTable("CarAna")
        Dim sqlQuery As New SQLQuery("SELECT * FROM CarAna")
        sqlQuery.cmdDataTable(cariDT)
        Return cariDT
    End Function

    <WebMethod()>
    Public Function CariHareketListesi() As DataTable
        Dim cariHareketDT As New DataTable("CarHarDet")
        Dim sqlQuery As New SQLQuery("SELECT * FROM CarHarDet")
        sqlQuery.cmdDataTable(cariHareketDT)
        Return cariHareketDT
    End Function

End Class