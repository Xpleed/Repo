namespace Keprendezo
{
    partial class Keprendezo
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
            this.buttonForras = new System.Windows.Forms.Button();
            this.buttonCel = new System.Windows.Forms.Button();
            this.buttonRendezes = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxForras = new System.Windows.Forms.TextBox();
            this.textBoxCel = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // buttonForras
            // 
            this.buttonForras.Location = new System.Drawing.Point(100, 241);
            this.buttonForras.Name = "buttonForras";
            this.buttonForras.Size = new System.Drawing.Size(75, 23);
            this.buttonForras.TabIndex = 0;
            this.buttonForras.Text = "Forrás";
            this.buttonForras.UseVisualStyleBackColor = true;
            this.buttonForras.Click += new System.EventHandler(this.buttonForras_Click);
            // 
            // buttonCel
            // 
            this.buttonCel.Location = new System.Drawing.Point(182, 240);
            this.buttonCel.Name = "buttonCel";
            this.buttonCel.Size = new System.Drawing.Size(75, 23);
            this.buttonCel.TabIndex = 1;
            this.buttonCel.Text = "Cél";
            this.buttonCel.UseVisualStyleBackColor = true;
            this.buttonCel.Click += new System.EventHandler(this.buttonCel_Click);
            // 
            // buttonRendezes
            // 
            this.buttonRendezes.Location = new System.Drawing.Point(264, 240);
            this.buttonRendezes.Name = "buttonRendezes";
            this.buttonRendezes.Size = new System.Drawing.Size(75, 23);
            this.buttonRendezes.TabIndex = 2;
            this.buttonRendezes.Text = "Rendezés";
            this.buttonRendezes.UseVisualStyleBackColor = true;
            this.buttonRendezes.Click += new System.EventHandler(this.buttonRendezes_Click);
            // 
            // textBoxForras
            // 
            this.textBoxForras.Location = new System.Drawing.Point(100, 112);
            this.textBoxForras.Name = "textBoxForras";
            this.textBoxForras.ReadOnly = true;
            this.textBoxForras.Size = new System.Drawing.Size(239, 20);
            this.textBoxForras.TabIndex = 3;
            // 
            // textBoxCel
            // 
            this.textBoxCel.Location = new System.Drawing.Point(100, 138);
            this.textBoxCel.Name = "textBoxCel";
            this.textBoxCel.ReadOnly = true;
            this.textBoxCel.Size = new System.Drawing.Size(239, 20);
            this.textBoxCel.TabIndex = 4;
            // 
            // Keprendezo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCel);
            this.Controls.Add(this.textBoxForras);
            this.Controls.Add(this.buttonRendezes);
            this.Controls.Add(this.buttonCel);
            this.Controls.Add(this.buttonForras);
            this.Name = "Keprendezo";
            this.Text = "Keprendezo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForras;
        private System.Windows.Forms.Button buttonCel;
        private System.Windows.Forms.Button buttonRendezes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxForras;
        private System.Windows.Forms.TextBox textBoxCel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}