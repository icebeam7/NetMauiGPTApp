using CommunityToolkit.Mvvm.ComponentModel;

namespace NetMauiGPTApp.ViewModels
{
	public partial class BaseViewModel : ObservableObject
	{
		[ObservableProperty]
		bool isBusy;
	}
}
