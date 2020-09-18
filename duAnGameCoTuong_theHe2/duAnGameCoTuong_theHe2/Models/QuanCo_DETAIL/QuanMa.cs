using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using duAnGameCoTuong_theHe2.Models.NguoiCho_DETAIL;

namespace duAnGameCoTuong_theHe2.Models.QuanCo_DETAIL
{
    public class QuanMa : QuanCo
    {
        public QuanMa()
            : base()
        {
            setICON();
        }

        public QuanMa(Diem2D toaDo, NguoiChoi soHuu)
            : base(toaDo, soHuu)
        {
            setICON();
        }

        private void setICON()
        {
            setKhongBiChieu();
            Cursor = Cursors.Hand;
            tenCo = TenQuanCo.QUAN_MA;
        }

        public override void setKhongBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_MA_DO);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_MA_DEN);
            Tag = "";
        }

        public override void setBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_MA_DO_BI_CHIEU);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_MA_DEN_BI_CHIEU);
            Tag = "BI_CHIEU";
        }

        public override bool nhinXem(QuanCo[,] banCo, bool resetIMG)
        {
            bool trenTrai = nhinTrenTrai(banCo, resetIMG),
                trenPhai = nhinTrenPhai(banCo, resetIMG),
                duoiTrai = nhinDuoiTrai(banCo, resetIMG),
                duoiPhai = nhinDuoiPhai(banCo, resetIMG),
                traiTren = nhinTraiTren(banCo, resetIMG),
                traiDuoi = nhinTraiDuoi(banCo, resetIMG),
                phaiTren = nhinPhaiTren(banCo, resetIMG),
                phaiDuoi = nhinPhaiDuoi(banCo, resetIMG);
            return trenTrai || trenPhai || duoiTrai || duoiPhai || traiTren || traiDuoi || phaiTren || phaiDuoi;
        }

        private bool nhinTrenTrai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i--; if (i < 1) return false;
            if (banCo[i, j].TenCo != TenQuanCo.CHUA_XAC_DINH) return false;
            i--; j--; if (j < 0) return false;
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
            i--; if (i < 1) return false;
            if (banCo[i, j].TenCo != TenQuanCo.CHUA_XAC_DINH) return false;
            i--; j++; if (j > banCo.GetLength(1) - 1) return false;
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

        private bool nhinDuoiTrai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i++; if (i > banCo.GetLength(0) - 2) return false;
            if (banCo[i, j].TenCo != TenQuanCo.CHUA_XAC_DINH) return false;
            i++; j--; if (j < 0) return false;
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
            i++; if (i > banCo.GetLength(0) - 2) return false;
            if (banCo[i, j].TenCo != TenQuanCo.CHUA_XAC_DINH) return false;
            i++; j++; if (j > banCo.GetLength(1) - 1) return false;
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

        private bool nhinTraiTren(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j--; if (j < 1) return false;
            if (banCo[i, j].TenCo != TenQuanCo.CHUA_XAC_DINH) return false;
            j--; i--; if (i < 0) return false;
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

        private bool nhinTraiDuoi(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j--; if (j < 1) return false;
            if (banCo[i, j].TenCo != TenQuanCo.CHUA_XAC_DINH) return false;
            j--; i++; if (i > banCo.GetLength(0) - 1) return false;
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

        private bool nhinPhaiTren(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j++; if (j > banCo.GetLength(1) - 2) return false;
            if (banCo[i, j].TenCo != TenQuanCo.CHUA_XAC_DINH) return false;
            j++; i--; if (i < 0) return false;
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

        private bool nhinPhaiDuoi(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j++; if (j > banCo.GetLength(1) - 2) return false;
            if (banCo[i, j].TenCo != TenQuanCo.CHUA_XAC_DINH) return false;
            j++; i++; if (i > banCo.GetLength(0) - 1) return false;
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
