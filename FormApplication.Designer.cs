namespace MCMP_Gestion_V01
{
    partial class FormApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplication));
            this.tableLayoutPanel_MainPage = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_MenuAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_GestionParam = new System.Windows.Forms.GroupBox();
            this.button_ParamQuit = new System.Windows.Forms.Button();
            this.groupBox_GestionInsc = new System.Windows.Forms.GroupBox();
            this.button_DelInsc = new System.Windows.Forms.Button();
            this.button_CreateInsc = new System.Windows.Forms.Button();
            this.button_MenuAdh = new System.Windows.Forms.Button();
            this.button_MenuInsc = new System.Windows.Forms.Button();
            this.button_MenuParam = new System.Windows.Forms.Button();
            this.groupBox_GestionAdh = new System.Windows.Forms.GroupBox();
            this.button_DeleteAdh = new System.Windows.Forms.Button();
            this.button_ModifAdh = new System.Windows.Forms.Button();
            this.button_CreateAdh = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Logo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.tabControl_Page = new System.Windows.Forms.TabControl();
            this.Activité = new System.Windows.Forms.TabPage();
            this.Adhérents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Head = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_SearchDate = new System.Windows.Forms.Label();
            this.dateTimePicker_Activité = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_SelectLang = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Search = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cda35_bd2DataSet1 = new MCMP_Gestion_V01.cda35_bd2DataSet1();
            this.aCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCTTableAdapter = new MCMP_Gestion_V01.cda35_bd2DataSet1TableAdapters.ACTTableAdapter();
            this.idactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinscLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daterdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieurdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieudestiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKtypeactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKadhcreateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKadhresponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel_MainPage.SuspendLayout();
            this.tableLayoutPanel_MenuAdmin.SuspendLayout();
            this.groupBox_GestionParam.SuspendLayout();
            this.groupBox_GestionInsc.SuspendLayout();
            this.groupBox_GestionAdh.SuspendLayout();
            this.flowLayoutPanel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.tabControl_Page.SuspendLayout();
            this.Activité.SuspendLayout();
            this.tableLayoutPanel_Head.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda35_bd2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_MainPage
            // 
            this.tableLayoutPanel_MainPage.ColumnCount = 2;
            this.tableLayoutPanel_MainPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel_MainPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MainPage.Controls.Add(this.tableLayoutPanel_MenuAdmin, 0, 1);
            this.tableLayoutPanel_MainPage.Controls.Add(this.flowLayoutPanel_Logo, 0, 0);
            this.tableLayoutPanel_MainPage.Controls.Add(this.tabControl_Page, 1, 1);
            this.tableLayoutPanel_MainPage.Controls.Add(this.tableLayoutPanel_Head, 1, 0);
            this.tableLayoutPanel_MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MainPage.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_MainPage.Name = "tableLayoutPanel_MainPage";
            this.tableLayoutPanel_MainPage.RowCount = 2;
            this.tableLayoutPanel_MainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1473F));
            this.tableLayoutPanel_MainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.8527F));
            this.tableLayoutPanel_MainPage.Size = new System.Drawing.Size(1284, 611);
            this.tableLayoutPanel_MainPage.TabIndex = 0;
            // 
            // tableLayoutPanel_MenuAdmin
            // 
            this.tableLayoutPanel_MenuAdmin.ColumnCount = 2;
            this.tableLayoutPanel_MenuAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.70833F));
            this.tableLayoutPanel_MenuAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.29167F));
            this.tableLayoutPanel_MenuAdmin.Controls.Add(this.groupBox_GestionParam, 1, 2);
            this.tableLayoutPanel_MenuAdmin.Controls.Add(this.groupBox_GestionInsc, 1, 1);
            this.tableLayoutPanel_MenuAdmin.Controls.Add(this.button_MenuAdh, 0, 0);
            this.tableLayoutPanel_MenuAdmin.Controls.Add(this.button_MenuInsc, 0, 1);
            this.tableLayoutPanel_MenuAdmin.Controls.Add(this.button_MenuParam, 0, 2);
            this.tableLayoutPanel_MenuAdmin.Controls.Add(this.groupBox_GestionAdh, 1, 0);
            this.tableLayoutPanel_MenuAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MenuAdmin.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel_MenuAdmin.Name = "tableLayoutPanel_MenuAdmin";
            this.tableLayoutPanel_MenuAdmin.RowCount = 3;
            this.tableLayoutPanel_MenuAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MenuAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MenuAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel_MenuAdmin.Size = new System.Drawing.Size(192, 543);
            this.tableLayoutPanel_MenuAdmin.TabIndex = 0;
            // 
            // groupBox_GestionParam
            // 
            this.groupBox_GestionParam.Controls.Add(this.button_ParamQuit);
            this.groupBox_GestionParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_GestionParam.Location = new System.Drawing.Point(84, 405);
            this.groupBox_GestionParam.Name = "groupBox_GestionParam";
            this.groupBox_GestionParam.Size = new System.Drawing.Size(105, 135);
            this.groupBox_GestionParam.TabIndex = 5;
            this.groupBox_GestionParam.TabStop = false;
            this.groupBox_GestionParam.Text = "Menu Paramètres";
            // 
            // button_ParamQuit
            // 
            this.button_ParamQuit.Location = new System.Drawing.Point(6, 56);
            this.button_ParamQuit.Name = "button_ParamQuit";
            this.button_ParamQuit.Size = new System.Drawing.Size(75, 23);
            this.button_ParamQuit.TabIndex = 1;
            this.button_ParamQuit.Text = "Quitter";
            this.button_ParamQuit.UseVisualStyleBackColor = true;
            this.button_ParamQuit.Click += new System.EventHandler(this.button_ParamQuit_Click);
            // 
            // groupBox_GestionInsc
            // 
            this.groupBox_GestionInsc.Controls.Add(this.button_DelInsc);
            this.groupBox_GestionInsc.Controls.Add(this.button_CreateInsc);
            this.groupBox_GestionInsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_GestionInsc.Location = new System.Drawing.Point(84, 204);
            this.groupBox_GestionInsc.Name = "groupBox_GestionInsc";
            this.groupBox_GestionInsc.Size = new System.Drawing.Size(105, 195);
            this.groupBox_GestionInsc.TabIndex = 4;
            this.groupBox_GestionInsc.TabStop = false;
            this.groupBox_GestionInsc.Text = "Menu Inscription";
            // 
            // button_DelInsc
            // 
            this.button_DelInsc.Location = new System.Drawing.Point(5, 86);
            this.button_DelInsc.Name = "button_DelInsc";
            this.button_DelInsc.Size = new System.Drawing.Size(75, 23);
            this.button_DelInsc.TabIndex = 2;
            this.button_DelInsc.Text = "Supprimer";
            this.button_DelInsc.UseVisualStyleBackColor = true;
            // 
            // button_CreateInsc
            // 
            this.button_CreateInsc.Location = new System.Drawing.Point(5, 51);
            this.button_CreateInsc.Name = "button_CreateInsc";
            this.button_CreateInsc.Size = new System.Drawing.Size(75, 23);
            this.button_CreateInsc.TabIndex = 1;
            this.button_CreateInsc.Text = "Créer";
            this.button_CreateInsc.UseVisualStyleBackColor = true;
            // 
            // button_MenuAdh
            // 
            this.button_MenuAdh.BackColor = System.Drawing.Color.DarkGray;
            this.button_MenuAdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_MenuAdh.Location = new System.Drawing.Point(3, 3);
            this.button_MenuAdh.Name = "button_MenuAdh";
            this.button_MenuAdh.Size = new System.Drawing.Size(75, 195);
            this.button_MenuAdh.TabIndex = 0;
            this.button_MenuAdh.Text = "Menu Adhérent";
            this.button_MenuAdh.UseVisualStyleBackColor = false;
            // 
            // button_MenuInsc
            // 
            this.button_MenuInsc.BackColor = System.Drawing.Color.DarkGray;
            this.button_MenuInsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_MenuInsc.Location = new System.Drawing.Point(3, 204);
            this.button_MenuInsc.Name = "button_MenuInsc";
            this.button_MenuInsc.Size = new System.Drawing.Size(75, 195);
            this.button_MenuInsc.TabIndex = 1;
            this.button_MenuInsc.Text = "Menu Inscription";
            this.button_MenuInsc.UseVisualStyleBackColor = false;
            // 
            // button_MenuParam
            // 
            this.button_MenuParam.BackColor = System.Drawing.Color.DarkGray;
            this.button_MenuParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_MenuParam.Location = new System.Drawing.Point(3, 405);
            this.button_MenuParam.Name = "button_MenuParam";
            this.button_MenuParam.Size = new System.Drawing.Size(75, 135);
            this.button_MenuParam.TabIndex = 2;
            this.button_MenuParam.Text = "Menu Paramètres";
            this.button_MenuParam.UseVisualStyleBackColor = false;
            // 
            // groupBox_GestionAdh
            // 
            this.groupBox_GestionAdh.Controls.Add(this.button_DeleteAdh);
            this.groupBox_GestionAdh.Controls.Add(this.button_ModifAdh);
            this.groupBox_GestionAdh.Controls.Add(this.button_CreateAdh);
            this.groupBox_GestionAdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_GestionAdh.Location = new System.Drawing.Point(84, 3);
            this.groupBox_GestionAdh.Name = "groupBox_GestionAdh";
            this.groupBox_GestionAdh.Size = new System.Drawing.Size(105, 195);
            this.groupBox_GestionAdh.TabIndex = 3;
            this.groupBox_GestionAdh.TabStop = false;
            this.groupBox_GestionAdh.Text = "Menu Adhérent";
            // 
            // button_DeleteAdh
            // 
            this.button_DeleteAdh.Location = new System.Drawing.Point(6, 140);
            this.button_DeleteAdh.Name = "button_DeleteAdh";
            this.button_DeleteAdh.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteAdh.TabIndex = 2;
            this.button_DeleteAdh.Text = "Supprimer";
            this.button_DeleteAdh.UseVisualStyleBackColor = true;
            // 
            // button_ModifAdh
            // 
            this.button_ModifAdh.Location = new System.Drawing.Point(6, 99);
            this.button_ModifAdh.Name = "button_ModifAdh";
            this.button_ModifAdh.Size = new System.Drawing.Size(75, 23);
            this.button_ModifAdh.TabIndex = 1;
            this.button_ModifAdh.Text = "Modifier Adhérent";
            this.button_ModifAdh.UseVisualStyleBackColor = true;
            // 
            // button_CreateAdh
            // 
            this.button_CreateAdh.Location = new System.Drawing.Point(6, 58);
            this.button_CreateAdh.Name = "button_CreateAdh";
            this.button_CreateAdh.Size = new System.Drawing.Size(75, 23);
            this.button_CreateAdh.TabIndex = 0;
            this.button_CreateAdh.Text = "Créer";
            this.button_CreateAdh.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Logo
            // 
            this.flowLayoutPanel_Logo.Controls.Add(this.pictureBox_Logo);
            this.flowLayoutPanel_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Logo.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_Logo.Name = "flowLayoutPanel_Logo";
            this.flowLayoutPanel_Logo.Size = new System.Drawing.Size(192, 56);
            this.flowLayoutPanel_Logo.TabIndex = 1;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Logo.Image = global::MCMP_Gestion_V01.Properties.Resources.logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(173, 47);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // tabControl_Page
            // 
            this.tabControl_Page.Controls.Add(this.Activité);
            this.tabControl_Page.Controls.Add(this.Adhérents);
            this.tabControl_Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Page.Location = new System.Drawing.Point(201, 65);
            this.tabControl_Page.Name = "tabControl_Page";
            this.tabControl_Page.SelectedIndex = 0;
            this.tabControl_Page.Size = new System.Drawing.Size(1080, 543);
            this.tabControl_Page.TabIndex = 2;
            // 
            // Activité
            // 
            this.Activité.Controls.Add(this.dataGridView1);
            this.Activité.Location = new System.Drawing.Point(4, 22);
            this.Activité.Name = "Activité";
            this.Activité.Padding = new System.Windows.Forms.Padding(3);
            this.Activité.Size = new System.Drawing.Size(1072, 517);
            this.Activité.TabIndex = 0;
            this.Activité.Text = "Activités";
            this.Activité.UseVisualStyleBackColor = true;
            // 
            // Adhérents
            // 
            this.Adhérents.Location = new System.Drawing.Point(4, 22);
            this.Adhérents.Name = "Adhérents";
            this.Adhérents.Padding = new System.Windows.Forms.Padding(3);
            this.Adhérents.Size = new System.Drawing.Size(1072, 517);
            this.Adhérents.TabIndex = 1;
            this.Adhérents.Text = "Adhérents";
            this.Adhérents.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Head
            // 
            this.tableLayoutPanel_Head.ColumnCount = 2;
            this.tableLayoutPanel_Head.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.16666F));
            this.tableLayoutPanel_Head.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.83333F));
            this.tableLayoutPanel_Head.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel_Head.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel_Head.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel_Head.Controls.Add(this.tableLayoutPanel_Search, 1, 1);
            this.tableLayoutPanel_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Head.Location = new System.Drawing.Point(201, 3);
            this.tableLayoutPanel_Head.Name = "tableLayoutPanel_Head";
            this.tableLayoutPanel_Head.RowCount = 2;
            this.tableLayoutPanel_Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Head.Size = new System.Drawing.Size(1080, 56);
            this.tableLayoutPanel_Head.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.30337F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.69663F));
            this.tableLayoutPanel2.Controls.Add(this.label_SearchDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_Activité, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 22);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label_SearchDate
            // 
            this.label_SearchDate.AutoSize = true;
            this.label_SearchDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_SearchDate.ForeColor = System.Drawing.Color.White;
            this.label_SearchDate.Location = new System.Drawing.Point(241, 0);
            this.label_SearchDate.Name = "label_SearchDate";
            this.label_SearchDate.Size = new System.Drawing.Size(149, 22);
            this.label_SearchDate.TabIndex = 1;
            this.label_SearchDate.Text = "Accès Rapide aux Activités  : ";
            this.label_SearchDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_Activité
            // 
            this.dateTimePicker_Activité.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_Activité.Location = new System.Drawing.Point(396, 3);
            this.dateTimePicker_Activité.Name = "dateTimePicker_Activité";
            this.dateTimePicker_Activité.Size = new System.Drawing.Size(287, 20);
            this.dateTimePicker_Activité.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.6779F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.3221F));
            this.tableLayoutPanel1.Controls.Add(this.label_SelectLang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(695, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 22);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label_SelectLang
            // 
            this.label_SelectLang.AutoSize = true;
            this.label_SelectLang.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_SelectLang.ForeColor = System.Drawing.Color.White;
            this.label_SelectLang.Location = new System.Drawing.Point(123, 0);
            this.label_SelectLang.Name = "label_SelectLang";
            this.label_SelectLang.Size = new System.Drawing.Size(94, 22);
            this.label_SelectLang.TabIndex = 0;
            this.label_SelectLang.Text = "Choisir une langue";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Français"});
            this.comboBox1.Location = new System.Drawing.Point(223, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Français";
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(3, 7);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(140, 13);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Gestion MCMP : Version 0.0";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_Search
            // 
            this.tableLayoutPanel_Search.ColumnCount = 2;
            this.tableLayoutPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.30337F));
            this.tableLayoutPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.69663F));
            this.tableLayoutPanel_Search.Controls.Add(this.textBox_Search, 1, 0);
            this.tableLayoutPanel_Search.Controls.Add(this.label_Search, 0, 0);
            this.tableLayoutPanel_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Search.Location = new System.Drawing.Point(695, 31);
            this.tableLayoutPanel_Search.Name = "tableLayoutPanel_Search";
            this.tableLayoutPanel_Search.RowCount = 1;
            this.tableLayoutPanel_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel_Search.Size = new System.Drawing.Size(382, 22);
            this.tableLayoutPanel_Search.TabIndex = 1;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(221, 3);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(158, 20);
            this.textBox_Search.TabIndex = 0;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Search.ForeColor = System.Drawing.Color.White;
            this.label_Search.Location = new System.Drawing.Point(103, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(112, 22);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Reccherche Rapide : ";
            this.label_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idactDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.datedebutDataGridViewTextBoxColumn,
            this.datefinDataGridViewTextBoxColumn,
            this.dateinscLimitDataGridViewTextBoxColumn,
            this.daterdvDataGridViewTextBoxColumn,
            this.lieurdvDataGridViewTextBoxColumn,
            this.lieudestiDataGridViewTextBoxColumn,
            this.fKtypeactDataGridViewTextBoxColumn,
            this.fKadhcreateurDataGridViewTextBoxColumn,
            this.fKadhresponDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1071, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // cda35_bd2DataSet1
            // 
            this.cda35_bd2DataSet1.DataSetName = "cda35_bd2DataSet1";
            this.cda35_bd2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCTBindingSource
            // 
            this.aCTBindingSource.DataMember = "ACT";
            this.aCTBindingSource.DataSource = this.cda35_bd2DataSet1;
            // 
            // aCTTableAdapter
            // 
            this.aCTTableAdapter.ClearBeforeFill = true;
            // 
            // idactDataGridViewTextBoxColumn
            // 
            this.idactDataGridViewTextBoxColumn.DataPropertyName = "Id_act";
            this.idactDataGridViewTextBoxColumn.HeaderText = "N°Activité";
            this.idactDataGridViewTextBoxColumn.Name = "idactDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Intitulé";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // datedebutDataGridViewTextBoxColumn
            // 
            this.datedebutDataGridViewTextBoxColumn.DataPropertyName = "date_debut";
            this.datedebutDataGridViewTextBoxColumn.HeaderText = "Début";
            this.datedebutDataGridViewTextBoxColumn.Name = "datedebutDataGridViewTextBoxColumn";
            // 
            // datefinDataGridViewTextBoxColumn
            // 
            this.datefinDataGridViewTextBoxColumn.DataPropertyName = "date_fin";
            this.datefinDataGridViewTextBoxColumn.HeaderText = "Fin";
            this.datefinDataGridViewTextBoxColumn.Name = "datefinDataGridViewTextBoxColumn";
            // 
            // dateinscLimitDataGridViewTextBoxColumn
            // 
            this.dateinscLimitDataGridViewTextBoxColumn.DataPropertyName = "date_inscLimit";
            this.dateinscLimitDataGridViewTextBoxColumn.HeaderText = "Limite inscription";
            this.dateinscLimitDataGridViewTextBoxColumn.Name = "dateinscLimitDataGridViewTextBoxColumn";
            // 
            // daterdvDataGridViewTextBoxColumn
            // 
            this.daterdvDataGridViewTextBoxColumn.DataPropertyName = "date_rdv";
            this.daterdvDataGridViewTextBoxColumn.HeaderText = "Date RdV";
            this.daterdvDataGridViewTextBoxColumn.Name = "daterdvDataGridViewTextBoxColumn";
            // 
            // lieurdvDataGridViewTextBoxColumn
            // 
            this.lieurdvDataGridViewTextBoxColumn.DataPropertyName = "lieu_rdv";
            this.lieurdvDataGridViewTextBoxColumn.HeaderText = "Lieu RdV";
            this.lieurdvDataGridViewTextBoxColumn.Name = "lieurdvDataGridViewTextBoxColumn";
            // 
            // lieudestiDataGridViewTextBoxColumn
            // 
            this.lieudestiDataGridViewTextBoxColumn.DataPropertyName = "lieu_desti";
            this.lieudestiDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.lieudestiDataGridViewTextBoxColumn.Name = "lieudestiDataGridViewTextBoxColumn";
            // 
            // fKtypeactDataGridViewTextBoxColumn
            // 
            this.fKtypeactDataGridViewTextBoxColumn.DataPropertyName = "FK_type_act";
            this.fKtypeactDataGridViewTextBoxColumn.HeaderText = "FK_type_act";
            this.fKtypeactDataGridViewTextBoxColumn.Name = "fKtypeactDataGridViewTextBoxColumn";
            // 
            // fKadhcreateurDataGridViewTextBoxColumn
            // 
            this.fKadhcreateurDataGridViewTextBoxColumn.DataPropertyName = "FK_adh_createur";
            this.fKadhcreateurDataGridViewTextBoxColumn.HeaderText = "FK_adh_createur";
            this.fKadhcreateurDataGridViewTextBoxColumn.Name = "fKadhcreateurDataGridViewTextBoxColumn";
            // 
            // fKadhresponDataGridViewTextBoxColumn
            // 
            this.fKadhresponDataGridViewTextBoxColumn.DataPropertyName = "FK_adh_respon";
            this.fKadhresponDataGridViewTextBoxColumn.HeaderText = "FK_adh_respon";
            this.fKadhresponDataGridViewTextBoxColumn.Name = "fKadhresponDataGridViewTextBoxColumn";
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.tableLayoutPanel_MainPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApplication";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application de Gestion MCMP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormApplication_FormClosing);
            this.Load += new System.EventHandler(this.FormApplication_Load);
            this.tableLayoutPanel_MainPage.ResumeLayout(false);
            this.tableLayoutPanel_MenuAdmin.ResumeLayout(false);
            this.groupBox_GestionParam.ResumeLayout(false);
            this.groupBox_GestionInsc.ResumeLayout(false);
            this.groupBox_GestionAdh.ResumeLayout(false);
            this.flowLayoutPanel_Logo.ResumeLayout(false);
            this.flowLayoutPanel_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.tabControl_Page.ResumeLayout(false);
            this.Activité.ResumeLayout(false);
            this.tableLayoutPanel_Head.ResumeLayout(false);
            this.tableLayoutPanel_Head.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_Search.ResumeLayout(false);
            this.tableLayoutPanel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda35_bd2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MainPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MenuAdmin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Logo;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.GroupBox groupBox_GestionParam;
        private System.Windows.Forms.Button button_ParamQuit;
        private System.Windows.Forms.GroupBox groupBox_GestionInsc;
        private System.Windows.Forms.Button button_DelInsc;
        private System.Windows.Forms.Button button_CreateInsc;
        private System.Windows.Forms.Button button_MenuAdh;
        private System.Windows.Forms.Button button_MenuInsc;
        private System.Windows.Forms.Button button_MenuParam;
        private System.Windows.Forms.GroupBox groupBox_GestionAdh;
        private System.Windows.Forms.Button button_DeleteAdh;
        private System.Windows.Forms.Button button_ModifAdh;
        private System.Windows.Forms.Button button_CreateAdh;
        private System.Windows.Forms.TabControl tabControl_Page;
        private System.Windows.Forms.TabPage Activité;
        private System.Windows.Forms.TabPage Adhérents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Head;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_SelectLang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_SearchDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Activité;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cda35_bd2DataSet1 cda35_bd2DataSet1;
        private System.Windows.Forms.BindingSource aCTBindingSource;
        private cda35_bd2DataSet1TableAdapters.ACTTableAdapter aCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinscLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daterdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieurdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieudestiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKtypeactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKadhcreateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKadhresponDataGridViewTextBoxColumn;
    }
}