using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Child2_Class obj_class2 = new Child2_Class();
            lstBOX_show.Items.Add(obj_class2.show());
            Base_Class obj_base = (Base_Class)
        }
    }
}
