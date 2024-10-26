namespace BMI.MVVM.View;

public partial class ViewPage : ContentPage
{
    public ViewPage()
    {
        InitializeComponent(); 
        BindingContext = new BMI.MVVM.Model.ViewModel();
    }
}