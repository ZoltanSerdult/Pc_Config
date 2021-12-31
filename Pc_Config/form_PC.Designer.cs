
namespace Pc_Config
{
    partial class form_PC
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
            this.checkBox_Gamer = new System.Windows.Forms.CheckBox();
            this.textBox_Tulaj = new System.Windows.Forms.TextBox();
            this.comboBox_OS = new System.Windows.Forms.ComboBox();
            this.textBox_ConfigNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_Gamer
            // 
            this.checkBox_Gamer.AutoSize = true;
            this.checkBox_Gamer.Location = new System.Drawing.Point(161, 156);
            this.checkBox_Gamer.Name = "checkBox_Gamer";
            this.checkBox_Gamer.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Gamer.TabIndex = 15;
            this.checkBox_Gamer.UseVisualStyleBackColor = true;
            // 
            // textBox_Tulaj
            // 
            this.textBox_Tulaj.Location = new System.Drawing.Point(161, 123);
            this.textBox_Tulaj.Name = "textBox_Tulaj";
            this.textBox_Tulaj.Size = new System.Drawing.Size(193, 20);
            this.textBox_Tulaj.TabIndex = 14;
            // 
            // comboBox_OS
            // 
            this.comboBox_OS.FormattingEnabled = true;
            this.comboBox_OS.Location = new System.Drawing.Point(161, 93);
            this.comboBox_OS.Name = "comboBox_OS";
            this.comboBox_OS.Size = new System.Drawing.Size(121, 21);
            this.comboBox_OS.TabIndex = 13;
            // 
            // textBox_ConfigNev
            // 
            this.textBox_ConfigNev.Location = new System.Drawing.Point(161, 63);
            this.textBox_ConfigNev.Name = "textBox_ConfigNev";
            this.textBox_ConfigNev.Size = new System.Drawing.Size(193, 20);
            this.textBox_ConfigNev.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gamer gép-e?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tulajdonos neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operációs rendszere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Konfiguráció neve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(48, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Számitógép Felvétel";
            // 
            // form_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_Gamer);
            this.Controls.Add(this.textBox_Tulaj);
            this.Controls.Add(this.comboBox_OS);
            this.Controls.Add(this.textBox_ConfigNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_PC";
            this.Text = "form_PC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Gamer;
        private System.Windows.Forms.TextBox textBox_Tulaj;
        private System.Windows.Forms.ComboBox comboBox_OS;
        private System.Windows.Forms.TextBox textBox_ConfigNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}