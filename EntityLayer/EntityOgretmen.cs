using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogrtId;
        public int OGRTID
        {
            get { return ogrtId; }
            set { ogrtId = value; }
        }

        private string ogrtAd;
        public string OGRTAD
        {
            get { return ogrtAd; }
            set { ogrtAd = value; }
        }

        private int ogrtBrans;
        public int OGRTBRANS
        {
            get { return ogrtBrans; }
            set { ogrtBrans = value; }
        }
    }
}
