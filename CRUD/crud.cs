using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class crud
    {
        SqlCommand command;
        SqlDataAdapter adapter;
        private static SqlConnection conn = new SqlConnection(Server_Source.Get_Conn());

        public static bool Add(int ID, string Name, string Surname, string Father_Name, string Email, string Birth_Date, string Address, string Group_ID)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand("insert into Student(Name,Surname,ID,Father_Name,Email,Birth_Date,Adress,Group_ID) values(@name,@surname,@id,@father_name,@email,@birth_date,@address,@group_id)", conn);
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@surname", Surname);
                command.Parameters.AddWithValue("@father_name", Father_Name);
                command.Parameters.AddWithValue("@email", Email);
                command.Parameters.AddWithValue("@address", Address);
                command.Parameters.AddWithValue("@group_id", Group_ID);
                command.Parameters.AddWithValue("@birth_date", Birth_Date);

                command.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool Del(string ID)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand command = new SqlCommand("delete Student where ID=@id", conn);
                command.Parameters.AddWithValue("@id", ID);

                command.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Upd(int ID,
                               string Name,
                               string Surname,
                               string Father_Name,
                               string Email,
                               string Birth_Date,
                               string Address,
                               string Group_ID)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand("insert into Student(Name,Surname,ID,Father_Name,Email,Birth_Date,Adress,Group_ID) values(@name,@surname,@id,@father_name,@email,@birth_date,@address,@group_id)", conn);
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@surname", Surname);
                command.Parameters.AddWithValue("@father_name", Father_Name);
                command.Parameters.AddWithValue("@email", Email);
                command.Parameters.AddWithValue("@address", Address);
                command.Parameters.AddWithValue("@group_id", Group_ID);
                command.Parameters.AddWithValue("@birth_date", Birth_Date);


                command.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public static DataView Read(string ID)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                DataSet dt = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Student where ID = '" + ID + "'", conn);
                adapter.Fill(dt);
                conn.Close();
                return dt.Tables[0].DefaultView;
            }
            catch
            {
                return null;
            }
        }
        public static DataView Show()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                DataSet dt = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Student ", conn);
                adapter.Fill(dt);
                conn.Close();
                return dt.Tables[0].DefaultView;
            }
            catch
            {
                return null;
            }
        }
    }
}

