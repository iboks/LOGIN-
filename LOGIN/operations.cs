using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATALAY;

namespace BUSLAY
{
    public class operations
    {
        private string _USERNAME = "";
        private string _PASSWORD = "";

public string USERNAME
        {
            get
            {
                return _USERNAME;
            }

            set
            {
                _USERNAME = value;
            }
        }
public string PASSWORD
{
    get
    {
        return _PASSWORD;
    }

    set
    {
        _PASSWORD = value;
    }
}

        dbconn da = new dbconn();
        public bool getUser()
        {
            if (da.IsValid(USERNAME,PASSWORD).Tables[0].Rows.Count ==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
            

    }
}
