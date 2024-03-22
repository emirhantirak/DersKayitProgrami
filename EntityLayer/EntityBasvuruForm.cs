using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruId;
        public int BASVURUID
        {
            get { return basvuruId; }
            set { basvuruId = value; }
        }

        private int basDersId;
        public int BASDERSID
        {
            get { return basDersId; }
            set { basDersId = value; }
        }

        private int basOgrId;
        public int BASOGRID
        {
            get { return basOgrId; }
            set { basOgrId = value; }
        }
    }
}
