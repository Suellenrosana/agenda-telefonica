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
    public partial class frmCadastroAgenda : Form
    {
        static bool primeiro = true;
        static string Opcao = "";
        static string ProximoCodigo = "";
        public string stringconexao = ConfigurationManager.ConnectionStrings["CaminhoAgenda"].ConnectionString;

        public frmCadastroAgenda()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuNovo_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == String.Empty && ProximoCodigo == String.Empty)
            {
                string ArquivoXML = stringconexao + @"CodigosPessoas.xml";

                XElement Codigos = XElement.Load(ArquivoXML);
                IEnumerable<XElement> codigo =
                    from c in Codigos.Elements("Codigo")
                    select c;

                foreach (XElement prox in codigo)
                {
                    int codigoatual = Convert.ToInt32(prox.Value);
                    int proximo = codigoatual += 1;
                    string proxatualizado = Convert.ToString(proximo);

                    prox.SetElementValue("Proximo", proxatualizado);
                    txtCodigo.Text = proxatualizado;
                    ProximoCodigo = proxatualizado;
                    break;
                }
                Codigos.Save(ArquivoXML);

            }
            else
            {
                txtCodigo.Text = ProximoCodigo;
            }

            lblOpcao.Text = "N o v o";
            Opcao = "N";
            button2.Enabled = true;
            button2.Text = "   &Gravar";

            habilitarTextBoxes();

            primeiro = true;
            splitContainer1.Visible = true;
            splitContainer1.Panel1Collapsed = true;
            if (primeiro)
            {
                txtNome.Focus();
                primeiro = false;
            }
            
            limparTextBoxes();
            listBox1.Items.Clear();
            toolStripTextBox1.Text = "";

        }

        private void mnuAlterar_Click(object sender, EventArgs e)
        {

            lblOpcao.Text = "A l t e r a r";
            Opcao = "A";
            button2.Enabled = true;
            button2.Text = "   &Gravar";
            txtCodigo.Text = "";

            habilitarTextBoxes();
            limparTextBoxes();
            txtCodigo.Text = "";
            primeiro = true;
            splitContainer1.Visible = true;
            splitContainer1.Panel2Collapsed = false;
            splitContainer1.Panel1Collapsed = false;

            if (primeiro)
            {
                toolStripTextBox1.Focus();
                primeiro = false;
            }
            btnLimparLista.PerformClick();
        }

        private void frmCadastroAgenda_Load(object sender, EventArgs e)
        {
            string ArquivoXML = stringconexao + @"TiposNumeros.xml";

            var tipos = from p in XElement.Load((ArquivoXML)).Elements("Tipo")
                        select new
                        {
                            CodigoTipo = p.Element("Codigo"),
                            DescrTipo = p.Element("Descricao").Value
                        };

            foreach (var desctipos in tipos)
            {
                cmbTipos1.Items.Add(desctipos.DescrTipo);
                cmbTipos2.Items.Add(desctipos.DescrTipo);
                cmbTipos3.Items.Add(desctipos.DescrTipo);
                cmbTipos4.Items.Add(desctipos.DescrTipo);
            }
        }

        private void frmCadastroAgenda_Shown(object sender, EventArgs e)
        {
            if (primeiro)
            {
                toolStripTextBox1.Focus();
                primeiro = false;
            }

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
            listBox1.Focus();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.toolStripButton1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            toolStripTextBox1.Text = "";
            limparTextBoxes();
            toolStripTextBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                XmlDocument oXML = new XmlDocument();
                XmlNodeList oNoLista = default(XmlNodeList);

                string ArquivoXML = stringconexao + @"Agenda.xml";

                oXML.Load(ArquivoXML);
                oNoLista = oXML.SelectNodes("/Pessoas/Pessoa");
                foreach (XmlNode oNo in oNoLista)
                {
                    if (listBox1.SelectedItem != null)
                    {
                        if (oNo.ChildNodes.Item(1).InnerText == listBox1.SelectedItem.ToString())
                        {
                            txtCodigo.Text = oNo.ChildNodes.Item(0).InnerText;

                            txtNome.Text = oNo.ChildNodes.Item(1).InnerText;

                            txtDDD1.Text = oNo.ChildNodes.Item(2).InnerText;
                            txtNumero1.Text = oNo.ChildNodes.Item(3).InnerText;
                            cmbTipos1.Text = oNo.ChildNodes.Item(4).InnerText;
                            txtObs1.Text = oNo.ChildNodes.Item(5).InnerText;

                            txtDDD2.Text = oNo.ChildNodes.Item(6).InnerText;
                            txtNumero2.Text = oNo.ChildNodes.Item(7).InnerText;
                            cmbTipos2.Text = oNo.ChildNodes.Item(8).InnerText;
                            txtObs2.Text = oNo.ChildNodes.Item(9).InnerText;

                            txtDDD3.Text = oNo.ChildNodes.Item(10).InnerText;
                            txtNumero3.Text = oNo.ChildNodes.Item(11).InnerText;
                            cmbTipos3.Text = oNo.ChildNodes.Item(12).InnerText;
                            txtObs3.Text = oNo.ChildNodes.Item(13).InnerText;

                            txtDDD4.Text = oNo.ChildNodes.Item(14).InnerText;
                            txtNumero4.Text = oNo.ChildNodes.Item(15).InnerText;
                            cmbTipos3.Text = oNo.ChildNodes.Item(16).InnerText;
                            txtObs4.Text = oNo.ChildNodes.Item(17).InnerText;
                        }
                    }
                }
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
                            txtCodigo.Text = oNo.ChildNodes.Item(0).InnerText;

                            txtNome.Text = oNo.ChildNodes.Item(1).InnerText;

                            txtDDD1.Text = oNo.ChildNodes.Item(2).InnerText;
                            txtNumero1.Text = oNo.ChildNodes.Item(3).InnerText;
                            cmbTipos1.Text = oNo.ChildNodes.Item(4).InnerText;
                            txtObs1.Text = oNo.ChildNodes.Item(5).InnerText;

                            txtDDD2.Text = oNo.ChildNodes.Item(6).InnerText;
                            txtNumero2.Text = oNo.ChildNodes.Item(7).InnerText;
                            cmbTipos2.Text = oNo.ChildNodes.Item(8).InnerText;
                            txtObs2.Text = oNo.ChildNodes.Item(9).InnerText;

                            txtDDD3.Text = oNo.ChildNodes.Item(10).InnerText;
                            txtNumero3.Text = oNo.ChildNodes.Item(11).InnerText;
                            cmbTipos3.Text = oNo.ChildNodes.Item(12).InnerText;
                            txtObs3.Text = oNo.ChildNodes.Item(13).InnerText;

                            txtDDD4.Text = oNo.ChildNodes.Item(14).InnerText;
                            txtNumero4.Text = oNo.ChildNodes.Item(15).InnerText;
                            cmbTipos3.Text = oNo.ChildNodes.Item(16).InnerText;
                            txtObs4.Text = oNo.ChildNodes.Item(17).InnerText;
                        }
                }
            }

        }
        private void limparTextBoxes()
        {
            //txtCodigo.Text = "";
            txtNome.Text = "";

            txtDDD1.Text = "";
            txtNumero1.Text = "";
            txtObs1.Text = "";
            cmbTipos1.Text = "";

            txtDDD2.Text = "";
            txtNumero2.Text = "";
            txtObs2.Text = "";
            cmbTipos2.Text = "";

            txtDDD3.Text = "";
            txtNumero3.Text = "";
            txtObs3.Text = "";
            cmbTipos3.Text = "";

            txtDDD4.Text = "";
            txtNumero4.Text = "";
            txtObs4.Text = "";
            cmbTipos4.Text = "";
        }

        private void mnuConsultar_Click(object sender, EventArgs e)
        {
            lblOpcao.Text = "C o n s u l t a r";
            Opcao = "C";
            button2.Enabled = false;
            txtCodigo.Text = "";

            primeiro = true;
            splitContainer1.Visible = true;
            splitContainer1.Panel2Collapsed = false;
            splitContainer1.Panel1Collapsed = false;

            if (primeiro)
            {
                toolStripTextBox1.Focus();
                primeiro = false;
            }
            limparTextBoxes();
            txtCodigo.Text = "";
            desabilitarTextBoxes();
            btnLimparLista.PerformClick();

        }
        private void desabilitarTextBoxes()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            

            txtDDD1.Enabled = false;
            txtNumero1.Enabled = false;
            txtObs1.Enabled = false;
            cmbTipos1.Enabled = false;

            txtDDD2.Enabled = false;
            txtNumero2.Enabled = false;
            txtObs2.Enabled = false;
            cmbTipos2.Enabled = false;

            txtDDD3.Enabled = false;
            txtNumero3.Enabled = false;
            txtObs3.Enabled = false;
            cmbTipos3.Enabled = false;

            txtDDD4.Enabled = false;
            txtNumero4.Enabled = false;
            txtObs4.Enabled = false;
            cmbTipos4.Enabled = false;

        }

        private void habilitarTextBoxes()
        {
            txtNome.Enabled = true;

            txtDDD1.Enabled = true;
            txtNumero1.Enabled = true;
            txtObs1.Enabled = true;
            cmbTipos1.Enabled = true;

            txtDDD2.Enabled = true;
            txtNumero2.Enabled = true;
            txtObs2.Enabled = true;
            cmbTipos2.Enabled = true;

            txtDDD3.Enabled = true;
            txtNumero3.Enabled = true;
            txtObs3.Enabled = true;
            cmbTipos3.Enabled = true;

            txtDDD4.Enabled = true;
            txtNumero4.Enabled = true;
            txtObs4.Enabled = true;
            cmbTipos4.Enabled = true;

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOpcao_Click(object sender, EventArgs e)
        {

        }

        private void mnuDeletar_Click(object sender, EventArgs e)
        {
            lblOpcao.Text = "E x c l u i r";
            Opcao = "E";
            button2.Enabled = true;
            button2.Text = "   &Excluir";
            txtCodigo.Text = "";

            primeiro = true;
            splitContainer1.Visible = true;
            splitContainer1.Panel2Collapsed = false;
            splitContainer1.Panel1Collapsed = false;

            if (primeiro)
            {
                toolStripTextBox1.Focus();
                primeiro = false;
            }
            desabilitarTextBoxes();
            btnLimparLista.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "" || txtNumero1.Text == "" || cmbTipos1.Text == "" )
            {
                MessageBox.Show("Você deve preencher 'NOME' e 'NÚMERO DE TELEFONE' e 'TIPO', do Número Telefone #1, pelo menos");
                txtNome.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Gravar essas Informações?", "Gravar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if(Opcao=="N")
                    {
                        XmlDocument xmldoc = new XmlDocument();
                        string ArquivoXML = stringconexao + @"Agenda.xml";
                        xmldoc.Load(ArquivoXML);

                        XmlElement novoelemento = xmldoc.CreateElement("Pessoa");
                        XmlElement xmlcodigo = xmldoc.CreateElement("Codigo");
                        XmlElement xmlnome = xmldoc.CreateElement("Nome");

                        XmlElement xmlddd1 = xmldoc.CreateElement("DDD1");
                        XmlElement xmlnumero1 = xmldoc.CreateElement("Numero1");
                        XmlElement xmltipo1 = xmldoc.CreateElement("Tipo1");
                        XmlElement xmlobs1 = xmldoc.CreateElement("Observacao1");

                        XmlElement xmlddd2 = xmldoc.CreateElement("DDD2");
                        XmlElement xmlnumero2 = xmldoc.CreateElement("Numero2");
                        XmlElement xmltipo2 = xmldoc.CreateElement("Tipo2");
                        XmlElement xmlobs2 = xmldoc.CreateElement("Observacao2");

                        XmlElement xmlddd3 = xmldoc.CreateElement("DDD3");
                        XmlElement xmlnumero3 = xmldoc.CreateElement("Numero3");
                        XmlElement xmltipo3 = xmldoc.CreateElement("Tipo3");
                        XmlElement xmlobs3 = xmldoc.CreateElement("Observacao3");

                        XmlElement xmlddd4 = xmldoc.CreateElement("DDD4");
                        XmlElement xmlnumero4 = xmldoc.CreateElement("Numero4");
                        XmlElement xmltipo4 = xmldoc.CreateElement("Tipo4");
                        XmlElement xmlobs4 = xmldoc.CreateElement("Observacao4");

                        //atribui o que será escrito nos Textbox's aos elementos do xml !
                        xmlcodigo.InnerText = txtCodigo.Text = (txtCodigo.Text == "" ? " " : txtCodigo.Text);
                        xmlnome.InnerText = txtNome.Text = (txtNome.Text == "" ? " " : txtNome.Text);

                        xmlddd1.InnerText = txtDDD1.Text = (txtDDD1.Text == "" ? " " : txtDDD1.Text);
                        xmlnumero1.InnerText = txtNumero1.Text = (txtNumero1.Text == "" ? " " : txtNumero1.Text);
                        xmltipo1.InnerText = cmbTipos1.Text = (cmbTipos1.Text == "" ? " " : cmbTipos1.Text);
                        xmlobs1.InnerText = txtObs1.Text = (txtObs1.Text == "" ? " " : txtObs1.Text);

                        xmlddd2.InnerText = txtDDD2.Text = (txtDDD2.Text == "" ? " " : txtDDD2.Text);
                        xmlnumero2.InnerText = txtNumero2.Text = (txtNumero2.Text == "" ? " " : txtNumero2.Text);
                        xmltipo2.InnerText = cmbTipos2.Text = (cmbTipos2.Text == "" ? " " : cmbTipos2.Text);
                        xmlobs2.InnerText = txtObs2.Text = (txtObs2.Text == "" ? " " : txtObs2.Text);

                        xmlddd3.InnerText = txtDDD3.Text = (txtDDD3.Text == "" ? " " : txtDDD3.Text);
                        xmlnumero3.InnerText = txtNumero3.Text = (txtNumero3.Text == "" ? " " : txtNumero3.Text);
                        xmltipo3.InnerText = cmbTipos3.Text = (cmbTipos3.Text == "" ? " " : cmbTipos3.Text);
                        xmlobs3.InnerText = txtObs3.Text = (txtObs3.Text == "" ? " " : txtObs3.Text);

                        xmlddd4.InnerText = txtDDD4.Text = (txtDDD4.Text == "" ? " " : txtDDD4.Text);
                        xmlnumero4.InnerText = txtNumero4.Text = (txtNumero4.Text == "" ? " " : txtNumero4.Text);
                        xmltipo4.InnerText = cmbTipos4.Text = (cmbTipos4.Text == "" ? " " : cmbTipos4.Text);
                        xmlobs4.InnerText = txtObs4.Text = (txtObs4.Text == "" ? " " : txtObs4.Text);

                        //inclui os novos elementos à tabela Pessoa !
                        novoelemento.AppendChild(xmlcodigo);
                        novoelemento.AppendChild(xmlnome);

                        novoelemento.AppendChild(xmlddd1);
                        novoelemento.AppendChild(xmlnumero1);
                        novoelemento.AppendChild(xmltipo1);
                        novoelemento.AppendChild(xmlobs1);

                        novoelemento.AppendChild(xmlddd2);
                        novoelemento.AppendChild(xmlnumero2);
                        novoelemento.AppendChild(xmltipo2);
                        novoelemento.AppendChild(xmlobs2);

                        novoelemento.AppendChild(xmlddd3);
                        novoelemento.AppendChild(xmlnumero3);
                        novoelemento.AppendChild(xmltipo3);
                        novoelemento.AppendChild(xmlobs3);

                        novoelemento.AppendChild(xmlddd4);
                        novoelemento.AppendChild(xmlnumero4);
                        novoelemento.AppendChild(xmltipo4);
                        novoelemento.AppendChild(xmlobs4);

                        //inclui os novos elemtntos ao XML !
                        xmldoc.DocumentElement.AppendChild(novoelemento);

                        //salva no XML !
                        xmldoc.Save(ArquivoXML);
                        MessageBox.Show("Nova Agenda cadastrada com sucesso!");
                        txtCodigo.Text = "";
                        ProximoCodigo = "";
                        mnuNovo.PerformClick();

                    }
                    else if (Opcao == "A")
                    {
                        string ArquivoXML = stringconexao + @"Agenda.xml";
                        XElement Pessoas = XElement.Load(ArquivoXML);

                        IEnumerable<XElement> pessoa = from p in Pessoas.Elements("Pessoa")
                                                       where ((string)p.Element("Nome")).Equals(listBox1.SelectedItem)
                                                       select p;

                        foreach(XElement ex in pessoa)
                        {
                            ex.SetElementValue("Nome", txtNome.Text);

                            ex.SetElementValue("DDD1", txtDDD1.Text);
                            ex.SetElementValue("Numero1", txtNumero1.Text);
                            ex.SetElementValue("Tipo1", cmbTipos1.Text);
                            ex.SetElementValue("Observacao1", txtObs1.Text);

                            ex.SetElementValue("DDD2", txtDDD2.Text);
                            ex.SetElementValue("Numero2", txtNumero2.Text);
                            ex.SetElementValue("Tipo2", cmbTipos2.Text);
                            ex.SetElementValue("Observacao2", txtObs2.Text);

                            ex.SetElementValue("DDD3", txtDDD3.Text);
                            ex.SetElementValue("Numero3", txtNumero3.Text);
                            ex.SetElementValue("Tipo3", cmbTipos3.Text);
                            ex.SetElementValue("Observacao3", txtObs3.Text);

                            ex.SetElementValue("DDD4", txtDDD4.Text);
                            ex.SetElementValue("Numero4", txtNumero4.Text);
                            ex.SetElementValue("Tipo4", cmbTipos4.Text);
                            ex.SetElementValue("Observacao4", txtObs4.Text);
                        }
                        MessageBox.Show("Alteração realizada com sucesso!");
                        Pessoas.Save(ArquivoXML);
                        txtCodigo.Text = "";
                        limparTextBoxes();
                        this.toolStripButton1.PerformClick();

                    }
                    else if(Opcao == "E")
                    {
                        string ArquivoXML = stringconexao + @"Agenda.xml";
                        XElement Pessoas = XElement.Load(ArquivoXML);

                        IEnumerable<XElement> pessoa = from p in Pessoas.Elements("Pessoa")
                                                       where ((string)p.Element("Nome")).Equals(listBox1.SelectedItem)
                                                       select p;
                        foreach(XElement ex in pessoa)
                        {
                            ex.Element("Nome").Parent.Remove();
                        }
                        MessageBox.Show("Agenda Telefônica excluída com sucesso!");
                        Pessoas.Save(ArquivoXML);
                        txtCodigo.Text = "";
                        limparTextBoxes();
                        this.toolStripButton1.PerformClick();
                    }
                }
                else
                {
                    limparTextBoxes();
                    txtNome.Focus();
                }
            }
        }
        private void txtNumero1_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtDDD1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtDDD2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void txtDDD3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void txtDDD4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

        }

        private void txtNumero3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

        }

        private void txtNumero4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void frmCadastroAgenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }

        }

        private void cmbTipos1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            {

                e.Handled = true;

                SendKeys.Send("{tab}");

            }

        }

        private void cmbTipos1_Leave(object sender, EventArgs e)
        {

        }

        private void mnuTiposNumeros_Click(object sender, EventArgs e)
        {
        }

        private void btnTipos_Click(object sender, EventArgs e)
        {
            splitContainer1.Visible = false;
            uscTreeViewTipos cFunc = new uscTreeViewTipos();
            cFunc.Parent = this;
            this.Controls.Add(cFunc);
            cFunc.Location = new Point(140, 85);
            lblOpcao.Text = "Tipos de Números Telefônicos";
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void frmCadastroAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0112: // Esse é o codigo de uma mensagem referente a barra de titulo do formulario
                    int command = m.WParam.ToInt32() & 0xfff0;
                    // 0xF010 eh o codigo do comando "Restore" 
                    // 0xF120 eh o Duplo Clique da Barra
                    if ((new int[] { 0xF010, 0xF120 }).Contains(command))
                    {
                        // Se for executado qq um desses casos ignorar o comando (nao passar para o windows) ao menos q o form esteje minimizado.. ai continua...
                        if (this.WindowState != FormWindowState.Minimized) return;
                    }
                    break;
            }

            base.WndProc(ref m);
        }
    }
}
