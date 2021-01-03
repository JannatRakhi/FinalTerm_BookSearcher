using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSearcher.Models;
using BookSearcher.Views;
using System.Data;
using System.Data.SqlClient;

namespace BookSearcher.Controllers
{
    class BookController
    {
        public DataTable dtTable = new DataTable();
        public int chng;

        
        books ob=new books();
       
        public void Show()
        {
            ob.Show();
            dtTable = ob.dtTable;
        }
        public void Close()
        {
            ob.Close();
        }
        public void performOperation()
        {
            ob.performOperation();
            dtTable = ob.dtTable;
            chng = ob.c;
        }
        public void searchOpen()
        {
            ob.searchOpen();
            dtTable = ob.dtTable;

        }
        public void earchClose()
        {
            ob.earchClose();
        }
    }
}
