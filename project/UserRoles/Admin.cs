using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Admin : User
    {
        public Admin()
        {
            // tom konstruktor — privileges kan tilføjes senere ved reference til parent-metoder
        }

        public void SetupDefaults()
        {
            //AddPrivilege(new SimplePrivilege(""));
            //AddPrivilege(new SimplePrivilege(""));
        }
    }
}