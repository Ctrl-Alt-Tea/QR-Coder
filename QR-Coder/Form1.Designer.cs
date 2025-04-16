namespace QR_Coder
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtInput = new TextBox();
            btnGenerate = new Button();
            txtBase64 = new TextBox();
            pictureBoxQRCode = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCopy = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(27, 46);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(774, 27);
            txtInput.TabIndex = 0;
            toolTip.SetToolTip(txtInput, "Enter your Base64-encoded string here.");
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.MediumSeaGreen;
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(6, 143);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(152, 29);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate QR Code";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtBase64
            // 
            txtBase64.Location = new Point(27, 99);
            txtBase64.Name = "txtBase64";
            txtBase64.Size = new Size(774, 27);
            txtBase64.TabIndex = 1;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(6, 26);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(284, 265);
            pictureBoxQRCode.TabIndex = 3;
            pictureBoxQRCode.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 4;
            label1.Text = "QR Code String:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 76);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 5;
            label2.Text = "Decoded Base64 String:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 517);
            label3.Name = "label3";
            label3.Size = new Size(160, 17);
            label3.TabIndex = 6;
            label3.Text = "Maintained by Dylan Rose";
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.SteelBlue;
            btnCopy.ForeColor = Color.White;
            btnCopy.Location = new Point(72, 297);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(147, 32);
            btnCopy.TabIndex = 3;
            btnCopy.Text = "Copy QR Code";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBase64);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtInput);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 180);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "QR Code Parameters";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBoxQRCode);
            groupBox2.Controls.Add(btnCopy);
            groupBox2.Location = new Point(257, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 333);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Your QR Code";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(830, 543);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "QR Coder";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnGenerate;
        private TextBox txtBase64;
        private PictureBox pictureBoxQRCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCopy;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolTip toolTip;
    }
}
