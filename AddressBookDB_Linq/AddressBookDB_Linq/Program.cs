using System;
using System.Data;

namespace AddressBookDB_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq_DataTable Linq_Table = new Linq_DataTable();
            DataTable dataTable = Linq_Table.CreateDataTable();
           // Linq_Table.DisplayAddressBook(dataTable);
           // Linq_Table.EditContacts(dataTable);
           // Linq_Table.DeleteContact(dataTable);
           // Linq_Table.RetrieveContactByCityOrState(dataTable);
           // Linq_Table.GetSizeOfAddressBookByCityOrState(dataTable);
            Linq_Table.SortContacts(dataTable);
        }
    }
}
