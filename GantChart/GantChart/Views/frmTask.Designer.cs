namespace GantChart.Views
{
    partial class frmTask
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTasks = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPercentCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbLink = new System.Windows.Forms.RichTextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lbpriority = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lsbUsers = new System.Windows.Forms.ListBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.lbSearchUser = new System.Windows.Forms.ListBox();
            this.tbSearchUser = new System.Windows.Forms.TextBox();
            this.tbPercentCompleted = new System.Windows.Forms.TextBox();
            this.dtpTDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFDate = new System.Windows.Forms.DateTimePicker();
            this.lbID = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.rtbLink);
            this.splitContainer1.Panel2.Controls.Add(this.cmbPriority);
            this.splitContainer1.Panel2.Controls.Add(this.lbpriority);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.btRefresh);
            this.splitContainer1.Panel2.Controls.Add(this.lsbUsers);
            this.splitContainer1.Panel2.Controls.Add(this.btEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btAdd);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.ID);
            this.splitContainer1.Panel2.Controls.Add(this.lbSearchUser);
            this.splitContainer1.Panel2.Controls.Add(this.tbSearchUser);
            this.splitContainer1.Panel2.Controls.Add(this.tbPercentCompleted);
            this.splitContainer1.Panel2.Controls.Add(this.dtpTDate);
            this.splitContainer1.Panel2.Controls.Add(this.dtpFDate);
            this.splitContainer1.Panel2.Controls.Add(this.lbID);
            this.splitContainer1.Panel2.Controls.Add(this.tbDescription);
            this.splitContainer1.Panel2.Controls.Add(this.tbTitle);
            this.splitContainer1.Size = new System.Drawing.Size(865, 639);
            this.splitContainer1.SplitterDistance = 592;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataTasks);
            this.splitContainer2.Size = new System.Drawing.Size(592, 639);
            this.splitContainer2.SplitterDistance = 75;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(592, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "TABLE TASK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataTasks
            // 
            this.dataTasks.AllowUserToAddRows = false;
            this.dataTasks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTasks.ColumnHeadersHeight = 35;
            this.dataTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cTitle,
            this.cDescription,
            this.cPriority,
            this.cToDate,
            this.cFromDate,
            this.cPercentCompleted,
            this.cUsers});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTasks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTasks.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataTasks.Location = new System.Drawing.Point(0, 0);
            this.dataTasks.Name = "dataTasks";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTasks.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataTasks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTasks.RowTemplate.Height = 24;
            this.dataTasks.Size = new System.Drawing.Size(592, 560);
            this.dataTasks.TabIndex = 0;
            this.dataTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTasks_CellClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Width = 125;
            // 
            // cTitle
            // 
            this.cTitle.HeaderText = "Title";
            this.cTitle.MinimumWidth = 6;
            this.cTitle.Name = "cTitle";
            this.cTitle.ReadOnly = true;
            this.cTitle.Width = 125;
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.MinimumWidth = 6;
            this.cDescription.Name = "cDescription";
            this.cDescription.ReadOnly = true;
            this.cDescription.Width = 125;
            // 
            // cPriority
            // 
            this.cPriority.HeaderText = "Priority";
            this.cPriority.MinimumWidth = 6;
            this.cPriority.Name = "cPriority";
            this.cPriority.Width = 125;
            // 
            // cToDate
            // 
            this.cToDate.HeaderText = "To Date";
            this.cToDate.MinimumWidth = 6;
            this.cToDate.Name = "cToDate";
            this.cToDate.ReadOnly = true;
            this.cToDate.Width = 125;
            // 
            // cFromDate
            // 
            this.cFromDate.HeaderText = "From Date";
            this.cFromDate.MinimumWidth = 6;
            this.cFromDate.Name = "cFromDate";
            this.cFromDate.ReadOnly = true;
            this.cFromDate.Width = 125;
            // 
            // cPercentCompleted
            // 
            this.cPercentCompleted.HeaderText = "Percent Completed";
            this.cPercentCompleted.MinimumWidth = 6;
            this.cPercentCompleted.Name = "cPercentCompleted";
            this.cPercentCompleted.ReadOnly = true;
            this.cPercentCompleted.Width = 125;
            // 
            // cUsers
            // 
            this.cUsers.HeaderText = "Users";
            this.cUsers.MinimumWidth = 6;
            this.cUsers.Name = "cUsers";
            this.cUsers.ReadOnly = true;
            this.cUsers.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Link:";
            // 
            // rtbLink
            // 
            this.rtbLink.Location = new System.Drawing.Point(65, 352);
            this.rtbLink.Name = "rtbLink";
            this.rtbLink.Size = new System.Drawing.Size(178, 61);
            this.rtbLink.TabIndex = 28;
            this.rtbLink.Text = "";
            this.rtbLink.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbLink_LinkClicked);
            // 
            // cmbPriority
            // 
            this.cmbPriority.AllowDrop = true;
            this.cmbPriority.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "LOW",
            "NORMAL",
            "HIGH"});
            this.cmbPriority.Location = new System.Drawing.Point(80, 322);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 24);
            this.cmbPriority.TabIndex = 24;
            // 
            // lbpriority
            // 
            this.lbpriority.AutoSize = true;
            this.lbpriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpriority.Location = new System.Drawing.Point(6, 322);
            this.lbpriority.Name = "lbpriority";
            this.lbpriority.Size = new System.Drawing.Size(67, 20);
            this.lbpriority.TabIndex = 23;
            this.lbpriority.Text = "Priority:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(110, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 22;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefresh.BackColor = System.Drawing.SystemColors.Menu;
            this.btRefresh.Location = new System.Drawing.Point(191, 3);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 32);
            this.btRefresh.TabIndex = 21;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // lsbUsers
            // 
            this.lsbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbUsers.FormattingEnabled = true;
            this.lsbUsers.ItemHeight = 16;
            this.lsbUsers.Location = new System.Drawing.Point(65, 419);
            this.lsbUsers.Name = "lsbUsers";
            this.lsbUsers.Size = new System.Drawing.Size(178, 52);
            this.lsbUsers.TabIndex = 20;
            this.lsbUsers.DoubleClick += new System.EventHandler(this.lsbUsers_DoubleClick);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.btEdit.Location = new System.Drawing.Point(182, 595);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 34);
            this.btEdit.TabIndex = 19;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btDelete.Location = new System.Drawing.Point(96, 595);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 34);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btAdd.Location = new System.Drawing.Point(9, 595);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 34);
            this.btAdd.TabIndex = 17;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Users:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Percent Completed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "To Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "From Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(5, 39);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(31, 20);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID:";
            // 
            // lbSearchUser
            // 
            this.lbSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchUser.FormattingEnabled = true;
            this.lbSearchUser.ItemHeight = 16;
            this.lbSearchUser.Location = new System.Drawing.Point(39, 505);
            this.lbSearchUser.Name = "lbSearchUser";
            this.lbSearchUser.Size = new System.Drawing.Size(218, 84);
            this.lbSearchUser.TabIndex = 9;
            this.lbSearchUser.DoubleClick += new System.EventHandler(this.lbSearchUser_DoubleClick);
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchUser.Location = new System.Drawing.Point(65, 477);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(164, 22);
            this.tbSearchUser.TabIndex = 8;
            this.tbSearchUser.Text = "Search User";
            this.tbSearchUser.TextChanged += new System.EventHandler(this.tbSearchUser_TextChanged);
            // 
            // tbPercentCompleted
            // 
            this.tbPercentCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPercentCompleted.Location = new System.Drawing.Point(168, 292);
            this.tbPercentCompleted.Name = "tbPercentCompleted";
            this.tbPercentCompleted.Size = new System.Drawing.Size(43, 22);
            this.tbPercentCompleted.TabIndex = 6;
            // 
            // dtpTDate
            // 
            this.dtpTDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTDate.CustomFormat = "MM/dd/yyyy ,HH:mm";
            this.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTDate.Location = new System.Drawing.Point(101, 257);
            this.dtpTDate.Name = "dtpTDate";
            this.dtpTDate.Size = new System.Drawing.Size(142, 22);
            this.dtpTDate.TabIndex = 5;
            // 
            // dtpFDate
            // 
            this.dtpFDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFDate.CustomFormat = "MM/dd/yyyy ,HH:mm";
            this.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFDate.Location = new System.Drawing.Point(101, 223);
            this.dtpFDate.Name = "dtpFDate";
            this.dtpFDate.Size = new System.Drawing.Size(142, 22);
            this.dtpFDate.TabIndex = 4;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbID.Location = new System.Drawing.Point(42, 39);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 17);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(9, 125);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(234, 86);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.Text = "";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(57, 72);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(114, 22);
            this.tbTitle.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 639);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTask";
            this.Load += new System.EventHandler(this.frmTask_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataTasks;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DateTimePicker dtpFDate;
        private System.Windows.Forms.DateTimePicker dtpTDate;
        private System.Windows.Forms.TextBox tbPercentCompleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ListBox lbSearchUser;
        private System.Windows.Forms.TextBox tbSearchUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListBox lsbUsers;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lbpriority;
        private System.Windows.Forms.RichTextBox rtbLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPercentCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}