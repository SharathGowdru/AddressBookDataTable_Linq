using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookDB_Linq
{
    class Linq_DataTable
    {
        public DataTable CreateDataTable()
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

            table.Rows.Add("Sharath", "Gowdru", "Channarayapatna", "Hassan", "Karnataka", "573116", "9916633661", "Sharath@gmail.com");
            table.Rows.Add("Shashi", "kumar", "KGF", "Kolar", "Karnataka", "573243", "9874563214", "Shashi@gmail.com");
            table.Rows.Add("Rohit", "Machale", "Madhigarabeedhi", "Pune", "Maharashtra", "535501", "8745632145", "rohit@gmail.com");
            table.Rows.Add("Shivam", "Satpute", "Mahanagar", "Nagpur", "Maharashtra", "546489", "9874566332", "shivam@gmail.com");
            table.Rows.Add("Jyosmita", "Das", "KeriColony", "SVm", "Assam", "546362", "9911225547", "jyosmita@gmail.com");
            table.Rows.Add("Charan", "Ketha", "Rajmundry", "Hyderabad", "Andrapradesh", "125445", "3214569875", "charan@gmail.com");
           
            return table;
        }
        public void DisplayAddressBook(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>();
            foreach (var contact in contacts)
            {
                Console.Write("First Name:" + contact.Field<string>("FirstName") + " " + "Last Name:" + contact.Field<string>("LastName") + " " + "Address:" + contact.Field<string>("Address") + " " + "City:" + contact.Field<string>("City") + " " + "State:" + contact.Field<string>("State")
                + " " + "Zip:" + contact.Field<int>("Zip") + " " + "Phone Number:" + contact.Field<int>("PhoneNumber") + " " + "Email:" + contact.Field<string>("Email") + " ");
            }
        }

    }
}