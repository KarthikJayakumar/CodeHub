using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DatabaseLayer
{
    public class Database
    {
        /// <summary>
        /// Triggers the email.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="uid">The uid.</param>
        /// <returns></returns>
        /// <author>karthik.jayakumar - 04-Apr-17 - 11:51 AM</author>
        public int TriggerEmail(string username, string uid)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=karthik;Password=karthik;Database=Email;");

            conn.Open();

            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand("select * from TriggerEmailFor('" + username + "', '" + uid + "');", conn);

            // Execute the query and obtain the value of the first column of the first row
            int isEmailTriggered = Convert.ToInt32(command.ExecuteScalar());

            //Console.Write("{0}\n", count);
            conn.Close();
            return isEmailTriggered;
        }
    }
}
