namespace QLGV
{
    partial class frmQuanLy
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
            this.btnShow = new System.Windows.Forms.Button();
            this.dtGridViewGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdGV = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtKhen = new System.Windows.Forms.TextBox();
            this.txtKyLuat = new System.Windows.Forms.TextBox();
            this.txtQuaTrinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 340);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(154, 31);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Hiển thị danh sách";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtGridViewGV
            // 
            this.dtGridViewGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewGV.Location = new System.Drawing.Point(1, 1);
            this.dtGridViewGV.Name = "dtGridViewGV";
            this.dtGridViewGV.RowTemplate.Height = 24;
            this.dtGridViewGV.Size = new System.Drawing.Size(883, 322);
            this.dtGridViewGV.TabIndex = 1;
            this.dtGridViewGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewGV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(15, 404);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(203, 22);
            this.txtTenGV.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 462);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(267, 404);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(182, 22);
            this.txtAddress.TabIndex = 8;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(486, 404);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(140, 22);
            this.txtBirthday.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã giáo viên";
            // 
            // txtIdGV
            // 
            this.txtIdGV.Location = new System.Drawing.Point(659, 404);
            this.txtIdGV.Name = "txtIdGV";
            this.txtIdGV.Size = new System.Drawing.Size(48, 22);
            this.txtIdGV.TabIndex = 11;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(172, 340);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 31);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giới tính";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(267, 462);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(182, 22);
            this.txtGender.TabIndex = 14;
            // 
            // txtKhen
            // 
            this.txtKhen.Location = new System.Drawing.Point(486, 461);
            this.txtKhen.Name = "txtKhen";
            this.txtKhen.Size = new System.Drawing.Size(140, 22);
            this.txtKhen.TabIndex = 15;
            // 
            // txtKyLuat
            // 
            this.txtKyLuat.Location = new System.Drawing.Point(659, 462);
            this.txtKyLuat.Name = "txtKyLuat";
            this.txtKyLuat.Size = new System.Drawing.Size(170, 22);
            this.txtKyLuat.TabIndex = 16;
            // 
            // txtQuaTrinh
            // 
            this.txtQuaTrinh.Location = new System.Drawing.Point(761, 404);
            this.txtQuaTrinh.Name = "txtQuaTrinh";
            this.txtQuaTrinh.Size = new System.Drawing.Size(100, 22);
            this.txtQuaTrinh.TabIndex = 17;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 526);
            this.Controls.Add(this.txtQuaTrinh);
            this.Controls.Add(this.txtKyLuat);
            this.Controls.Add(this.txtKhen);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtIdGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridViewGV);
            this.Controls.Add(this.btnShow);
            this.Name = "frmQuanLy";
            this.Text = "Quản lý thông tin giáo viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dtGridViewGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdGV;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtKhen;
        private System.Windows.Forms.TextBox txtKyLuat;
        private System.Windows.Forms.TextBox txtQuaTrinh;
    }
}

