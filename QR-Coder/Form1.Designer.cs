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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtInput = new TextBox();
            btnGenerate = new Button();
            txtBase64 = new TextBox();
            pictureBoxQRCode = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(14, 41);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(774, 27);
            txtInput.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(14, 156);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(152, 29);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate QR Code";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtBase64
            // 
            txtBase64.Location = new Point(14, 111);
            txtBase64.Name = "txtBase64";
            txtBase64.Size = new Size(774, 27);
            txtBase64.TabIndex = 2;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(504, 144);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(284, 265);
            pictureBoxQRCode.TabIndex = 3;
            pictureBoxQRCode.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 4;
            label1.Text = "QR Code String:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 5;
            label2.Text = "Decoded Base64 String:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(-3, 424);
            label3.Name = "label3";
            label3.Size = new Size(160, 17);
            label3.TabIndex = 6;
            label3.Text = "Maintained by Dylan Rose";
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(641, 415);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(147, 32);
            btnCopy.TabIndex = 7;
            btnCopy.Text = "Copy QR Code";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCopy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(txtBase64);
            Controls.Add(btnGenerate);
            Controls.Add(txtInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "QR Coder";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
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
    }
}
