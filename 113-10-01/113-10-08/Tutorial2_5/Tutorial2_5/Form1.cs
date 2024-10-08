using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*----------------------------------------
   班級:資管一乙
------------------------------------------*/
namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //顯示撲克牌背面
        private void btnshowback_Click(object sender, EventArgs e)
        {
            ptxback.Visible=true;
            ptxfront.Visible=false;
        }
        //顯示撲克牌正面
        private void btnshowfront_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible=true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
