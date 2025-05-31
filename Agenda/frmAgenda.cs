using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmAgenda : Form
    {
        public string usuLogadoAgenda = "";     // Essa variável fica disponível para toda a classe. 
                                                //Ela é responsável por guardar o login de quem entrou no sistema
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = this.BackgroundImage;

            frmLogin frmInicio = new frmLogin();    //Aqui é criada a instância do frmLogin e abre-se a tela de Login
            frmInicio.ShowDialog();
            usuLogadoAgenda = frmInicio.usuLogado;

            if (frmInicio.LiberaMenu=="S")      //Verifica se o perfil do usuário é Administrador(igual a "S")
                                                //e mostra a barra de menu principal
            {
                menuStrip1.Visible = true;
            }
            else      //Se não for perfil de Administrador, então exibe somente a tela de consulta geral da Agenda
            {
                frmExibeAgenda frmExAgenda = new frmExibeAgenda();
                //frmExAgenda.Location = new Point(180, 120);
                frmExAgenda.usuarioLogado = usuLogadoAgenda;    //Passa para a tela de consulta da Agenda, o nome de quem está logado.
                frmExAgenda.ShowDialog();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAgenda frmCadAgenda = new frmCadastroAgenda();
            //frmCadAgenda.Location = new Point(180, 100);
                
            frmCadAgenda.ShowDialog();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Encerra a aplicação
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)        //Evento click do botão "Usuários". Abre a tela de Cadastro de Usuários
        {
            frmCadastroUsuarios frmCadUsu = new frmCadastroUsuarios();
            //frmCadUsu.Location = new Point(250, 200);
            frmCadUsu.ShowDialog();
        }

        private void frmAgenda_Shown(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuStrip1_Resize(object sender, EventArgs e)
        {
            
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0112: // Esse é o codigo de uma mensagem referente a barra de titulo do formulario
                    int command = m.WParam.ToInt32() & 0xfff0;
                    // 0xF010 é o codigo do comando "Restore" 
                    // 0xF120 é o Duplo Clique da Barra
                    if ((new int[] { 0xF010, 0xF120 }).Contains(command))
                    {
                        // Se for executado qq um desses casos ignorar o comando 
                        //  (nao passar para o windows) ao menos q o form esteja minimizado.. ai continua...
                        if (this.WindowState != FormWindowState.Minimized) return;
                    }
                    break;
            }

            base.WndProc(ref m);
        }

        private void frmAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
