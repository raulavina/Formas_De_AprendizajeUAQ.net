namespace Trabajo3
{
    partial class PantallaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnacerca = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnIntro = new System.Windows.Forms.Button();
            this.duelStateButton = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hypertech";
            // 
            // btnacerca
            // 
            this.btnacerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacerca.Location = new System.Drawing.Point(397, 161);
            this.btnacerca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnacerca.Name = "btnacerca";
            this.btnacerca.Size = new System.Drawing.Size(100, 36);
            this.btnacerca.TabIndex = 2;
            this.btnacerca.Text = "Acerca de";
            this.btnacerca.UseVisualStyleBackColor = true;
            this.btnacerca.Click += new System.EventHandler(this.btnacerca_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(397, 96);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 46);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test Enfoque";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnIntro
            // 
            this.btnIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.Location = new System.Drawing.Point(397, 45);
            this.btnIntro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(100, 36);
            this.btnIntro.TabIndex = 4;
            this.btnIntro.Text = "Introducción";
            this.btnIntro.UseVisualStyleBackColor = true;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // duelStateButton
            // 
            this.duelStateButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.duelStateButton.Location = new System.Drawing.Point(272, 279);
            this.duelStateButton.Name = "duelStateButton";
            this.duelStateButton.Size = new System.Drawing.Size(46, 29);
            this.duelStateButton.TabIndex = 17;
            this.duelStateButton.Text = "Play";
            this.duelStateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.duelStateButton.UseVisualStyleBackColor = true;
            this.duelStateButton.CheckedChanged += new System.EventHandler(this.duelStateButton_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(502, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 29);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Play";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Location = new System.Drawing.Point(502, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 29);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Play";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Location = new System.Drawing.Point(502, 165);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(46, 29);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Play";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(577, 320);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.duelStateButton);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnacerca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaInicial";
            this.Text = "Hypertech";
            this.Load += new System.EventHandler(this.PantallaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnacerca;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.CheckBox duelStateButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}