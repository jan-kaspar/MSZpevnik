namespace MSZpevnik;

public partial class SearchResultsPage : ContentPage
{
	public SearchResultsPage(List<SongData> selection)
	{
		InitializeComponent();

		Title = "V�sledky hled�n�";

		ResultsView.ItemsSource = selection;
	}

	private async void ResultsView_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		if (e.Item != null)
			await Navigation.PushAsync(new SongViewPage((SongData) e.Item));

		ResultsView.SelectedItem = null;
	}
}