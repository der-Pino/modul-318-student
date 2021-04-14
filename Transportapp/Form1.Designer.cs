
namespace Transportapp
{
    partial class Programmfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Verbindungssuche = new System.Windows.Forms.GroupBox();
            this.AbfahrtSuche = new System.Windows.Forms.TextBox();
            this.ZielSuche = new System.Windows.Forms.TextBox();
            this.Suchen = new System.Windows.Forms.Button();
            this.testbox = new System.Windows.Forms.TextBox();
            this.Verbindungssuche.SuspendLayout();
            this.SuspendLayout();
            // 
            // Verbindungssuche
            // 
            this.Verbindungssuche.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Verbindungssuche.Controls.Add(this.testbox);
            this.Verbindungssuche.Controls.Add(this.Suchen);
            this.Verbindungssuche.Controls.Add(this.ZielSuche);
            this.Verbindungssuche.Controls.Add(this.AbfahrtSuche);
            this.Verbindungssuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verbindungssuche.Location = new System.Drawing.Point(36, 33);
            this.Verbindungssuche.Name = "Verbindungssuche";
            this.Verbindungssuche.Size = new System.Drawing.Size(472, 641);
            this.Verbindungssuche.TabIndex = 0;
            this.Verbindungssuche.TabStop = false;
            this.Verbindungssuche.Text = "Verbindungssuche";
            // 
            // AbfahrtSuche
            // 
            this.AbfahrtSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbfahrtSuche.Location = new System.Drawing.Point(23, 52);
            this.AbfahrtSuche.Name = "AbfahrtSuche";
            this.AbfahrtSuche.Size = new System.Drawing.Size(219, 24);
            this.AbfahrtSuche.TabIndex = 0;
            this.AbfahrtSuche.Text = "Abfahrtsort";
            // 
            // ZielSuche
            // 
            this.ZielSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZielSuche.Location = new System.Drawing.Point(23, 98);
            this.ZielSuche.Name = "ZielSuche";
            this.ZielSuche.Size = new System.Drawing.Size(219, 24);
            this.ZielSuche.TabIndex = 1;
            this.ZielSuche.Text = "Zielort";
            // 
            // Suchen
            // 
            this.Suchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suchen.Location = new System.Drawing.Point(23, 128);
            this.Suchen.Name = "Suchen";
            this.Suchen.Size = new System.Drawing.Size(140, 25);
            this.Suchen.TabIndex = 3;
            this.Suchen.Text = "Suchen 🔎";
            this.Suchen.UseVisualStyleBackColor = true;
            this.Suchen.Click += new System.EventHandler(this.Suchen_Click);
            // 
            // testbox
            // 
            this.testbox.Location = new System.Drawing.Point(75, 257);
            this.testbox.Multiline = true;
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(364, 228);
            this.testbox.TabIndex = 4;
            // 
            // Programmfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1436, 710);
            this.Controls.Add(this.Verbindungssuche);
            this.Name = "Programmfenster";
            this.Text = "MyTransport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Verbindungssuche.ResumeLayout(false);
            this.Verbindungssuche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Verbindungssuche;
        private System.Windows.Forms.TextBox AbfahrtSuche;
        private System.Windows.Forms.TextBox ZielSuche;
        private System.Windows.Forms.Button Suchen;
        private System.Windows.Forms.TextBox testbox;
    }
}

