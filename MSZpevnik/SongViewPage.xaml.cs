namespace MSZpevnik;

public partial class SongViewPage : ContentPage
{
	public SongViewPage(SongData song)
	{
		InitializeComponent();

		Title = @"Píseň " + song.GetNumber();

		string path = @"Songs/" + song.GetFileName();
		SongWebView.Source = path;
	}
}