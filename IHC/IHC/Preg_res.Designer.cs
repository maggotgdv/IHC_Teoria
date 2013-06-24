namespace IHC
{
    partial class Preg_res
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
            this.pregunta = new System.Windows.Forms.Label();
            this.RDrespuesta2 = new System.Windows.Forms.RadioButton();
            this.RDrespuesta1 = new System.Windows.Forms.RadioButton();
            this.RDrespuesta3 = new System.Windows.Forms.RadioButton();
            this.RDrespuesta4 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta.ForeColor = System.Drawing.Color.White;
            this.pregunta.Location = new System.Drawing.Point(71, 71);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(52, 21);
            this.pregunta.TabIndex = 0;
            this.pregunta.Text = "label1";
            // 
            // RDrespuesta2
            // 
            this.RDrespuesta2.AutoSize = true;
            this.RDrespuesta2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDrespuesta2.Location = new System.Drawing.Point(75, 170);
            this.RDrespuesta2.Name = "RDrespuesta2";
            this.RDrespuesta2.Size = new System.Drawing.Size(119, 25);
            this.RDrespuesta2.TabIndex = 1;
            this.RDrespuesta2.TabStop = true;
            this.RDrespuesta2.Text = "radioButton1";
            this.RDrespuesta2.UseVisualStyleBackColor = true;
            this.RDrespuesta2.CheckedChanged += new System.EventHandler(this.RDrespuesta2_CheckedChanged_1);
            // 
            // RDrespuesta1
            // 
            this.RDrespuesta1.AutoSize = true;
            this.RDrespuesta1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDrespuesta1.Location = new System.Drawing.Point(75, 136);
            this.RDrespuesta1.Name = "RDrespuesta1";
            this.RDrespuesta1.Size = new System.Drawing.Size(119, 25);
            this.RDrespuesta1.TabIndex = 2;
            this.RDrespuesta1.TabStop = true;
            this.RDrespuesta1.Text = "radioButton2";
            this.RDrespuesta1.UseVisualStyleBackColor = true;
            this.RDrespuesta1.CheckedChanged += new System.EventHandler(this.RDrespuesta2_CheckedChanged);
            // 
            // RDrespuesta3
            // 
            this.RDrespuesta3.AutoSize = true;
            this.RDrespuesta3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDrespuesta3.Location = new System.Drawing.Point(75, 205);
            this.RDrespuesta3.Name = "RDrespuesta3";
            this.RDrespuesta3.Size = new System.Drawing.Size(119, 25);
            this.RDrespuesta3.TabIndex = 3;
            this.RDrespuesta3.TabStop = true;
            this.RDrespuesta3.Text = "radioButton3";
            this.RDrespuesta3.UseVisualStyleBackColor = true;
            this.RDrespuesta3.CheckedChanged += new System.EventHandler(this.RDrespuesta3_CheckedChanged);
            // 
            // RDrespuesta4
            // 
            this.RDrespuesta4.AutoSize = true;
            this.RDrespuesta4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDrespuesta4.Location = new System.Drawing.Point(75, 238);
            this.RDrespuesta4.Name = "RDrespuesta4";
            this.RDrespuesta4.Size = new System.Drawing.Size(119, 25);
            this.RDrespuesta4.TabIndex = 4;
            this.RDrespuesta4.TabStop = true;
            this.RDrespuesta4.Text = "radioButton4";
            this.RDrespuesta4.UseVisualStyleBackColor = true;
            this.RDrespuesta4.CheckedChanged += new System.EventHandler(this.RDrespuesta4_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(289, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Siguiente Pregunta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pregunta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pregunta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 115);
            this.panel1.TabIndex = 8;
            // 
            // Preg_res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RDrespuesta4);
            this.Controls.Add(this.RDrespuesta3);
            this.Controls.Add(this.RDrespuesta1);
            this.Controls.Add(this.RDrespuesta2);
            this.Name = "Preg_res";
            this.Text = "Preg_res";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.RadioButton RDrespuesta2;
        private System.Windows.Forms.RadioButton RDrespuesta1;
        private System.Windows.Forms.RadioButton RDrespuesta3;
        private System.Windows.Forms.RadioButton RDrespuesta4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}