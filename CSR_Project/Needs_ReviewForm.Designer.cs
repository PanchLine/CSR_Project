namespace CSR_Project
{
    partial class Needs_ReviewForm
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelNeed = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDocument = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxNeed = new System.Windows.Forms.ComboBox();
            this.comboBoxDocument = new System.Windows.Forms.ComboBox();
            this.listViewNeedsReview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelName = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(1216, 534);
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
            this.buttonEdit.Location = new System.Drawing.Point(1029, 534);
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
            this.buttonAdd.Location = new System.Drawing.Point(842, 534);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 51);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CSR_Project.Properties.Resources.ЦСРИРиСУ;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(463, 141);
            this.pictureBoxLogo.TabIndex = 68;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelNeed
            // 
            this.labelNeed.AutoSize = true;
            this.labelNeed.Location = new System.Drawing.Point(9, 184);
            this.labelNeed.Name = "labelNeed";
            this.labelNeed.Size = new System.Drawing.Size(94, 17);
            this.labelNeed.TabIndex = 69;
            this.labelNeed.Text = "Потребность";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(9, 231);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 70;
            this.labelDate.Text = "Дата";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(9, 276);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(98, 17);
            this.labelComment.TabIndex = 71;
            this.labelComment.Text = "Комментарий";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(9, 378);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(167, 17);
            this.labelPrice.TabIndex = 72;
            this.labelPrice.Text = "Общая стоимость (руб.)";
            // 
            // labelDocument
            // 
            this.labelDocument.AutoSize = true;
            this.labelDocument.Location = new System.Drawing.Point(9, 423);
            this.labelDocument.Name = "labelDocument";
            this.labelDocument.Size = new System.Drawing.Size(73, 17);
            this.labelDocument.TabIndex = 73;
            this.labelDocument.Text = "Документ";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(12, 251);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(323, 22);
            this.textBoxDate.TabIndex = 74;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(12, 296);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(323, 79);
            this.textBoxComment.TabIndex = 75;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 398);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(323, 22);
            this.textBoxPrice.TabIndex = 76;
            // 
            // comboBoxNeed
            // 
            this.comboBoxNeed.FormattingEnabled = true;
            this.comboBoxNeed.Location = new System.Drawing.Point(12, 204);
            this.comboBoxNeed.Name = "comboBoxNeed";
            this.comboBoxNeed.Size = new System.Drawing.Size(323, 24);
            this.comboBoxNeed.TabIndex = 77;
            this.comboBoxNeed.SelectedIndexChanged += new System.EventHandler(this.comboBoxNeed_SelectedIndexChanged);
            // 
            // comboBoxDocument
            // 
            this.comboBoxDocument.FormattingEnabled = true;
            this.comboBoxDocument.Location = new System.Drawing.Point(12, 443);
            this.comboBoxDocument.Name = "comboBoxDocument";
            this.comboBoxDocument.Size = new System.Drawing.Size(323, 24);
            this.comboBoxDocument.TabIndex = 78;
            // 
            // listViewNeedsReview
            // 
            this.listViewNeedsReview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewNeedsReview.FullRowSelect = true;
            this.listViewNeedsReview.GridLines = true;
            this.listViewNeedsReview.HideSelection = false;
            this.listViewNeedsReview.Location = new System.Drawing.Point(341, 159);
            this.listViewNeedsReview.MultiSelect = false;
            this.listViewNeedsReview.Name = "listViewNeedsReview";
            this.listViewNeedsReview.Size = new System.Drawing.Size(1056, 369);
            this.listViewNeedsReview.TabIndex = 79;
            this.listViewNeedsReview.UseCompatibleStateImageBehavior = false;
            this.listViewNeedsReview.View = System.Windows.Forms.View.Details;
            this.listViewNeedsReview.SelectedIndexChanged += new System.EventHandler(this.listViewNeedsReview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Потребность";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Комментарий";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Общая стоимость";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Документ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(481, 107);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 17);
            this.labelName.TabIndex = 81;
            this.labelName.Text = "labelName";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(481, 133);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(64, 17);
            this.labelDep.TabIndex = 80;
            this.labelDep.Text = "labelDep";
            // 
            // Needs_ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 597);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.listViewNeedsReview);
            this.Controls.Add(this.comboBoxDocument);
            this.Controls.Add(this.comboBoxNeed);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDocument);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNeed);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Needs_ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рассмотрение потребностей";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelNeed;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDocument;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxNeed;
        private System.Windows.Forms.ComboBox comboBoxDocument;
        private System.Windows.Forms.ListView listViewNeedsReview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDep;
    }
}