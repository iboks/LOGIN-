using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace DATALAY
{
    public class dbconn
    {
        string conString = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
        public DataSet IsValid(string UserName, string PASSWORD)
        {
            OleDbConnection con = new OleDbConnection(conString);
            con.Open();

            OleDbCommand cmd = new OleDbCommand("select USERNAME ,PASSWORD from USERS where USERNAME='" + UserName + " ' and PASSWORD='" + PASSWORD + "'", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }
    }
    }
