﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Kairos.Services.Implementaciones
{
    public class ImportarDesdeDBImpl : IImportarDesdeDB
    {
        public List<DateTime> ObtenerColumnaDesdeDB(string connectionString, string database, string nombreDeTabla, string nombreColumna)
        {
            List<DateTime> dates = null;
            try
            {
                string query = "SELECT " + nombreColumna + " FROM " + database + ".DBO." + nombreDeTabla + " ORDER BY " + nombreColumna + " ASC";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dates = new List<DateTime>();
                    while (reader.Read())
                    {
                        dates.Add(Convert.ToDateTime(reader[0]));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                dates = null;
                Console.WriteLine(ex.Message);
            }
            return dates;
        }
    }
}
