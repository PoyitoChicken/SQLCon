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

namespace Actualizarsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try {
              SqlConnection con;
              string strcon = @"Data Source ='';Initial Catalog=''; Integrated Security =True ;Persist Security Info =True";
              string p1 = "UPDATE N";
              con = new SqlConnection(strcon);
              SqlCommand cmd;
              string unidad = textUnidad.Text;
              con.Open();
              cmd = new SqlCommand("UPDATE N"+textUnidad.Text+" SET RentaReal ='" + int.Parse(textRentaReal.Text) + "', RentaDepositada ='" + int.Parse(textRentaDepositada.Text) + "', PagoSeguro ='" + int.Parse(textPagoSeguro.Text) + "', Recuperacion ='" + int.Parse(textRecuperacion.Text) + "', Renta ='" + int.Parse(textRenta.Text) + "', Banco ='" + textBanco.Text + "', Semana= '" + int.Parse(textSemana.Text) + "' WHERE Entrada ='"+int.Parse(textEntrada.Text)+"'", con);                
              cmd.ExecuteNonQuery();
              con.Close();
              System.Threading.Thread.Sleep(1000);
              MessageBox.Show("La informacion se guardo exitosamente");
              Application.Exit();
            }
            catch {
                MessageBox.Show("La informacion fallo al enviarse");
                Application.Exit();
            }

        }
    }
}
