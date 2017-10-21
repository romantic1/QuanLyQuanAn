namespace ChiNhanh
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
            this.dgv_hienThi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_maChiNhanh = new System.Windows.Forms.TextBox();
            this.text_tenChiNhanh = new System.Windows.Forms.TextBox();
            this.text_soDienThoai = new System.Windows.Forms.TextBox();
            this.text_diaChi = new System.Windows.Forms.TextBox();
            this.text_tinhThanh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hienThi
            // 
            this.dgv_hienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_hienThi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_hienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienThi.Location = new System.Drawing.Point(388, 28);
            this.dgv_hienThi.Name = "dgv_hienThi";
            this.dgv_hienThi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_hienThi.Size = new System.Drawing.Size(437, 465);
            this.dgv_hienThi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin chi nhánh";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xuất nhân viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "Refesh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã chi nhánh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên chi nhánh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tỉnh thành";
            // 
            // text_maChiNhanh
            // 
            this.text_maChiNhanh.Location = new System.Drawing.Point(100, 28);
            this.text_maChiNhanh.Name = "text_maChiNhanh";
            this.text_maChiNhanh.Size = new System.Drawing.Size(266, 20);
            this.text_maChiNhanh.TabIndex = 10;
            // 
            // text_tenChiNhanh
            // 
            this.text_tenChiNhanh.Location = new System.Drawing.Point(100, 72);
            this.text_tenChiNhanh.Multiline = true;
            this.text_tenChiNhanh.Name = "text_tenChiNhanh";
            this.text_tenChiNhanh.Size = new System.Drawing.Size(266, 63);
            this.text_tenChiNhanh.TabIndex = 11;
            // 
            // text_soDienThoai
            // 
            this.text_soDienThoai.Location = new System.Drawing.Point(100, 167);
            this.text_soDienThoai.Name = "text_soDienThoai";
            this.text_soDienThoai.Size = new System.Drawing.Size(266, 20);
            this.text_soDienThoai.TabIndex = 12;
            // 
            // text_diaChi
            // 
            this.text_diaChi.Location = new System.Drawing.Point(100, 225);
            this.text_diaChi.Multiline = true;
            this.text_diaChi.Name = "text_diaChi";
            this.text_diaChi.Size = new System.Drawing.Size(266, 58);
            this.text_diaChi.TabIndex = 13;
            // 
            // text_tinhThanh
            // 
            this.text_tinhThanh.Location = new System.Drawing.Point(99, 304);
            this.text_tinhThanh.Name = "text_tinhThanh";
            this.text_tinhThanh.Size = new System.Drawing.Size(266, 20);
            this.text_tinhThanh.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_chiNhanh
            // 
            this.cb_chiNhanh.FormattingEnabled = true;
            this.cb_chiNhanh.Items.AddRange(new object[] {
            "Chi Nhánh 1",
            "Chi Nhánh 2",
            "Chi Nhánh 3",
            "Chi Nhánh 4",
            "Chi Nhánh 5",
            "Chi Nhánh 6"});
            this.cb_chiNhanh.Location = new System.Drawing.Point(223, 386);
            this.cb_chiNhanh.Name = "cb_chiNhanh";
            this.cb_chiNhanh.Size = new System.Drawing.Size(121, 21);
            this.cb_chiNhanh.TabIndex = 16;
            this.cb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cb_chiNhanh_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chi nhánh";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(99, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 47);
            this.button4.TabIndex = 18;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 505);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_chiNhanh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_tinhThanh);
            this.Controls.Add(this.text_diaChi);
            this.Controls.Add(this.text_soDienThoai);
            this.Controls.Add(this.text_tenChiNhanh);
            this.Controls.Add(this.text_maChiNhanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hienThi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Nhánh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_maChiNhanh;
        private System.Windows.Forms.TextBox text_tenChiNhanh;
        private System.Windows.Forms.TextBox text_soDienThoai;
        private System.Windows.Forms.TextBox text_diaChi;
        private System.Windows.Forms.TextBox text_tinhThanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_chiNhanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}

