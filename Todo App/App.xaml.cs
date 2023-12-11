using Todo_App.Views;

namespace Todo_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new TodoListPage())
		{
			BarTextColor = Color.FromRgb(76, 187, 23)
        };
	}
}
