Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxTabControl
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Data.Filtering
Imports System.Collections

Partial Public Class Individual_Cell_Highlighting
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub ASPxGridView1_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableDataCellEventArgs)
		e.Cell.Attributes.Add("onclick", "OnCellClick(this);")
	End Sub
End Class

