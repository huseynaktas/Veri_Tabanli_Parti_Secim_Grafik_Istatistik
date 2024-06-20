using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_Tabanli_Parti_Secim_Grafik_Istatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3JI920O\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True;");

        private void btnOyGirisi_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand
                ("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            cmd.Parameters.AddWithValue("@p1", txtIlceAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtAP.Text);
            cmd.Parameters.AddWithValue("@p3", txtBP.Text);
            cmd.Parameters.AddWithValue("@p4", txtCP.Text);
            cmd.Parameters.AddWithValue("@p5", txtDP.Text);
            cmd.Parameters.AddWithValue("@p6", txtEP.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}
