namespace MauiModalTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnShowModalClicked(object sender, EventArgs e)
	{
		count++;

        await Navigation.PushModalAsync(new ModalPage());
    }
}

