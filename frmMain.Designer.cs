namespace EmployeeUI
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txSalary = new System.Windows.Forms.MaskedTextBox();
            this.rdSingle = new System.Windows.Forms.RadioButton();
            this.rdMarried = new System.Windows.Forms.RadioButton();
            this.txJob = new System.Windows.Forms.ComboBox();
            this.txCity = new System.Windows.Forms.ComboBox();
            this.txSurName = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btGraphic = new System.Windows.Forms.Button();
            this.btIstatistic = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txSalary);
            this.groupBox1.Controls.Add(this.rdSingle);
            this.groupBox1.Controls.Add(this.rdMarried);
            this.groupBox1.Controls.Add(this.txJob);
            this.groupBox1.Controls.Add(this.txCity);
            this.groupBox1.Controls.Add(this.txSurName);
            this.groupBox1.Controls.Add(this.txName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // txSalary
            // 
            this.txSalary.Location = new System.Drawing.Point(90, 176);
            this.txSalary.Name = "txSalary";
            this.txSalary.Size = new System.Drawing.Size(121, 20);
            this.txSalary.TabIndex = 5;
            // 
            // rdSingle
            // 
            this.rdSingle.AutoSize = true;
            this.rdSingle.Location = new System.Drawing.Point(158, 150);
            this.rdSingle.Name = "rdSingle";
            this.rdSingle.Size = new System.Drawing.Size(53, 17);
            this.rdSingle.TabIndex = 4;
            this.rdSingle.TabStop = true;
            this.rdSingle.Text = "Bekar";
            this.rdSingle.UseVisualStyleBackColor = true;
            // 
            // rdMarried
            // 
            this.rdMarried.AutoSize = true;
            this.rdMarried.Location = new System.Drawing.Point(90, 150);
            this.rdMarried.Name = "rdMarried";
            this.rdMarried.Size = new System.Drawing.Size(42, 17);
            this.rdMarried.TabIndex = 4;
            this.rdMarried.TabStop = true;
            this.rdMarried.Text = "Evli";
            this.rdMarried.UseVisualStyleBackColor = true;
            // 
            // txJob
            // 
            this.txJob.FormattingEnabled = true;
            this.txJob.Location = new System.Drawing.Point(90, 118);
            this.txJob.Name = "txJob";
            this.txJob.Size = new System.Drawing.Size(121, 21);
            this.txJob.TabIndex = 3;
            // 
            // txCity
            // 
            this.txCity.FormattingEnabled = true;
            this.txCity.Location = new System.Drawing.Point(90, 88);
            this.txCity.Name = "txCity";
            this.txCity.Size = new System.Drawing.Size(121, 21);
            this.txCity.TabIndex = 2;
            // 
            // txSurName
            // 
            this.txSurName.Location = new System.Drawing.Point(90, 62);
            this.txSurName.Name = "txSurName";
            this.txSurName.Size = new System.Drawing.Size(121, 20);
            this.txSurName.TabIndex = 1;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(90, 35);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(121, 20);
            this.txName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maaşı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Medeni Hali :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Meslegi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şehri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btGraphic);
            this.groupBox2.Controls.Add(this.btIstatistic);
            this.groupBox2.Controls.Add(this.btClear);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.btList);
            this.groupBox2.Location = new System.Drawing.Point(260, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btGraphic
            // 
            this.btGraphic.Location = new System.Drawing.Point(6, 199);
            this.btGraphic.Name = "btGraphic";
            this.btGraphic.Size = new System.Drawing.Size(169, 23);
            this.btGraphic.TabIndex = 0;
            this.btGraphic.Text = "Grafikler";
            this.btGraphic.UseVisualStyleBackColor = true;
            this.btGraphic.Click += new System.EventHandler(this.btGraphic_Click);
            // 
            // btIstatistic
            // 
            this.btIstatistic.Location = new System.Drawing.Point(6, 165);
            this.btIstatistic.Name = "btIstatistic";
            this.btIstatistic.Size = new System.Drawing.Size(169, 23);
            this.btIstatistic.TabIndex = 0;
            this.btIstatistic.Text = "İstatistikler";
            this.btIstatistic.UseVisualStyleBackColor = true;
            this.btIstatistic.Click += new System.EventHandler(this.btIstatistic_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(6, 136);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(169, 23);
            this.btClear.TabIndex = 0;
            this.btClear.Text = "Temizle";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(6, 107);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(169, 23);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Güncelle";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(6, 78);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(169, 23);
            this.btDelete.TabIndex = 0;
            this.btDelete.Text = "Sil";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(6, 49);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(169, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Ekle";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btList
            // 
            this.btList.Location = new System.Drawing.Point(6, 20);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(169, 23);
            this.btList.TabIndex = 0;
            this.btList.Text = "Listele";
            this.btList.UseVisualStyleBackColor = true;
            this.btList.Click += new System.EventHandler(this.btList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 439);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(468, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(465, 261);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(139, 13);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "Personel Id Buraya Gelecek";
            this.lbId.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 716);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txSalary;
        private System.Windows.Forms.RadioButton rdSingle;
        private System.Windows.Forms.RadioButton rdMarried;
        private System.Windows.Forms.ComboBox txJob;
        private System.Windows.Forms.ComboBox txCity;
        private System.Windows.Forms.TextBox txSurName;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btList;
        private System.Windows.Forms.Button btGraphic;
        private System.Windows.Forms.Button btIstatistic;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbId;
    }
}

