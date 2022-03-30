Imports DBConnection
Imports MySql.Data.MySqlClient
Public Class HolderSingleton
    'object for selecting and viewing loan application
    Public Shared selectedLoanApplication As LoanApplication = New LoanApplication()
    'object for selecting and viewing CIR
    Public Shared selectedCIR As CIReport = New CIReport()
    'object to hold inputs for creating or updating loan application
    Public Shared createLoanApplication As LoanApplication = New LoanApplication()
    'object to hold inputs for creating or updating CIR
    Public Shared createCIR As CIReport = New CIReport()
    'connection object needed to connect with the database
    Public Shared connection As MySqlConnection = New MySqlConnection("server = localhost; userid = root; password = canturne; database = chonggos_db")
    'object to hold user info
    Public Shared currentUser As User = New User()
End Class
