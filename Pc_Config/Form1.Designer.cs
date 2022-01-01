
namespace Pc_Config
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
            this.listBox_Mutat = new System.Windows.Forms.ListBox();
            this.button_Pcfevetel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Mutat
            // 
            this.listBox_Mutat.FormattingEnabled = true;
            this.listBox_Mutat.Location = new System.Drawing.Point(23, 88);
            this.listBox_Mutat.Name = "listBox_Mutat";
            this.listBox_Mutat.Size = new System.Drawing.Size(610, 277);
            this.listBox_Mutat.TabIndex = 8;
            // 
            // button_Pcfevetel
            // 
            this.button_Pcfevetel.Location = new System.Drawing.Point(23, 13);
            this.button_Pcfevetel.Name = "button_Pcfevetel";
            this.button_Pcfevetel.Size = new System.Drawing.Size(167, 37);
            this.button_Pcfevetel.TabIndex = 9;
            this.button_Pcfevetel.Text = "Számitógép felvétel";
            this.button_Pcfevetel.UseVisualStyleBackColor = true;
            this.button_Pcfevetel.Click += new System.EventHandler(this.button_Pcfevetel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 397);
            this.Controls.Add(this.button_Pcfevetel);
            this.Controls.Add(this.listBox_Mutat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Pcfevetel;
        public System.Windows.Forms.ListBox listBox_Mutat;
    }
}

