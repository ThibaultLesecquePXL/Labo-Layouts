namespace Layouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void GridPageClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GridPage));
        }

    }

}
