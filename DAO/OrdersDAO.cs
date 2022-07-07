using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Orders.API.DAO
{
    public class OrdersDAO
    {
        private readonly Connection _connection;
        private readonly SqlCommand _command;
        private SqlDataReader? _reader;
        readonly DataTable _dataTable;
        public OrdersDAO()
        {
            _connection = new Connection();
            _command = new SqlCommand();
            _dataTable = new DataTable();
        }

        public DataTable GetOrders()
        {
            _command.Connection = _connection.AbrirConection();
            _command.CommandText = "GetOrders";
            _command.CommandType = CommandType.StoredProcedure;
            _reader = _command.ExecuteReader();
            _dataTable.Load(_reader);
            _reader.Close();
            _connection.CerrarConection();
            return _dataTable;
        }

    }
}