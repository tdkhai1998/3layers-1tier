namespace _3layers_1tier
{
    partial class SÁCH
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
            this.DATA = new System.Windows.Forms.GroupBox();
            this.dGrV_main = new System.Windows.Forms.DataGridView();
            this.btn_load_all = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_UpdateAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrV_main)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA
            // 
            this.DATA.Controls.Add(this.dGrV_main);
            this.DATA.Location = new System.Drawing.Point(39, 155);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(1072, 347);
            this.DATA.TabIndex = 0;
            this.DATA.TabStop = false;
            this.DATA.Text = "DATA";
            // 
            // dGrV_main
            // 
            this.dGrV_main.AllowUserToAddRows = false;
            this.dGrV_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrV_main.Location = new System.Drawing.Point(7, 22);
            this.dGrV_main.Name = "dGrV_main";
            this.dGrV_main.RowTemplate.Height = 24;
            this.dGrV_main.Size = new System.Drawing.Size(1059, 319);
            this.dGrV_main.TabIndex = 0;
            this.dGrV_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrV_main_CellClick);
            this.dGrV_main.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrV_main_CellEnter);
            this.dGrV_main.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrV_main_CellValueChanged);
            this.dGrV_main.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dGrV_main_KeyPress);
            // 
            // btn_load_all
            // 
            this.btn_load_all.Location = new System.Drawing.Point(39, 99);
            this.btn_load_all.Name = "btn_load_all";
            this.btn_load_all.Size = new System.Drawing.Size(158, 32);
            this.btn_load_all.TabIndex = 1;
            this.btn_load_all.Text = "LOAD ALL";
            this.btn_load_all.UseVisualStyleBackColor = true;
            this.btn_load_all.Click += new System.EventHandler(this.btn_load_all_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(266, 99);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(158, 32);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "NEW*";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(947, 99);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(158, 32);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(493, 99);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(158, 32);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_UpdateAll
            // 
            this.btn_UpdateAll.Location = new System.Drawing.Point(720, 99);
            this.btn_UpdateAll.Name = "btn_UpdateAll";
            this.btn_UpdateAll.Size = new System.Drawing.Size(158, 32);
            this.btn_UpdateAll.TabIndex = 6;
            this.btn_UpdateAll.Text = "UPDATE ALL  TABLE";
            this.btn_UpdateAll.UseVisualStyleBackColor = true;
            this.btn_UpdateAll.Click += new System.EventHandler(this.btn_UpdateAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÍ ĐẦU SÁCH";
            // 
            // SÁCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_UpdateAll);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_load_all);
            this.Controls.Add(this.DATA);
            this.Name = "SÁCH";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGrV_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DATA;
        private System.Windows.Forms.DataGridView dGrV_main;
        private System.Windows.Forms.Button btn_load_all;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_UpdateAll;
        private System.Windows.Forms.Label label1;
    }
}

