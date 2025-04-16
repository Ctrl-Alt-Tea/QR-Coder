using System.Text;
using ZXing;
using ZXing.Windows.Compatibility;

namespace QR_Coder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string base64Input = txtInput.Text;
                if (string.IsNullOrWhiteSpace(base64Input))
                {
                    MessageBox.Show("Input text cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Decode Base64 string
                byte[] decodedBytes = Convert.FromBase64String(base64Input);
                string decodedText = Encoding.UTF8.GetString(decodedBytes);
                txtBase64.Text = decodedText;

                // Generate QR Code
                BarcodeWriter qrWriter = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Height = pictureBoxQRCode.Height,
                        Width = pictureBoxQRCode.Width
                    }
                };
                Bitmap qrCodeImage = qrWriter.Write(decodedText);

                if (qrCodeImage != null)
                {
                    pictureBoxQRCode.Image = qrCodeImage;
                }
                else
                {
                    MessageBox.Show("QR Code generation failed.");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Base64 string. Please provide a valid Base64-encoded string.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCopy_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxQRCode.Image != null)
            {
                Clipboard.SetImage(pictureBoxQRCode.Image);
                MessageBox.Show("QR Code copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No QR Code to copy. Please generate one first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
