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
using System.Security.Cryptography;

namespace Agenda
{
    public partial class frmCadastroUsuarios : Form
    {
        static bool primeiro = true;
        static string Opcao = "";
        static string ProximoCodigo = "";
        static string senhaCripDecr = "";
        public string stringconexao = ConfigurationManager.ConnectionStrings["CaminhoAgenda"].ConnectionString;

        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuNovo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == String.Empty && ProximoCodigo == String.Empty)
            {
                string ArquivoXML = stringconexao + @"CodigosUsuarios.xml";

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
            btnGravar.Enabled = true;
            btnGravar.Text = "   &Gravar";

            habilitarTextBoxes();

            primeiro = true;
            splitContainer1.Visible = true;
            splitContainer1.Panel1Collapsed = true;
            if (primeiro)
            {
                txtRegistro.Focus();
                primeiro = false;
            }

            limparTextBoxes();
            listBox1.Items.Clear();
            toolStripTextBox1.Text = "";

        }
        private void habilitarTextBoxes()
        {
            txtNomeUsuario.Enabled = true;

            txtLogin.Enabled = true;
            txtRegistro.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void desabilitarTextBoxes()
        {
            txtNomeUsuario.Enabled = false;

            txtLogin.Enabled = false;
            txtRegistro.Enabled = false;
            txtSenha.Enabled = false;

        }
        private void limparTextBoxes()
        {
            //txtCodigo.Text = "";
            txtNomeUsuario.Text = "";

            txtRegistro.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCadastroUsuarios_Shown(object sender, EventArgs e)
        {
            if (primeiro)
            {
                toolStripTextBox1.Focus();
                primeiro = false;
            }
        }

        private void mnuAlterar_Click(object sender, EventArgs e)
        {
            lblOpcao.Text = "A l t e r a r";
            Opcao = "A";
            btnGravar.Enabled = true;
            btnGravar.Text = "   &Gravar";
            txtCodigo.Text = "";

            habilitarTextBoxes();
            limparTextBoxes();
            txtCodigo.Text = "";
            btnLimparLista.PerformClick();

            primeiro = true;
            splitContainer1.Visible = true;
            splitContainer1.Panel2Collapsed = false;
            splitContainer1.Panel1Collapsed = false;

            if (primeiro)
            {
                toolStripTextBox1.Focus();
                primeiro = false;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string ArquivoXML = stringconexao + @"Usuarios.xml";
            var prods = from p in XElement.Load((ArquivoXML)).Elements("Usuario")
                        where p.Element("Nome").Value.IndexOf(toolStripTextBox1.Text, StringComparison.InvariantCultureIgnoreCase) >= 0
                        select new
                        {
                            NomePessoa = p.Element("Nome").Value
                        };

            listBox1.Items.Clear();
            foreach (var nomes in prods)
            {
                listBox1.Items.Add(nomes.NomePessoa);
            }
            listBox1.Focus();
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            toolStripTextBox1.Text = "";
            txtCodigo.Text = "";
            limparTextBoxes();
            toolStripTextBox1.Focus();
        }

        private void mnuConsultar_Click(object sender, EventArgs e)
        {
            lblOpcao.Text = "C o n s u l t a r";
            Opcao = "C";
            btnGravar.Enabled = false;
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

        private void mnuDeletar_Click(object sender, EventArgs e)
        {
            lblOpcao.Text = "E x c l u i r";
            Opcao = "E";
            btnGravar.Enabled = true;
            btnGravar.Text = "   &Excluir";
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

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text == "" || txtRegistro.Text == "" || txtLogin.Text == "")
            {
                MessageBox.Show("Você deve preencher 'REGISTRO' e 'NOME' e 'LOGIN'");
                limparTextBoxes();
                txtNomeUsuario.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Gravar informações desse Usuário?", "Gravar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Opcao == "N")
                    {
                        string ArquivoXML = stringconexao + @"Usuarios.xml";

                        XElement Usuarios = XElement.Load(ArquivoXML);
                        XElement novoUsuario = new XElement("Usuario",
                            new XElement("Codigo", txtCodigo.Text),
                            new XElement("Nome", txtNomeUsuario.Text),
                            new XElement("Login", txtLogin.Text),
                            new XElement("TipoUsu", radioButton1.Checked ? radioButton1.Tag : radioButton2.Tag),
                            new XElement("Senha", senhaCripDecr),
                            new XElement("Registro", txtRegistro.Text)
                            );
                        MessageBox.Show("Novo Usuário cadastrado com sucesso!");
                        Usuarios.Add(novoUsuario);
                        Usuarios.Save(ArquivoXML);
                        limparTextBoxes();
                        ProximoCodigo = "";
                        txtCodigo.Text = "";
                        mnuNovo.PerformClick();

                    }
                    else if (Opcao == "A")
                    {
                        if (txtNomeUsuario.Text == "" || txtRegistro.Text == "" || txtLogin.Text == "" || txtSenha.Text == "")
                        {
                            MessageBox.Show("Você deve informar: 'NOME' e 'REGISTRO' e 'LOGIN' e 'SENHA'");
                            txtRegistro.Focus();
                        }
                        else
                        {
                            string ArquivoXML = stringconexao + @"Usuarios.xml";
                            XElement Usuarios = XElement.Load(ArquivoXML);

                            IEnumerable<XElement> pessoa = from p in Usuarios.Elements("Usuario")
                                                           where p.Element("Nome").Value.IndexOf(listBox1.SelectedItem.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0
                                                           select p;

                            foreach (XElement ex in pessoa)
                            {
                                ex.SetElementValue("Nome", txtNomeUsuario.Text);

                                ex.SetElementValue("Login", txtLogin.Text);
                                ex.SetElementValue("TipoUsu", radioButton1.Checked ? radioButton1.Tag : radioButton2.Tag);
                                ex.SetElementValue("Senha", senhaCripDecr);
                                ex.SetElementValue("Registro", txtRegistro.Text);
                            }
                            MessageBox.Show("Alteração realizada com sucesso!");
                            Usuarios.Save(ArquivoXML);
                            btnLimparLista.PerformClick();
                        }
                    }
                    else if (Opcao == "E")
                    {
                        string ArquivoXML = stringconexao + @"Usuarios.xml";
                        XElement Usuarios = XElement.Load(ArquivoXML);

                        IEnumerable<XElement> pessoa = from p in Usuarios.Elements("Pessoa")
                                                       where p.Element("Nome").Value.IndexOf(listBox1.SelectedItem.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0
                                                       select p;
                        foreach (XElement ex in pessoa)
                        {
                            ex.Element("Nome").Parent.Remove();
                        }

                        MessageBox.Show("Usuário excluído com sucesso!");
                        Usuarios.Save(ArquivoXML);
                        txtCodigo.Text = "";
                        limparTextBoxes();
                        this.toolStripButton1.PerformClick();

                    }
                }
            }
        }

        private void txtRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument oXML = new XmlDocument();
            XmlNodeList oNoLista = default(XmlNodeList);

            //Define o caminho do arquivo XML 
            string ArquivoXML = stringconexao + @"Usuarios.xml";

            //carrega o arquivo XML
            oXML.Load(ArquivoXML);
            oNoLista = oXML.SelectNodes("/Usuarios/Usuario");
            foreach (XmlNode oNo in oNoLista)
            {
                if(listBox1.SelectedItem != null)
                {
                    if (oNo.ChildNodes.Item(1).InnerText == listBox1.SelectedItem.ToString())
                    {
                        txtCodigo.Text = oNo.ChildNodes.Item(0).InnerText;

                        txtNomeUsuario.Text = oNo.ChildNodes.Item(1).InnerText;

                        txtLogin.Text = oNo.ChildNodes.Item(2).InnerText;

                        if (oNo.ChildNodes.Item(3).InnerText == "A")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        txtRegistro.Text = oNo.ChildNodes.Item(5).InnerText;
                    }
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            XmlDocument oXML = new XmlDocument();
            XmlNodeList oNoLista = default(XmlNodeList);

            //Define o caminho do arquivo XML 
            string ArquivoXML = stringconexao + @"Usuarios.xml";

            //carrega o arquivo XML
            oXML.Load(ArquivoXML);
            oNoLista = oXML.SelectNodes("/Usuarios/Usuario");
            foreach (XmlNode oNo in oNoLista)
            {   
                if (listBox1.SelectedItem != null)
                {
                    if (oNo.ChildNodes.Item(1).InnerText == listBox1.SelectedItem.ToString())
                    {
                        txtCodigo.Text = oNo.ChildNodes.Item(0).InnerText;

                        txtNomeUsuario.Text = oNo.ChildNodes.Item(1).InnerText;

                        txtLogin.Text = oNo.ChildNodes.Item(2).InnerText;

                        if (oNo.ChildNodes.Item(3).InnerText == "A")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        txtRegistro.Text = oNo.ChildNodes.Item(5).InnerText;
                    }

                }

            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigo.Text = "";
                limparTextBoxes();

                this.toolStripButton1.PerformClick();
            }

        }

        private void txtRegistro_Validating(object sender, CancelEventArgs e)
        {
            string ArquivoXML = stringconexao + @"Usuarios.xml";
            XElement Usuarios = XElement.Load(ArquivoXML);

            IEnumerable<XElement> Usuario =
                from b in Usuarios.Elements("Usuario")
                where ((string)b.Element("Registro")).Equals(txtRegistro.Text)
                select b;

            foreach (XElement ex in Usuario)
            {
                if(Opcao=="N")
                {
                    if(ex.Element("Registro").Value == txtRegistro.Text && ex.Element("Nome").Value != txtNomeUsuario.Text && txtNomeUsuario.Text != "")
                    {
                        MessageBox.Show("Registro já Existe!");
                        e.Cancel = true;
                    }
                }
                else
                {
                    if (ex.Element("Registro").Value != txtRegistro.Text)
                    {
                        if(Opcao=="A")
                        {
                            if(MessageBox.Show("Deseja alterar o Registro?","", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                e.Cancel = true;
                            }
                        }
                    }
                }
            }
        }

        private void frmCadastroUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsUpper(e.KeyChar)) && !(char.IsLower(e.KeyChar)) && !(char.IsDigit(e.KeyChar)) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void frmCadastroUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private static string CriptarDecriptar(string senha)
        {
            string textoTemp = "";

            string s = senha;

            foreach (char c in s)
            {
                if(c <= 128)
                {
                    textoTemp = textoTemp + char.ConvertFromUtf32(c + 128);
                }
                else if(c >= 128)
                {
                    textoTemp = textoTemp + char.ConvertFromUtf32(c - 128);
                }
            }

            return senha = textoTemp;
        }   
        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
            {
                senhaCripDecr = CriptarDecriptar(txtSenha.Text.ToString());
            }

        }

        private void txtRegistro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
