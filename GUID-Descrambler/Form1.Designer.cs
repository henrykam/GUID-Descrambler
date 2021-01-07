
namespace GUID_Descrambler
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.includeDashesCheckBox = new System.Windows.Forms.CheckBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.validLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 83);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(341, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 67);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(37, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "GUID:";
            // 
            // includeDashesCheckBox
            // 
            this.includeDashesCheckBox.Location = new System.Drawing.Point(12, 147);
            this.includeDashesCheckBox.Name = "includeDashesCheckBox";
            this.includeDashesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.includeDashesCheckBox.TabIndex = 2;
            this.includeDashesCheckBox.Text = "Include dashes";
            this.includeDashesCheckBox.UseVisualStyleBackColor = true;
            this.includeDashesCheckBox.CheckedChanged += new System.EventHandler(this.includeDashesCheckBox_CheckedChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 122);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(341, 20);
            this.outputTextBox.TabIndex = 3;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 106);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(42, 13);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Output:";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(278, 148);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // validLabel
            // 
            this.validLabel.AutoSize = true;
            this.validLabel.ForeColor = System.Drawing.Color.Green;
            this.validLabel.Location = new System.Drawing.Point(55, 67);
            this.validLabel.Name = "validLabel";
            this.validLabel.Size = new System.Drawing.Size(0, 13);
            this.validLabel.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(341, 41);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Some databases store GUIDs in reverse byte order for indexing purposes. Enter a G" +
    "UID below to obtain the reverse byte order representation of the GUID.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 184);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.validLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.includeDashesCheckBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GUID Descrambler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.CheckBox includeDashesCheckBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label validLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}

