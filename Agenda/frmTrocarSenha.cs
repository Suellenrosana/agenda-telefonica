using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;

namespace Agenda
{
    public partial class frmTrocarSenha : Form
    {
        public string trocarSenhaUsuLogado = "";
        public string stringconexao = ConfigurationManager.ConnectionStrings["CaminhoAgenda"].ConnectionString;

        public frmTrocarSenha()
        {
            InitializeComponent();
        }

        private void frmTrocarSenha_Paint(object sender, PaintEventArgs e)
        {
            Form frm = (Form)sender;
            ControlPaint.DrawBorder(e.Graphics, frm.ClientRectangle,
            Color.DarkRed, 5, ButtonBorderStyle.Solid,
            Color.DarkRed, 5, ButtonBorderStyle.Solid,
            Color.DarkRed, 5, ButtonBorderStyle.Solid,
            Color.DarkRed, 5, ButtonBorderStyle.Solid);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrocarSenha_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = trocarSenhaUsuLogado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text != textBox2.Text) || (textBox1.Text=="" && textBox2.Text==""))
            {
                MessageBox.Show("Senhas não conferem!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            else
            {
                string ArquivoXML = stringconexao + @"Usuarios.xml";
                XElement Usuarios = XElement.Load(ArquivoXML);

                IEnumerable<XElement> pessoa = from p in Usuarios.Elements("Usuario")
                                               where p.Element("Login").Value.IndexOf(lblNomeUsuario.Text.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0
                                               select p;

                foreach (XElement ex in pessoa)
                {
                    ex.SetElementValue("Senha", CriptarDecriptar(textBox1.Text.ToString()));
                }
                MessageBox.Show("Alteração realizada com sucesso!");
                Usuarios.Save(ArquivoXML);

                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox1.Focus();
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsUpper(e.KeyChar)) && !(char.IsLower(e.KeyChar)) && !(char.IsDigit(e.KeyChar)) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
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

    }
}
