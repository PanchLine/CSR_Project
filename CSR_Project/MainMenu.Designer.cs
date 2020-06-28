namespace CSR_Project
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonDepartments = new System.Windows.Forms.Button();
            this.buttonProfessions = new System.Windows.Forms.Button();
            this.buttonNeeds = new System.Windows.Forms.Button();
            this.buttonNeedsReview = new System.Windows.Forms.Button();
            this.buttonDocuments = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(155, 410);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(294, 42);
            this.buttonUsers.TabIndex = 1;
            this.buttonUsers.Text = "Сотрудники";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonDepartments
            // 
            this.buttonDepartments.Location = new System.Drawing.Point(155, 507);
            this.buttonDepartments.Name = "buttonDepartments";
            this.buttonDepartments.Size = new System.Drawing.Size(294, 42);
            this.buttonDepartments.TabIndex = 2;
            this.buttonDepartments.Text = "Отделы";
            this.buttonDepartments.UseVisualStyleBackColor = true;
            this.buttonDepartments.Click += new System.EventHandler(this.buttonDepartments_Click);
            // 
            // buttonProfessions
            // 
            this.buttonProfessions.Location = new System.Drawing.Point(155, 458);
            this.buttonProfessions.Name = "buttonProfessions";
            this.buttonProfessions.Size = new System.Drawing.Size(294, 43);
            this.buttonProfessions.TabIndex = 3;
            this.buttonProfessions.Text = "Должности";
            this.buttonProfessions.UseVisualStyleBackColor = true;
            this.buttonProfessions.Click += new System.EventHandler(this.buttonProfessions_Click);
            // 
            // buttonNeeds
            // 
            this.buttonNeeds.Location = new System.Drawing.Point(155, 265);
            this.buttonNeeds.Name = "buttonNeeds";
            this.buttonNeeds.Size = new System.Drawing.Size(294, 43);
            this.buttonNeeds.TabIndex = 4;
            this.buttonNeeds.Text = "Потребности";
            this.buttonNeeds.UseVisualStyleBackColor = true;
            this.buttonNeeds.Click += new System.EventHandler(this.buttonNeeds_Click);
            // 
            // buttonNeedsReview
            // 
            this.buttonNeedsReview.Location = new System.Drawing.Point(155, 314);
            this.buttonNeedsReview.Name = "buttonNeedsReview";
            this.buttonNeedsReview.Size = new System.Drawing.Size(294, 42);
            this.buttonNeedsReview.TabIndex = 5;
            this.buttonNeedsReview.Text = "Рассмотрение потребностей";
            this.buttonNeedsReview.UseVisualStyleBackColor = true;
            this.buttonNeedsReview.Click += new System.EventHandler(this.buttonNeedsReview_Click);
            // 
            // buttonDocuments
            // 
            this.buttonDocuments.Location = new System.Drawing.Point(155, 362);
            this.buttonDocuments.Name = "buttonDocuments";
            this.buttonDocuments.Size = new System.Drawing.Size(294, 42);
            this.buttonDocuments.TabIndex = 6;
            this.buttonDocuments.Text = "Документы";
            this.buttonDocuments.UseVisualStyleBackColor = true;
            this.buttonDocuments.Click += new System.EventHandler(this.buttonDocuments_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CSR_Project.Properties.Resources.ЦСРИРиСУ;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(484, 176);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(9, 227);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(64, 17);
            this.labelDep.TabIndex = 7;
            this.labelDep.Text = "labelDep";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 201);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "labelName";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 561);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.buttonDocuments);
            this.Controls.Add(this.buttonNeedsReview);
            this.Controls.Add(this.buttonNeeds);
            this.Controls.Add(this.buttonProfessions);
            this.Controls.Add(this.buttonDepartments);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonDepartments;
        private System.Windows.Forms.Button buttonProfessions;
        private System.Windows.Forms.Button buttonNeeds;
        private System.Windows.Forms.Button buttonNeedsReview;
        private System.Windows.Forms.Button buttonDocuments;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Label labelName;
    }
}

