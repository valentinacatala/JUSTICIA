using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        profugos oProfugos;
        DataTable tPro;
 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oProfugos = new profugos();
            tPro = oProfugos.getData();

            lbProfugos.DisplayMember = "nombre";
            lbProfugos.ValueMember = "id";
            lbProfugos.DataSource = tPro;
        }

        private void lbProfugos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string foto;

            foreach (DataRow fPro in tPro.Rows)
            {
                if (fPro["id"].ToString() == lbProfugos.SelectedValue.ToString())
                {
                    foto = $"{fPro["id"]}.jpg";
                    pbFoto.Load($"C:\\Users\\Alumno\\source\\repos\\WindowsFormsApp1\\bin\\Debug\\fotos\\{foto}");
                }
            }
        }
    }
}
