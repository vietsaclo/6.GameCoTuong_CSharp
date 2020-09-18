using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using duAnGameCoTuong_theHe2.Models.QuanCo_DETAIL;

namespace duAnGameCoTuong_theHe2.Models.NguoiCho_DETAIL
{
    public class NguoiChoiB:NguoiChoi
    {
        public NguoiChoiB()
        {
            tenNguoiChoi = "Người Chơi B";
            dsQuanCo = new List<Label>();

            QuanCo quanXe = new QuanXe(new Diem2D(0, 0), this); dsQuanCo.Add(quanXe);
            quanXe = new QuanXe(new Diem2D(0, 8), this); dsQuanCo.Add(quanXe);

            QuanCo quanMa = new QuanMa(new Diem2D(0, 1), this); dsQuanCo.Add(quanMa);
            quanMa = new QuanMa(new Diem2D(0, 7), this); dsQuanCo.Add(quanMa);

            QuanBo quanBo = new QuanBo(new Diem2D(0, 2), this); dsQuanCo.Add(quanBo);
            quanBo = new QuanBo(new Diem2D(0, 6), this); dsQuanCo.Add(quanBo);

            QuanSi quanSi = new QuanSi(new Diem2D(0, 3), this); dsQuanCo.Add(quanSi);
            quanSi = new QuanSi(new Diem2D(0, 5), this); dsQuanCo.Add(quanSi);

            QuanTuong quanTuong = new QuanTuong(new Diem2D(0, 4), this); dsQuanCo.Add(quanTuong);

            QuanPhao quanPhao = new QuanPhao(new Diem2D(2, 1), this); dsQuanCo.Add(quanPhao);
            quanPhao = new QuanPhao(new Diem2D(2, 7), this); dsQuanCo.Add(quanPhao);

            QuanTot quanTot = new QuanTot(new Diem2D(3, 0), this); dsQuanCo.Add(quanTot);
            quanTot = new QuanTot(new Diem2D(3, 2), this); dsQuanCo.Add(quanTot);
            quanTot = new QuanTot(new Diem2D(3, 4), this); dsQuanCo.Add(quanTot);
            quanTot = new QuanTot(new Diem2D(3, 6), this); dsQuanCo.Add(quanTot);
            quanTot = new QuanTot(new Diem2D(3, 8), this); dsQuanCo.Add(quanTot);
        }

        public override void chienThang()
        {
            MessageBox.Show("Xin chúc mừng [ " + tenNguoiChoi + "] đã chiến thắng trò chơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void biChieuTuong()
        {
            MessageBox.Show("[ " + tenNguoiChoi + "] đang bị đối phương chiếu tướng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
