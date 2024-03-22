using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class User : Person
    {
        public User(int id, string hoTen, string cCCD, string sDT, DateTime dob, string khuvuc) : base(id, hoTen, cCCD, sDT, dob, khuvuc)
        {
        }
    }
}
