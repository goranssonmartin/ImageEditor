namespace ImageEditorWinForms
{
    partial class ImageEditorForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.editedImage = new System.Windows.Forms.PictureBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.greyScaleButton = new System.Windows.Forms.Button();
            this.negativeButton = new System.Windows.Forms.Button();
            this.blurredButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.originalImage.Location = new System.Drawing.Point(75, 81);
            this.originalImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.originalImage.Name = "pictureBox1";
            this.originalImage.Size = new System.Drawing.Size(75, 41);
            this.originalImage.TabIndex = 0;
            this.originalImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.editedImage.Location = new System.Drawing.Point(375, 81);
            this.editedImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editedImage.Name = "pictureBox2";
            this.editedImage.Size = new System.Drawing.Size(75, 41);
            this.editedImage.TabIndex = 1;
            this.editedImage.TabStop = false;
            // 
            // button1
            // 
            this.openFileButton.Location = new System.Drawing.Point(9, 10);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openFileButton.Name = "button1";
            this.openFileButton.Size = new System.Drawing.Size(75, 20);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // button2
            // 
            this.greyScaleButton.Location = new System.Drawing.Point(253, 136);
            this.greyScaleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.greyScaleButton.Name = "button2";
            this.greyScaleButton.Size = new System.Drawing.Size(94, 20);
            this.greyScaleButton.TabIndex = 3;
            this.greyScaleButton.Text = "Black and White";
            this.greyScaleButton.UseVisualStyleBackColor = true;
            this.greyScaleButton.Click += new System.EventHandler(this.GreyScaleButton_Click);
            // 
            // button3
            // 
            this.negativeButton.Location = new System.Drawing.Point(253, 161);
            this.negativeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.negativeButton.Name = "button3";
            this.negativeButton.Size = new System.Drawing.Size(94, 20);
            this.negativeButton.TabIndex = 4;
            this.negativeButton.Text = "Negative";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // button4
            // 
            this.blurredButton.Location = new System.Drawing.Point(253, 186);
            this.blurredButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blurredButton.Name = "button4";
            this.blurredButton.Size = new System.Drawing.Size(94, 20);
            this.blurredButton.TabIndex = 5;
            this.blurredButton.Text = "Blurred";
            this.blurredButton.UseVisualStyleBackColor = true;
            this.blurredButton.Click += new System.EventHandler(this.BlurredButton_Click);
            // 
            // button5
            // 
            this.saveFileButton.Location = new System.Drawing.Point(502, 338);
            this.saveFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveFileButton.Name = "button5";
            this.saveFileButton.Size = new System.Drawing.Size(75, 20);
            this.saveFileButton.TabIndex = 6;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.blurredButton);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.greyScaleButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.editedImage);
            this.Controls.Add(this.originalImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ImageEditor";
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.PictureBox editedImage;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button greyScaleButton;
        private System.Windows.Forms.Button negativeButton;
        private System.Windows.Forms.Button blurredButton;
        private System.Windows.Forms.Button saveFileButton;
    }
}

