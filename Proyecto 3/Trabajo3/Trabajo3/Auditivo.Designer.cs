namespace Trabajo3
{
    partial class Auditivo
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 75);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(452, 208);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "Es usted es una persona Estructurada\n\nLe gusta manejar sus propios tiempo y tener" +
    " una agenda para manejar sus dias, sino hace esto se siente desorganizado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estructurada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.Location = new System.Drawing.Point(294, 289);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(46, 29);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "Play";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(345, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 29);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Play";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Auditivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 330);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Auditivo";
            this.Text = "Estructurada";
            this.Load += new System.EventHandler(this.Auditivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}