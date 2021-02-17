using System;
using System.IO;
using System.Windows.Forms;

namespace Csharp_2021_Dateikonverter
{
	public partial class frmKonverter : Form
	{
		public frmKonverter()
		{
			InitializeComponent();
		}

		private void btnLesen_Click(object sender, EventArgs e)
		{
			// OpenFileDialog erstellen und konfigurieren
			var ofd = new OpenFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
				Filter = "Textdateien (*.txt)|*.txt|" +
				"Alle Dateien (*.*)|*.*",
				Title = "Datei zum Öffnen auswählen"
			};

			// OpenFileDialog anzeigen und Funktion verlassen, wenn nicht auf
			// "Öffnen" gedrückt wurde
			if (ofd.ShowDialog() != DialogResult.OK) return;

			// StreamReader-Objekt zum Dateizugriff erstellen (lesend)
			var sr = new StreamReader(ofd.FileName);

			string zeile = "";

			while (!sr.EndOfStream)		// == sr.Peek() != -1
			{
				zeile = sr.ReadLine();  // Zeile für Zeile die Datei einlesen

				// mit double.TryParse() prüfen, ob eingelesene Zeile in eine 
				// Zahl umgewandelt werden kann
				// => liefert true, falls ja
				// => liefert false, falls nein
				if (double.TryParse(zeile, out double wert)) lstWerte.Items.Add($"{wert:##.00}");
				else lstFehler.Items.Add(zeile);
			}

			// StreamReader & Datei schließen
			sr.Close();
		}

		private void btnSchreiben_Click(object sender, EventArgs e)
		{
			// SaveFileDialog-Objekt erstellen und initialisieren
			var sfd = new SaveFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
				Filter = "Textdateien (*.txt)|*.txt|" +
				"Alle Dateien (*.*)|*.*",
				Title = "Datei speichern unter..."
			};

			// sfd anzeigen und Rückgabe auswerten
			if (sfd.ShowDialog() != DialogResult.OK) return;

			// StreamWriter erstellen
			var sw = new StreamWriter(sfd.FileName);

			// Alle Elemente der Liste in der Textdatei speichern
			foreach (var item in lstWerte.Items)
			{
				sw.WriteLine(item);
			}

			// StreamWriter schließen
			sw.Close();
		}
	}
}
