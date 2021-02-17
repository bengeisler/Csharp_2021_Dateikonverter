
namespace Csharp_2021_Dateikonverter
{
	partial class frmKonverter
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
			this.btnLesen = new System.Windows.Forms.Button();
			this.btnSchreiben = new System.Windows.Forms.Button();
			this.lstWerte = new System.Windows.Forms.ListBox();
			this.lstFehler = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnLesen
			// 
			this.btnLesen.Location = new System.Drawing.Point(44, 12);
			this.btnLesen.Name = "btnLesen";
			this.btnLesen.Size = new System.Drawing.Size(75, 23);
			this.btnLesen.TabIndex = 0;
			this.btnLesen.Text = "Lesen";
			this.btnLesen.UseVisualStyleBackColor = true;
			this.btnLesen.Click += new System.EventHandler(this.btnLesen_Click);
			// 
			// btnSchreiben
			// 
			this.btnSchreiben.Location = new System.Drawing.Point(216, 12);
			this.btnSchreiben.Name = "btnSchreiben";
			this.btnSchreiben.Size = new System.Drawing.Size(75, 23);
			this.btnSchreiben.TabIndex = 1;
			this.btnSchreiben.Text = "Schreiben";
			this.btnSchreiben.UseVisualStyleBackColor = true;
			this.btnSchreiben.Click += new System.EventHandler(this.btnSchreiben_Click);
			// 
			// lstWerte
			// 
			this.lstWerte.FormattingEnabled = true;
			this.lstWerte.Location = new System.Drawing.Point(12, 41);
			this.lstWerte.Name = "lstWerte";
			this.lstWerte.Size = new System.Drawing.Size(139, 225);
			this.lstWerte.TabIndex = 2;
			// 
			// lstFehler
			// 
			this.lstFehler.FormattingEnabled = true;
			this.lstFehler.Location = new System.Drawing.Point(184, 41);
			this.lstFehler.Name = "lstFehler";
			this.lstFehler.Size = new System.Drawing.Size(139, 225);
			this.lstFehler.TabIndex = 3;
			// 
			// frmKonverter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 286);
			this.Controls.Add(this.lstFehler);
			this.Controls.Add(this.lstWerte);
			this.Controls.Add(this.btnSchreiben);
			this.Controls.Add(this.btnLesen);
			this.Name = "frmKonverter";
			this.Text = "Dateikonverter";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLesen;
		private System.Windows.Forms.Button btnSchreiben;
		private System.Windows.Forms.ListBox lstWerte;
		private System.Windows.Forms.ListBox lstFehler;
	}
}

