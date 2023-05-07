namespace Görsel_Programlama_Ödev;

public partial class RenkSecici : ContentPage
{
	public RenkSecici()
	{
		InitializeComponent();
	}

    private void RedSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateRenkKoduLabel();
    }

    private void GreenSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateRenkKoduLabel();
    }

    private void BlueSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateRenkKoduLabel();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Color yeniRenk = Color.FromRgb((int)RedSlider.Value, (int)GreenSlider.Value, (int)BlueSlider.Value);
        RenkKodu.Text = $"{yeniRenk.ToHex()}";
        FlexLayout2.BackgroundColor = yeniRenk;
    }

    private void UpdateRenkKoduLabel()
    {
        Color yeniRenk = Color.FromRgb((int)RedSlider.Value, (int)GreenSlider.Value, (int)BlueSlider.Value);
        RenkKodu.Text = $"{yeniRenk.ToHex()}";
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
      
        Clipboard.SetTextAsync(RenkKodu.Text);
    }
}