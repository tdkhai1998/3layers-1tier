namespace _3layers_1tier
{
    partial class InsertNew
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
            this.textBox_tenSach = new System.Windows.Forms.TextBox();
            this.textBox_soLuong = new System.Windows.Forms.TextBox();
            this.textBox_tacGia = new System.Windows.Forms.TextBox();
            this.textBox_namXuatBan = new System.Windows.Forms.MaskedTextBox();
            this.textBox_theLoai = new System.Windows.Forms.ComboBox();
            this.textBox_tomTat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_tenForm = new System.Windows.Forms.Label();
            this.btn_themMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_tenSach
            // 
            this.textBox_tenSach.Location = new System.Drawing.Point(484, 34);
            this.textBox_tenSach.Name = "textBox_tenSach";
            this.textBox_tenSach.Size = new System.Drawing.Size(204, 22);
            this.textBox_tenSach.TabIndex = 0;
            // 
            // textBox_soLuong
            // 
            this.textBox_soLuong.Location = new System.Drawing.Point(484, 208);
            this.textBox_soLuong.Name = "textBox_soLuong";
            this.textBox_soLuong.Size = new System.Drawing.Size(204, 22);
            this.textBox_soLuong.TabIndex = 1;
            this.textBox_soLuong.Text = "1";
            this.textBox_soLuong.TextChanged += new System.EventHandler(this.textBox_soLuong_TextChanged);
            this.textBox_soLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_soLuong_KeyPress);
            // 
            // textBox_tacGia
            // 
            this.textBox_tacGia.Location = new System.Drawing.Point(484, 92);
            this.textBox_tacGia.Name = "textBox_tacGia";
            this.textBox_tacGia.Size = new System.Drawing.Size(204, 22);
            this.textBox_tacGia.TabIndex = 3;
            // 
            // textBox_namXuatBan
            // 
            this.textBox_namXuatBan.Location = new System.Drawing.Point(484, 150);
            this.textBox_namXuatBan.Mask = "0000";
            this.textBox_namXuatBan.Name = "textBox_namXuatBan";
            this.textBox_namXuatBan.Size = new System.Drawing.Size(204, 22);
            this.textBox_namXuatBan.TabIndex = 4;
            this.textBox_namXuatBan.Text = "2019";
            this.textBox_namXuatBan.ValidatingType = typeof(int);
            // 
            // textBox_theLoai
            // 
            this.textBox_theLoai.FormattingEnabled = true;
            this.textBox_theLoai.Items.AddRange(new object[] {
            "Truyện Tranh",
            "Giáo trình",
            "Tiểu Thuyết",
            "Sách tham khảo",
            "Tác phẩm văn học"});
            this.textBox_theLoai.Location = new System.Drawing.Point(484, 266);
            this.textBox_theLoai.Name = "textBox_theLoai";
            this.textBox_theLoai.Size = new System.Drawing.Size(204, 24);
            this.textBox_theLoai.TabIndex = 5;
            // 
            // textBox_tomTat
            // 
            this.textBox_tomTat.Location = new System.Drawing.Point(50, 335);
            this.textBox_tomTat.Multiline = true;
            this.textBox_tomTat.Name = "textBox_tomTat";
            this.textBox_tomTat.Size = new System.Drawing.Size(643, 220);
            this.textBox_tomTat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Năm xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thể loại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tóm tắt";
            // 
            // label_tenForm
            // 
            this.label_tenForm.AutoSize = true;
            this.label_tenForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenForm.Location = new System.Drawing.Point(31, 92);
            this.label_tenForm.Name = "label_tenForm";
            this.label_tenForm.Size = new System.Drawing.Size(266, 36);
            this.label_tenForm.TabIndex = 15;
            this.label_tenForm.Text = "THÊM SÁCH MỚI";
            // 
            // btn_themMoi
            // 
            this.btn_themMoi.Location = new System.Drawing.Point(86, 173);
            this.btn_themMoi.Name = "btn_themMoi";
            this.btn_themMoi.Size = new System.Drawing.Size(156, 57);
            this.btn_themMoi.TabIndex = 16;
            this.btn_themMoi.Text = "THÊM MỚI";
            this.btn_themMoi.UseVisualStyleBackColor = true;
            this.btn_themMoi.Click += new System.EventHandler(this.btn_themMoi_Click);
            // 
            // InsertNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 591);
            this.Controls.Add(this.btn_themMoi);
            this.Controls.Add(this.label_tenForm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_tomTat);
            this.Controls.Add(this.textBox_theLoai);
            this.Controls.Add(this.textBox_namXuatBan);
            this.Controls.Add(this.textBox_tacGia);
            this.Controls.Add(this.textBox_soLuong);
            this.Controls.Add(this.textBox_tenSach);
            this.Name = "InsertNew";
            this.Text = "InsertNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tenSach;
        private System.Windows.Forms.TextBox textBox_soLuong;
        private System.Windows.Forms.TextBox textBox_tacGia;
        private System.Windows.Forms.MaskedTextBox textBox_namXuatBan;
        private System.Windows.Forms.ComboBox textBox_theLoai;
        private System.Windows.Forms.TextBox textBox_tomTat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_tenForm;
        private System.Windows.Forms.Button btn_themMoi;
    }
}