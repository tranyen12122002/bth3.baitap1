namespace bth3.baitap1
{
    partial class Giaiphuongtrinhbacnhat
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
            this.components = new System.ComponentModel.Container();
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.lbnghiem = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtnghiem = new System.Windows.Forms.TextBox();
            this.btngiai = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(144, 35);
            this.lba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(66, 22);
            this.lba.TabIndex = 0;
            this.lba.Text = "Nhập a";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(143, 87);
            this.lbb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(67, 22);
            this.lbb.TabIndex = 1;
            this.lbb.Text = "Nhập b";
            // 
            // lbnghiem
            // 
            this.lbnghiem.AutoSize = true;
            this.lbnghiem.Location = new System.Drawing.Point(31, 144);
            this.lbnghiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnghiem.Name = "lbnghiem";
            this.lbnghiem.Size = new System.Drawing.Size(179, 22);
            this.lbnghiem.TabIndex = 2;
            this.lbnghiem.Text = "Nghiệm phương trình";
            // 
            // txta
            // 
            this.txta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txta.Location = new System.Drawing.Point(235, 32);
            this.txta.Margin = new System.Windows.Forms.Padding(4);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(267, 29);
            this.txta.TabIndex = 3;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // txtb
            // 
            this.txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb.Location = new System.Drawing.Point(235, 84);
            this.txtb.Margin = new System.Windows.Forms.Padding(4);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(267, 29);
            this.txtb.TabIndex = 4;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // txtnghiem
            // 
            this.txtnghiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnghiem.Location = new System.Drawing.Point(235, 141);
            this.txtnghiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtnghiem.Name = "txtnghiem";
            this.txtnghiem.Size = new System.Drawing.Size(267, 29);
            this.txtnghiem.TabIndex = 5;
            // 
            // btngiai
            // 
            this.btngiai.Location = new System.Drawing.Point(35, 219);
            this.btngiai.Margin = new System.Windows.Forms.Padding(4);
            this.btngiai.Name = "btngiai";
            this.btngiai.Size = new System.Drawing.Size(82, 35);
            this.btngiai.TabIndex = 6;
            this.btngiai.Text = "Giải";
            this.btngiai.UseVisualStyleBackColor = true;
            this.btngiai.Click += new System.EventHandler(this.btngiai_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(220, 219);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 35);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(418, 219);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 35);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Giaiphuongtrinhbacnhat
            // 
            this.AcceptButton = this.btngiai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(536, 288);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btngiai);
            this.Controls.Add(this.txtnghiem);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbnghiem);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giaiphuongtrinhbacnhat";
            this.Text = "Giải phương trình bậc nhất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giaiphuongtrinhbacnhat_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label lbnghiem;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtnghiem;
        private System.Windows.Forms.Button btngiai;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

