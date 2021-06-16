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
            table.Columns.Add("PhoneNumber", typeof(Int32));
            table.Columns.Add("Email", typeof(string));

            table.Rows.Add("Sharath", "Gowdru", "Channarayapatna", "Hassan", "Karnataka", "573116", "831087735", "Sharath@gmail.com");
            table.Rows.Add("Shashi", "kumar", "KGF", "Kolar", "Karnataka", "573243", "987456321", "Shashi@gmail.com");
            table.Rows.Add("Rohit", "Machale", "Madhigarabeedhi", "Pune", "Maharashtra", "535501", "874563214", "rohit@gmail.com");
            table.Rows.Add("Shivam", "Satpute", "Mahanagar", "Nagpur", "Maharashtra", "546489", "987456632", "shivam@gmail.com");
            table.Rows.Add("Jyosmita", "Das", "KeriColony", "indiranagar", "Assam", "546362", "991122557", "jyosmita@gmail.com");
            table.Rows.Add("Charan", "Ketha", "Rajmundry", "Hyderabad", "Andrapradesh", "125445", "321456875", "charan@gmail.com");
           
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
        public void EditContacts(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Shashi");
            foreach (var contact in contacts)
            {
                contact.SetField("LastName", "Gowda");
                contact.SetField("City", "Banglore");
                contact.SetField("State", "Karnataka");
            }

            Console.WriteLine("The Contact is updated succesfully\n");
            DisplayAddressBook(contacts.CopyToDataTable());
        }
        public void DeleteContact(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Sharath");
            foreach (var row in contacts.ToList())
            {
                row.Delete();
            }
            Console.WriteLine("The Contact is deleted succesfully. Now the list contains following records \n");
            DisplayAddressBook(table);
        }
        public void RetrieveContactByCityOrState(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(x => x.Field<string>("State") == "Karnataka");
            foreach (var contact in contacts)
            {
                Console.Write("First Name : " + contact.Field<string>("FirstName") + " " + "Last Name : " + contact.Field<string>("LastName") + " " + "Address : " + contact.Field<string>("Address") + " " + "City : " + contact.Field<string>("City") + " " + "State : " + contact.Field<string>("State")
                     + " " + "Zip : " + contact.Field<int>("Zip") + " " + "Phone Number : " + contact.Field<Int32>("PhoneNumber") + " " + "Email : " + contact.Field<string>("Email") + " ");
                Console.WriteLine("\n------------------------------------");
            }

        }
    }

}
