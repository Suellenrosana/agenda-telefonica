using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Agenda
{
    public partial class frmLogin : Form
    {
        public string LiberaMenu = "";
        public string stringconexao = ConfigurationManager.ConnectionStrings["CaminhoAgenda"].ConnectionString;
        public string usuLogado = "";
        public string senhaCripDecr = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument oXML = new XmlDocument();
            XmlNodeList oNoLista = default(XmlNodeList);

            string ArquivoXML = stringconexao + @"Usuarios.xml";

            try
            {
                oXML.Load(ArquivoXML);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Mensagem da exceção: " + ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Mensagem: " + ex2.Source);

                throw;
            }

            int contador = 0;

            oNoLista = oXML.SelectNodes("/Usuarios/Usuario");
            foreach (XmlNode oNo in oNoLista)
            {
                if (oNo.ChildNodes.Item(2).InnerText == textBox1.Text || oNo.ChildNodes.Item(5).InnerText == textBox1.Text)
                {
                    if (oNo.ChildNodes.Item(4).InnerText == CriptarDecriptar(textBox2.Text.ToString()))
                    {
                        usuLogado = textBox1.Text;
                        if (oNo.ChildNodes.Item(3).InnerText == "A")
                        {
                            
                            LiberaMenu = "S";
                            this.Close();
                        }
                        else
                        {
                            LiberaMenu = "N";
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha não existem, ou não são válidos!!");
                    }
                }
                else
                {
                    contador++;
                }
            }
            if (contador == oNoLista.Count)
            {
                MessageBox.Show("Usuário ou Senha não existem, ou não são válidos!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            Form frm = (Form)sender;
            ControlPaint.DrawBorder(e.Graphics, frm.ClientRectangle,
            Color.DarkRed, 5, ButtonBorderStyle.Solid,
            Color.DarkRed, 5, ButtonBorderStyle.Solid,
            Color.DarkRed, 5, ButtonBorderStyle.Solid,
            Color.DarkRed, 5, ButtonBorderStyle.Solid);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsUpper(e.KeyChar)) && !(char.IsLower(e.KeyChar)) && !(char.IsDigit(e.KeyChar)) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private static string CriptarDecriptar(string senha)
        {
            string textoTemp = "";

            string s = senha;

            foreach (char c in s)
            {
                if (c <= 128)
                {
                    textoTemp = textoTemp + char.ConvertFromUtf32(c + 128);
                }
                else if (c >= 128)
                {
                    textoTemp = textoTemp + char.ConvertFromUtf32(c - 128);
                }
            }

            return senha = textoTemp;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }

        }
    }
}
