namespace Agenda
{
    partial class frmCadastroUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeletar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Firebrick;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.lblOpcao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(820, 70);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackgroundImage = global::Agenda.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Agenda.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(131, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cadastro de Usuários";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpcao
            // 
            this.lblOpcao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.ForeColor = System.Drawing.Color.White;
            this.lblOpcao.Location = new System.Drawing.Point(643, 23);
            this.lblOpcao.Margin = new System.Windows.Forms.Padding(300, 0, 3, 0);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(0, 24);
            this.lblOpcao.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNovo,
            this.mnuAlterar,
            this.mnuConsultar,
            this.mnuDeletar,
            this.btnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 20, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(121, 403);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuNovo
            // 
            this.mnuNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNovo.ForeColor = System.Drawing.SystemColors.Window;
            this.mnuNovo.Image = global::Agenda.Properties.Resources.Add;
            this.mnuNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuNovo.Name = "mnuNovo";
            this.mnuNovo.Padding = new System.Windows.Forms.Padding(4);
            this.mnuNovo.Size = new System.Drawing.Size(108, 29);
            this.mnuNovo.Text = "    &Novo";
            this.mnuNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuNovo.Click += new System.EventHandler(this.mnuNovo_Click);
            // 
            // mnuAlterar
            // 
            this.mnuAlterar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAlterar.ForeColor = System.Drawing.SystemColors.Window;
            this.mnuAlterar.Image = global::Agenda.Properties.Resources.Modify;
            this.mnuAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAlterar.Name = "mnuAlterar";
            this.mnuAlterar.Padding = new System.Windows.Forms.Padding(4);
            this.mnuAlterar.Size = new System.Drawing.Size(108, 29);
            this.mnuAlterar.Text = "    &Alterar";
            this.mnuAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAlterar.Click += new System.EventHandler(this.mnuAlterar_Click);
            // 
            // mnuConsultar
            // 
            this.mnuConsultar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuConsultar.ForeColor = System.Drawing.SystemColors.Window;
            this.mnuConsultar.Image = global::Agenda.Properties.Resources.View;
            this.mnuConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuConsultar.Name = "mnuConsultar";
            this.mnuConsultar.Padding = new System.Windows.Forms.Padding(4);
            this.mnuConsultar.Size = new System.Drawing.Size(108, 29);
            this.mnuConsultar.Text = "    &Consultar";
            this.mnuConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuConsultar.Click += new System.EventHandler(this.mnuConsultar_Click);
            // 
            // mnuDeletar
            // 
            this.mnuDeletar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDeletar.ForeColor = System.Drawing.SystemColors.Window;
            this.mnuDeletar.Image = global::Agenda.Properties.Resources.Delete;
            this.mnuDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuDeletar.Name = "mnuDeletar";
            this.mnuDeletar.Padding = new System.Windows.Forms.Padding(4);
            this.mnuDeletar.Size = new System.Drawing.Size(108, 29);
            this.mnuDeletar.Text = "    &Excluir";
            this.mnuDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuDeletar.Click += new System.EventHandler(this.mnuDeletar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::Agenda.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 52);
            this.btnSair.Text = "&S A I R";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(121, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLimparLista);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.txtSenha);
            this.splitContainer1.Panel2.Controls.Add(this.lblSenha);
            this.splitContainer1.Panel2.Controls.Add(this.txtLogin);
            this.splitContainer1.Panel2.Controls.Add(this.txtNomeUsuario);
            this.splitContainer1.Panel2.Controls.Add(this.txtRegistro);
            this.splitContainer1.Panel2.Controls.Add(this.txtCodigo);
            this.splitContainer1.Panel2.Controls.Add(this.lblLogin);
            this.splitContainer1.Panel2.Controls.Add(this.lblNome);
            this.splitContainer1.Panel2.Controls.Add(this.lblRegistro);
            this.splitContainer1.Panel2.Controls.Add(this.lblCodigo);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(699, 403);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.Visible = false;
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparLista.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLimparLista.Image = global::Agenda.Properties.Resources.clear;
            this.btnLimparLista.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimparLista.Location = new System.Drawing.Point(91, 352);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(135, 38);
            this.btnLimparLista.TabIndex = 3;
            this.btnLimparLista.Text = "&Limpar Lista";
            this.btnLimparLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.OldLace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 306);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.toolStrip2.Size = new System.Drawing.Size(303, 37);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.TabStop = true;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoToolTip = true;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 24);
            this.toolStripLabel1.Text = "&Pesquisar:";
            this.toolStripLabel1.ToolTipText = "Pesquisa Nome ou partes do nome cadastrado";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AcceptsReturn = true;
            this.toolStripTextBox1.AcceptsTab = true;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(180, 27);
            this.toolStripTextBox1.ToolTipText = "Digite o Nome ou partes do nome cadastrado";
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Agenda.Properties.Resources.Find;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Pesquisa Nome ou partes do nome cadastrado";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     Tipos de Usuários: ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderSize = 3;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(213, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(130, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "U";
            this.radioButton2.Text = "&Usuário (consultas)";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatAppearance.BorderSize = 3;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(22, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "A";
            this.radioButton1.Text = "&Administrador do Sistema";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGravar.Image = global::Agenda.Properties.Resources.Save;
            this.btnGravar.Location = new System.Drawing.Point(141, 354);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(107, 36);
            this.btnGravar.TabIndex = 33;
            this.btnGravar.Text = "   &Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptsReturn = true;
            this.txtSenha.AcceptsTab = true;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(67, 244);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(186, 21);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_Validating);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(20, 247);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(65, 116);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(208, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeUsuario.Location = new System.Drawing.Point(65, 73);
            this.txtNomeUsuario.MaxLength = 60;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(314, 20);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Location = new System.Drawing.Point(279, 31);
            this.txtRegistro.MaxLength = 6;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro.TabIndex = 0;
            this.txtRegistro.TextChanged += new System.EventHandler(this.txtRegistro_TextChanged);
            this.txtRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistro_KeyPress);
            this.txtRegistro.Validating += new System.ComponentModel.CancelEventHandler(this.txtRegistro_Validating);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(65, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 119);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(224, 33);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(49, 13);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Registro:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // frmCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 473);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Shown += new System.EventHandler(this.frmCadastroUsuarios_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroUsuarios_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCadastroUsuarios_KeyPress);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNovo;
        private System.Windows.Forms.ToolStripMenuItem mnuAlterar;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultar;
        private System.Windows.Forms.ToolStripMenuItem mnuDeletar;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}