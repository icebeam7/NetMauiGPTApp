using NetMauiGPTApp.ViewModels;

namespace NetMauiGPTApp.Views;

public partial class ConversationView : ContentPage
{
	public ConversationView(ConversationViewModel vm)
	{
		InitializeComponent();

		this.BindingContext = vm;
	}
}