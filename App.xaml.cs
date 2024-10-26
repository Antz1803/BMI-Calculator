using Microsoft.Maui.Controls;
using BMI.MVVM.View;
namespace BMI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new BMI.MVVM.View.ViewPage();
        }
    }
}
