Namespace SfDataGridDemo
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.sfDataGrid1 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
			CType(Me.sfDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' sfDataGrid1
			' 
			Me.sfDataGrid1.AccessibleName = "Table"
			Me.sfDataGrid1.AllowFiltering = True
			Me.sfDataGrid1.AllowResizingColumns = True
			Me.sfDataGrid1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
			Me.sfDataGrid1.Location = New System.Drawing.Point(10, 5)
			Me.sfDataGrid1.Margin = New System.Windows.Forms.Padding(5)
			Me.sfDataGrid1.Name = "sfDataGrid1"
			Me.sfDataGrid1.Size = New System.Drawing.Size(1008, 543)
			Me.sfDataGrid1.TabIndex = 0
			Me.sfDataGrid1.Text = "sfDataGrid1"
			' 
			' Form1
			' 
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(1024, 553)
			Me.Controls.Add(Me.sfDataGrid1)
			Me.Margin = New System.Windows.Forms.Padding(5)
			Me.MinimumSize = New System.Drawing.Size(500, 400)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Data Binding"
			CType(Me.sfDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private sfDataGrid1 As Syncfusion.WinForms.DataGrid.SfDataGrid
		#End Region
	End Class
End Namespace
