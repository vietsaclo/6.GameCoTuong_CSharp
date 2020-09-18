using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using duAnGameCoTuong_theHe2.Models.QuanCo_DETAIL;

namespace duAnGameCoTuong_theHe2.Models.NguoiCho_DETAIL
{
    public class NguoiChoiA:NguoiChoi
    {
        public NguoiChoiA()
        {
            tenNguoiChoi = "Người Chơi A";
            dsQuanCo = new List<Label>();

            QuanCo quanXe = new QuanXe(new Diem2D(9, 0), this); dsQuanCo.Add(quanXe);
            quanXe = new QuanXe(new Diem2D(9, 8), this); dsQuanCo.Add(quanXe);

            QuanCo quanMa = new QuanMa(new Diem2D(9, 1), this); dsQuanCo.Add(quanMa);
            quanMa = new QuanMa(new Diem2D(9, 7), this); dsQuanCo.Add(quanMa);

            QuanBo quanBo = new QuanBo(new Diem2D(9, 2), this); dsQuanCo.Add(quanBo);
            quanBo = new QuanBo(new Diem2D(9, 6), this); dsQuanCo.Add(quanBo);

            QuanSi quanSi = new QuanSi(new Diem2D(9, 3), this); dsQuanCo.Add(quanSi);
            quanSi = new QuanSi(new Diem2D(9, 5), this); dsQuanCo.Add(quanSi);

            QuanTuong quanTuong = new QuanTuong(new Diem2D(9, 4), this); dsQuanCo.Add(quanTuong);

            QuanPhao quanPhao = new QuanPhao(new Diem2D(7,1), this); dsQuanCo.Add(quanPhao);
            quanPhao = new QuanPhao(new Diem2D(7,7), this); dsQuanCo.Add(quanPhao);

            QuanTot quanTot = new QuanTot(new Diem2D(6,0), this); dsQuanCo.Add(quanTot);
            quanTot = new QuanTot(new Diem2D(6,2), this); dsQuanCo.Add(quanTot);
            quanTot = new QuanTot(new Diem2D(6,4), this); dsQuanCo.Add(quanTot);
            quanTot = new QuanTot(new Diem2D(6,6), this); dsQuanCo.Add(quanTot);
            quanTot = new QuanTot(new Diem2D(6,8), this); dsQuanCo.Add(quanTot);
        }

        public override void chienThang()
        {
            MessageBox.Show("Xin chúc mừng [ " + tenNguoiChoi + "] đã chiến thắng trò chơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void biChieuTuong()
        {
            MessageBox.Show("[ "+tenNguoiChoi + "] đang bị đối phương chiếu tướng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
