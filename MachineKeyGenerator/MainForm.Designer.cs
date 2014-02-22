namespace MachineKeyGenerator
{
    partial class MainForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.KeySizeDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GeneratedKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateKeyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 49);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(51, 13);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "InfoLabel";
            // 
            // KeySizeDropDown
            // 
            this.KeySizeDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.KeySizeDropDown.FormattingEnabled = true;
            this.KeySizeDropDown.Location = new System.Drawing.Point(12, 25);
            this.KeySizeDropDown.Name = "KeySizeDropDown";
            this.KeySizeDropDown.Size = new System.Drawing.Size(559, 21);
            this.KeySizeDropDown.TabIndex = 1;
            this.KeySizeDropDown.SelectedIndexChanged += new System.EventHandler(this.KeySizeDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key Size:";
            // 
            // GeneratedKeyTextBox
            // 
            this.GeneratedKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratedKeyTextBox.Location = new System.Drawing.Point(15, 117);
            this.GeneratedKeyTextBox.Multiline = true;
            this.GeneratedKeyTextBox.Name = "GeneratedKeyTextBox";
            this.GeneratedKeyTextBox.Size = new System.Drawing.Size(556, 109);
            this.GeneratedKeyTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generated Key:";
            // 
            // GenerateKeyButton
            // 
            this.GenerateKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateKeyButton.Location = new System.Drawing.Point(15, 233);
            this.GenerateKeyButton.Name = "GenerateKeyButton";
            this.GenerateKeyButton.Size = new System.Drawing.Size(555, 32);
            this.GenerateKeyButton.TabIndex = 5;
            this.GenerateKeyButton.Text = "GenerateKey";
            this.GenerateKeyButton.UseVisualStyleBackColor = true;
            this.GenerateKeyButton.Click += new System.EventHandler(this.GenerateKeyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 273);
            this.Controls.Add(this.GenerateKeyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeneratedKeyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeySizeDropDown);
            this.Controls.Add(this.InfoLabel);
            this.Name = "MainForm";
            this.Text = "Machinekey Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.ComboBox KeySizeDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox GeneratedKeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateKeyButton;
    }
}

