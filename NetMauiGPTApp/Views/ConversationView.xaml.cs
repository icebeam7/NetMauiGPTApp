using NetMauiGPTApp.ViewModels;

namespace NetMauiGPTApp.Views;

public partial class ConversationView : ContentPage
{
    public ConversationView(ConversationViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;

        vm.CollectionView = myCollectionView;
        vm.ConversationView = mainPage;
    }

}