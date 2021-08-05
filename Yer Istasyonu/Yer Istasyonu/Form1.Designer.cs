
namespace Yer_Istasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RotatingImg = new System.Windows.Forms.PictureBox();
            this.txtBoxRoll = new System.Windows.Forms.TextBox();
            this.PixBoxTrial = new System.Windows.Forms.PictureBox();
            this.txtBoxPitch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RotatingImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBoxTrial)).BeginInit();
            this.SuspendLayout();
            // 
            // RotatingImg
            // 
            this.RotatingImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RotatingImg.Image = ((System.Drawing.Image)(resources.GetObject("RotatingImg.Image")));
            this.RotatingImg.Location = new System.Drawing.Point(213, 273);
            this.RotatingImg.Name = "RotatingImg";
            this.RotatingImg.Size = new System.Drawing.Size(100, 93);
            this.RotatingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RotatingImg.TabIndex = 0;
            this.RotatingImg.TabStop = false;
            // 
            // txtBoxRoll
            // 
            this.txtBoxRoll.Location = new System.Drawing.Point(213, 372);
            this.txtBoxRoll.Name = "txtBoxRoll";
            this.txtBoxRoll.Size = new System.Drawing.Size(100, 23);
            this.txtBoxRoll.TabIndex = 1;
            this.txtBoxRoll.TextChanged += new System.EventHandler(this.txtBoxRoll_TextChanged);
            // 
            // PixBoxTrial
            // 
            this.PixBoxTrial.Image = ((System.Drawing.Image)(resources.GetObject("PixBoxTrial.Image")));
            this.PixBoxTrial.Location = new System.Drawing.Point(213, 135);
            this.PixBoxTrial.Name = "PixBoxTrial";
            this.PixBoxTrial.Size = new System.Drawing.Size(100, 96);
            this.PixBoxTrial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PixBoxTrial.TabIndex = 2;
            this.PixBoxTrial.TabStop = false;
            // 
            // txtBoxPitch
            // 
            this.txtBoxPitch.Location = new System.Drawing.Point(335, 371);
            this.txtBoxPitch.Name = "txtBoxPitch";
            this.txtBoxPitch.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPitch.TabIndex = 3;
            this.txtBoxPitch.TextChanged += new System.EventHandler(this.txtBoxPitch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.txtBoxPitch);
            this.Controls.Add(this.PixBoxTrial);
            this.Controls.Add(this.txtBoxRoll);
            this.Controls.Add(this.RotatingImg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RotatingImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBoxTrial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RotatingImg;
        private System.Windows.Forms.TextBox txtBoxRoll;
        private System.Windows.Forms.PictureBox PixBoxTrial;
        private System.Windows.Forms.TextBox txtBoxPitch;
    }
}

