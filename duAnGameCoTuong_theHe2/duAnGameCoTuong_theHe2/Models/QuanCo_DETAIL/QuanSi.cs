﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duAnGameCoTuong_theHe2.Models.NguoiCho_DETAIL;
using System.Drawing;
using System.Windows.Forms;

namespace duAnGameCoTuong_theHe2.Models.QuanCo_DETAIL
{
    public class QuanSi : QuanCo
    {
        public QuanSi()
            : base()
        {
            setICON();
        }

        public QuanSi(Diem2D toaDo, NguoiChoi soHuu)
            : base(toaDo, soHuu)
        {
            setICON();
        }

        private void setICON()
        {
            setKhongBiChieu();
            Cursor = Cursors.Hand;
            tenCo = TenQuanCo.QUAN_SI;
        }

        public override void setKhongBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_SI_DO);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_SI_DEN);
            Tag = "";
        }

        public override void setBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_SI_DO_BI_CHIEU);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_SI_DEN_BI_CHIEU);
            Tag = "BI_CHIEU";
        }

        public override bool nhinXem(QuanCo[,] banCo, bool resetIMG)
        {
            bool trenTrai = nhinTrenTrai(banCo, resetIMG),
                trenPhai = nhinTrenPhai(banCo, resetIMG),
                duoiTrai = nhinDuoiTrai(banCo, resetIMG),
                duoiPhai = nhinDuoiPhai(banCo, resetIMG);
            return trenTrai || trenPhai || duoiTrai || duoiPhai;
        }

        private bool nhinTrenTrai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            if (i - 1 < 0 || j - 1 < 3) return false;
            i--; j--;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinTrenPhai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            if (i - 1 < 0 || j + 1 > 5) return false;
            i--; j++;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i,j],resetIMG);
        }

        private bool nhinDuoiTrai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            if (i + 1 > banCo.GetLength(0) -1 || j -1 < 3) return false;
            i++; j--;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinDuoiPhai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            if (i + 1 > banCo.GetLength(0)-1 || j + 1 > 5) return false;
            i++; j++;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }
    }
}