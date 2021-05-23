
namespace WinformRadioButton
{
    partial class FormRadioButtonAndCheckbox
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
            this.lblTitleNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTilteLapTrinh = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelColor = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelFont = new System.Windows.Forms.FlowLayoutPanel();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelRadioButtonAndCheckbox = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelColor.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxFont.SuspendLayout();
            this.flowLayoutPanelFont.SuspendLayout();
            this.tableLayoutPanelRadioButtonAndCheckbox.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleNhapTen
            // 
            this.lblTitleNhapTen.AutoSize = true;
            this.lblTitleNhapTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleNhapTen.Location = new System.Drawing.Point(3, 0);
            this.lblTitleNhapTen.Name = "lblTitleNhapTen";
            this.lblTitleNhapTen.Size = new System.Drawing.Size(75, 39);
            this.lblTitleNhapTen.TabIndex = 0;
            this.lblTitleNhapTen.Text = "Nhập tên: ";
            this.lblTitleNhapTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhapTen.Location = new System.Drawing.Point(84, 6);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(505, 27);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.Text = "Nguyễn Văn A";
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.Location = new System.Drawing.Point(587, 15);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTilteLapTrinh
            // 
            this.lblTilteLapTrinh.AutoSize = true;
            this.lblTilteLapTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTilteLapTrinh.Location = new System.Drawing.Point(3, 0);
            this.lblTilteLapTrinh.Name = "lblTilteLapTrinh";
            this.lblTilteLapTrinh.Size = new System.Drawing.Size(128, 60);
            this.lblTilteLapTrinh.TabIndex = 3;
            this.lblTilteLapTrinh.Text = "Lập Trình Bởi: ";
            this.lblTilteLapTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLapTrinh.Location = new System.Drawing.Point(137, 0);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(431, 60);
            this.lblLapTrinh.TabIndex = 4;
            this.lblLapTrinh.Text = "Nguyễn Văn A";
            this.lblLapTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radBlack.Location = new System.Drawing.Point(23, 98);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(67, 24);
            this.radBlack.TabIndex = 5;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(23, 38);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(72, 24);
            this.radGreen.TabIndex = 3;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(23, 68);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(61, 24);
            this.radBlue.TabIndex = 4;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(23, 8);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(57, 24);
            this.radRed.TabIndex = 2;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelColor
            // 
            this.flowLayoutPanelColor.Controls.Add(this.radRed);
            this.flowLayoutPanelColor.Controls.Add(this.radGreen);
            this.flowLayoutPanelColor.Controls.Add(this.radBlue);
            this.flowLayoutPanelColor.Controls.Add(this.radBlack);
            this.flowLayoutPanelColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelColor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelColor.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanelColor.Name = "flowLayoutPanelColor";
            this.flowLayoutPanelColor.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.flowLayoutPanelColor.Size = new System.Drawing.Size(175, 173);
            this.flowLayoutPanelColor.TabIndex = 6;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.flowLayoutPanelColor);
            this.groupBoxColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxColor.Location = new System.Drawing.Point(3, 3);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(181, 199);
            this.groupBoxColor.TabIndex = 7;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.Controls.Add(this.flowLayoutPanelFont);
            this.groupBoxFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFont.Location = new System.Drawing.Point(190, 3);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(181, 199);
            this.groupBoxFont.TabIndex = 8;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "Font";
            // 
            // flowLayoutPanelFont
            // 
            this.flowLayoutPanelFont.Controls.Add(this.chkBold);
            this.flowLayoutPanelFont.Controls.Add(this.chkItalic);
            this.flowLayoutPanelFont.Controls.Add(this.chkUnderline);
            this.flowLayoutPanelFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFont.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFont.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanelFont.Name = "flowLayoutPanelFont";
            this.flowLayoutPanelFont.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.flowLayoutPanelFont.Size = new System.Drawing.Size(175, 173);
            this.flowLayoutPanelFont.TabIndex = 9;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBold.Location = new System.Drawing.Point(23, 8);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(100, 24);
            this.chkBold.TabIndex = 8;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chkItalic.Location = new System.Drawing.Point(23, 38);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(121, 24);
            this.chkItalic.TabIndex = 6;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.chkUnderline.Location = new System.Drawing.Point(23, 68);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(99, 24);
            this.chkUnderline.TabIndex = 7;
            this.chkUnderline.Text = "Gạch chân";
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelRadioButtonAndCheckbox
            // 
            this.tableLayoutPanelRadioButtonAndCheckbox.ColumnCount = 2;
            this.tableLayoutPanelRadioButtonAndCheckbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRadioButtonAndCheckbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRadioButtonAndCheckbox.Controls.Add(this.groupBoxColor, 0, 0);
            this.tableLayoutPanelRadioButtonAndCheckbox.Controls.Add(this.groupBoxFont, 1, 0);
            this.tableLayoutPanelRadioButtonAndCheckbox.Location = new System.Drawing.Point(219, 114);
            this.tableLayoutPanelRadioButtonAndCheckbox.Name = "tableLayoutPanelRadioButtonAndCheckbox";
            this.tableLayoutPanelRadioButtonAndCheckbox.RowCount = 1;
            this.tableLayoutPanelRadioButtonAndCheckbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRadioButtonAndCheckbox.Size = new System.Drawing.Size(374, 205);
            this.tableLayoutPanelRadioButtonAndCheckbox.TabIndex = 10;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 3;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58156F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.41844F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanelBottom.Controls.Add(this.btnThoat, 2, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.lblTilteLapTrinh, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.lblLapTrinh, 1, 0);
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(80, 334);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(684, 60);
            this.tableLayoutPanelBottom.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.68243F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.31757F));
            this.tableLayoutPanelTop.Controls.Add(this.txtNhapTen, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.lblTitleNhapTen, 0, 0);
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(169, 45);
            this.tableLayoutPanelTop.Name = "tableLayoutPanel1";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(592, 39);
            this.tableLayoutPanelTop.TabIndex = 12;
            // 
            // FormRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelRadioButtonAndCheckbox);
            this.Name = "FormRadioButton";
            this.Text = "Form1";
            this.flowLayoutPanelColor.ResumeLayout(false);
            this.flowLayoutPanelColor.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxFont.ResumeLayout(false);
            this.flowLayoutPanelFont.ResumeLayout(false);
            this.flowLayoutPanelFont.PerformLayout();
            this.tableLayoutPanelRadioButtonAndCheckbox.ResumeLayout(false);
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTilteLapTrinh;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFont;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRadioButtonAndCheckbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
    }
}

