namespace CSR_Project
{
    partial class NeedsForm
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
            this.labelItem = new System.Windows.Forms.Label();
            this.labelTotalItems = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelJustification = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxTotalItems = new System.Windows.Forms.TextBox();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxJustification = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.listViewNeeds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelName = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(1124, 535);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(181, 51);
            this.buttonDel.TabIndex = 36;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(937, 535);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(181, 51);
            this.buttonEdit.TabIndex = 35;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(750, 535);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 51);
            this.buttonAdd.TabIndex = 34;
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
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(9, 169);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(122, 17);
            this.labelItem.TabIndex = 69;
            this.labelItem.Text = "Предмет закупки";
            // 
            // labelTotalItems
            // 
            this.labelTotalItems.AutoSize = true;
            this.labelTotalItems.Location = new System.Drawing.Point(12, 214);
            this.labelTotalItems.Name = "labelTotalItems";
            this.labelTotalItems.Size = new System.Drawing.Size(110, 17);
            this.labelTotalItems.TabIndex = 70;
            this.labelTotalItems.Text = "Кол-во товаров";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(9, 259);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(197, 17);
            this.labelPrice.TabIndex = 71;
            this.labelPrice.Text = "Стоимость за единицу (руб.)";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(9, 306);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(154, 17);
            this.labelTotalPrice.TabIndex = 72;
            this.labelTotalPrice.Text = "Итоговая сумма (руб.)";
            // 
            // labelJustification
            // 
            this.labelJustification.AutoSize = true;
            this.labelJustification.Location = new System.Drawing.Point(9, 351);
            this.labelJustification.Name = "labelJustification";
            this.labelJustification.Size = new System.Drawing.Size(97, 17);
            this.labelJustification.TabIndex = 73;
            this.labelJustification.Text = "Обоснование";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(9, 396);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(98, 17);
            this.labelComment.TabIndex = 75;
            this.labelComment.Text = "Комментарий";
            // 
            // textBoxTotalItems
            // 
            this.textBoxTotalItems.Location = new System.Drawing.Point(12, 234);
            this.textBoxTotalItems.Name = "textBoxTotalItems";
            this.textBoxTotalItems.Size = new System.Drawing.Size(279, 22);
            this.textBoxTotalItems.TabIndex = 77;
            this.textBoxTotalItems.TextChanged += new System.EventHandler(this.textBoxTotalItems_TextChanged);
            this.textBoxTotalItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalKeyPress);
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(12, 189);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(279, 22);
            this.textBoxItem.TabIndex = 78;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 281);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(279, 22);
            this.textBoxPrice.TabIndex = 79;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceKeyPress);
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(12, 326);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(279, 22);
            this.textBoxTotalPrice.TabIndex = 80;
            // 
            // textBoxJustification
            // 
            this.textBoxJustification.Location = new System.Drawing.Point(12, 371);
            this.textBoxJustification.Name = "textBoxJustification";
            this.textBoxJustification.Size = new System.Drawing.Size(279, 22);
            this.textBoxJustification.TabIndex = 81;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(12, 416);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(279, 66);
            this.textBoxComment.TabIndex = 82;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(12, 485);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(50, 17);
            this.labelDepartment.TabIndex = 84;
            this.labelDepartment.Text = "Отдел";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(15, 505);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(279, 24);
            this.comboBoxDepartment.TabIndex = 83;
            // 
            // listViewNeeds
            // 
            this.listViewNeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewNeeds.FullRowSelect = true;
            this.listViewNeeds.GridLines = true;
            this.listViewNeeds.HideSelection = false;
            this.listViewNeeds.Location = new System.Drawing.Point(297, 169);
            this.listViewNeeds.MultiSelect = false;
            this.listViewNeeds.Name = "listViewNeeds";
            this.listViewNeeds.Size = new System.Drawing.Size(1008, 360);
            this.listViewNeeds.TabIndex = 85;
            this.listViewNeeds.UseCompatibleStateImageBehavior = false;
            this.listViewNeeds.View = System.Windows.Forms.View.Details;
            this.listViewNeeds.SelectedIndexChanged += new System.EventHandler(this.listViewNeeds_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Предмет закупки";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Кол-во товаров";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Стоимость за единицу (руб.)";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Итоговая сумма";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Обоснование";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Комментарий";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Отдел";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(481, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 17);
            this.labelName.TabIndex = 87;
            this.labelName.Text = "labelName";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(481, 136);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(64, 17);
            this.labelDep.TabIndex = 86;
            this.labelDep.Text = "labelDep";
            // 
            // NeedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 598);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.listViewNeeds);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxJustification);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.textBoxTotalItems);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelJustification);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTotalItems);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "NeedsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребности";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelTotalItems;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelJustification;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxTotalItems;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.TextBox textBoxJustification;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ListView listViewNeeds;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDep;
    }
}