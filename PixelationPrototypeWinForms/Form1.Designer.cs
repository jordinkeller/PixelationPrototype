namespace PixelationPrototypeWinForms
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
            this.UI_btnChoosePic = new System.Windows.Forms.Button();
            this.UI_btnPixelate = new System.Windows.Forms.Button();
            this.UI_PictureViewer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_lblFileLocation = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_txtPixelSize = new System.Windows.Forms.TextBox();
            this.UI_btnReduceColors = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_txtColorReduction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UI_PictureViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_btnChoosePic
            // 
            this.UI_btnChoosePic.Location = new System.Drawing.Point(13, 13);
            this.UI_btnChoosePic.Name = "UI_btnChoosePic";
            this.UI_btnChoosePic.Size = new System.Drawing.Size(192, 23);
            this.UI_btnChoosePic.TabIndex = 0;
            this.UI_btnChoosePic.Text = "Choose Picture";
            this.UI_btnChoosePic.UseVisualStyleBackColor = true;
            this.UI_btnChoosePic.Click += new System.EventHandler(this.UI_btnChoosePic_Click);
            // 
            // UI_btnPixelate
            // 
            this.UI_btnPixelate.Location = new System.Drawing.Point(15, 100);
            this.UI_btnPixelate.Name = "UI_btnPixelate";
            this.UI_btnPixelate.Size = new System.Drawing.Size(190, 23);
            this.UI_btnPixelate.TabIndex = 1;
            this.UI_btnPixelate.Text = "Pixelate";
            this.UI_btnPixelate.UseVisualStyleBackColor = true;
            this.UI_btnPixelate.Click += new System.EventHandler(this.UI_btnPixelate_Click);
            // 
            // UI_PictureViewer
            // 
            this.UI_PictureViewer.Location = new System.Drawing.Point(211, 13);
            this.UI_PictureViewer.Name = "UI_PictureViewer";
            this.UI_PictureViewer.Size = new System.Drawing.Size(376, 328);
            this.UI_PictureViewer.TabIndex = 2;
            this.UI_PictureViewer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Location:";
            // 
            // UI_lblFileLocation
            // 
            this.UI_lblFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_lblFileLocation.Location = new System.Drawing.Point(88, 39);
            this.UI_lblFileLocation.Name = "UI_lblFileLocation";
            this.UI_lblFileLocation.Size = new System.Drawing.Size(117, 23);
            this.UI_lblFileLocation.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pixel Size:";
            // 
            // UI_txtPixelSize
            // 
            this.UI_txtPixelSize.Location = new System.Drawing.Point(88, 74);
            this.UI_txtPixelSize.Name = "UI_txtPixelSize";
            this.UI_txtPixelSize.Size = new System.Drawing.Size(117, 20);
            this.UI_txtPixelSize.TabIndex = 6;
            this.UI_txtPixelSize.TextChanged += new System.EventHandler(this.UI_txtPixelSize_TextChanged);
            // 
            // UI_btnReduceColors
            // 
            this.UI_btnReduceColors.Enabled = false;
            this.UI_btnReduceColors.Location = new System.Drawing.Point(15, 177);
            this.UI_btnReduceColors.Name = "UI_btnReduceColors";
            this.UI_btnReduceColors.Size = new System.Drawing.Size(190, 23);
            this.UI_btnReduceColors.TabIndex = 7;
            this.UI_btnReduceColors.Text = "Reduce Colors";
            this.UI_btnReduceColors.UseVisualStyleBackColor = true;
            this.UI_btnReduceColors.Click += new System.EventHandler(this.UI_btnReduceColors_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reduced Color Amount:";
            // 
            // UI_txtColorReduction
            // 
            this.UI_txtColorReduction.Location = new System.Drawing.Point(15, 151);
            this.UI_txtColorReduction.Name = "UI_txtColorReduction";
            this.UI_txtColorReduction.Size = new System.Drawing.Size(190, 20);
            this.UI_txtColorReduction.TabIndex = 10;
            this.UI_txtColorReduction.TextChanged += new System.EventHandler(this.UI_txtColorReduction_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 353);
            this.Controls.Add(this.UI_txtColorReduction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UI_btnReduceColors);
            this.Controls.Add(this.UI_txtPixelSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_lblFileLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_PictureViewer);
            this.Controls.Add(this.UI_btnPixelate);
            this.Controls.Add(this.UI_btnChoosePic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_PictureViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_btnChoosePic;
        private System.Windows.Forms.Button UI_btnPixelate;
        private System.Windows.Forms.PictureBox UI_PictureViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UI_lblFileLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UI_txtPixelSize;
        private System.Windows.Forms.Button UI_btnReduceColors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UI_txtColorReduction;
    }
}

