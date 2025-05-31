using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Configuration;

namespace Agenda
{
    public partial class uscTreeViewTipos : UserControl
    {
        public string stringconexao = ConfigurationManager.ConnectionStrings["CaminhoAgenda"].ConnectionString;

        public uscTreeViewTipos()
        {
            InitializeComponent();
        }

        private void uscTreeViewTipos_Load(object sender, EventArgs e)
        {
            string ArquivoXML = stringconexao + @"TiposNumeros.xml";
            treeView1.Nodes.Clear();

            TreeNode node = new TreeNode("Tipos de Números de Telefone");
            treeView1.Nodes.Add(node);

            XElement TiposNum = XElement.Load(ArquivoXML);
            var tipos = from p in XElement.Load((ArquivoXML)).Elements("Tipo")
                        select new
                        {
                            CodigoTipo = p.Element("Codigo"),
                            DescrTipo = p.Element("Descricao").Value
                        };

            foreach (var tipo in tipos)
            {
                TreeNode childNode = new TreeNode(tipo.DescrTipo);
                node.Nodes.Add(childNode);
                childNode.Tag = tipo.CodigoTipo.Value;
            }
            
            treeView1.ExpandAll();
            treeView1.Focus();

            ToolTip toolTip1 = new ToolTip();

            // Cria os tempos de espera dos ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Força o texto do ToolTip seja mostrado se o Form está ativo ou não
            toolTip1.ShowAlways = true;

            // Cria os ToolTip text 
            toolTip1.SetToolTip(this.textBox1, "Digite aqui o novo Tipo e tecle [ENTER]");
            toolTip1.SetToolTip(this.btnNovo, "Clique e abra um campo para digitar o novo Tipo");
            toolTip1.SetToolTip(this.btnDeletar, "Escolha o Tipo acima e clique aqui...");

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            if(textBox1.Visible && label1.Visible && treeView1.SelectedNode.Text != "Tipos de Números de Telefone")
            {
                textBox1.Visible = false;
                label1.Visible = false;
                if(treeView1.SelectedNode.Text != "Tipos de Números de Telefone")
                {
                    btnDeletar.Enabled = true;
                }
            }
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(treeView1.SelectedNode.Text != "")
            {
                if (e.KeyCode == Keys.Insert)
                {
                    textBox1.Enabled = true;
                    textBox1.Focus();
                }

                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Deseja deletar o Tipo: " + treeView1.SelectedNode.Text + " ?", "Tipos Números", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (treeView1.SelectedNode.Text == "Tipos de Números de Telefone")
                        {
                            MessageBox.Show("Não é possível deletar. Este não é um Tipo de Número!");
                        }
                        else
                        {
                            string ArquivoXML = stringconexao + @"TiposNumeros.xml";

                            XElement Tipos = XElement.Load(ArquivoXML);

                            IEnumerable<XElement> tipo = from b in Tipos.Elements("Tipo")
                                                         where ((string)b.Element("Codigo")).Equals(treeView1.SelectedNode.Tag.ToString())
                                                         select b;

                            foreach (XElement ex in tipo)
                            {
                                ex.Element("Descricao").Parent.Remove();
                            }

                            Tipos.Save(ArquivoXML);

                            treeView1.Nodes.Remove(treeView1.SelectedNode);
                            treeView1.ExpandAll();
                            MessageBox.Show("Tipo de Número Telefônico deletado com sucesso!!");
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if(MessageBox.Show("Deseja gravar o novo Tipo?","Tipo Nummérico",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        string proxNovo = "";
                        string ArquivoXML = stringconexao + @"CodigosTipos.xml";

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
                            proxNovo = proxatualizado;
                            break;
                        }

                        Codigos.Save(ArquivoXML);

                        treeView1.Nodes[0].Nodes.Add(textBox1.Text);
                        treeView1.Nodes[0].LastNode.Tag = proxNovo;
                        treeView1.ExpandAll();

                        string ArqXML = stringconexao + @"TiposNumeros.xml";
                        XElement Tipo = XElement.Load(ArqXML);
                        XElement novoCodigo = new XElement("Tipo",
                            new XElement("Codigo", proxNovo),
                            new XElement("Descricao", textBox1.Text)
                            );

                        Tipo.Add(novoCodigo);
                        Tipo.Save(ArqXML);

                        textBox1.Text = "";
                        label1.Visible = false;
                        textBox1.Visible = false;
                        btnDeletar.Enabled = true;

                        treeView1.ExpandAll();
                        treeView1.Refresh();

                        MessageBox.Show("Tipo de Número Telefônico cadastrado com sucesso!!");

                    }
                }
                else
                {
                    if(textBox1.Text == "")
                    {
                        MessageBox.Show("Não pode ser 'Em Branco'!!");
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

            btnDeletar.Enabled = false;

            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode.Text != "Tipos de Números de Telefone")
            {
                if (MessageBox.Show("Deseja deletar o Tipo: " + treeView1.SelectedNode.Text + " ?", "Tipos Números", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (treeView1.SelectedNode.Text != "")
                    {
                        if (treeView1.SelectedNode.Text == "Tipos de Números de Telefone")
                        {
                            MessageBox.Show("Não é possível deletar. Este não é um Tipo de Número!");
                        }
                        else
                        {
                            string ArquivoXML = stringconexao + @"TiposNumeros.xml";

                            XElement Tipos = XElement.Load(ArquivoXML);

                            IEnumerable<XElement> tipo = from b in Tipos.Elements("Tipo")
                                                         where ((string)b.Element("Codigo")).Equals(treeView1.SelectedNode.Tag.ToString())
                                                         select b;

                            foreach (XElement ex in tipo)
                            {
                                ex.Element("Descricao").Parent.Remove();
                            }

                            Tipos.Save(ArquivoXML);

                            treeView1.Nodes.Remove(treeView1.SelectedNode);
                            treeView1.ExpandAll();
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Não é possível deletar. Este não é um Tipo de Número!");
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
