namespace CSR_Project
{
    partial class DocumentsForm
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelContract = new System.Windows.Forms.Label();
            this.labelAct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFinance_Report = new System.Windows.Forms.Label();
            this.textBoxContract = new System.Windows.Forms.TextBox();
            this.textBoxAct = new System.Windows.Forms.TextBox();
            this.textBoxFinance_Report = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewDocuments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelName = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(952, 504);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(181, 51);
            this.buttonDel.TabIndex = 39;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(765, 504);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(181, 51);
            this.buttonEdit.TabIndex = 38;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(578, 504);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 51);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelContract
            // 
            this.labelContract.AutoSize = true;
            this.labelContract.Location = new System.Drawing.Point(21, 211);
            this.labelContract.Name = "labelContract";
            this.labelContract.Size = new System.Drawing.Size(63, 17);
            this.labelContract.TabIndex = 40;
            this.labelContract.Text = "Договор";
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.Location = new System.Drawing.Point(21, 292);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(88, 17);
            this.labelAct.TabIndex = 41;
            this.labelAct.Text = "Нормат. акт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 42;
            // 
            // labelFinance_Report
            // 
            this.labelFinance_Report.AutoSize = true;
            this.labelFinance_Report.Location = new System.Drawing.Point(21, 371);
            this.labelFinance_Report.Name = "labelFinance_Report";
            this.labelFinance_Report.Size = new System.Drawing.Size(135, 17);
            this.labelFinance_Report.TabIndex = 43;
            this.labelFinance_Report.Text = "Финансовый отчёт";
            // 
            // textBoxContract
            // 
            this.textBoxContract.Location = new System.Drawing.Point(24, 231);
            this.textBoxContract.Multiline = true;
            this.textBoxContract.Name = "textBoxContract";
            this.textBoxContract.Size = new System.Drawing.Size(280, 58);
            this.textBoxContract.TabIndex = 44;
            // 
            // textBoxAct
            // 
            this.textBoxAct.Location = new System.Drawing.Point(24, 312);
            this.textBoxAct.Multiline = true;
            this.textBoxAct.Name = "textBoxAct";
            this.textBoxAct.Size = new System.Drawing.Size(280, 56);
            this.textBoxAct.TabIndex = 45;
            // 
            // textBoxFinance_Report
            // 
            this.textBoxFinance_Report.Location = new System.Drawing.Point(24, 391);
            this.textBoxFinance_Report.Multiline = true;
            this.textBoxFinance_Report.Name = "textBoxFinance_Report";
            this.textBoxFinance_Report.Size = new System.Drawing.Size(280, 57);
            this.textBoxFinance_Report.TabIndex = 46;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(24, 471);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(280, 22);
            this.textBoxDate.TabIndex = 47;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(21, 451);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 48;
            this.labelDate.Text = "Дата";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CSR_Project.Properties.Resources.ЦСРИРиСУ;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(492, 134);
            this.pictureBoxLogo.TabIndex = 68;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewDocuments
            // 
            this.listViewDocuments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDocuments.FullRowSelect = true;
            this.listViewDocuments.GridLines = true;
            this.listViewDocuments.HideSelection = false;
            this.listViewDocuments.Location = new System.Drawing.Point(310, 152);
            this.listViewDocuments.MultiSelect = false;
            this.listViewDocuments.Name = "listViewDocuments";
            this.listViewDocuments.Size = new System.Drawing.Size(823, 346);
            this.listViewDocuments.TabIndex = 69;
            this.listViewDocuments.UseCompatibleStateImageBehavior = false;
            this.listViewDocuments.View = System.Windows.Forms.View.Details;
            this.listViewDocuments.SelectedIndexChanged += new System.EventHandler(this.listViewDocuments_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Договор";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Нормат. акт";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Финансовый отчёт";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(510, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 17);
            this.labelName.TabIndex = 71;
            this.labelName.Text = "labelName";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(510, 126);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(64, 17);
            this.labelDep.TabIndex = 70;
            this.labelDep.Text = "labelDep";
            // 
            // DocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 567);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.listViewDocuments);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxFinance_Report);
            this.Controls.Add(this.textBoxAct);
            this.Controls.Add(this.textBoxContract);
            this.Controls.Add(this.labelFinance_Report);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAct);
            this.Controls.Add(this.labelContract);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "DocumentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Документы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelContract;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFinance_Report;
        private System.Windows.Forms.TextBox textBoxContract;
        private System.Windows.Forms.TextBox textBoxAct;
        private System.Windows.Forms.TextBox textBoxFinance_Report;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewDocuments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDep;
    }
}