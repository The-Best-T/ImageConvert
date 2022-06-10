namespace ImageConvert
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
            this.inputButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.inputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.outputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(109, 188);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(138, 60);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "Input";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(510, 188);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(138, 60);
            this.outputButton.TabIndex = 1;
            this.outputButton.Text = "Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(311, 188);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(138, 60);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.inputButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.FolderBrowserDialog inputFolder;
        private System.Windows.Forms.FolderBrowserDialog outputFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

