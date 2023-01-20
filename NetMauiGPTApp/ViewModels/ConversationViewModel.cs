using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NetMauiGPTApp.Services;

namespace NetMauiGPTApp.ViewModels
{
	public partial class ConversationViewModel : BaseViewModel
	{
		[ObservableProperty]
		string query;

		[ObservableProperty]
		string answer;

		[ObservableProperty]
		string generatedImage;

		IOpenAIService openAIService;

		public ConversationViewModel(IOpenAIService openAIService)
		{
			this.openAIService = openAIService;
		}

		[RelayCommand]
		async Task AskQuestionAsync()
		{
			IsBusy = true;
			Answer = await openAIService.AskQuestion(Query);
			IsBusy = false;
		}

		[RelayCommand]
		async Task CreateImageAsync()
		{
			IsBusy = true;
			GeneratedImage = await openAIService.CreateImage(Query);
			IsBusy = false;
		}
	}
}
