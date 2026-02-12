namespace ExpressionsSample;

public partial class MainPage : ContentPage
{
	public MainViewModel ViewModel { get; }

	public MainPage()
	{
		InitializeComponent();
		ViewModel = new MainViewModel();
		BindingContext = ViewModel;
	}

	public void OnCounterClicked() => ViewModel.ClickCount++;
}
