namespace Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (this.AnimationIsRunning("TransitionAnimation"))
		{
			return;
		}

		var parentAnimation = new Animation();

		//PlanetsAnimation
		//parentAnimation.Add(0, 0.2, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));

	}
}