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

namespace ConnectSQL
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
        private void btnAceptar_Click(object sender, EventArgs e)
        //@"Data Source =''; Initial Catalog = ''; Persist Security Info = True; UID = ''; Password = ''"
        {
            SqlConnection con;
            string strcon = @"Data Source ='';Initial Catalog=EcosPrueba1; Integrated Security =True ;Persist Security Info =True";
            string p1 = "INSERT INTO N";
            con = new SqlConnection(strcon);
            SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand(p1 + txtUnidad.Text +  "(RentaReal, RentaDepositada, PagoSeguro, Recuperacion, Renta, Banco, Semana) VALUES('" + int.Parse(txtRentaReal.Text) + "','"+ int.Parse(txtRentaDepositada.Text) +"','"+ int.Parse(txtPagoSeguro.Text) +"','"+ int.Parse(txtRecuperacion.Text) +"','"+ int.Parse(txtRenta.Text) +"','"+int.Parse(txtBanco.Text) +"', '"+ int.Parse(txtSemana.Text) +"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            System.Threading.Thread.Sleep(1000);
            MessageBox.Show("La informacion se guardo exitosamente");
            Application.Exit();
        }

        
    }
}
