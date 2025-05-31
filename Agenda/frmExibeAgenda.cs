using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Configuration;

namespace Agenda
{
    public partial class frmExibeAgenda : Form
    {
        static bool primeiro = true;
        public string stringconexao = ConfigurationManager.ConnectionStrings["CaminhoAgenda"].ConnectionString;
        public string usuarioLogado = "";

        public frmExibeAgenda()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string ArquivoXML = stringconexao + @"Agenda.xml";
            var prods = from p in XElement.Load((ArquivoXML)).Elements("Pessoa")
                        where p.Element("Nome").Value.Contains(toolStripTextBox1.Text)
                        select new
                        {
                            NomePessoa = p.Element("Nome").Value,
                            IdPessoa = p.Element("Codigo").Value
                        };

            listBox1.Items.Clear();

            foreach (var nomes in prods)
            {
                listBox1.Items.Add(nomes.NomePessoa);
            }

        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.toolStripButton1.PerformClick();
            }

        }


        private void frmExibeAgenda_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            XmlDocument oXML = new XmlDocument();
            XmlNodeList oNoLista = default(XmlNodeList);

            //Define o caminho do arquivo XML 
            string ArquivoXML = stringconexao + @"Agenda.xml";
            
            //carrega o arquivo XML
            oXML.Load(ArquivoXML);
            oNoLista = oXML.SelectNodes("/Pessoas/Pessoa");
            foreach (XmlNode oNo in oNoLista)
            {
                if (listBox1.SelectedItem != null)
                {
                    if (oNo.ChildNodes.Item(1).InnerText == listBox1.SelectedItem.ToString())
                    {
                        lblNome.Text = oNo.ChildNodes.Item(1).InnerText;
                        lblDDD1.Text = oNo.ChildNodes.Item(2).InnerText;
                        lblNumero1.Text = oNo.ChildNodes.Item(3).InnerText;
                        lblTipo1.Text = oNo.ChildNodes.Item(4).InnerText;

                        lblDDD2.Text = oNo.ChildNodes.Item(6).InnerText;
                        lblNumero2.Text = oNo.ChildNodes.Item(7).InnerText;
                        lblTipo2.Text = oNo.ChildNodes.Item(8).InnerText;
                        lblObs2.Text = oNo.ChildNodes.Item(9).InnerText;

                        lblDDD3.Text = oNo.ChildNodes.Item(10).InnerText;
                        lblNumero3.Text = oNo.ChildNodes.Item(11).InnerText;
                        lblTipo3.Text = oNo.ChildNodes.Item(12).InnerText;
                        lblObs3.Text = oNo.ChildNodes.Item(13).InnerText;

                        lblDDD4.Text = oNo.ChildNodes.Item(14).InnerText;
                        lblNumero4.Text = oNo.ChildNodes.Item(15).InnerText;
                        lblTipo3.Text = oNo.ChildNodes.Item(16).InnerText;
                        lblObs4.Text = oNo.ChildNodes.Item(17).InnerText;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument oXML = new XmlDocument();
            XmlNodeList oNoLista = default(XmlNodeList);

            //Define o caminho do arquivo XML 
            string ArquivoXML = stringconexao + @"Agenda.xml";
            
            //carrega o arquivo XML
            oXML.Load(ArquivoXML);
            oNoLista = oXML.SelectNodes("/Pessoas/Pessoa");
            foreach (XmlNode oNo in oNoLista)
            {
                if (listBox1.SelectedItem != null)
                {
                    if (oNo.ChildNodes.Item(1).InnerText == listBox1.SelectedItem.ToString())
                    {
                        lblNome.Text = oNo.ChildNodes.Item(1).InnerText;
                        lblDDD1.Text = oNo.ChildNodes.Item(2).InnerText;
                        lblNumero1.Text = oNo.ChildNodes.Item(3).InnerText;
                        lblTipo1.Text = oNo.ChildNodes.Item(4).InnerText;
                        lblObs1.Text = oNo.ChildNodes.Item(5).InnerText;

                        lblDDD2.Text = oNo.ChildNodes.Item(6).InnerText;
                        lblNumero2.Text = oNo.ChildNodes.Item(7).InnerText;
                        lblTipo2.Text = oNo.ChildNodes.Item(8).InnerText;
                        lblObs2.Text = oNo.ChildNodes.Item(9).InnerText;

                        lblDDD3.Text = oNo.ChildNodes.Item(10).InnerText;
                        lblNumero3.Text = oNo.ChildNodes.Item(11).InnerText;
                        lblTipo3.Text = oNo.ChildNodes.Item(12).InnerText;
                        lblObs3.Text = oNo.ChildNodes.Item(13).InnerText;

                        lblDDD4.Text = oNo.ChildNodes.Item(14).InnerText;
                        lblNumero4.Text = oNo.ChildNodes.Item(15).InnerText;
                        lblTipo3.Text = oNo.ChildNodes.Item(16).InnerText;
                        lblObs4.Text = oNo.ChildNodes.Item(17).InnerText;
                    }
                }
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            toolStripTextBox1.Text = "";
            lblNome.Text = "";
            lblDDD1.Text = "";
            lblDDD2.Text = "";
            lblDDD3.Text = "";
            lblDDD4.Text = "";
            lblNumero1.Text = "";
            lblNumero2.Text = "";
            lblNumero3.Text = "";
            lblNumero4.Text = "";
            lblTipo1.Text = "";
            lblTipo2.Text = "";
            lblTipo3.Text = "";
            lblTipo4.Text = "";
            primeiro = true;
            if (primeiro)
            {
                toolStripTextBox1.Focus();
                primeiro = false;
            }

        }

        private void frmExibeAgenda_Shown(object sender, EventArgs e)
        {
            if (primeiro)
            {
                toolStripTextBox1.Focus();
                primeiro = false;
            }
        }

        private void lblDDD3_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblObs4_Click(object sender, EventArgs e)
        {

        }

        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            frmTrocarSenha frmTrocar = new frmTrocarSenha();
            frmTrocar.trocarSenhaUsuLogado = usuarioLogado;
            frmTrocar.ShowDialog();
        }

        private void frmExibeAgenda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmExibeAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }       
}
