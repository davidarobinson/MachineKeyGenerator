using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MachineKeyGenerator
{
    public partial class MainForm : Form
    {
        List<KeyDetail> keyOptions = new List<KeyDetail>(){
            new KeyDetail { Text = "SHA1, Validation key of 64 bytes (128 Hex chars)", Description="", KeyLength=128},
            new KeyDetail { Text = "AES, Decryption key of 32 bytes (64 Hex chars)", Description = "", KeyLength=64 },
            new KeyDetail { Text = "3DES, Decryption key of 24 byes (48 Hex chars)", Description="", KeyLength=48}
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InfoLabel.Text = "Each byte is represented by two hexadecimal characters; therefore a 32-byte key requires 64 hexidecimal characters.";
            PopulateKeySizes();
        }

        private void PopulateKeySizes()
        {
            bindingSource1.DataSource = keyOptions;
            KeySizeDropDown.DataSource = bindingSource1.DataSource;
            KeySizeDropDown.DisplayMember = "Text";
            KeySizeDropDown.ValueMember = "KeyLength";
        }

        private void KeySizeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            var item = KeySizeDropDown.SelectedItem;
            var len = ((KeyDetail)item).KeyLength;
            byte[] buffer = new byte[len / 2];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);

            StringBuilder sb = new StringBuilder(len);
            for (int loopCount = 0; loopCount < buffer.Length; loopCount++)
                sb.Append(string.Format("{0:X2}", buffer[loopCount]));

            GeneratedKeyTextBox.Text = sb.ToString();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class KeyDetail
    {
        public string Text { get; set; }
        public string Description { get; set; }
        public int KeyLength { get; set; }
    }
}
