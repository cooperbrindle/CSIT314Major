﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication5
{
    class Database
    {

        private SqlConnection connection;
        private DataTable table;

        public Database()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cooper\Source\Repos\CSIT314Major\WindowsFormsApplication5\Data.mdf;Integrated Security=True;Connect Timeout=30");
            table = new DataTable();
        }

        public DataTable query(String queryString)
        {
            table = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(queryString, connection);
            sda.Fill(table);
            return table;
        } 
    }
}
