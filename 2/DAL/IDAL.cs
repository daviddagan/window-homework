using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {

        void AddFlower(Flower fl);//function to add a speciality to the XML file by the DAL layer
        void DeleteFlower(int fl);//function to delete a speciality to the XML file by the DAL layer
        void UpdateFlower(Flower fl);//function to update a speciality to the XML file by the DAL layer
    }
}
