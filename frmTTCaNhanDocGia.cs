using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmTTCaNhanDocGia : Form
    {
        public frmTTCaNhanDocGia()
        {
            InitializeComponent();
        }

        private void frmTTCaNhanDocGia_Load(object sender, EventArgs e)
        {
            MessageBox.Show(frmLogin.user);
        }
    }
}
