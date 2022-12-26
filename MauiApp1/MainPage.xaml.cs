using MauiApp1.DataAccess;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        count++;
        using (var context = new MyDemoContext())
        {
            context.People.Add(new Person() { Name = $"Person{count}" });
            context.SaveChanges();
        }

        CounterBtn.Text = $"{count} people added";

        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

