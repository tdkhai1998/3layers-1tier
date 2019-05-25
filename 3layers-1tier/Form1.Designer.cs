namespace _3layers_1tier
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_load_all = new System.Windows.Forms.Button();
            this.dGrV_main = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrV_main)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGrV_main);
            this.groupBox1.Location = new System.Drawing.Point(39, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_load_all
            // 
            this.btn_load_all.Location = new System.Drawing.Point(39, 55);
            this.btn_load_all.Name = "btn_load_all";
            this.btn_load_all.Size = new System.Drawing.Size(139, 32);
            this.btn_load_all.TabIndex = 1;
            this.btn_load_all.Text = "Load All";
            this.btn_load_all.UseVisualStyleBackColor = true;
            this.btn_load_all.Click += new System.EventHandler(this.btn_load_all_Click);
            // 
            // dGrV_main
            // 
            this.dGrV_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrV_main.Location = new System.Drawing.Point(7, 22);
            this.dGrV_main.Name = "dGrV_main";
            this.dGrV_main.RowTemplate.Height = 24;
            this.dGrV_main.Size = new System.Drawing.Size(1059, 319);
            this.dGrV_main.TabIndex = 0;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(214, 55);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(139, 32);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "New*";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 535);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_load_all);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGrV_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGrV_main;
        private System.Windows.Forms.Button btn_load_all;
        private System.Windows.Forms.Button btn_insert;
    }
}

