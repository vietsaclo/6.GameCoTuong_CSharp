using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using duAnGameCoTuong_theHe2.Models;
using duAnGameCoTuong_theHe2.Models.NguoiCho_DETAIL;
using duAnGameCoTuong_theHe2.Models.QuanCo_DETAIL;

namespace duAnGameCoTuong_theHe2
{
    public partial class frmGame : Form
    {
        private const int rows = 10;
        private const int cols = 9;
        private NguoiChoi nguoiA;
        private NguoiChoi nguoiB;
        private QuanCo[,] banCo;
        private QuanCo[,] banCo2;
        private bool luotNguoiA;
        private QuanCo qcLichSu;
        private QuanCo qcPrev;
        private DongHo dongHoNguoiA;
        private DongHo dongHoNguoiB;

        public frmGame()
        {
            InitializeComponent();
            khoiTaoThuocTinh();
        }

        private void khoiTaoThuocTinh()
        {
            nguoiA = new NguoiChoiA();
            nguoiB = new NguoiChoiB();
            banCo = null;
            dongHoNguoiA = new DongHo();
            dongHoNguoiB = new DongHo();
            lblShowDongHoNguoiA.Text = lblShowDongHoNguoiB.Text = "0 : 0 : 0 s";
        }

        private void taoBanCo()
        {
            banCo = new QuanCo[rows, cols];
            QuanCo qcTemp;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    qcTemp = new QuanCo();
                    qcTemp.ToaDo = new Diem2D(i,j);
                    qcTemp.Location = new Point(j*qcTemp.Width,i*qcTemp.Height);
                    banCo[i, j] = qcTemp;
                }
            }
        }

        private void napCacQuanCoLenBan()
        {
            foreach (QuanCo qc in nguoiA.DsQuanCo)
            {
                int i = qc.ToaDo.X,
                    j = qc.ToaDo.Y;
                qc.Location = banCo[i, j].Location;
                banCo[i, j] = qc;
            }

            foreach (QuanCo qc in nguoiB.DsQuanCo)
            {
                int i = qc.ToaDo.X,
                    j = qc.ToaDo.Y;
                qc.Location = banCo[i, j].Location;
                banCo[i, j] = qc;
            }
        }

        private void hienThiBanCoLen()
        {
            pnBanCo.Controls.Clear();
            foreach (QuanCo qc in banCo)
            {
                qc.Click += qc_Click;
                pnBanCo.Controls.Add(qc);
            }
        }

        private void hienThiBanCoLen2()
        {
            banCo2 = new QuanCo[rows, cols];
            QuanCo qcTemp;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    qcTemp = new QuanCo();
                    qcTemp.ToaDo = new Diem2D(i, j);
                    qcTemp.Location = new Point(j * qcTemp.Width, i * qcTemp.Height);
                    qcTemp.BorderStyle = BorderStyle.FixedSingle;
                    banCo2[i, j] = qcTemp;
                    pnBanCo2.Controls.Add(qcTemp);
                    if (i==4||i == 5)
                        qcTemp.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void qc_Click_pnBanCo2(object sender, EventArgs e)
        {
            MessageBox.Show("Bàn cờ chỉ để hiển thị không để chơi ! Vui lòng chơi bàn bên trái Thank .","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void _startGame()
        {
            khoiTaoThuocTinh();
            nguoiA.TenNguoiChoi = txtTenNguoiChoiA.Text.Trim();
            nguoiB.TenNguoiChoi = txtTenNguoiChoiB.Text.Trim();
            if (String.IsNullOrEmpty(nguoiA.TenNguoiChoi) || String.IsNullOrEmpty(nguoiB.TenNguoiChoi))
            {
                MessageBox.Show("Vui Lòng nhập tên để chơi");
                return;
            }
            lblShowTenNguoiChoiA.Text = nguoiA.TenNguoiChoi;
            lblShowTenNguoiChoiB.Text = nguoiB.TenNguoiChoi;
            if (lblShowTenNguoiChoiA.BackColor == Color.White && lblShowTenNguoiChoiB.BackColor == Color.White)
            {
                luotNguoiA = true;
                lblShowTenNguoiChoiA.BackColor = Color.LightCoral;
            }

            taoBanCo();
            napCacQuanCoLenBan();
            hienThiBanCoLen();
            hienThiBanCoLen2();
            pnBanCo.BackgroundImage = Image.FromFile(_Modules.IMG_BG_TABLE_495_550);
            dongHoTinhGio.Start();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _startGame();
            btnDaoLuocChoi.Enabled = false;
            btnStartGame.Enabled = false;
            btnReStartGame.Enabled = true;
        }

        private void btnReStartGame_Click(object sender, EventArgs e)
        {
            pnBanCo.BackgroundImage = null;
            pnBanCo.Controls.Clear();
            pnBanCo2.Controls.Clear();
            btnDaoLuocChoi.Enabled = true;
            btnStartGame.Enabled = true;
            btnReStartGame.Enabled = false;
            dongHoTinhGio.Stop();
            lblShowDongHoNguoiA.Text = lblShowDongHoNguoiB.Text = "0 : 0 : 0 s";
        }

        private void chuyenNguoiChoi()
        {
            luotNguoiA = !luotNguoiA;
            if (luotNguoiA)
            {
                lblShowTenNguoiChoiA.BackColor = Color.LightCoral;
                lblShowTenNguoiChoiB.BackColor = Color.White;
            }
            else
            {
                lblShowTenNguoiChoiB.BackColor = Color.Silver;
                lblShowTenNguoiChoiA.BackColor = Color.White;
            }
        }

        private void qc_Click(object sender, EventArgs e)
        {
            QuanCo qc = sender as QuanCo;
            if (luotNguoiA)
            {
                if (qc.SoHuu is NguoiChoiA)
                    setNhinXem(qc);
                else if (qc.SoHuu is NguoiChoiB || qc.SoHuu == null)
                {
                    setDiChuyen(qc,false);
                    if (isBiChieuTuong(nguoiB))
                        nguoiB.biChieuTuong();
                }
            }
            else
            {
                if (qc.SoHuu is NguoiChoiB)
                    setNhinXem(qc);
                else if (qc.SoHuu is NguoiChoiA || qc.SoHuu == null)
                {
                    setDiChuyen(qc,false);
                    if (isBiChieuTuong(nguoiA))
                        nguoiA.biChieuTuong();
                }
            }
        }

        private void setNhinXem(QuanCo qc)
        {
            if (qcPrev != null)
                qcPrev.nhinXem(banCo, true);
            qc.nhinXem(banCo, false);
            qcPrev = qc;
        }

        private void setDiChuyen(QuanCo qc,bool bacChap)
        {
            if (!bacChap)
                if (!qc.Tag.ToString().Equals("DUONG_DI") && !qc.Tag.ToString().Equals("BI_CHIEU"))
                    return;
            qcPrev.nhinXem(banCo, true);
            QuanCo qcCu = qcPrev._copy(),
                qcMoi = qc._copy(); Diem2D toaDoCu = qcCu.ToaDo, toaDoMoi = qcMoi.ToaDo;

            pnBanCo.Controls.Remove(qcPrev);
            pnBanCo.Controls.Remove(qc);

            QuanCo qcNew;

            if (qcCu is QuanXe) qcNew = new QuanXe(toaDoMoi, qcCu.SoHuu);
            else if (qcCu is QuanMa) qcNew = new QuanMa(toaDoMoi, qcCu.SoHuu);
            else if (qcCu is QuanBo) qcNew = new QuanBo(toaDoMoi, qcCu.SoHuu);
            else if (qcCu is QuanSi) qcNew = new QuanSi(toaDoMoi, qcCu.SoHuu);
            else if (qcCu is QuanTuong) qcNew = new QuanTuong(toaDoMoi, qcCu.SoHuu);
            else if (qcCu is QuanPhao) qcNew = new QuanPhao(toaDoMoi, qcCu.SoHuu);
            else qcNew = new QuanTot(toaDoMoi,qcCu.SoHuu);

            qcNew.Image = qcCu.Image;
            qcNew.Location = qcMoi.Location;
            qcNew.Click += qc_Click;

            QuanCo qcOld = new QuanCo();
            qcOld.ToaDo = qcCu.ToaDo;
            qcOld.Location = qcCu.Location;
            qcOld.Click += qc_Click;

            banCo[toaDoMoi.X, toaDoMoi.Y] = qcNew;
            banCo[toaDoCu.X, toaDoCu.Y] = qcOld;

            pnBanCo.Controls.Add(qcNew);
            pnBanCo.Controls.Add(qcOld);

            qcLichSu = qcOld;
            qcPrev = qcNew;
            quanCo_copy_img(qcMoi, banCo2);
            if (qcMoi.TenCo == TenQuanCo.QUAN_TUONG)
            {
                setChienThangCuocChoi(qcNew.SoHuu);
                return;
            }
            chuyenNguoiChoi();
        }

        private bool isBiChieuTuong(NguoiChoi soHuu)
        {
            NguoiChoi qcNguoiKiaSoHuu = soHuu is NguoiChoiA ? nguoiB : nguoiA;
            foreach (QuanCo qc in banCo)
                if (qc.SoHuu == qcNguoiKiaSoHuu)
                    if (qc.nhinXem(banCo, true))
                        return true;

            return false;
        }

        private QuanCo getQuanCo_by_toaDo(Diem2D td)
        {
            foreach (QuanCo qc in banCo)
                if (qc.ToaDo.X == td.X && qc.ToaDo.Y == td.Y)
                    return qc;
            return null;
        }

        private void setChienThangCuocChoi(NguoiChoi soHuu)
        {
            soHuu.chienThang();
            foreach (QuanCo qc in banCo)
            {
                qc.Cursor = Cursors.No;
                qc.Click += qc_Click2;
            }
            dongHoTinhGio.Stop();
        }

        private void qc_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("Trò chơi đã kết thúc ! Vui lòng Restart lại game","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnDaoLuocChoi_Click(object sender, EventArgs e)
        {
            chuyenNguoiChoi();
        }

        private void dongHoTinhGio_Tick(object sender, EventArgs e)
        {
            if (luotNguoiA)
                dongHoNguoiA.tangMotGiay(lblShowDongHoNguoiA);
            else
                dongHoNguoiB.tangMotGiay(lblShowDongHoNguoiB);
        }

        private void quanCo_copy_img(QuanCo qc, QuanCo[,] banCo)
        {
            switch (qc.TenCo)
            {
                case TenQuanCo.QUAN_XE:
                    {
                        if (qc.SoHuu is NguoiChoiA)
                        {
                            if (banCo[9, 0].Image == null)
                                banCo[9, 0].Image = qc.Image;
                            else
                                banCo[9, 8].Image = qc.Image;
                        }
                        else
                        {
                            if (banCo[0, 0].Image == null)
                                banCo[0, 0].Image = qc.Image;
                            else
                                banCo[0, 8].Image = qc.Image;
                        }
                        break;
                    }
                case TenQuanCo.QUAN_MA:
                    {
                        if (qc.SoHuu is NguoiChoiA)
                        {
                            if (banCo[9, 1].Image == null)
                                banCo[9, 1].Image = qc.Image;
                            else
                                banCo[9, 7].Image = qc.Image;
                        }
                        else
                        {
                            if (banCo[0, 1].Image == null)
                                banCo[0, 1].Image = qc.Image;
                            else
                                banCo[0, 7].Image = qc.Image;
                        }
                        break;
                    }

                case TenQuanCo.QUAN_BO:
                    {
                        if (qc.SoHuu is NguoiChoiA)
                        {
                            if (banCo[9, 2].Image == null)
                                banCo[9, 2].Image = qc.Image;
                            else
                                banCo[9, 6].Image = qc.Image;
                        }
                        else
                        {
                            if (banCo[0, 2].Image == null)
                                banCo[0, 2].Image = qc.Image;
                            else
                                banCo[0, 6].Image = qc.Image;
                        }
                        break;
                    }

                case TenQuanCo.QUAN_SI:
                    {
                        if (qc.SoHuu is NguoiChoiA)
                        {
                            if (banCo[9, 3].Image == null)
                                banCo[9, 3].Image = qc.Image;
                            else
                                banCo[9, 5].Image = qc.Image;
                        }
                        else
                        {
                            if (banCo[0, 3].Image == null)
                                banCo[0, 3].Image = qc.Image;
                            else
                                banCo[0, 5].Image = qc.Image;
                        }
                        break;
                    }

                case TenQuanCo.QUAN_TUONG:
                    {
                        if (qc.SoHuu is NguoiChoiA)
                        {
                            banCo[9, 4].Image = qc.Image;
                        }
                        else
                        {
                            banCo[0, 4].Image = qc.Image;
                        }
                        break;
                    }

                case TenQuanCo.QUAN_PHAO:
                    {
                        if (qc.SoHuu is NguoiChoiA)
                        {
                            if (banCo[7, 1].Image == null)
                                banCo[7, 1].Image = qc.Image;
                            else
                                banCo[7, 7].Image = qc.Image;
                        }
                        else
                        {
                            if (banCo[2, 1].Image == null)
                                banCo[2, 1].Image = qc.Image;
                            else
                                banCo[2, 7].Image = qc.Image;
                        }
                        break;
                    }

                case TenQuanCo.QUAN_TOT:
                    {
                        if (qc.SoHuu is NguoiChoiA)
                        {
                            if (banCo[6, 0].Image == null)
                                banCo[6, 0].Image = qc.Image;
                            else if (banCo[6, 2].Image == null)
                                banCo[6, 2].Image = qc.Image;
                            else if (banCo[6, 4].Image == null)
                                banCo[6, 4].Image = qc.Image;
                            else if (banCo[6, 6].Image == null)
                                banCo[6, 6].Image = qc.Image;
                            else
                                banCo[6, 8].Image = qc.Image;
                        }
                        else
                        {
                            if (banCo[3, 0].Image == null)
                                banCo[3, 0].Image = qc.Image;
                            else if (banCo[3, 2].Image == null)
                                banCo[3, 2].Image = qc.Image;
                            else if (banCo[3, 4].Image == null)
                                banCo[3, 4].Image = qc.Image;
                            else if (banCo[3, 6].Image == null)
                                banCo[3, 6].Image = qc.Image;
                            else
                                banCo[3, 8].Image = qc.Image;
                        }
                        break;
                    }

                default:
                    {

                        break;
                    }
            }
        }
    }
}