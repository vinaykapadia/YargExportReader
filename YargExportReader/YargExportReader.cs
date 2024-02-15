using System.Diagnostics;
using Newtonsoft.Json;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace YargExportReader
{
    public partial class YargExportReader : Form
    {
        private List<Song> _songList = new();

        public YargExportReader()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            InitializeComponent();
        }

        private void YargExportReader_Load(object sender, EventArgs e)
        {
            GrdSongs.DataSource = _songList;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            DlgOpenFile.ShowDialog();
        }

        private void DlgOpenFile_FileOk(object sender, EventArgs e)
        {
            TxtFile.Text = DlgOpenFile.FileName;
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText(TxtFile.Text);
            _songList = JsonConvert.DeserializeObject<List<Song>>(json)?.OrderBy(s => s.Artist).ThenBy(s => s.Name).ToList()
                ?? new();
            GrdSongs.DataSource = _songList;
        }

        private void BtnExportText_Click(object sender, EventArgs e)
        {
            DlgSaveTxtFile.ShowDialog();
        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            DlgSavePdfFile.ShowDialog();
        }

        private void DlgSaveTxtFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var output = _songList.Select(s => $"{s.Artist} - {s.Name}");
            File.WriteAllLines(DlgSaveTxtFile.FileName, output);
            Launch(DlgSaveTxtFile.FileName);
        }

        private void DlgSavePdfFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Margin(1, Unit.Centimetre);

                    page.Content().Inlined(inlined =>
                    {
                        inlined.Item().PaddingBottom(1, Unit.Centimetre).Text("Song List").FontSize(24)
                            .FontColor(Colors.Blue.Darken2).SemiBold();

                        foreach (var artist in _songList.GroupBy(s => s.Artist))
                        {
                            inlined.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(2, Unit.Centimetre);
                                    columns.RelativeColumn();
                                    columns.ConstantColumn(2, Unit.Centimetre);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().ColumnSpan(3).Background(Colors.Grey.Lighten3).Border(1)
                                        .BorderColor(Colors.Grey.Lighten1).Padding(5).Text(artist.Key).FontSize(10);
                                });

                                foreach (var song in artist)
                                {
                                    table.Cell().Padding(5).Text(" ").FontSize(10);
                                    table.Cell().Padding(5).Text(song.Name).FontSize(10);
                                    table.Cell().Padding(5).AlignRight().Text(song.SongLength).FontSize(10);
                                }
                            });
                        }
                    });

                });
            }).GeneratePdf(DlgSavePdfFile.FileName);

            Launch(DlgSavePdfFile.FileName);
        }

        private void Launch(string fileName)
        {
            Process.Start(new ProcessStartInfo(fileName)
            {
                UseShellExecute = true
            });
        }
    }
}
