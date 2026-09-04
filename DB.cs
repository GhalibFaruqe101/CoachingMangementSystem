using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   

namespace CoachingMangementSystem
    {
        class DB
        {
            private SqlConnection connect;

            public DB()
            {
                this.connect = new SqlConnection(
                     @"Data Source=DESKTOP-FIDVE11\SQLEXPRESS;Initial Catalog=CoachingManagementDB;Integrated Security=True");
            }

            public DataTable ExecuteQuery(string sql)
            {
                try
                {
                    connect.Open();

                    SqlCommand cmd = new SqlCommand(sql, connect);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    return table;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }

            public int ExecuteDMLQuery(string sql)
            {
                try
                {
                    connect.Open();

                    SqlCommand cmd = new SqlCommand(sql, connect);

                    int count = cmd.ExecuteNonQuery();

                    return count;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }


