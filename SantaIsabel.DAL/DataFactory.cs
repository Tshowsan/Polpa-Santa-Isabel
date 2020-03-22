using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaIsabel.DAL
{
    public class DataFactory
    {
        private static ConexaoDataContext dataContex;
        public static ConexaoDataContext DataContex
        {
            get
            {
                if (dataContex == null)
                    dataContex = new ConexaoDataContext();

                return dataContex;
            }
        }
    }
}
