﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class CongViec
    {
        private int iD;
        private int iDTho;
        private int iDUser;
        private string tieuDe = "";
        private string linhVuc = "";
        private string moTa;
        private string khuVuc;
        private DateTime dateThue;
        private string ghiChu = "";
        private string trangThai = "";

        public int ID { get => iD; set => iD = value; }
        public int IDTho { get => iDTho; set => iDTho = value; }
        public int IDUser { get => iDUser; set => iDUser = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public DateTime DateThue { get => dateThue; set => dateThue = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public CongViec()
        {

        }
        public CongViec(int iDTho, int iDUser, string linhVuc, string khuVuc)
        {
            this.IDTho = iDTho;
            this.IDUser = iDUser;
            this.linhVuc = linhVuc;
            this.KhuVuc = khuVuc;
        }

        public CongViec(int iD, int iDTho, int iDUser, string tieuDe, string linhVuc, string moTa, string khuVuc, DateTime dateThue, string trangThai)
        {
            this.iD = iD;
            this.iDTho = iDTho;
            this.iDUser = iDUser;
            this.tieuDe = tieuDe;
            this.linhVuc = linhVuc;
            this.moTa = moTa;
            this.khuVuc = khuVuc;
            this.dateThue = dateThue;
            this.trangThai = trangThai;
        }
    }
}
