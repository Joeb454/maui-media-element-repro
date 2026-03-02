namespace MediaElementAudioSessionRepro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		Player.Handler?.DisconnectHandler();
	}
}
