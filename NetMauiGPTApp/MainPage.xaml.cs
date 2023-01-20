using NetMauiGPTApp.Services;
using System.Diagnostics;

namespace NetMauiGPTApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	IOpenAIService service;

	public MainPage(IOpenAIService service)
	{
		InitializeComponent();
		this.service = service;
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		var text = await service.CreateImage("A cat dressed as a mafia boss");
		Debug.WriteLine(text);
		//await DisplayAlert("Answer", text, "OK");



		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

