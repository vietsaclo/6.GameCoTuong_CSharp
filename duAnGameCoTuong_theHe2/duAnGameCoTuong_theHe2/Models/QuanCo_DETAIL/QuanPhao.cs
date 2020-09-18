using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duAnGameCoTuong_theHe2.Models.NguoiCho_DETAIL;
using System.Drawing;
using System.Windows.Forms;

namespace duAnGameCoTuong_theHe2.Models.QuanCo_DETAIL
{
    public class QuanPhao : QuanCo
    {
        public QuanPhao()
            : base()
        {
            setICON();
        }

        public QuanPhao(Diem2D toaDo, NguoiChoi soHuu)
            : base(toaDo, soHuu)
        {
            setICON();
        }

        private void setICON()
        {
            setKhongBiChieu();
            Cursor = Cursors.Hand;
            tenCo = TenQuanCo.QUAN_PHAO;
        }

        public override void setKhongBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_PHAO_DO);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_PHAO_DEN);
            Tag = "";
        }

        public override void setBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_PHAO_DO_BI_CHIEU);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_PHAO_DEN_BI_CHIEU);
            Tag = "BI_CHIEU";
        }

        public override bool nhinXem(QuanCo[,] banCo, bool resetIMG)
        {
            bool truoc = nhinTruoc(banCo, resetIMG),
                sau = nhinSau(banCo, resetIMG),
                trai = nhinTrai(banCo, resetIMG),
                phai = nhinPhai(banCo, resetIMG);
            return truoc || sau || trai || phai;
        }

        private bool nhinTruoc(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i--; if (i == -1) return false;
            Image img; String tg;
            if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                banCo[i, j].Image = img;
                banCo[i--, j].Tag = tg;
                if (i == -1)
                    return false;
            }
            i--; if (i == -1) return false;
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                i--;
                if (i == -1)
                    return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinSau(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i++; if (i == banCo.GetLength(0)) return false;
            Image img; String tg;
            if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                banCo[i, j].Image = img;
                banCo[i++, j].Tag = tg;
                if (i == banCo.GetLength(0))
                    return false;
            }
            i++; if (i == banCo.GetLength(0)) return false;
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                i++;
                if (i == banCo.GetLength(0))
                    return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinTrai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j--; if (j == -1) return false;
            Image img; String tg;
            if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                banCo[i, j].Image = img;
                banCo[i, j--].Tag = tg;
                if (j == -1) 
                    return false;
            }
            j--; if (j == -1) return false;
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                j--;
                if (j == -1)
                    return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinPhai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j++; if (j == banCo.GetLength(1)) return false;
            Image img; String tg;
            if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                banCo[i, j].Image = img;
                banCo[i, j++].Tag = tg;
                if (j == banCo.GetLength(1))
                    return false;
            }
            j++; if (j == banCo.GetLength(1)) return false;
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                j++;
                if (j == banCo.GetLength(1))
                    return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }
    }
}
