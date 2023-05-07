namespace Görsel_Programlama_Ödev;

public partial class FlyoutPage1 : FlyoutPage
{
	public FlyoutPage1()
	{

		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Detail = new FlyoutPage1();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Detail = new Kredi_Hesaplama();
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Detail = new Vucut_Kitle_Indeksi();
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        Detail = new RenkSecici();
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        Detail = new Yapilacaklar();
    }
}