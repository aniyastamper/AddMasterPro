namespace AddPro;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
        Title = "Add Master Pro";
    }


    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtFirstNumber.Text =String.Empty;
        txtSecondNumber.Text =String.Empty;
        lblDisplay.Text = "0";
    }

    private void Add_OnClicked(object sender, EventArgs e)
    {
        Double dblFirst,dblSecond;
        Double.TryParse(txtFirstNumber.Text, out dblFirst);
        Double.TryParse(txtSecondNumber.Text, out dblSecond);

        lblDisplay.Text = (dblFirst + dblSecond).ToString();
    }
}