
namespace WinformButton
{
    partial class FormButton
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHo
            // 
            this.btnHo.AutoSize = true;
            this.btnHo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHo.Location = new System.Drawing.Point(171, 189);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(61, 30);
            this.btnHo.TabIndex = 2;
            this.btnHo.Text = "Họ lót";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.29258F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.70742F));
            this.tableLayoutPanel1.Controls.Add(this.lblHoTen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTen, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTen, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(123, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.72839F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.27161F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 114);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.lblHoTen, 2);
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoTen.Location = new System.Drawing.Point(0, 0);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(458, 50);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHo
            // 
            this.lblHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHo.Location = new System.Drawing.Point(3, 50);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(119, 31);
            this.lblHo.TabIndex = 1;
            this.lblHo.Text = "Họ lót";
            this.lblHo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHo
            // 
            this.txtHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHo.Location = new System.Drawing.Point(128, 53);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(327, 27);
            this.txtHo.TabIndex = 0;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTen.Location = new System.Drawing.Point(3, 81);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(119, 33);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTen
            // 
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.Location = new System.Drawing.Point(128, 84);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(327, 27);
            this.txtTen.TabIndex = 1;
            // 
            // btnTen
            // 
            this.btnTen.AutoSize = true;
            this.btnTen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTen.Location = new System.Drawing.Point(286, 189);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(42, 30);
            this.btnTen.TabIndex = 3;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.AutoSize = true;
            this.btnHoTen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHoTen.Location = new System.Drawing.Point(393, 189);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(85, 30);
            this.btnHoTen.TabIndex = 4;
            this.btnHoTen.Text = "Họ và Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(207, 252);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(215, 29);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Thoát chương trình";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // FormButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormButton";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

