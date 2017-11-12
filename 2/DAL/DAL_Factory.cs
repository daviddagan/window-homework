using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Factory 
    {
        static DAL_XML instance = null;
        DAL_Factory() { }

        public static IDAL getDAL()
        {
            if (instance == null)
                instance = new DAL_XML();
            return instance;
        }
    }
}
