namespace YargExportReader;

public static class PdfTemplate
{
    public const string Start = "<!DOCTYPE html><html><head><meta charset='UTF-8'><style type='text/css'>@page wide {margin: 1cm}body {color: #231f20;margin: 1cm;}@page :not(:first) {margin-top: 1cm;}.right-align {text-align: right}.artist {background: #ddddde;font-weight: bold;}.songlist-table {width: 100%;border-collapse: collapse;}td {vertical-align: top;padding: 3mm;}.songlist-table tbody:before {display: block;content: ' ';margin-top: 1mm;}table {page-break-inside: auto}tr {page-break-inside: avoid;page-break-after: auto}</style></head><body><table class='songlist-table'><tbody>";

    public const string End = "</tbody></table></body></html>";

    public const string ArtistLine = "<tr class='artist'><td colspan='4'>{0}</td></tr>";

    public const string SongLine = "<tr><td /><td>{0}</td><td>{1}</td><td class='right-align'>{2}</td></tr>";
}