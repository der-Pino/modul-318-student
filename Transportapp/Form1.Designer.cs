
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VerbindungssucheTab = new System.Windows.Forms.GroupBox();
            this.Zielortvorschlag = new System.Windows.Forms.ListBox();
            this.Abfahrtvorschlag = new System.Windows.Forms.ListBox();
            this.SucheTausch = new System.Windows.Forms.Button();
            this.SucheClear = new System.Windows.Forms.Button();
            this.VerbindungsListe = new System.Windows.Forms.DataGridView();
            this.VonSpalte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtSpalte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BisSpalte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnkunftSpalte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suchen = new System.Windows.Forms.Button();
            this.ZielSuche = new System.Windows.Forms.TextBox();
            this.AbfahrtSuche = new System.Windows.Forms.TextBox();
            this.ansichtswitch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AbfahrtenTab = new System.Windows.Forms.GroupBox();
            this.Stationsvorschlage = new System.Windows.Forms.ListBox();
            this.StationSuchen = new System.Windows.Forms.Button();
            this.StationClear = new System.Windows.Forms.Button();
            this.Abfahrtstafel = new System.Windows.Forms.DataGridView();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnkunftsZiel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationsSuche = new System.Windows.Forms.TextBox();
            this.VerbindungssucheTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungsListe)).BeginInit();
            this.ansichtswitch.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.AbfahrtenTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // VerbindungssucheTab
            // 
            this.VerbindungssucheTab.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.VerbindungssucheTab.Controls.Add(this.Zielortvorschlag);
            this.VerbindungssucheTab.Controls.Add(this.Abfahrtvorschlag);
            this.VerbindungssucheTab.Controls.Add(this.SucheTausch);
            this.VerbindungssucheTab.Controls.Add(this.SucheClear);
            this.VerbindungssucheTab.Controls.Add(this.VerbindungsListe);
            this.VerbindungssucheTab.Controls.Add(this.Suchen);
            this.VerbindungssucheTab.Controls.Add(this.ZielSuche);
            this.VerbindungssucheTab.Controls.Add(this.AbfahrtSuche);
            this.VerbindungssucheTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerbindungssucheTab.Location = new System.Drawing.Point(6, 6);
            this.VerbindungssucheTab.Name = "VerbindungssucheTab";
            this.VerbindungssucheTab.Size = new System.Drawing.Size(635, 641);
            this.VerbindungssucheTab.TabIndex = 0;
            this.VerbindungssucheTab.TabStop = false;
            this.VerbindungssucheTab.Text = "Verbindungen Suchen";
            // 
            // Zielortvorschlag
            // 
            this.Zielortvorschlag.FormattingEnabled = true;
            this.Zielortvorschlag.ItemHeight = 22;
            this.Zielortvorschlag.Location = new System.Drawing.Point(291, 82);
            this.Zielortvorschlag.Name = "Zielortvorschlag";
            this.Zielortvorschlag.Size = new System.Drawing.Size(219, 70);
            this.Zielortvorschlag.TabIndex = 8;
            this.Zielortvorschlag.SelectedIndexChanged += new System.EventHandler(this.Zielortvorschlag_SelectedIndexChanged);
            // 
            // Abfahrtvorschlag
            // 
            this.Abfahrtvorschlag.FormattingEnabled = true;
            this.Abfahrtvorschlag.ItemHeight = 22;
            this.Abfahrtvorschlag.Location = new System.Drawing.Point(23, 82);
            this.Abfahrtvorschlag.Name = "Abfahrtvorschlag";
            this.Abfahrtvorschlag.Size = new System.Drawing.Size(219, 70);
            this.Abfahrtvorschlag.TabIndex = 7;
            this.Abfahrtvorschlag.SelectedIndexChanged += new System.EventHandler(this.Abfahrtvorschlag_SelectedIndexChanged);
            // 
            // SucheTausch
            // 
            this.SucheTausch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SucheTausch.Location = new System.Drawing.Point(248, 52);
            this.SucheTausch.Name = "SucheTausch";
            this.SucheTausch.Size = new System.Drawing.Size(37, 24);
            this.SucheTausch.TabIndex = 6;
            this.SucheTausch.Text = "⇄";
            this.SucheTausch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SucheTausch.UseVisualStyleBackColor = true;
            this.SucheTausch.Click += new System.EventHandler(this.SucheTausch_Click);
            // 
            // SucheClear
            // 
            this.SucheClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SucheClear.Location = new System.Drawing.Point(526, 52);
            this.SucheClear.Name = "SucheClear";
            this.SucheClear.Size = new System.Drawing.Size(30, 24);
            this.SucheClear.TabIndex = 5;
            this.SucheClear.Text = "⨯";
            this.SucheClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SucheClear.UseVisualStyleBackColor = true;
            this.SucheClear.Click += new System.EventHandler(this.SucheClear_Click);
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
            this.VerbindungsListe.RowHeadersVisible = false;
            this.VerbindungsListe.RowHeadersWidth = 51;
            this.VerbindungsListe.RowTemplate.Height = 24;
            this.VerbindungsListe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VerbindungsListe.Size = new System.Drawing.Size(588, 411);
            this.VerbindungsListe.TabIndex = 4;
            // 
            // VonSpalte
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VonSpalte.DefaultCellStyle = dataGridViewCellStyle5;
            this.VonSpalte.HeaderText = "Von";
            this.VonSpalte.MinimumWidth = 6;
            this.VonSpalte.Name = "VonSpalte";
            this.VonSpalte.ReadOnly = true;
            // 
            // AbfahrtSpalte
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbfahrtSpalte.DefaultCellStyle = dataGridViewCellStyle6;
            this.AbfahrtSpalte.HeaderText = "Abfahrt";
            this.AbfahrtSpalte.MinimumWidth = 6;
            this.AbfahrtSpalte.Name = "AbfahrtSpalte";
            this.AbfahrtSpalte.ReadOnly = true;
            // 
            // BisSpalte
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BisSpalte.DefaultCellStyle = dataGridViewCellStyle7;
            this.BisSpalte.HeaderText = "Bis";
            this.BisSpalte.MinimumWidth = 6;
            this.BisSpalte.Name = "BisSpalte";
            this.BisSpalte.ReadOnly = true;
            // 
            // AnkunftSpalte
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnkunftSpalte.DefaultCellStyle = dataGridViewCellStyle8;
            this.AnkunftSpalte.HeaderText = "Ankunft";
            this.AnkunftSpalte.MinimumWidth = 6;
            this.AnkunftSpalte.Name = "AnkunftSpalte";
            this.AnkunftSpalte.ReadOnly = true;
            // 
            // Suchen
            // 
            this.Suchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suchen.Location = new System.Drawing.Point(23, 167);
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
            this.ZielSuche.Location = new System.Drawing.Point(291, 52);
            this.ZielSuche.Name = "ZielSuche";
            this.ZielSuche.Size = new System.Drawing.Size(219, 24);
            this.ZielSuche.TabIndex = 1;
            this.ZielSuche.Text = "Zielort";
            this.ZielSuche.TextChanged += new System.EventHandler(this.ZielSuche_TextChanged);
            // 
            // AbfahrtSuche
            // 
            this.AbfahrtSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbfahrtSuche.Location = new System.Drawing.Point(23, 52);
            this.AbfahrtSuche.Name = "AbfahrtSuche";
            this.AbfahrtSuche.Size = new System.Drawing.Size(219, 24);
            this.AbfahrtSuche.TabIndex = 0;
            this.AbfahrtSuche.Text = "Abfahrtsort";
            this.AbfahrtSuche.TextChanged += new System.EventHandler(this.AbfahrtSuche_TextChanged);
            // 
            // ansichtswitch
            // 
            this.ansichtswitch.Controls.Add(this.tabPage1);
            this.ansichtswitch.Controls.Add(this.tabPage2);
            this.ansichtswitch.Location = new System.Drawing.Point(12, 12);
            this.ansichtswitch.Name = "ansichtswitch";
            this.ansichtswitch.SelectedIndex = 0;
            this.ansichtswitch.Size = new System.Drawing.Size(656, 686);
            this.ansichtswitch.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.VerbindungssucheTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungssuche";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AbfahrtenTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AbfahrtenTab
            // 
            this.AbfahrtenTab.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AbfahrtenTab.Controls.Add(this.Stationsvorschlage);
            this.AbfahrtenTab.Controls.Add(this.StationSuchen);
            this.AbfahrtenTab.Controls.Add(this.StationClear);
            this.AbfahrtenTab.Controls.Add(this.Abfahrtstafel);
            this.AbfahrtenTab.Controls.Add(this.StationsSuche);
            this.AbfahrtenTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbfahrtenTab.Location = new System.Drawing.Point(8, 8);
            this.AbfahrtenTab.Name = "AbfahrtenTab";
            this.AbfahrtenTab.Size = new System.Drawing.Size(635, 641);
            this.AbfahrtenTab.TabIndex = 7;
            this.AbfahrtenTab.TabStop = false;
            this.AbfahrtenTab.Text = "Abfahrten";
            // 
            // Stationsvorschlage
            // 
            this.Stationsvorschlage.FormattingEnabled = true;
            this.Stationsvorschlage.ItemHeight = 22;
            this.Stationsvorschlage.Location = new System.Drawing.Point(172, 92);
            this.Stationsvorschlage.Name = "Stationsvorschlage";
            this.Stationsvorschlage.Size = new System.Drawing.Size(255, 48);
            this.Stationsvorschlage.TabIndex = 8;
            this.Stationsvorschlage.SelectedIndexChanged += new System.EventHandler(this.Stationsvorschlage_SelectedIndexChanged);
            // 
            // StationSuchen
            // 
            this.StationSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationSuchen.Location = new System.Drawing.Point(172, 146);
            this.StationSuchen.Name = "StationSuchen";
            this.StationSuchen.Size = new System.Drawing.Size(255, 25);
            this.StationSuchen.TabIndex = 7;
            this.StationSuchen.Text = "Suchen 🔎";
            this.StationSuchen.UseVisualStyleBackColor = true;
            this.StationSuchen.Click += new System.EventHandler(this.StationSuchen_Click);
            // 
            // StationClear
            // 
            this.StationClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationClear.Location = new System.Drawing.Point(441, 63);
            this.StationClear.Name = "StationClear";
            this.StationClear.Size = new System.Drawing.Size(27, 22);
            this.StationClear.TabIndex = 6;
            this.StationClear.Text = "⨯";
            this.StationClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StationClear.UseVisualStyleBackColor = true;
            this.StationClear.Click += new System.EventHandler(this.StationClear_Click);
            // 
            // Abfahrtstafel
            // 
            this.Abfahrtstafel.AllowUserToAddRows = false;
            this.Abfahrtstafel.AllowUserToDeleteRows = false;
            this.Abfahrtstafel.AllowUserToOrderColumns = true;
            this.Abfahrtstafel.AllowUserToResizeColumns = false;
            this.Abfahrtstafel.AllowUserToResizeRows = false;
            this.Abfahrtstafel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Abfahrtstafel.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Abfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Abfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtszeit,
            this.AnkunftsZiel});
            this.Abfahrtstafel.Location = new System.Drawing.Point(18, 214);
            this.Abfahrtstafel.MultiSelect = false;
            this.Abfahrtstafel.Name = "Abfahrtstafel";
            this.Abfahrtstafel.ReadOnly = true;
            this.Abfahrtstafel.RowHeadersVisible = false;
            this.Abfahrtstafel.RowHeadersWidth = 51;
            this.Abfahrtstafel.RowTemplate.Height = 24;
            this.Abfahrtstafel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Abfahrtstafel.Size = new System.Drawing.Size(588, 411);
            this.Abfahrtstafel.TabIndex = 5;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrt";
            this.Abfahrtszeit.MinimumWidth = 6;
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.ReadOnly = true;
            // 
            // AnkunftsZiel
            // 
            this.AnkunftsZiel.HeaderText = "Ziel";
            this.AnkunftsZiel.MinimumWidth = 6;
            this.AnkunftsZiel.Name = "AnkunftsZiel";
            this.AnkunftsZiel.ReadOnly = true;
            // 
            // StationsSuche
            // 
            this.StationsSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationsSuche.Location = new System.Drawing.Point(172, 62);
            this.StationsSuche.Name = "StationsSuche";
            this.StationsSuche.Size = new System.Drawing.Size(255, 24);
            this.StationsSuche.TabIndex = 0;
            this.StationsSuche.Text = "Station";
            this.StationsSuche.TextChanged += new System.EventHandler(this.StationsSuche_TextChanged);
            // 
            // Programmfenster
            // 
            this.AcceptButton = this.Suchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1101, 710);
            this.Controls.Add(this.ansichtswitch);
            this.Name = "Programmfenster";
            this.Text = "MyTransport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VerbindungssucheTab.ResumeLayout(false);
            this.VerbindungssucheTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungsListe)).EndInit();
            this.ansichtswitch.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.AbfahrtenTab.ResumeLayout(false);
            this.AbfahrtenTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abfahrtstafel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VerbindungssucheTab;
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
        private System.Windows.Forms.TabControl ansichtswitch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox AbfahrtenTab;
        private System.Windows.Forms.DataGridView Abfahrtstafel;
        private System.Windows.Forms.TextBox StationsSuche;
        private System.Windows.Forms.Button StationClear;
        private System.Windows.Forms.Button StationSuchen;
        private System.Windows.Forms.ListBox Stationsvorschlage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnkunftsZiel;
        private System.Windows.Forms.ListBox Zielortvorschlag;
        private System.Windows.Forms.ListBox Abfahrtvorschlag;
    }
}

