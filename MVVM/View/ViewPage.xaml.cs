namespace BMI.MVVM.View;

public partial class ViewPage : ContentPage
{
    public ViewPage()
    {
        InitializeComponent(); 
        //Binding the model
        BindingContext = new BMI.MVVM.Model.ViewModel();
    }
}
