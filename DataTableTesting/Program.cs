using System;
using System.Data;

namespace DataTableTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class DataTableTest
    {

        public DataTableTest()
        {
            CreateTable();
        }

        public DataTable TestTable => CreateTable();

        private DataTable CreateTable()
        {
            var table = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Name";
            table.PrimaryKey[0] = column;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "Inded";
            table.Columns.Add(column);

            for (int i = 0; i <= 2; i++)
            {
                row = table.NewRow();
                row["Name"] = $"Name{i}";
                row["Measure"] = i;
                table.Rows.Add(row);
            }
            var test = table.Columns["Measure"];
            var rowtest = table.Rows.Find("Name2");
            var test2 = table.Rows.Find("Name2").Field<int>(test);
            return table;
        }
    }
}
