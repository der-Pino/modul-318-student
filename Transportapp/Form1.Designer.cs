
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Verbindungssuche = new System.Windows.Forms.GroupBox();
            this.VerbindungsListe = new System.Windows.Forms.DataGridView();
            this.VonSpalte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtSpalte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BisSpalte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnkunftSpalte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suchen = new System.Windows.Forms.Button();
            this.ZielSuche = new System.Windows.Forms.TextBox();
            this.AbfahrtSuche = new System.Windows.Forms.TextBox();
            this.SucheClear = new System.Windows.Forms.Button();
            this.SucheTausch = new System.Windows.Forms.Button();
            this.Verbindungssuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungsListe)).BeginInit();
            this.SuspendLayout();
            // 
            // Verbindungssuche
            // 
            this.Verbindungssuche.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Verbindungssuche.Controls.Add(this.SucheTausch);
            this.Verbindungssuche.Controls.Add(this.SucheClear);
            this.Verbindungssuche.Controls.Add(this.VerbindungsListe);
            this.Verbindungssuche.Controls.Add(this.Suchen);
            this.Verbindungssuche.Controls.Add(this.ZielSuche);
            this.Verbindungssuche.Controls.Add(this.AbfahrtSuche);
            this.Verbindungssuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verbindungssuche.Location = new System.Drawing.Point(36, 33);
            this.Verbindungssuche.Name = "Verbindungssuche";
            this.Verbindungssuche.Size = new System.Drawing.Size(648, 641);
            this.Verbindungssuche.TabIndex = 0;
            this.Verbindungssuche.TabStop = false;
            this.Verbindungssuche.Text = "Verbindungssuche";
            // 
            // VerbindungsListe
            // 
            this.VerbindungsListe.AllowUserToAddRows = false;
            this.VerbindungsListe.AllowUserToDeleteRows = false;
            this.VerbindungsListe.AllowUserToResizeColumns = false;
            this.VerbindungsListe.AllowUserToResizeRows = false;
            this.VerbindungsListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VerbindungsListe.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VerbindungsListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbindungsListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VonSpalte,
            this.AbfahrtSpalte,
            this.BisSpalte,
            this.AnkunftSpalte});
            this.VerbindungsListe.Location = new System.Drawing.Point(23, 198);
            this.VerbindungsListe.MultiSelect = false;
            this.VerbindungsListe.Name = "VerbindungsListe";
            this.VerbindungsListe.ReadOnly = true;
            this.VerbindungsListe.RowHeadersWidth = 51;
            this.VerbindungsListe.RowTemplate.Height = 24;
            this.VerbindungsListe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VerbindungsListe.Size = new System.Drawing.Size(588, 411);
            this.VerbindungsListe.TabIndex = 4;
            // 
            // VonSpalte
            // 
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VonSpalte.DefaultCellStyle = dataGridViewCellStyle33;
            this.VonSpalte.HeaderText = "Von";
            this.VonSpalte.MinimumWidth = 6;
            this.VonSpalte.Name = "VonSpalte";
            this.VonSpalte.ReadOnly = true;
            // 
            // AbfahrtSpalte
            // 
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbfahrtSpalte.DefaultCellStyle = dataGridViewCellStyle34;
            this.AbfahrtSpalte.HeaderText = "Abfahrt";
            this.AbfahrtSpalte.MinimumWidth = 6;
            this.AbfahrtSpalte.Name = "AbfahrtSpalte";
            this.AbfahrtSpalte.ReadOnly = true;
            // 
            // BisSpalte
            // 
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BisSpalte.DefaultCellStyle = dataGridViewCellStyle35;
            this.BisSpalte.HeaderText = "Bis";
            this.BisSpalte.MinimumWidth = 6;
            this.BisSpalte.Name = "BisSpalte";
            this.BisSpalte.ReadOnly = true;
            // 
            // AnkunftSpalte
            // 
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnkunftSpalte.DefaultCellStyle = dataGridViewCellStyle36;
            this.AnkunftSpalte.HeaderText = "Ankunft";
            this.AnkunftSpalte.MinimumWidth = 6;
            this.AnkunftSpalte.Name = "AnkunftSpalte";
            this.AnkunftSpalte.ReadOnly = true;
            // 
            // Suchen
            // 
            this.Suchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suchen.Location = new System.Drawing.Point(23, 128);
            this.Suchen.Name = "Suchen";
            this.Suchen.Size = new System.Drawing.Size(140, 25);
            this.Suchen.TabIndex = 3;
            this.Suchen.Text = "Suchen 🔎";
            this.Suchen.UseVisualStyleBackColor = true;
            this.Suchen.Click += new System.EventHandler(this.Suchen_Click);
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
            // AbfahrtSuche
            // 
            this.AbfahrtSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbfahrtSuche.Location = new System.Drawing.Point(23, 52);
            this.AbfahrtSuche.Name = "AbfahrtSuche";
            this.AbfahrtSuche.Size = new System.Drawing.Size(219, 24);
            this.AbfahrtSuche.TabIndex = 0;
            this.AbfahrtSuche.Text = "Abfahrtsort";
            // 
            // SucheClear
            // 
            this.SucheClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SucheClear.Location = new System.Drawing.Point(169, 128);
            this.SucheClear.Name = "SucheClear";
            this.SucheClear.Size = new System.Drawing.Size(73, 25);
            this.SucheClear.TabIndex = 5;
            this.SucheClear.Text = "⨯";
            this.SucheClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SucheClear.UseVisualStyleBackColor = true;
            this.SucheClear.Click += new System.EventHandler(this.SucheClear_Click);
            // 
            // SucheTausch
            // 
            this.SucheTausch.Location = new System.Drawing.Point(248, 52);
            this.SucheTausch.Name = "SucheTausch";
            this.SucheTausch.Size = new System.Drawing.Size(25, 70);
            this.SucheTausch.TabIndex = 6;
            this.SucheTausch.Text = "↕";
            this.SucheTausch.UseVisualStyleBackColor = true;
            this.SucheTausch.Click += new System.EventHandler(this.SucheTausch_Click);
            // 
            // Programmfenster
            // 
            this.AcceptButton = this.Suchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 710);
            this.Controls.Add(this.Verbindungssuche);
            this.Name = "Programmfenster";
            this.Text = "MyTransport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Verbindungssuche.ResumeLayout(false);
            this.Verbindungssuche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungsListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Verbindungssuche;
        private System.Windows.Forms.TextBox AbfahrtSuche;
        private System.Windows.Forms.TextBox ZielSuche;
        private System.Windows.Forms.Button Suchen;
        private System.Windows.Forms.DataGridView VerbindungsListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VonSpalte;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbfahrtSpalte;
        private System.Windows.Forms.DataGridViewTextBoxColumn BisSpalte;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnkunftSpalte;
        private System.Windows.Forms.Button SucheClear;
        private System.Windows.Forms.Button SucheTausch;
    }
}

