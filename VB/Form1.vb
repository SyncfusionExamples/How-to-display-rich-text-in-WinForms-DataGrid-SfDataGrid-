Imports Syncfusion.WinForms.Core
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Renderers
Imports Syncfusion.WinForms.DataGrid.Styles
Imports Syncfusion.WinForms.GridCommon.ScrollAxis
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace SfDataGridDemo
	Partial Public Class Form1
		Inherits Form

		Private employeeCollection As DataTable
		Public Sub New()
			InitializeComponent()

			Dim table = Me.GetDataTable()
			'customize the TextBoxCellRenderer 
			Me.sfDataGrid1.CellRenderers.Remove("TextBox")
			Me.sfDataGrid1.CellRenderers.Add("TextBox", New GridRichTextCellRenderer())

			Me.sfDataGrid1.AutoGenerateColumns = False
			sfDataGrid1.DataSource = table

			Me.sfDataGrid1.Columns.Add(New GridTextColumn() With {
				.MappingName = "OrderID",
				.HeaderText = "Order ID"
			})
			Me.sfDataGrid1.Columns.Add(New GridTextColumn() With {
				.MappingName = "CustomerID",
				.HeaderText = "Customer ID"
			})
			Me.sfDataGrid1.Columns.Add(New GridTextColumn() With {
				.MappingName = "CustomerName",
				.HeaderText = "Customer Name"
			})
			Me.sfDataGrid1.Columns.Add(New GridTextColumn() With {
				.MappingName = "Country",
				.HeaderText = "Country"
			})
			Me.sfDataGrid1.Columns.Add(New GridTextColumn() With {
				.MappingName = "ShipCity",
				.HeaderText = "Ship City"
			})


		End Sub

		Public Function GetDataTable() As DataTable
			employeeCollection = New DataTable()

			employeeCollection.Columns.Add("OrderID", GetType(Integer))
			employeeCollection.Columns.Add("CustomerID", GetType(String))
			employeeCollection.Columns.Add("CustomerName", GetType(String))
			employeeCollection.Columns.Add("Country", GetType(String))
			employeeCollection.Columns.Add("ShipCity", GetType(String))

			employeeCollection.Rows.Add(1001, "{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red255\green0\blue0;}" & "{\fonttbl{\f0 Monotype Corsiva;" & ControlChars.CrLf & "}}\qc\f0\fs30 {\i ALFKI}}", "Maria Anders", "Germany", "Berlin")
			employeeCollection.Rows.Add(1002, "{\rtf\ansi \b ANATR\b0}", "Ana Trujilo", "Mexico", "Mexico D.F.")
			employeeCollection.Rows.Add(1003, "{\rtf\ansi\ansicpg ANTON\deflang7177{\f0\fnil\fcharset }}", "Antonio Moreno", "Mexico", "Mexico D.F.")
			employeeCollection.Rows.Add(1004, "{\rtf\ansi AROUT }", "Thomas Hardy", "UK", "London")
			employeeCollection.Rows.Add(1005, "{\rtf\ansi BERGS }", "Christina Berglund", "Sweden", "Lula")
			employeeCollection.Rows.Add(1006, "{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red255\green0\blue0; }\cf2 BLAUS}", "Hanna Moos", "Germany", "Mannheim")
			employeeCollection.Rows.Add(1007, "{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red0\green255\blue0; }\cf2 BLONP}", "Frederique Citeaux", "France", "Strasbourg")
			employeeCollection.Rows.Add(1008, "{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red0\green0\blue255; }\cf2 BOLID}", "Martin Sommer", "Spain", "Madrid")
			employeeCollection.Rows.Add(1009, "{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red150\green10\blue20; }\cf2 BONAP}", "Laurence Lebihan", "France", "Marseille")
			employeeCollection.Rows.Add(1010, "{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red0\green220\blue100; }\cf2 BOTTM}", "Elizabeth Lincoln", "Canada", "Tsawassen")
			Return employeeCollection

		End Function
	End Class

	Public Class GridRichTextCellRenderer
		Inherits GridTextBoxCellRenderer

		Protected Overrides Sub OnRender(ByVal paint As Graphics, ByVal cellRect As Rectangle, ByVal cellValue As String, ByVal style As CellStyleInfo, ByVal column As DataColumnBase, ByVal rowColumnIndex As RowColumnIndex)
			'here customize based on your scenario
			If column.GridColumn.MappingName = "CustomerID" Then 'here draw the richtex in SfDataGrid
				TextPainter.DrawRichText(paint, cellValue, cellRect)
			Else
				MyBase.OnRender(paint, cellRect, cellValue, style, column, rowColumnIndex)
			End If
		End Sub
	End Class
End Namespace