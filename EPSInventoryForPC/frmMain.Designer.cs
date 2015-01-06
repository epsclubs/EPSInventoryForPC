namespace EPSInventoryForPC
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1231241",
            "12",
            "23",
            "34",
            "432",
            "1231",
            "23432",
            "123124",
            "12412"}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ePSInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAboutText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxEditAmount = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button_EditOK = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBox_EditAmt = new System.Windows.Forms.TextBox();
            this.comboBox_EditAmt = new System.Windows.Forms.ComboBox();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.ChemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChemFormula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChemState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChemCurAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChemAlertAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChemIdealAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChemAmtPurch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChemNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SearchBar = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxViewState = new System.Windows.Forms.GroupBox();
            this.cboxFilter_StateGas = new System.Windows.Forms.CheckBox();
            this.cboxFilter_StateLiquid = new System.Windows.Forms.CheckBox();
            this.cboxFilter_StateSolid = new System.Windows.Forms.CheckBox();
            this.cboxFilter_StateAll = new System.Windows.Forms.CheckBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.cboxFilter_SearchFormula = new System.Windows.Forms.CheckBox();
            this.cboxFilter_SearchName = new System.Windows.Forms.CheckBox();
            this.cboxFilter_SearchChemID = new System.Windows.Forms.CheckBox();
            this.buttonFilter_ViewClr = new System.Windows.Forms.Button();
            this.SearchByItems = new System.Windows.Forms.Label();
            this.txtBoxFilter_ViewItems = new System.Windows.Forms.TextBox();
            this.txtFilter_Search = new System.Windows.Forms.TextBox();
            this.comboBoxFilter_ViewItems2 = new System.Windows.Forms.ComboBox();
            this.comboBoxFilter_ViewItems1 = new System.Windows.Forms.ComboBox();
            this.groupBoxViewStatus = new System.Windows.Forms.GroupBox();
            this.cboxFilter_StatusGreen = new System.Windows.Forms.CheckBox();
            this.cboxFilter_StatusYellow = new System.Windows.Forms.CheckBox();
            this.cboxFilter_StatusRed = new System.Windows.Forms.CheckBox();
            this.cboxFilter_StatusAll = new System.Windows.Forms.CheckBox();
            this.buttonFilter_SearchClr = new System.Windows.Forms.Button();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonEdit_Clear = new System.Windows.Forms.Button();
            this.buttonEdit_Cancel = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEdit_AlertAmt = new System.Windows.Forms.TextBox();
            this.txtEdit_Note = new System.Windows.Forms.TextBox();
            this.txtEdit_Usage = new System.Windows.Forms.TextBox();
            this.txtEdit_IdealAmt = new System.Windows.Forms.TextBox();
            this.txtEdit_Edit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonEdit_OK = new System.Windows.Forms.Button();
            this.comboEdit = new System.Windows.Forms.ComboBox();
            this.radioButtonEdit_Usage = new System.Windows.Forms.RadioButton();
            this.radioButtonEdit_Edit = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRemove_Confirm = new System.Windows.Forms.TextBox();
            this.buttonRemove_Confirm = new System.Windows.Forms.Button();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.buttonAdd_Clear = new System.Windows.Forms.Button();
            this.buttonAdd_Cancel = new System.Windows.Forms.Button();
            this.buttonAdd_OK = new System.Windows.Forms.Button();
            this.txtAdd_IdealAmt = new System.Windows.Forms.TextBox();
            this.txtAdd_AlertAmt = new System.Windows.Forms.TextBox();
            this.txtAdd_CurrAmt = new System.Windows.Forms.TextBox();
            this.txtAdd_State = new System.Windows.Forms.TextBox();
            this.txtAdd_Formula = new System.Windows.Forms.TextBox();
            this.txtAdd_Name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxEditAmount.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SearchBar.SuspendLayout();
            this.groupBoxViewState.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxViewStatus.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ePSInventoryToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1244, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ePSInventoryToolStripMenuItem
            // 
            this.ePSInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.preferenceToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.quitToolStripMenuItem});
            this.ePSInventoryToolStripMenuItem.Name = "ePSInventoryToolStripMenuItem";
            this.ePSInventoryToolStripMenuItem.Size = new System.Drawing.Size(91, 19);
            this.ePSInventoryToolStripMenuItem.Text = "EPS Inventory";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAboutText});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripAboutText
            // 
            this.toolStripAboutText.Name = "toolStripAboutText";
            this.toolStripAboutText.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.preferenceToolStripMenuItem.Text = "Preference";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem3.Text = "Log Out";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 717);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1244, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 692);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxEditAmount);
            this.panel1.Controls.Add(this.listViewMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 682);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxEditAmount
            // 
            this.groupBoxEditAmount.Controls.Add(this.label27);
            this.groupBoxEditAmount.Controls.Add(this.label26);
            this.groupBoxEditAmount.Controls.Add(this.label25);
            this.groupBoxEditAmount.Controls.Add(this.label20);
            this.groupBoxEditAmount.Controls.Add(this.button_EditOK);
            this.groupBoxEditAmount.Controls.Add(this.label21);
            this.groupBoxEditAmount.Controls.Add(this.label22);
            this.groupBoxEditAmount.Controls.Add(this.label23);
            this.groupBoxEditAmount.Controls.Add(this.label24);
            this.groupBoxEditAmount.Controls.Add(this.txtBox_EditAmt);
            this.groupBoxEditAmount.Controls.Add(this.comboBox_EditAmt);
            this.groupBoxEditAmount.Location = new System.Drawing.Point(0, 593);
            this.groupBoxEditAmount.Name = "groupBoxEditAmount";
            this.groupBoxEditAmount.Size = new System.Drawing.Size(906, 85);
            this.groupBoxEditAmount.TabIndex = 3;
            this.groupBoxEditAmount.TabStop = false;
            this.groupBoxEditAmount.Text = "Select a chemical and edit its amount";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(220, 55);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 21);
            this.label27.TabIndex = 22;
            this.label27.Text = "label27";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(220, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 21);
            this.label26.TabIndex = 21;
            this.label26.Text = "label26";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(64, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 21);
            this.label25.TabIndex = 20;
            this.label25.Text = "label25";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(74, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 21);
            this.label20.TabIndex = 19;
            this.label20.Text = "label20";
            // 
            // button_EditOK
            // 
            this.button_EditOK.Location = new System.Drawing.Point(777, 28);
            this.button_EditOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_EditOK.Name = "button_EditOK";
            this.button_EditOK.Size = new System.Drawing.Size(91, 37);
            this.button_EditOK.TabIndex = 18;
            this.button_EditOK.Text = "OK";
            this.button_EditOK.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 55);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 21);
            this.label21.TabIndex = 17;
            this.label21.Text = "State:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(142, 28);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 21);
            this.label22.TabIndex = 16;
            this.label22.Text = "Formula:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(158, 55);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 21);
            this.label23.TabIndex = 15;
            this.label23.Text = "Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 28);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 21);
            this.label24.TabIndex = 14;
            this.label24.Text = "ChemID:";
            // 
            // txtBox_EditAmt
            // 
            this.txtBox_EditAmt.Location = new System.Drawing.Point(468, 33);
            this.txtBox_EditAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_EditAmt.Name = "txtBox_EditAmt";
            this.txtBox_EditAmt.Size = new System.Drawing.Size(222, 29);
            this.txtBox_EditAmt.TabIndex = 10;
            // 
            // comboBox_EditAmt
            // 
            this.comboBox_EditAmt.FormattingEnabled = true;
            this.comboBox_EditAmt.Items.AddRange(new object[] {
            "Consume",
            "Input Amount",
            "Purchased Amount"});
            this.comboBox_EditAmt.Location = new System.Drawing.Point(340, 33);
            this.comboBox_EditAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_EditAmt.Name = "comboBox_EditAmt";
            this.comboBox_EditAmt.Size = new System.Drawing.Size(105, 29);
            this.comboBox_EditAmt.TabIndex = 11;
            this.comboBox_EditAmt.Text = "Comsume";
            // 
            // listViewMain
            // 
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChemID,
            this.ChemName,
            this.ChemFormula,
            this.ChemState,
            this.ChemCurAmt,
            this.ChemAlertAmt,
            this.ChemIdealAmt,
            this.ChemAmtPurch,
            this.ChemNote});
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.GridLines = true;
            this.listViewMain.HoverSelection = true;
            this.listViewMain.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewMain.LabelWrap = false;
            this.listViewMain.Location = new System.Drawing.Point(14, 5);
            this.listViewMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.ShowGroups = false;
            this.listViewMain.Size = new System.Drawing.Size(906, 606);
            this.listViewMain.TabIndex = 2;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.listViewMain_SelectedIndexChanged);
            // 
            // ChemID
            // 
            this.ChemID.Text = "Chem ID";
            this.ChemID.Width = 81;
            // 
            // ChemName
            // 
            this.ChemName.Text = "Name";
            // 
            // ChemFormula
            // 
            this.ChemFormula.Text = "Formula";
            // 
            // ChemState
            // 
            this.ChemState.Text = "State";
            // 
            // ChemCurAmt
            // 
            this.ChemCurAmt.Text = "Current Amount";
            this.ChemCurAmt.Width = 100;
            // 
            // ChemAlertAmt
            // 
            this.ChemAlertAmt.Text = "Alert Amount";
            this.ChemAlertAmt.Width = 100;
            // 
            // ChemIdealAmt
            // 
            this.ChemIdealAmt.Text = "Ideal Storage";
            this.ChemIdealAmt.Width = 100;
            // 
            // ChemAmtPurch
            // 
            this.ChemAmtPurch.Text = "Amount To Purchase";
            this.ChemAmtPurch.Width = 117;
            // 
            // ChemNote
            // 
            this.ChemNote.Text = "Note";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SearchBar);
            this.tabControl1.Controls.Add(this.tabPageEdit);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(918, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 682);
            this.tabControl1.TabIndex = 1;
            // 
            // SearchBar
            // 
            this.SearchBar.Controls.Add(this.label8);
            this.SearchBar.Controls.Add(this.groupBoxViewState);
            this.SearchBar.Controls.Add(this.groupBoxSearch);
            this.SearchBar.Controls.Add(this.buttonFilter_ViewClr);
            this.SearchBar.Controls.Add(this.SearchByItems);
            this.SearchBar.Controls.Add(this.txtBoxFilter_ViewItems);
            this.SearchBar.Controls.Add(this.txtFilter_Search);
            this.SearchBar.Controls.Add(this.comboBoxFilter_ViewItems2);
            this.SearchBar.Controls.Add(this.comboBoxFilter_ViewItems1);
            this.SearchBar.Controls.Add(this.groupBoxViewStatus);
            this.SearchBar.Controls.Add(this.buttonFilter_SearchClr);
            this.SearchBar.Location = new System.Drawing.Point(4, 30);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBar.Size = new System.Drawing.Size(314, 648);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.Text = "Filter";
            this.SearchBar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-4, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Search with keyword:";
            // 
            // groupBoxViewState
            // 
            this.groupBoxViewState.Controls.Add(this.cboxFilter_StateGas);
            this.groupBoxViewState.Controls.Add(this.cboxFilter_StateLiquid);
            this.groupBoxViewState.Controls.Add(this.cboxFilter_StateSolid);
            this.groupBoxViewState.Controls.Add(this.cboxFilter_StateAll);
            this.groupBoxViewState.Location = new System.Drawing.Point(161, 228);
            this.groupBoxViewState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxViewState.Name = "groupBoxViewState";
            this.groupBoxViewState.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxViewState.Size = new System.Drawing.Size(144, 183);
            this.groupBoxViewState.TabIndex = 8;
            this.groupBoxViewState.TabStop = false;
            this.groupBoxViewState.Text = "view state";
            // 
            // cboxFilter_StateGas
            // 
            this.cboxFilter_StateGas.AutoSize = true;
            this.cboxFilter_StateGas.Checked = true;
            this.cboxFilter_StateGas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_StateGas.Location = new System.Drawing.Point(10, 144);
            this.cboxFilter_StateGas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_StateGas.Name = "cboxFilter_StateGas";
            this.cboxFilter_StateGas.Size = new System.Drawing.Size(89, 25);
            this.cboxFilter_StateGas.TabIndex = 3;
            this.cboxFilter_StateGas.Text = "view gas";
            this.cboxFilter_StateGas.UseVisualStyleBackColor = true;
            // 
            // cboxFilter_StateLiquid
            // 
            this.cboxFilter_StateLiquid.AutoSize = true;
            this.cboxFilter_StateLiquid.Checked = true;
            this.cboxFilter_StateLiquid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_StateLiquid.Location = new System.Drawing.Point(10, 107);
            this.cboxFilter_StateLiquid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_StateLiquid.Name = "cboxFilter_StateLiquid";
            this.cboxFilter_StateLiquid.Size = new System.Drawing.Size(104, 25);
            this.cboxFilter_StateLiquid.TabIndex = 2;
            this.cboxFilter_StateLiquid.Text = "view liquid";
            this.cboxFilter_StateLiquid.UseVisualStyleBackColor = true;
            // 
            // cboxFilter_StateSolid
            // 
            this.cboxFilter_StateSolid.AutoSize = true;
            this.cboxFilter_StateSolid.Checked = true;
            this.cboxFilter_StateSolid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_StateSolid.Location = new System.Drawing.Point(10, 69);
            this.cboxFilter_StateSolid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_StateSolid.Name = "cboxFilter_StateSolid";
            this.cboxFilter_StateSolid.Size = new System.Drawing.Size(98, 25);
            this.cboxFilter_StateSolid.TabIndex = 1;
            this.cboxFilter_StateSolid.Text = "view solid";
            this.cboxFilter_StateSolid.UseVisualStyleBackColor = true;
            // 
            // cboxFilter_StateAll
            // 
            this.cboxFilter_StateAll.AutoSize = true;
            this.cboxFilter_StateAll.Checked = true;
            this.cboxFilter_StateAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_StateAll.Location = new System.Drawing.Point(10, 32);
            this.cboxFilter_StateAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_StateAll.Name = "cboxFilter_StateAll";
            this.cboxFilter_StateAll.Size = new System.Drawing.Size(81, 25);
            this.cboxFilter_StateAll.TabIndex = 0;
            this.cboxFilter_StateAll.Text = "view all";
            this.cboxFilter_StateAll.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.cboxFilter_SearchFormula);
            this.groupBoxSearch.Controls.Add(this.cboxFilter_SearchName);
            this.groupBoxSearch.Controls.Add(this.cboxFilter_SearchChemID);
            this.groupBoxSearch.Location = new System.Drawing.Point(0, 82);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSearch.Size = new System.Drawing.Size(305, 133);
            this.groupBoxSearch.TabIndex = 4;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "search for";
            // 
            // cboxFilter_SearchFormula
            // 
            this.cboxFilter_SearchFormula.AutoSize = true;
            this.cboxFilter_SearchFormula.Checked = true;
            this.cboxFilter_SearchFormula.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_SearchFormula.Location = new System.Drawing.Point(10, 84);
            this.cboxFilter_SearchFormula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_SearchFormula.Name = "cboxFilter_SearchFormula";
            this.cboxFilter_SearchFormula.Size = new System.Drawing.Size(87, 25);
            this.cboxFilter_SearchFormula.TabIndex = 3;
            this.cboxFilter_SearchFormula.Text = "Formula";
            this.cboxFilter_SearchFormula.UseVisualStyleBackColor = true;
            // 
            // cboxFilter_SearchName
            // 
            this.cboxFilter_SearchName.AutoSize = true;
            this.cboxFilter_SearchName.Checked = true;
            this.cboxFilter_SearchName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_SearchName.Location = new System.Drawing.Point(171, 49);
            this.cboxFilter_SearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_SearchName.Name = "cboxFilter_SearchName";
            this.cboxFilter_SearchName.Size = new System.Drawing.Size(71, 25);
            this.cboxFilter_SearchName.TabIndex = 2;
            this.cboxFilter_SearchName.Text = "Name";
            this.cboxFilter_SearchName.UseVisualStyleBackColor = true;
            // 
            // cboxFilter_SearchChemID
            // 
            this.cboxFilter_SearchChemID.AutoSize = true;
            this.cboxFilter_SearchChemID.Checked = true;
            this.cboxFilter_SearchChemID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_SearchChemID.Location = new System.Drawing.Point(10, 49);
            this.cboxFilter_SearchChemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_SearchChemID.Name = "cboxFilter_SearchChemID";
            this.cboxFilter_SearchChemID.Size = new System.Drawing.Size(85, 25);
            this.cboxFilter_SearchChemID.TabIndex = 1;
            this.cboxFilter_SearchChemID.Text = "ChemID";
            this.cboxFilter_SearchChemID.UseVisualStyleBackColor = true;
            // 
            // buttonFilter_ViewClr
            // 
            this.buttonFilter_ViewClr.Location = new System.Drawing.Point(277, 460);
            this.buttonFilter_ViewClr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFilter_ViewClr.Name = "buttonFilter_ViewClr";
            this.buttonFilter_ViewClr.Size = new System.Drawing.Size(34, 30);
            this.buttonFilter_ViewClr.TabIndex = 7;
            this.buttonFilter_ViewClr.Text = "X";
            this.buttonFilter_ViewClr.UseVisualStyleBackColor = true;
            // 
            // SearchByItems
            // 
            this.SearchByItems.AutoSize = true;
            this.SearchByItems.Location = new System.Drawing.Point(-4, 435);
            this.SearchByItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchByItems.Name = "SearchByItems";
            this.SearchByItems.Size = new System.Drawing.Size(146, 21);
            this.SearchByItems.TabIndex = 6;
            this.SearchByItems.Text = "View items that are:";
            // 
            // txtBoxFilter_ViewItems
            // 
            this.txtBoxFilter_ViewItems.Location = new System.Drawing.Point(214, 461);
            this.txtBoxFilter_ViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFilter_ViewItems.Name = "txtBoxFilter_ViewItems";
            this.txtBoxFilter_ViewItems.Size = new System.Drawing.Size(61, 29);
            this.txtBoxFilter_ViewItems.TabIndex = 5;
            // 
            // txtFilter_Search
            // 
            this.txtFilter_Search.Location = new System.Drawing.Point(0, 37);
            this.txtFilter_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilter_Search.Name = "txtFilter_Search";
            this.txtFilter_Search.Size = new System.Drawing.Size(275, 29);
            this.txtFilter_Search.TabIndex = 0;
            // 
            // comboBoxFilter_ViewItems2
            // 
            this.comboBoxFilter_ViewItems2.FormattingEnabled = true;
            this.comboBoxFilter_ViewItems2.Items.AddRange(new object[] {
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "!="});
            this.comboBoxFilter_ViewItems2.Location = new System.Drawing.Point(161, 460);
            this.comboBoxFilter_ViewItems2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFilter_ViewItems2.Name = "comboBoxFilter_ViewItems2";
            this.comboBoxFilter_ViewItems2.Size = new System.Drawing.Size(45, 29);
            this.comboBoxFilter_ViewItems2.TabIndex = 4;
            // 
            // comboBoxFilter_ViewItems1
            // 
            this.comboBoxFilter_ViewItems1.FormattingEnabled = true;
            this.comboBoxFilter_ViewItems1.Items.AddRange(new object[] {
            "ChemID",
            "Current Amount",
            "Alert Amount",
            "Ideal Storage",
            "Amount to Purchase"});
            this.comboBoxFilter_ViewItems1.Location = new System.Drawing.Point(-4, 461);
            this.comboBoxFilter_ViewItems1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFilter_ViewItems1.Name = "comboBoxFilter_ViewItems1";
            this.comboBoxFilter_ViewItems1.Size = new System.Drawing.Size(158, 29);
            this.comboBoxFilter_ViewItems1.TabIndex = 3;
            this.comboBoxFilter_ViewItems1.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_ViewItems1_SelectedIndexChanged);
            // 
            // groupBoxViewStatus
            // 
            this.groupBoxViewStatus.Controls.Add(this.cboxFilter_StatusGreen);
            this.groupBoxViewStatus.Controls.Add(this.cboxFilter_StatusYellow);
            this.groupBoxViewStatus.Controls.Add(this.cboxFilter_StatusRed);
            this.groupBoxViewStatus.Controls.Add(this.cboxFilter_StatusAll);
            this.groupBoxViewStatus.Location = new System.Drawing.Point(0, 228);
            this.groupBoxViewStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxViewStatus.Name = "groupBoxViewStatus";
            this.groupBoxViewStatus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxViewStatus.Size = new System.Drawing.Size(153, 183);
            this.groupBoxViewStatus.TabIndex = 2;
            this.groupBoxViewStatus.TabStop = false;
            this.groupBoxViewStatus.Text = "view status";
            // 
            // cboxFilter_StatusGreen
            // 
            this.cboxFilter_StatusGreen.AutoSize = true;
            this.cboxFilter_StatusGreen.Checked = true;
            this.cboxFilter_StatusGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_StatusGreen.Location = new System.Drawing.Point(10, 144);
            this.cboxFilter_StatusGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_StatusGreen.Name = "cboxFilter_StatusGreen";
            this.cboxFilter_StatusGreen.Size = new System.Drawing.Size(105, 25);
            this.cboxFilter_StatusGreen.TabIndex = 3;
            this.cboxFilter_StatusGreen.Text = "view green";
            this.cboxFilter_StatusGreen.UseVisualStyleBackColor = true;
            // 
            // cboxFilter_StatusYellow
            // 
            this.cboxFilter_StatusYellow.AutoSize = true;
            this.cboxFilter_StatusYellow.Checked = true;
            this.cboxFilter_StatusYellow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_StatusYellow.Location = new System.Drawing.Point(10, 107);
            this.cboxFilter_StatusYellow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_StatusYellow.Name = "cboxFilter_StatusYellow";
            this.cboxFilter_StatusYellow.Size = new System.Drawing.Size(110, 25);
            this.cboxFilter_StatusYellow.TabIndex = 2;
            this.cboxFilter_StatusYellow.Text = "view yellow";
            this.cboxFilter_StatusYellow.UseVisualStyleBackColor = true;
            // 
            // cboxFilter_StatusRed
            // 
            this.cboxFilter_StatusRed.AutoSize = true;
            this.cboxFilter_StatusRed.Checked = true;
            this.cboxFilter_StatusRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_StatusRed.Location = new System.Drawing.Point(10, 69);
            this.cboxFilter_StatusRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_StatusRed.Name = "cboxFilter_StatusRed";
            this.cboxFilter_StatusRed.Size = new System.Drawing.Size(88, 25);
            this.cboxFilter_StatusRed.TabIndex = 1;
            this.cboxFilter_StatusRed.Text = "view red";
            this.cboxFilter_StatusRed.UseVisualStyleBackColor = true;
            // 
            // cboxFilter_StatusAll
            // 
            this.cboxFilter_StatusAll.AutoSize = true;
            this.cboxFilter_StatusAll.Checked = true;
            this.cboxFilter_StatusAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxFilter_StatusAll.Location = new System.Drawing.Point(10, 32);
            this.cboxFilter_StatusAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFilter_StatusAll.Name = "cboxFilter_StatusAll";
            this.cboxFilter_StatusAll.Size = new System.Drawing.Size(81, 25);
            this.cboxFilter_StatusAll.TabIndex = 0;
            this.cboxFilter_StatusAll.Text = "view all";
            this.cboxFilter_StatusAll.UseVisualStyleBackColor = true;
            // 
            // buttonFilter_SearchClr
            // 
            this.buttonFilter_SearchClr.Location = new System.Drawing.Point(277, 37);
            this.buttonFilter_SearchClr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFilter_SearchClr.Name = "buttonFilter_SearchClr";
            this.buttonFilter_SearchClr.Size = new System.Drawing.Size(34, 29);
            this.buttonFilter_SearchClr.TabIndex = 1;
            this.buttonFilter_SearchClr.Text = "X";
            this.buttonFilter_SearchClr.UseVisualStyleBackColor = true;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.label31);
            this.tabPageEdit.Controls.Add(this.label30);
            this.tabPageEdit.Controls.Add(this.label29);
            this.tabPageEdit.Controls.Add(this.label28);
            this.tabPageEdit.Controls.Add(this.buttonEdit_Clear);
            this.tabPageEdit.Controls.Add(this.buttonEdit_Cancel);
            this.tabPageEdit.Controls.Add(this.label18);
            this.tabPageEdit.Controls.Add(this.label17);
            this.tabPageEdit.Controls.Add(this.txtEdit_AlertAmt);
            this.tabPageEdit.Controls.Add(this.txtEdit_Note);
            this.tabPageEdit.Controls.Add(this.txtEdit_Usage);
            this.tabPageEdit.Controls.Add(this.txtEdit_IdealAmt);
            this.tabPageEdit.Controls.Add(this.txtEdit_Edit);
            this.tabPageEdit.Controls.Add(this.label16);
            this.tabPageEdit.Controls.Add(this.label15);
            this.tabPageEdit.Controls.Add(this.label14);
            this.tabPageEdit.Controls.Add(this.buttonEdit_OK);
            this.tabPageEdit.Controls.Add(this.comboEdit);
            this.tabPageEdit.Controls.Add(this.radioButtonEdit_Usage);
            this.tabPageEdit.Controls.Add(this.radioButtonEdit_Edit);
            this.tabPageEdit.Controls.Add(this.label4);
            this.tabPageEdit.Controls.Add(this.label3);
            this.tabPageEdit.Controls.Add(this.label2);
            this.tabPageEdit.Controls.Add(this.label1);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 30);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageEdit.Size = new System.Drawing.Size(314, 648);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Edit";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            this.tabPageEdit.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(86, 106);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(61, 21);
            this.label31.TabIndex = 24;
            this.label31.Text = "label31";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(86, 85);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(61, 21);
            this.label30.TabIndex = 23;
            this.label30.Text = "label30";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(86, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(61, 21);
            this.label29.TabIndex = 22;
            this.label29.Text = "label29";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(86, 43);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 21);
            this.label28.TabIndex = 21;
            this.label28.Text = "label28";
            // 
            // buttonEdit_Clear
            // 
            this.buttonEdit_Clear.Location = new System.Drawing.Point(111, 594);
            this.buttonEdit_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit_Clear.Name = "buttonEdit_Clear";
            this.buttonEdit_Clear.Size = new System.Drawing.Size(104, 37);
            this.buttonEdit_Clear.TabIndex = 20;
            this.buttonEdit_Clear.Text = "Clear";
            this.buttonEdit_Clear.UseVisualStyleBackColor = true;
            // 
            // buttonEdit_Cancel
            // 
            this.buttonEdit_Cancel.Location = new System.Drawing.Point(0, 594);
            this.buttonEdit_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit_Cancel.Name = "buttonEdit_Cancel";
            this.buttonEdit_Cancel.Size = new System.Drawing.Size(103, 37);
            this.buttonEdit_Cancel.TabIndex = 19;
            this.buttonEdit_Cancel.Text = "Cancel";
            this.buttonEdit_Cancel.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-1, 384);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 21);
            this.label18.TabIndex = 18;
            this.label18.Text = "Note:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-1, 324);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 21);
            this.label17.TabIndex = 17;
            this.label17.Text = "Ideal Storage:";
            // 
            // txtEdit_AlertAmt
            // 
            this.txtEdit_AlertAmt.Location = new System.Drawing.Point(0, 290);
            this.txtEdit_AlertAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdit_AlertAmt.Name = "txtEdit_AlertAmt";
            this.txtEdit_AlertAmt.Size = new System.Drawing.Size(314, 29);
            this.txtEdit_AlertAmt.TabIndex = 16;
            // 
            // txtEdit_Note
            // 
            this.txtEdit_Note.Location = new System.Drawing.Point(0, 410);
            this.txtEdit_Note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdit_Note.Multiline = true;
            this.txtEdit_Note.Name = "txtEdit_Note";
            this.txtEdit_Note.Size = new System.Drawing.Size(314, 174);
            this.txtEdit_Note.TabIndex = 10;
            // 
            // txtEdit_Usage
            // 
            this.txtEdit_Usage.Location = new System.Drawing.Point(191, 206);
            this.txtEdit_Usage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdit_Usage.Name = "txtEdit_Usage";
            this.txtEdit_Usage.Size = new System.Drawing.Size(123, 29);
            this.txtEdit_Usage.TabIndex = 8;
            // 
            // txtEdit_IdealAmt
            // 
            this.txtEdit_IdealAmt.Location = new System.Drawing.Point(0, 350);
            this.txtEdit_IdealAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdit_IdealAmt.Name = "txtEdit_IdealAmt";
            this.txtEdit_IdealAmt.Size = new System.Drawing.Size(314, 29);
            this.txtEdit_IdealAmt.TabIndex = 5;
            // 
            // txtEdit_Edit
            // 
            this.txtEdit_Edit.Location = new System.Drawing.Point(78, 171);
            this.txtEdit_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdit_Edit.Name = "txtEdit_Edit";
            this.txtEdit_Edit.Size = new System.Drawing.Size(236, 29);
            this.txtEdit_Edit.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-1, 264);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 21);
            this.label16.TabIndex = 15;
            this.label16.Text = "Alert Amount:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 145);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Change Current Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-1, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = "You are about to edit this item:";
            // 
            // buttonEdit_OK
            // 
            this.buttonEdit_OK.Location = new System.Drawing.Point(223, 594);
            this.buttonEdit_OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit_OK.Name = "buttonEdit_OK";
            this.buttonEdit_OK.Size = new System.Drawing.Size(91, 37);
            this.buttonEdit_OK.TabIndex = 12;
            this.buttonEdit_OK.Text = "OK";
            this.buttonEdit_OK.UseVisualStyleBackColor = true;
            // 
            // comboEdit
            // 
            this.comboEdit.FormattingEnabled = true;
            this.comboEdit.Items.AddRange(new object[] {
            "Purchase",
            "Consume"});
            this.comboEdit.Location = new System.Drawing.Point(78, 206);
            this.comboEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboEdit.Name = "comboEdit";
            this.comboEdit.Size = new System.Drawing.Size(105, 29);
            this.comboEdit.TabIndex = 9;
            this.comboEdit.Text = "Comsume";
            // 
            // radioButtonEdit_Usage
            // 
            this.radioButtonEdit_Usage.AutoSize = true;
            this.radioButtonEdit_Usage.Location = new System.Drawing.Point(4, 206);
            this.radioButtonEdit_Usage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonEdit_Usage.Name = "radioButtonEdit_Usage";
            this.radioButtonEdit_Usage.Size = new System.Drawing.Size(71, 25);
            this.radioButtonEdit_Usage.TabIndex = 7;
            this.radioButtonEdit_Usage.TabStop = true;
            this.radioButtonEdit_Usage.Text = "Usage";
            this.radioButtonEdit_Usage.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdit_Edit
            // 
            this.radioButtonEdit_Edit.AutoSize = true;
            this.radioButtonEdit_Edit.Location = new System.Drawing.Point(4, 171);
            this.radioButtonEdit_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonEdit_Edit.Name = "radioButtonEdit_Edit";
            this.radioButtonEdit_Edit.Size = new System.Drawing.Size(54, 25);
            this.radioButtonEdit_Edit.TabIndex = 6;
            this.radioButtonEdit_Edit.TabStop = true;
            this.radioButtonEdit_Edit.Text = "Edit";
            this.radioButtonEdit_Edit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Formula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ChemID:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.textBoxRemove_Confirm);
            this.tabPage4.Controls.Add(this.buttonRemove_Confirm);
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(314, 648);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Remove";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(8, 185);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(303, 52);
            this.label19.TabIndex = 18;
            this.label19.Text = "Please enter the Chem Name that you are about to delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Are you ABSOLUTELY sure?";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 104);
            this.label5.TabIndex = 15;
            this.label5.Text = "This action CANNOT be undone. This will permanently delete the chemical ---,and r" +
    "emove all its contents and data.";
            // 
            // textBoxRemove_Confirm
            // 
            this.textBoxRemove_Confirm.Location = new System.Drawing.Point(0, 241);
            this.textBoxRemove_Confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRemove_Confirm.Name = "textBoxRemove_Confirm";
            this.textBoxRemove_Confirm.Size = new System.Drawing.Size(314, 29);
            this.textBoxRemove_Confirm.TabIndex = 14;
            this.textBoxRemove_Confirm.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // buttonRemove_Confirm
            // 
            this.buttonRemove_Confirm.BackColor = System.Drawing.Color.Red;
            this.buttonRemove_Confirm.ForeColor = System.Drawing.Color.Silver;
            this.buttonRemove_Confirm.Location = new System.Drawing.Point(0, 289);
            this.buttonRemove_Confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove_Confirm.Name = "buttonRemove_Confirm";
            this.buttonRemove_Confirm.Size = new System.Drawing.Size(314, 37);
            this.buttonRemove_Confirm.TabIndex = 13;
            this.buttonRemove_Confirm.Text = "Confirm to remove";
            this.buttonRemove_Confirm.UseVisualStyleBackColor = false;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.buttonAdd_Clear);
            this.tabPageAdd.Controls.Add(this.buttonAdd_Cancel);
            this.tabPageAdd.Controls.Add(this.buttonAdd_OK);
            this.tabPageAdd.Controls.Add(this.txtAdd_IdealAmt);
            this.tabPageAdd.Controls.Add(this.txtAdd_AlertAmt);
            this.tabPageAdd.Controls.Add(this.txtAdd_CurrAmt);
            this.tabPageAdd.Controls.Add(this.txtAdd_State);
            this.tabPageAdd.Controls.Add(this.txtAdd_Formula);
            this.tabPageAdd.Controls.Add(this.txtAdd_Name);
            this.tabPageAdd.Controls.Add(this.label13);
            this.tabPageAdd.Controls.Add(this.label12);
            this.tabPageAdd.Controls.Add(this.label6);
            this.tabPageAdd.Controls.Add(this.label9);
            this.tabPageAdd.Controls.Add(this.label10);
            this.tabPageAdd.Controls.Add(this.label11);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 30);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAdd.Size = new System.Drawing.Size(314, 648);
            this.tabPageAdd.TabIndex = 4;
            this.tabPageAdd.Text = "Add";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // buttonAdd_Clear
            // 
            this.buttonAdd_Clear.Location = new System.Drawing.Point(111, 365);
            this.buttonAdd_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd_Clear.Name = "buttonAdd_Clear";
            this.buttonAdd_Clear.Size = new System.Drawing.Size(104, 37);
            this.buttonAdd_Clear.TabIndex = 34;
            this.buttonAdd_Clear.Text = "Clear";
            this.buttonAdd_Clear.UseVisualStyleBackColor = true;
            // 
            // buttonAdd_Cancel
            // 
            this.buttonAdd_Cancel.Location = new System.Drawing.Point(0, 365);
            this.buttonAdd_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd_Cancel.Name = "buttonAdd_Cancel";
            this.buttonAdd_Cancel.Size = new System.Drawing.Size(103, 37);
            this.buttonAdd_Cancel.TabIndex = 33;
            this.buttonAdd_Cancel.Text = "Cancel";
            this.buttonAdd_Cancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd_OK
            // 
            this.buttonAdd_OK.Location = new System.Drawing.Point(223, 365);
            this.buttonAdd_OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd_OK.Name = "buttonAdd_OK";
            this.buttonAdd_OK.Size = new System.Drawing.Size(91, 37);
            this.buttonAdd_OK.TabIndex = 32;
            this.buttonAdd_OK.Text = "OK";
            this.buttonAdd_OK.UseVisualStyleBackColor = true;
            // 
            // txtAdd_IdealAmt
            // 
            this.txtAdd_IdealAmt.Location = new System.Drawing.Point(0, 312);
            this.txtAdd_IdealAmt.Name = "txtAdd_IdealAmt";
            this.txtAdd_IdealAmt.Size = new System.Drawing.Size(314, 29);
            this.txtAdd_IdealAmt.TabIndex = 31;
            // 
            // txtAdd_AlertAmt
            // 
            this.txtAdd_AlertAmt.Location = new System.Drawing.Point(0, 254);
            this.txtAdd_AlertAmt.Name = "txtAdd_AlertAmt";
            this.txtAdd_AlertAmt.Size = new System.Drawing.Size(314, 29);
            this.txtAdd_AlertAmt.TabIndex = 29;
            // 
            // txtAdd_CurrAmt
            // 
            this.txtAdd_CurrAmt.Location = new System.Drawing.Point(0, 198);
            this.txtAdd_CurrAmt.Name = "txtAdd_CurrAmt";
            this.txtAdd_CurrAmt.Size = new System.Drawing.Size(314, 29);
            this.txtAdd_CurrAmt.TabIndex = 27;
            // 
            // txtAdd_State
            // 
            this.txtAdd_State.Location = new System.Drawing.Point(0, 142);
            this.txtAdd_State.Name = "txtAdd_State";
            this.txtAdd_State.Size = new System.Drawing.Size(314, 29);
            this.txtAdd_State.TabIndex = 26;
            // 
            // txtAdd_Formula
            // 
            this.txtAdd_Formula.Location = new System.Drawing.Point(0, 86);
            this.txtAdd_Formula.Name = "txtAdd_Formula";
            this.txtAdd_Formula.Size = new System.Drawing.Size(314, 29);
            this.txtAdd_Formula.TabIndex = 25;
            // 
            // txtAdd_Name
            // 
            this.txtAdd_Name.Location = new System.Drawing.Point(0, 30);
            this.txtAdd_Name.Name = "txtAdd_Name";
            this.txtAdd_Name.Size = new System.Drawing.Size(314, 29);
            this.txtAdd_Name.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-4, 286);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "Ideal Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-4, 230);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Alert Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Current Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-4, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "State";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-4, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Chem Formula";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-4, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Chem Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 739);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPS Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxEditAmount.ResumeLayout(false);
            this.groupBoxEditAmount.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.SearchBar.ResumeLayout(false);
            this.SearchBar.PerformLayout();
            this.groupBoxViewState.ResumeLayout(false);
            this.groupBoxViewState.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxViewStatus.ResumeLayout(false);
            this.groupBoxViewStatus.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ePSInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader ChemID;
        private System.Windows.Forms.ColumnHeader ChemName;
        private System.Windows.Forms.ColumnHeader ChemFormula;
        private System.Windows.Forms.ColumnHeader ChemState;
        private System.Windows.Forms.ColumnHeader ChemCurAmt;
        private System.Windows.Forms.ColumnHeader ChemAlertAmt;
        private System.Windows.Forms.ColumnHeader ChemIdealAmt;
        private System.Windows.Forms.ColumnHeader ChemAmtPurch;
        private System.Windows.Forms.ColumnHeader ChemNote;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripTextBox toolStripAboutText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SearchBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxViewState;
        private System.Windows.Forms.CheckBox cboxFilter_StateGas;
        private System.Windows.Forms.CheckBox cboxFilter_StateLiquid;
        private System.Windows.Forms.CheckBox cboxFilter_StateSolid;
        private System.Windows.Forms.CheckBox cboxFilter_StateAll;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.CheckBox cboxFilter_SearchFormula;
        private System.Windows.Forms.CheckBox cboxFilter_SearchName;
        private System.Windows.Forms.CheckBox cboxFilter_SearchChemID;
        private System.Windows.Forms.Button buttonFilter_ViewClr;
        private System.Windows.Forms.Label SearchByItems;
        private System.Windows.Forms.TextBox txtBoxFilter_ViewItems;
        private System.Windows.Forms.TextBox txtFilter_Search;
        private System.Windows.Forms.ComboBox comboBoxFilter_ViewItems2;
        private System.Windows.Forms.ComboBox comboBoxFilter_ViewItems1;
        private System.Windows.Forms.GroupBox groupBoxViewStatus;
        private System.Windows.Forms.CheckBox cboxFilter_StatusGreen;
        private System.Windows.Forms.CheckBox cboxFilter_StatusYellow;
        private System.Windows.Forms.CheckBox cboxFilter_StatusRed;
        private System.Windows.Forms.CheckBox cboxFilter_StatusAll;
        private System.Windows.Forms.Button buttonFilter_SearchClr;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.Button buttonEdit_Clear;
        private System.Windows.Forms.Button buttonEdit_Cancel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEdit_AlertAmt;
        private System.Windows.Forms.TextBox txtEdit_Note;
        private System.Windows.Forms.TextBox txtEdit_Usage;
        private System.Windows.Forms.TextBox txtEdit_IdealAmt;
        private System.Windows.Forms.TextBox txtEdit_Edit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonEdit_OK;
        private System.Windows.Forms.ComboBox comboEdit;
        private System.Windows.Forms.RadioButton radioButtonEdit_Usage;
        private System.Windows.Forms.RadioButton radioButtonEdit_Edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRemove_Confirm;
        private System.Windows.Forms.Button buttonRemove_Confirm;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonAdd_Clear;
        private System.Windows.Forms.Button buttonAdd_Cancel;
        private System.Windows.Forms.Button buttonAdd_OK;
        private System.Windows.Forms.TextBox txtAdd_IdealAmt;
        private System.Windows.Forms.TextBox txtAdd_AlertAmt;
        private System.Windows.Forms.TextBox txtAdd_CurrAmt;
        private System.Windows.Forms.TextBox txtAdd_State;
        private System.Windows.Forms.TextBox txtAdd_Formula;
        private System.Windows.Forms.TextBox txtAdd_Name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBoxEditAmount;
        private System.Windows.Forms.Button button_EditOK;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBox_EditAmt;
        private System.Windows.Forms.ComboBox comboBox_EditAmt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;

    }
}