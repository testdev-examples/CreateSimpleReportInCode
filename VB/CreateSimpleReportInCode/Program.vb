Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CreateSimpleReportInCode
    Friend Class Program
        Shared Sub Main(ByVal args() As String)
            Dim report = DxReportHelper.GetMyReport()
        End Sub
    End Class
    Public Class DxReportHelper
        Public Shared Function GetMyReport() As XtraReport
            ' todo
            Return Nothing
        End Function
    End Class
End Namespace
