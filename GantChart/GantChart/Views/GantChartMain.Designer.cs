namespace GantChart.Views
{
    partial class GantChartMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSort = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbView = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbLink = new System.Windows.Forms.RichTextBox();
            this.lstSearchUser = new System.Windows.Forms.ListBox();
            this.tbSearchUser = new System.Windows.Forms.TextBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPriority = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPercentCompleted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDexcription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btEditTask = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1MinSize = 1000;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1277, 753);
            this.splitContainer1.SplitterDistance = 1000;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
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
            this.splitContainer2.Size = new System.Drawing.Size(1000, 753);
            this.splitContainer2.SplitterDistance = 92;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1000, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "GantChart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btSort);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbbView);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rtbLink);
            this.panel1.Controls.Add(this.lstSearchUser);
            this.panel1.Controls.Add(this.tbSearchUser);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.lstUser);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbPriority);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPercentCompleted);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbDexcription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btEditTask);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Controls.Add(this.txbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 753);
            this.panel1.TabIndex = 0;
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(184, 718);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(75, 29);
            this.btSort.TabIndex = 33;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "View:";
            // 
            // cbbView
            // 
            this.cbbView.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbView.FormattingEnabled = true;
            this.cbbView.Location = new System.Drawing.Point(161, 0);
            this.cbbView.Name = "cbbView";
            this.cbbView.Size = new System.Drawing.Size(112, 28);
            this.cbbView.TabIndex = 31;
            this.cbbView.SelectedValueChanged += new System.EventHandler(this.cbbView_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Link:";
            // 
            // rtbLink
            // 
            this.rtbLink.Location = new System.Drawing.Point(67, 440);
            this.rtbLink.Name = "rtbLink";
            this.rtbLink.Size = new System.Drawing.Size(192, 36);
            this.rtbLink.TabIndex = 29;
            this.rtbLink.Text = "";
            this.rtbLink.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbLink_LinkClicked);
            // 
            // lstSearchUser
            // 
            this.lstSearchUser.FormattingEnabled = true;
            this.lstSearchUser.ItemHeight = 20;
            this.lstSearchUser.Location = new System.Drawing.Point(15, 585);
            this.lstSearchUser.Name = "lstSearchUser";
            this.lstSearchUser.Size = new System.Drawing.Size(244, 84);
            this.lstSearchUser.TabIndex = 20;
            this.lstSearchUser.DoubleClick += new System.EventHandler(this.lstSearchUser_DoubleClick);
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.Location = new System.Drawing.Point(144, 552);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(115, 27);
            this.tbSearchUser.TabIndex = 19;
            this.tbSearchUser.Text = "Search User";
            this.tbSearchUser.TextChanged += new System.EventHandler(this.tbSearchUser_TextChanged);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.btEdit.Location = new System.Drawing.Point(184, 675);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 40);
            this.btEdit.TabIndex = 18;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // lstUser
            // 
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 20;
            this.lstUser.Location = new System.Drawing.Point(67, 482);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(192, 64);
            this.lstUser.TabIndex = 17;
            this.lstUser.DoubleClick += new System.EventHandler(this.lstUser_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Users:";
            // 
            // cbbPriority
            // 
            this.cbbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPriority.FormattingEnabled = true;
            this.cbbPriority.Items.AddRange(new object[] {
            "LOW",
            "NORMAL",
            "HIGH"});
            this.cbbPriority.Location = new System.Drawing.Point(48, 142);
            this.cbbPriority.Name = "cbbPriority";
            this.cbbPriority.Size = new System.Drawing.Size(123, 28);
            this.cbbPriority.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Priority:";
            // 
            // tbPercentCompleted
            // 
            this.tbPercentCompleted.Location = new System.Drawing.Point(152, 407);
            this.tbPercentCompleted.Name = "tbPercentCompleted";
            this.tbPercentCompleted.Size = new System.Drawing.Size(107, 27);
            this.tbPercentCompleted.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-4, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "PercentCompleted:";
            // 
            // tbDexcription
            // 
            this.tbDexcription.Location = new System.Drawing.Point(49, 302);
            this.tbDexcription.Name = "tbDexcription";
            this.tbDexcription.Size = new System.Drawing.Size(210, 96);
            this.tbDexcription.TabIndex = 10;
            this.tbDexcription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "To Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "From Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.SystemColors.Menu;
            this.lbID.Location = new System.Drawing.Point(45, 66);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 20);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Location = new System.Drawing.Point(88, 675);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 72);
            this.button3.TabIndex = 4;
            this.button3.Text = "Edit Users";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btEditTask
            // 
            this.btEditTask.BackColor = System.Drawing.SystemColors.Menu;
            this.btEditTask.Location = new System.Drawing.Point(6, 675);
            this.btEditTask.Name = "btEditTask";
            this.btEditTask.Size = new System.Drawing.Size(75, 72);
            this.btEditTask.TabIndex = 3;
            this.btEditTask.Text = "Edit Tasks";
            this.btEditTask.UseVisualStyleBackColor = false;
            this.btEditTask.Click += new System.EventHandler(this.btEditTask_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "MM/dd/yyyy, hh:mm";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(49, 249);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 27);
            this.dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "MM/dd/yyyy, HH:mm";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(49, 196);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 27);
            this.dtpFromDate.TabIndex = 1;
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(48, 89);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(100, 27);
            this.txbTitle.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GantChartMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1277, 753);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GantChartMain";
            this.Text = "GantChartMain";
            this.Load += new System.EventHandler(this.from_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btEditTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.RichTextBox tbDexcription;
        private System.Windows.Forms.TextBox tbPercentCompleted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.ListBox lstSearchUser;
        private System.Windows.Forms.TextBox tbSearchUser;
        private System.Windows.Forms.RichTextBox rtbLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btSort;
    }
}