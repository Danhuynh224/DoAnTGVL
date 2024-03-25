using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class TaiKhoan
    {
        private int id=0;
        private string role="";
        private string lognamme="";
        private string pass = "";

        public TaiKhoan() { }   

        public TaiKhoan(int id, string role, string lognamme, string pass)
        {
            this.id = id;
            this.role = role;
            this.lognamme = lognamme;
            this.pass = pass;
        }

        public int Id { get => id; set => id = value; }
        public string Role { get => role; set => role = value; }
        public string Lognamme { get => lognamme; set => lognamme = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
