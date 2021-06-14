using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookDB_Linq
{
    class Linq_DataTable
    {
        public void CreateDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(int));
            table.Columns.Add("PhoneNumber", typeof(int));
            table.Columns.Add("Email", typeof(string));

        }

    }
}