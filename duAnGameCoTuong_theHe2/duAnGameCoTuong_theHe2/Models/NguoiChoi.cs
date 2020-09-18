using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duAnGameCoTuong_theHe2.Models
{
    public abstract class NguoiChoi
    {
        protected String tenNguoiChoi;
        protected List<Label> dsQuanCo;

        public String TenNguoiChoi
        {
            get { return tenNguoiChoi; }
            set { tenNguoiChoi = value; }
        }

        public List<Label> DsQuanCo
        {
            get { return dsQuanCo; }
            set { dsQuanCo = value; }
        }

        public abstract void chienThang();

        public abstract void biChieuTuong();
    }
}
