using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    [Flags]
    public enum Roles:byte
    {
        guest=1,
        Developer=2,
        secretary=4,
        DBA=8,
        SecurityOfficer=16
    }
}
