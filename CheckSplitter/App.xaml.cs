namespace CheckSplitter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override Window CreateWindow(IActivationState activationState) {
        var Window = base.CreateWindow(activationState);

        // Add here your sizing code
        // Add here your positioning code
        var displayInfo = DeviceDisplay.Current.MainDisplayInfo;

        Window.Height = 560;
        Window.Width = 400;

        //Window.X = (displayInfo.Width / displayInfo.Density - Window.Width) / 2;
        //Window.Y = (displayInfo.Height / displayInfo.Density - Window.Height) / 2;

        return Window;
    }
}
