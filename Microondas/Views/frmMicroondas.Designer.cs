namespace Microondas
{
    partial class frmMicroondas
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
            this.lblCaracter = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ttbCaracter = new System.Windows.Forms.Label();
            this.ttbCaracterCadastro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.cbbPotenciaCadastro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTempoCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMaisTrintaSeg = new System.Windows.Forms.Button();
            this.btnFrango = new System.Windows.Forms.Button();
            this.btnSopa = new System.Windows.Forms.Button();
            this.btnArroz = new System.Windows.Forms.Button();
            this.btnCarne = new System.Windows.Forms.Button();
            this.btnPipoca = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbProgramas = new System.Windows.Forms.ComboBox();
            this.mskTempoPrograma = new System.Windows.Forms.MaskedTextBox();
            this.cbbPotenciaPrograma = new System.Windows.Forms.ComboBox();
            this.ttbInfAquecimento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbInstrucao = new System.Windows.Forms.TextBox();
            this.lblPotLeng = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ofdAbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.maskTxtArq = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPotArq = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaracter
            // 
            this.lblCaracter.AutoSize = true;
            this.lblCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCaracter.Location = new System.Drawing.Point(28, 41);
            this.lblCaracter.Name = "lblCaracter";
            this.lblCaracter.Size = new System.Drawing.Size(0, 18);
            this.lblCaracter.TabIndex = 5;
            this.lblCaracter.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimer.Location = new System.Drawing.Point(41, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(150, 55);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.ttbInfAquecimento);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(7, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 436);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ttbInstrucao);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.ttbCaracter);
            this.groupBox3.Controls.Add(this.ttbCaracterCadastro);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ttbNome);
            this.groupBox3.Controls.Add(this.cbbPotenciaCadastro);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mskTempoCadastro);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(11, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 272);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PROGRAMA";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(174, 228);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 32);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(72, 228);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 32);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // ttbCaracter
            // 
            this.ttbCaracter.AutoSize = true;
            this.ttbCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbCaracter.Location = new System.Drawing.Point(11, 200);
            this.ttbCaracter.Name = "ttbCaracter";
            this.ttbCaracter.Size = new System.Drawing.Size(91, 17);
            this.ttbCaracter.TabIndex = 20;
            this.ttbCaracter.Text = "CARACTER*:";
            // 
            // ttbCaracterCadastro
            // 
            this.ttbCaracterCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbCaracterCadastro.Location = new System.Drawing.Point(102, 197);
            this.ttbCaracterCadastro.MaxLength = 1;
            this.ttbCaracterCadastro.Name = "ttbCaracterCadastro";
            this.ttbCaracterCadastro.Size = new System.Drawing.Size(215, 20);
            this.ttbCaracterCadastro.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "NOME*:";
            // 
            // ttbNome
            // 
            this.ttbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbNome.Location = new System.Drawing.Point(102, 27);
            this.ttbNome.MaxLength = 50;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(215, 20);
            this.ttbNome.TabIndex = 16;
            // 
            // cbbPotenciaCadastro
            // 
            this.cbbPotenciaCadastro.FormattingEnabled = true;
            this.cbbPotenciaCadastro.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbPotenciaCadastro.Location = new System.Drawing.Point(102, 167);
            this.cbbPotenciaCadastro.Name = "cbbPotenciaCadastro";
            this.cbbPotenciaCadastro.Size = new System.Drawing.Size(215, 21);
            this.cbbPotenciaCadastro.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "TEMPO*:";
            // 
            // mskTempoCadastro
            // 
            this.mskTempoCadastro.Location = new System.Drawing.Point(102, 134);
            this.mskTempoCadastro.Mask = "90:00";
            this.mskTempoCadastro.Name = "mskTempoCadastro";
            this.mskTempoCadastro.Size = new System.Drawing.Size(215, 20);
            this.mskTempoCadastro.TabIndex = 14;
            this.mskTempoCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "POTÊNCIA*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(623, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TEMP. COZIMENTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(623, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "POTÊNCIA:";
            // 
            // btnMaisTrintaSeg
            // 
            this.btnMaisTrintaSeg.Location = new System.Drawing.Point(738, 291);
            this.btnMaisTrintaSeg.Name = "btnMaisTrintaSeg";
            this.btnMaisTrintaSeg.Size = new System.Drawing.Size(103, 42);
            this.btnMaisTrintaSeg.TabIndex = 8;
            this.btnMaisTrintaSeg.Text = "+30 s";
            this.btnMaisTrintaSeg.UseVisualStyleBackColor = true;
            this.btnMaisTrintaSeg.Click += new System.EventHandler(this.btnMaisTrintaSeg_Click);
            // 
            // btnFrango
            // 
            this.btnFrango.Location = new System.Drawing.Point(626, 191);
            this.btnFrango.Name = "btnFrango";
            this.btnFrango.Size = new System.Drawing.Size(106, 42);
            this.btnFrango.TabIndex = 9;
            this.btnFrango.Text = "FRANGO";
            this.btnFrango.UseVisualStyleBackColor = true;
            this.btnFrango.Click += new System.EventHandler(this.btnFrango_Click);
            // 
            // btnSopa
            // 
            this.btnSopa.Location = new System.Drawing.Point(738, 191);
            this.btnSopa.Name = "btnSopa";
            this.btnSopa.Size = new System.Drawing.Size(103, 42);
            this.btnSopa.TabIndex = 10;
            this.btnSopa.Text = "SOPA";
            this.btnSopa.UseVisualStyleBackColor = true;
            this.btnSopa.Click += new System.EventHandler(this.btnSopa_Click);
            // 
            // btnArroz
            // 
            this.btnArroz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArroz.Location = new System.Drawing.Point(626, 239);
            this.btnArroz.Name = "btnArroz";
            this.btnArroz.Size = new System.Drawing.Size(106, 42);
            this.btnArroz.TabIndex = 11;
            this.btnArroz.Text = "ARROZ";
            this.btnArroz.UseVisualStyleBackColor = true;
            this.btnArroz.Click += new System.EventHandler(this.btnArroz_Click);
            // 
            // btnCarne
            // 
            this.btnCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarne.Location = new System.Drawing.Point(738, 239);
            this.btnCarne.Name = "btnCarne";
            this.btnCarne.Size = new System.Drawing.Size(103, 42);
            this.btnCarne.TabIndex = 12;
            this.btnCarne.Text = "CARNE";
            this.btnCarne.UseVisualStyleBackColor = true;
            this.btnCarne.Click += new System.EventHandler(this.btnCarne_Click);
            // 
            // btnPipoca
            // 
            this.btnPipoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPipoca.Location = new System.Drawing.Point(626, 291);
            this.btnPipoca.Name = "btnPipoca";
            this.btnPipoca.Size = new System.Drawing.Size(106, 42);
            this.btnPipoca.TabIndex = 13;
            this.btnPipoca.Text = "PIPOCA";
            this.btnPipoca.UseVisualStyleBackColor = true;
            this.btnPipoca.Click += new System.EventHandler(this.btnPipoca_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(626, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 42);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(740, 358);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(101, 42);
            this.btnPausar.TabIndex = 15;
            this.btnPausar.Text = "PAUSAR";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(626, 406);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(216, 42);
            this.btnLigar.TabIndex = 16;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(623, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "PROGRAMAS:";
            // 
            // cbbProgramas
            // 
            this.cbbProgramas.FormattingEnabled = true;
            this.cbbProgramas.Location = new System.Drawing.Point(738, 93);
            this.cbbProgramas.Name = "cbbProgramas";
            this.cbbProgramas.Size = new System.Drawing.Size(103, 21);
            this.cbbProgramas.TabIndex = 18;
            this.cbbProgramas.SelectedIndexChanged += new System.EventHandler(this.cbbProgramas_SelectedIndexChanged);
            // 
            // mskTempoPrograma
            // 
            this.mskTempoPrograma.Location = new System.Drawing.Point(738, 120);
            this.mskTempoPrograma.Mask = "90:00";
            this.mskTempoPrograma.Name = "mskTempoPrograma";
            this.mskTempoPrograma.Size = new System.Drawing.Size(103, 20);
            this.mskTempoPrograma.TabIndex = 19;
            this.mskTempoPrograma.ValidatingType = typeof(System.DateTime);
            // 
            // cbbPotenciaPrograma
            // 
            this.cbbPotenciaPrograma.FormattingEnabled = true;
            this.cbbPotenciaPrograma.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbPotenciaPrograma.Location = new System.Drawing.Point(738, 151);
            this.cbbPotenciaPrograma.Name = "cbbPotenciaPrograma";
            this.cbbPotenciaPrograma.Size = new System.Drawing.Size(103, 21);
            this.cbbPotenciaPrograma.TabIndex = 20;
            // 
            // ttbInfAquecimento
            // 
            this.ttbInfAquecimento.BackColor = System.Drawing.SystemColors.Window;
            this.ttbInfAquecimento.Enabled = false;
            this.ttbInfAquecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbInfAquecimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ttbInfAquecimento.Location = new System.Drawing.Point(361, 10);
            this.ttbInfAquecimento.Multiline = true;
            this.ttbInfAquecimento.Name = "ttbInfAquecimento";
            this.ttbInfAquecimento.Size = new System.Drawing.Size(232, 413);
            this.ttbInfAquecimento.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPotLeng);
            this.panel1.Controls.Add(this.lblCaracter);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Location = new System.Drawing.Point(626, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 73);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "INSTRUÇ*:";
            // 
            // ttbInstrucao
            // 
            this.ttbInstrucao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbInstrucao.Location = new System.Drawing.Point(102, 53);
            this.ttbInstrucao.MaxLength = 150;
            this.ttbInstrucao.Multiline = true;
            this.ttbInstrucao.Name = "ttbInstrucao";
            this.ttbInstrucao.Size = new System.Drawing.Size(215, 69);
            this.ttbInstrucao.TabIndex = 22;
            // 
            // lblPotLeng
            // 
            this.lblPotLeng.AutoSize = true;
            this.lblPotLeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotLeng.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPotLeng.Location = new System.Drawing.Point(26, 12);
            this.lblPotLeng.Name = "lblPotLeng";
            this.lblPotLeng.Size = new System.Drawing.Size(0, 18);
            this.lblPotLeng.TabIndex = 6;
            this.lblPotLeng.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "P";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPotArq);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtArquivo);
            this.groupBox1.Controls.Add(this.maskTxtArq);
            this.groupBox1.Controls.Add(this.btnAbrirArquivo);
            this.groupBox1.Location = new System.Drawing.Point(11, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 142);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARQUIVO";
            // 
            // ofdAbrirArquivo
            // 
            this.ofdAbrirArquivo.FileName = "openFileDialog1";
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArquivo.Location = new System.Drawing.Point(266, 22);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(51, 26);
            this.btnAbrirArquivo.TabIndex = 24;
            this.btnAbrirArquivo.Text = "....";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(14, 26);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.ReadOnly = true;
            this.txtArquivo.Size = new System.Drawing.Size(246, 20);
            this.txtArquivo.TabIndex = 26;
            // 
            // maskTxtArq
            // 
            this.maskTxtArq.Enabled = false;
            this.maskTxtArq.Location = new System.Drawing.Point(127, 68);
            this.maskTxtArq.Mask = "90:00";
            this.maskTxtArq.Name = "maskTxtArq";
            this.maskTxtArq.Size = new System.Drawing.Size(103, 20);
            this.maskTxtArq.TabIndex = 22;
            this.maskTxtArq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskTxtArq.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(11, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "TEMP. COZIMENTO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(11, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "POTÊNCIA:";
            // 
            // txtPotArq
            // 
            this.txtPotArq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPotArq.Enabled = false;
            this.txtPotArq.Location = new System.Drawing.Point(127, 100);
            this.txtPotArq.MaxLength = 50;
            this.txtPotArq.Name = "txtPotArq";
            this.txtPotArq.Size = new System.Drawing.Size(103, 20);
            this.txtPotArq.TabIndex = 24;
            this.txtPotArq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMicroondas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbbPotenciaPrograma);
            this.Controls.Add(this.mskTempoPrograma);
            this.Controls.Add(this.cbbProgramas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPipoca);
            this.Controls.Add(this.btnCarne);
            this.Controls.Add(this.btnArroz);
            this.Controls.Add(this.btnSopa);
            this.Controls.Add(this.btnFrango);
            this.Controls.Add(this.btnMaisTrintaSeg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMicroondas";
            this.Text = "MICROONDAS";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnMaisTrintaSeg;
        private System.Windows.Forms.Button btnFrango;
        private System.Windows.Forms.Button btnSopa;
        private System.Windows.Forms.Button btnArroz;
        private System.Windows.Forms.Button btnCarne;
        private System.Windows.Forms.Button btnPipoca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblCaracter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbProgramas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label ttbCaracter;
        private System.Windows.Forms.TextBox ttbCaracterCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.ComboBox cbbPotenciaCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTempoCadastro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTempoPrograma;
        private System.Windows.Forms.ComboBox cbbPotenciaPrograma;
        private System.Windows.Forms.TextBox ttbInfAquecimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbInstrucao;
        private System.Windows.Forms.Label lblPotLeng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArquivo;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.TextBox txtPotArq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskTxtArq;
    }
}

