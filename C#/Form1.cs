using Syncfusion.WinForms.Core;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SfDataGridDemo
{
    public partial class Form1 : Form
    {
        DataTable employeeCollection;
        public Form1()
        {
            InitializeComponent();

            var table = this.GetDataTable();
            //customize the TextBoxCellRenderer 
            this.sfDataGrid1.CellRenderers.Remove("TextBox");
            this.sfDataGrid1.CellRenderers.Add("TextBox", new GridRichTextCellRenderer());

            this.sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.DataSource = table;

            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "OrderID", HeaderText = "Order ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerName", HeaderText = "Customer Name" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Country", HeaderText = "Country" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" });


        }       

        public DataTable GetDataTable()
        {
            employeeCollection = new DataTable();

            employeeCollection.Columns.Add("OrderID", typeof(int));
            employeeCollection.Columns.Add("CustomerID", typeof(string));
            employeeCollection.Columns.Add("CustomerName", typeof(string));
            employeeCollection.Columns.Add("Country", typeof(string));
            employeeCollection.Columns.Add("ShipCity", typeof(string));

            employeeCollection.Rows.Add(1001, "{\\rtf1\\ansi\\deff0{\\colortbl;\\red0\\green0\\blue0;\\red255\\green0\\blue0;}" + "{\\fonttbl{\\f0 Monotype Corsiva;\r\n}}\\qc\\f0\\fs30 {\\i ALFKI}}", "Maria Anders", "Germany", "Berlin");           
            employeeCollection.Rows.Add(1002, "{\\rtf\\ansi \\b ANATR\\b0}", "Ana Trujilo", "Mexico", "Mexico D.F.");
            employeeCollection.Rows.Add(1003, "{\\rtf\\ansi\\ansicpg ANTON\\deflang7177{\\f0\\fnil\\fcharset }}", "Antonio Moreno", "Mexico", "Mexico D.F.");
            employeeCollection.Rows.Add(1004, "{\\rtf\\ansi AROUT }", "Thomas Hardy", "UK", "London");
            employeeCollection.Rows.Add(1005, "{\\rtf\\ansi BERGS }", "Christina Berglund", "Sweden", "Lula");
            employeeCollection.Rows.Add(1006, "{\\rtf1\\ansi\\deff0{\\colortbl;\\red0\\green0\\blue0;\\red255\\green0\\blue0; }\\cf2 BLAUS}", "Hanna Moos", "Germany", "Mannheim");
            employeeCollection.Rows.Add(1007, "{\\rtf1\\ansi\\deff0{\\colortbl;\\red0\\green0\\blue0;\\red0\\green255\\blue0; }\\cf2 BLONP}", "Frederique Citeaux", "France", "Strasbourg");
            employeeCollection.Rows.Add(1008, "{\\rtf1\\ansi\\deff0{\\colortbl;\\red0\\green0\\blue0;\\red0\\green0\\blue255; }\\cf2 BOLID}", "Martin Sommer", "Spain", "Madrid");
            employeeCollection.Rows.Add(1009, "{\\rtf1\\ansi\\deff0{\\colortbl;\\red0\\green0\\blue0;\\red150\\green10\\blue20; }\\cf2 BONAP}", "Laurence Lebihan", "France", "Marseille");
            employeeCollection.Rows.Add(1010, "{\\rtf1\\ansi\\deff0{\\colortbl;\\red0\\green0\\blue0;\\red0\\green220\\blue100; }\\cf2 BOTTM}", "Elizabeth Lincoln", "Canada", "Tsawassen");
            return employeeCollection;

        }
    }
    
    public class GridRichTextCellRenderer : GridTextBoxCellRenderer
    {
        protected override void OnRender(Graphics paint, Rectangle cellRect, string cellValue, CellStyleInfo style, DataColumnBase column, RowColumnIndex rowColumnIndex)
        {
            //here customize based on your scenario
            if (column.GridColumn.MappingName == "CustomerID")
            {   //here draw the richtex in SfDataGrid             
                TextPainter.DrawRichText(paint, cellValue, cellRect);                
            }
            else
                base.OnRender(paint, cellRect, cellValue, style, column, rowColumnIndex);
        }
    }   
}