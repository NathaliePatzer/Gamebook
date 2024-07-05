namespace GameBook
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txLancamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDataSet = new GameBook.GameDataSet();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.plataformasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txConsultarGenero = new System.Windows.Forms.TextBox();
            this.btConsultarGenero = new System.Windows.Forms.Button();
            this.btInsertGenero = new System.Windows.Forms.Button();
            this.btUpdateGenero = new System.Windows.Forms.Button();
            this.btDeleteGenero = new System.Windows.Forms.Button();
            this.txInsertGenero = new System.Windows.Forms.TextBox();
            this.txInsertPlataforma = new System.Windows.Forms.TextBox();
            this.btDeletePlataforma = new System.Windows.Forms.Button();
            this.btUpdatePlataforma = new System.Windows.Forms.Button();
            this.btInsertPlataforma = new System.Windows.Forms.Button();
            this.btConsultarPlataforma = new System.Windows.Forms.Button();
            this.txConsultarPlataforma = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txConsulta = new System.Windows.Forms.TextBox();
            this.txConsultarHoras = new System.Windows.Forms.TextBox();
            this.txConsultarJogo = new System.Windows.Forms.TextBox();
            this.btMaisJogado = new System.Windows.Forms.Button();
            this.btTotalHoras = new System.Windows.Forms.Button();
            this.btConsultarHorasJogo = new System.Windows.Forms.Button();
            this.btConsultarAno = new System.Windows.Forms.Button();
            this.btConsultarNome = new System.Windows.Forms.Button();
            this.txHoras = new System.Windows.Forms.TextBox();
            this.cbAvaliacao = new System.Windows.Forms.ComboBox();
            this.avaliacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btSomarHoras = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.avaliacoesTableAdapter = new GameBook.GameDataSetTableAdapters.AvaliacoesTableAdapter();
            this.plataformasTableAdapter = new GameBook.GameDataSetTableAdapters.PlataformasTableAdapter();
            this.generosTableAdapter = new GameBook.GameDataSetTableAdapters.GenerosTableAdapter();
            this.txIdGenero = new System.Windows.Forms.TextBox();
            this.txIdPlataforma = new System.Windows.Forms.TextBox();
            this.txIdAvaliacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataformasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GridView1
            // 
            this.GridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.GridView1.Location = new System.Drawing.Point(485, 504);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(456, 139);
            this.GridView1.TabIndex = 1;
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txNome.Location = new System.Drawing.Point(78, 294);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(149, 21);
            this.txNome.TabIndex = 2;
            // 
            // txLancamento
            // 
            this.txLancamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLancamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txLancamento.Location = new System.Drawing.Point(78, 349);
            this.txLancamento.Name = "txLancamento";
            this.txLancamento.Size = new System.Drawing.Size(149, 21);
            this.txLancamento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.label1.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(90, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.label2.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(79, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lançado em";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.label3.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(81, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gênero";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.label4.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(79, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Plataforma";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.cbGenero.DataSource = this.generosBindingSource;
            this.cbGenero.DisplayMember = "Nome_Genero";
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(78, 404);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(122, 23);
            this.cbGenero.TabIndex = 10;
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.gameDataSet;
            // 
            // gameDataSet
            // 
            this.gameDataSet.DataSetName = "GameDataSet";
            this.gameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.cbPlataforma.DataSource = this.plataformasBindingSource;
            this.cbPlataforma.DisplayMember = "Nome_Plataforma";
            this.cbPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.Location = new System.Drawing.Point(78, 460);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(122, 23);
            this.cbPlataforma.TabIndex = 11;
            // 
            // plataformasBindingSource
            // 
            this.plataformasBindingSource.DataMember = "Plataformas";
            this.plataformasBindingSource.DataSource = this.gameDataSet;
            // 
            // txConsultarGenero
            // 
            this.txConsultarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txConsultarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConsultarGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txConsultarGenero.Location = new System.Drawing.Point(516, 255);
            this.txConsultarGenero.Name = "txConsultarGenero";
            this.txConsultarGenero.Size = new System.Drawing.Size(149, 21);
            this.txConsultarGenero.TabIndex = 12;
            // 
            // btConsultarGenero
            // 
            this.btConsultarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btConsultarGenero.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btConsultarGenero.Location = new System.Drawing.Point(516, 283);
            this.btConsultarGenero.Name = "btConsultarGenero";
            this.btConsultarGenero.Size = new System.Drawing.Size(149, 31);
            this.btConsultarGenero.TabIndex = 14;
            this.btConsultarGenero.Text = "CONSULTAR";
            this.btConsultarGenero.UseCompatibleTextRendering = true;
            this.btConsultarGenero.UseVisualStyleBackColor = false;
            this.btConsultarGenero.Click += new System.EventHandler(this.btConsultarGenero_Click);
            // 
            // btInsertGenero
            // 
            this.btInsertGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btInsertGenero.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btInsertGenero.Location = new System.Drawing.Point(516, 363);
            this.btInsertGenero.Name = "btInsertGenero";
            this.btInsertGenero.Size = new System.Drawing.Size(149, 31);
            this.btInsertGenero.TabIndex = 16;
            this.btInsertGenero.Text = "ADICIONAR";
            this.btInsertGenero.UseCompatibleTextRendering = true;
            this.btInsertGenero.UseVisualStyleBackColor = false;
            this.btInsertGenero.Click += new System.EventHandler(this.btInsertGenero_Click);
            // 
            // btUpdateGenero
            // 
            this.btUpdateGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btUpdateGenero.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btUpdateGenero.Location = new System.Drawing.Point(516, 402);
            this.btUpdateGenero.Name = "btUpdateGenero";
            this.btUpdateGenero.Size = new System.Drawing.Size(149, 31);
            this.btUpdateGenero.TabIndex = 17;
            this.btUpdateGenero.Text = "ALTERAR";
            this.btUpdateGenero.UseCompatibleTextRendering = true;
            this.btUpdateGenero.UseVisualStyleBackColor = false;
            this.btUpdateGenero.Click += new System.EventHandler(this.btUpdateGenero_Click);
            // 
            // btDeleteGenero
            // 
            this.btDeleteGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btDeleteGenero.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btDeleteGenero.Location = new System.Drawing.Point(516, 441);
            this.btDeleteGenero.Name = "btDeleteGenero";
            this.btDeleteGenero.Size = new System.Drawing.Size(149, 31);
            this.btDeleteGenero.TabIndex = 18;
            this.btDeleteGenero.Text = "EXCLUIR";
            this.btDeleteGenero.UseCompatibleTextRendering = true;
            this.btDeleteGenero.UseVisualStyleBackColor = false;
            this.btDeleteGenero.Click += new System.EventHandler(this.btDeleteGenero_Click);
            // 
            // txInsertGenero
            // 
            this.txInsertGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txInsertGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInsertGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txInsertGenero.Location = new System.Drawing.Point(516, 333);
            this.txInsertGenero.Name = "txInsertGenero";
            this.txInsertGenero.Size = new System.Drawing.Size(149, 21);
            this.txInsertGenero.TabIndex = 19;
            // 
            // txInsertPlataforma
            // 
            this.txInsertPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txInsertPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInsertPlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txInsertPlataforma.Location = new System.Drawing.Point(756, 331);
            this.txInsertPlataforma.Name = "txInsertPlataforma";
            this.txInsertPlataforma.Size = new System.Drawing.Size(149, 21);
            this.txInsertPlataforma.TabIndex = 25;
            // 
            // btDeletePlataforma
            // 
            this.btDeletePlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btDeletePlataforma.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletePlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btDeletePlataforma.Location = new System.Drawing.Point(756, 439);
            this.btDeletePlataforma.Name = "btDeletePlataforma";
            this.btDeletePlataforma.Size = new System.Drawing.Size(149, 31);
            this.btDeletePlataforma.TabIndex = 24;
            this.btDeletePlataforma.Text = "EXCLUIR";
            this.btDeletePlataforma.UseCompatibleTextRendering = true;
            this.btDeletePlataforma.UseVisualStyleBackColor = false;
            this.btDeletePlataforma.Click += new System.EventHandler(this.btDeletePlataforma_Click);
            // 
            // btUpdatePlataforma
            // 
            this.btUpdatePlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btUpdatePlataforma.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdatePlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btUpdatePlataforma.Location = new System.Drawing.Point(756, 400);
            this.btUpdatePlataforma.Name = "btUpdatePlataforma";
            this.btUpdatePlataforma.Size = new System.Drawing.Size(149, 31);
            this.btUpdatePlataforma.TabIndex = 23;
            this.btUpdatePlataforma.Text = "ALTERAR";
            this.btUpdatePlataforma.UseCompatibleTextRendering = true;
            this.btUpdatePlataforma.UseVisualStyleBackColor = false;
            this.btUpdatePlataforma.Click += new System.EventHandler(this.btUpdatePlataforma_Click);
            // 
            // btInsertPlataforma
            // 
            this.btInsertPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btInsertPlataforma.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertPlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btInsertPlataforma.Location = new System.Drawing.Point(756, 361);
            this.btInsertPlataforma.Name = "btInsertPlataforma";
            this.btInsertPlataforma.Size = new System.Drawing.Size(149, 31);
            this.btInsertPlataforma.TabIndex = 22;
            this.btInsertPlataforma.Text = "ADICIONAR";
            this.btInsertPlataforma.UseCompatibleTextRendering = true;
            this.btInsertPlataforma.UseVisualStyleBackColor = false;
            this.btInsertPlataforma.Click += new System.EventHandler(this.btInsertPlataforma_Click);
            // 
            // btConsultarPlataforma
            // 
            this.btConsultarPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btConsultarPlataforma.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarPlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btConsultarPlataforma.Location = new System.Drawing.Point(756, 281);
            this.btConsultarPlataforma.Name = "btConsultarPlataforma";
            this.btConsultarPlataforma.Size = new System.Drawing.Size(149, 31);
            this.btConsultarPlataforma.TabIndex = 21;
            this.btConsultarPlataforma.Text = "CONSULTAR";
            this.btConsultarPlataforma.UseCompatibleTextRendering = true;
            this.btConsultarPlataforma.UseVisualStyleBackColor = false;
            this.btConsultarPlataforma.Click += new System.EventHandler(this.btConsultarPlataforma_Click);
            // 
            // txConsultarPlataforma
            // 
            this.txConsultarPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txConsultarPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConsultarPlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txConsultarPlataforma.Location = new System.Drawing.Point(756, 253);
            this.txConsultarPlataforma.Name = "txConsultarPlataforma";
            this.txConsultarPlataforma.Size = new System.Drawing.Size(149, 21);
            this.txConsultarPlataforma.TabIndex = 20;
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btConsultar.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btConsultar.Location = new System.Drawing.Point(267, 227);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(43, 38);
            this.btConsultar.TabIndex = 26;
            this.btConsultar.Text = "<";
            this.btConsultar.UseCompatibleTextRendering = true;
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btInsert.Font = new System.Drawing.Font("Cambria Math", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btInsert.Location = new System.Drawing.Point(314, 227);
            this.btInsert.Name = "btInsert";
            this.btInsert.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btInsert.Size = new System.Drawing.Size(43, 38);
            this.btInsert.TabIndex = 27;
            this.btInsert.Text = "^";
            this.btInsert.UseCompatibleTextRendering = true;
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btUpdate.Font = new System.Drawing.Font("Cambria Math", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btUpdate.Location = new System.Drawing.Point(361, 227);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btUpdate.Size = new System.Drawing.Size(43, 38);
            this.btUpdate.TabIndex = 28;
            this.btUpdate.Text = "ˇ";
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btUpdate.UseCompatibleTextRendering = true;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btDelete.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btDelete.Location = new System.Drawing.Point(408, 227);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(43, 38);
            this.btDelete.TabIndex = 29;
            this.btDelete.Text = ">";
            this.btDelete.UseCompatibleTextRendering = true;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txConsulta
            // 
            this.txConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txConsulta.Location = new System.Drawing.Point(284, 117);
            this.txConsulta.Name = "txConsulta";
            this.txConsulta.Size = new System.Drawing.Size(149, 21);
            this.txConsulta.TabIndex = 30;
            // 
            // txConsultarHoras
            // 
            this.txConsultarHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txConsultarHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConsultarHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txConsultarHoras.Location = new System.Drawing.Point(284, 319);
            this.txConsultarHoras.Name = "txConsultarHoras";
            this.txConsultarHoras.Size = new System.Drawing.Size(149, 21);
            this.txConsultarHoras.TabIndex = 31;
            // 
            // txConsultarJogo
            // 
            this.txConsultarJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txConsultarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConsultarJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txConsultarJogo.Location = new System.Drawing.Point(284, 507);
            this.txConsultarJogo.Name = "txConsultarJogo";
            this.txConsultarJogo.Size = new System.Drawing.Size(149, 21);
            this.txConsultarJogo.TabIndex = 32;
            // 
            // btMaisJogado
            // 
            this.btMaisJogado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btMaisJogado.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaisJogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btMaisJogado.Location = new System.Drawing.Point(284, 420);
            this.btMaisJogado.Name = "btMaisJogado";
            this.btMaisJogado.Size = new System.Drawing.Size(43, 38);
            this.btMaisJogado.TabIndex = 33;
            this.btMaisJogado.Text = "@";
            this.btMaisJogado.UseCompatibleTextRendering = true;
            this.btMaisJogado.UseVisualStyleBackColor = false;
            this.btMaisJogado.Click += new System.EventHandler(this.btMaisJogado_Click);
            // 
            // btTotalHoras
            // 
            this.btTotalHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btTotalHoras.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTotalHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btTotalHoras.Location = new System.Drawing.Point(340, 420);
            this.btTotalHoras.Name = "btTotalHoras";
            this.btTotalHoras.Size = new System.Drawing.Size(43, 38);
            this.btTotalHoras.TabIndex = 34;
            this.btTotalHoras.Text = "/";
            this.btTotalHoras.UseCompatibleTextRendering = true;
            this.btTotalHoras.UseVisualStyleBackColor = false;
            this.btTotalHoras.Click += new System.EventHandler(this.btTotalHoras_Click);
            // 
            // btConsultarHorasJogo
            // 
            this.btConsultarHorasJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btConsultarHorasJogo.Font = new System.Drawing.Font("Cambria Math", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarHorasJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btConsultarHorasJogo.Location = new System.Drawing.Point(396, 420);
            this.btConsultarHorasJogo.Name = "btConsultarHorasJogo";
            this.btConsultarHorasJogo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btConsultarHorasJogo.Size = new System.Drawing.Size(43, 38);
            this.btConsultarHorasJogo.TabIndex = 35;
            this.btConsultarHorasJogo.Text = "*";
            this.btConsultarHorasJogo.UseCompatibleTextRendering = true;
            this.btConsultarHorasJogo.UseVisualStyleBackColor = false;
            this.btConsultarHorasJogo.Click += new System.EventHandler(this.btConsultarHorasJogo_Click);
            // 
            // btConsultarAno
            // 
            this.btConsultarAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btConsultarAno.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btConsultarAno.Location = new System.Drawing.Point(338, 545);
            this.btConsultarAno.Name = "btConsultarAno";
            this.btConsultarAno.Size = new System.Drawing.Size(95, 38);
            this.btConsultarAno.TabIndex = 36;
            this.btConsultarAno.Text = "ANO";
            this.btConsultarAno.UseCompatibleTextRendering = true;
            this.btConsultarAno.UseVisualStyleBackColor = false;
            this.btConsultarAno.Click += new System.EventHandler(this.btConsultarAno_Click);
            // 
            // btConsultarNome
            // 
            this.btConsultarNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btConsultarNome.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btConsultarNome.Location = new System.Drawing.Point(338, 599);
            this.btConsultarNome.Name = "btConsultarNome";
            this.btConsultarNome.Size = new System.Drawing.Size(95, 38);
            this.btConsultarNome.TabIndex = 37;
            this.btConsultarNome.Text = "NOME";
            this.btConsultarNome.UseCompatibleTextRendering = true;
            this.btConsultarNome.UseVisualStyleBackColor = false;
            this.btConsultarNome.Click += new System.EventHandler(this.btConsultarNome_Click);
            // 
            // txHoras
            // 
            this.txHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txHoras.Location = new System.Drawing.Point(78, 533);
            this.txHoras.Name = "txHoras";
            this.txHoras.Size = new System.Drawing.Size(56, 21);
            this.txHoras.TabIndex = 38;
            // 
            // cbAvaliacao
            // 
            this.cbAvaliacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.cbAvaliacao.DataSource = this.avaliacoesBindingSource;
            this.cbAvaliacao.DisplayMember = "Descricao";
            this.cbAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvaliacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.cbAvaliacao.FormattingEnabled = true;
            this.cbAvaliacao.Location = new System.Drawing.Point(78, 599);
            this.cbAvaliacao.Name = "cbAvaliacao";
            this.cbAvaliacao.Size = new System.Drawing.Size(122, 23);
            this.cbAvaliacao.TabIndex = 39;
            this.cbAvaliacao.ValueMember = "ID_Avaliacao";
            // 
            // avaliacoesBindingSource
            // 
            this.avaliacoesBindingSource.DataMember = "Avaliacoes";
            this.avaliacoesBindingSource.DataSource = this.gameDataSet;
            // 
            // btSomarHoras
            // 
            this.btSomarHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btSomarHoras.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomarHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btSomarHoras.Location = new System.Drawing.Point(193, 524);
            this.btSomarHoras.Name = "btSomarHoras";
            this.btSomarHoras.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btSomarHoras.Size = new System.Drawing.Size(34, 38);
            this.btSomarHoras.TabIndex = 40;
            this.btSomarHoras.Text = "#";
            this.btSomarHoras.UseCompatibleTextRendering = true;
            this.btSomarHoras.UseVisualStyleBackColor = false;
            this.btSomarHoras.Click += new System.EventHandler(this.btSomarHoras_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btLimpar.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btLimpar.Location = new System.Drawing.Point(284, 146);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(149, 24);
            this.btLimpar.TabIndex = 41;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseCompatibleTextRendering = true;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // avaliacoesTableAdapter
            // 
            this.avaliacoesTableAdapter.ClearBeforeFill = true;
            // 
            // plataformasTableAdapter
            // 
            this.plataformasTableAdapter.ClearBeforeFill = true;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // txIdGenero
            // 
            this.txIdGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txIdGenero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generosBindingSource, "ID_Genero", true));
            this.txIdGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txIdGenero.Location = new System.Drawing.Point(206, 404);
            this.txIdGenero.Name = "txIdGenero";
            this.txIdGenero.Size = new System.Drawing.Size(21, 20);
            this.txIdGenero.TabIndex = 42;
            // 
            // txIdPlataforma
            // 
            this.txIdPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txIdPlataforma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plataformasBindingSource, "ID_Plataforma", true));
            this.txIdPlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txIdPlataforma.Location = new System.Drawing.Point(206, 461);
            this.txIdPlataforma.Name = "txIdPlataforma";
            this.txIdPlataforma.Size = new System.Drawing.Size(21, 20);
            this.txIdPlataforma.TabIndex = 43;
            // 
            // txIdAvaliacao
            // 
            this.txIdAvaliacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.txIdAvaliacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avaliacoesBindingSource, "ID_Avaliacao", true));
            this.txIdAvaliacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(182)))));
            this.txIdAvaliacao.Location = new System.Drawing.Point(206, 601);
            this.txIdAvaliacao.Name = "txIdAvaliacao";
            this.txIdAvaliacao.Size = new System.Drawing.Size(21, 20);
            this.txIdAvaliacao.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 684);
            this.Controls.Add(this.txIdAvaliacao);
            this.Controls.Add(this.txIdPlataforma);
            this.Controls.Add(this.txIdGenero);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSomarHoras);
            this.Controls.Add(this.cbAvaliacao);
            this.Controls.Add(this.txHoras);
            this.Controls.Add(this.btConsultarNome);
            this.Controls.Add(this.btConsultarAno);
            this.Controls.Add(this.btConsultarHorasJogo);
            this.Controls.Add(this.btTotalHoras);
            this.Controls.Add(this.btMaisJogado);
            this.Controls.Add(this.txConsultarJogo);
            this.Controls.Add(this.txConsultarHoras);
            this.Controls.Add(this.txConsulta);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.txInsertPlataforma);
            this.Controls.Add(this.btDeletePlataforma);
            this.Controls.Add(this.btUpdatePlataforma);
            this.Controls.Add(this.btInsertPlataforma);
            this.Controls.Add(this.btConsultarPlataforma);
            this.Controls.Add(this.txConsultarPlataforma);
            this.Controls.Add(this.txInsertGenero);
            this.Controls.Add(this.btDeleteGenero);
            this.Controls.Add(this.btUpdateGenero);
            this.Controls.Add(this.btInsertGenero);
            this.Controls.Add(this.btConsultarGenero);
            this.Controls.Add(this.txConsultarGenero);
            this.Controls.Add(this.cbPlataforma);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txLancamento);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GameBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataformasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txLancamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbPlataforma;
        private System.Windows.Forms.TextBox txConsultarGenero;
        private System.Windows.Forms.Button btConsultarGenero;
        private System.Windows.Forms.Button btInsertGenero;
        private System.Windows.Forms.Button btUpdateGenero;
        private System.Windows.Forms.Button btDeleteGenero;
        private System.Windows.Forms.TextBox txInsertGenero;
        private System.Windows.Forms.TextBox txInsertPlataforma;
        private System.Windows.Forms.Button btDeletePlataforma;
        private System.Windows.Forms.Button btUpdatePlataforma;
        private System.Windows.Forms.Button btInsertPlataforma;
        private System.Windows.Forms.Button btConsultarPlataforma;
        private System.Windows.Forms.TextBox txConsultarPlataforma;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txConsulta;
        private System.Windows.Forms.TextBox txConsultarHoras;
        private System.Windows.Forms.TextBox txConsultarJogo;
        private System.Windows.Forms.Button btMaisJogado;
        private System.Windows.Forms.Button btTotalHoras;
        private System.Windows.Forms.Button btConsultarHorasJogo;
        private System.Windows.Forms.Button btConsultarAno;
        private System.Windows.Forms.Button btConsultarNome;
        private System.Windows.Forms.TextBox txHoras;
        private System.Windows.Forms.ComboBox cbAvaliacao;
        private System.Windows.Forms.Button btSomarHoras;
        private System.Windows.Forms.Button btLimpar;
        private GameDataSet gameDataSet;
        private System.Windows.Forms.BindingSource avaliacoesBindingSource;
        private GameDataSetTableAdapters.AvaliacoesTableAdapter avaliacoesTableAdapter;
        private System.Windows.Forms.BindingSource plataformasBindingSource;
        private GameDataSetTableAdapters.PlataformasTableAdapter plataformasTableAdapter;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private GameDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.TextBox txIdGenero;
        private System.Windows.Forms.TextBox txIdPlataforma;
        private System.Windows.Forms.TextBox txIdAvaliacao;
    }
}

