namespace Görsel_Programlama_Ödev;

public partial class Kredi_Hesaplama : ContentPage
{

	public Kredi_Hesaplama()
	{
		InitializeComponent();
	}


    private void Button_Clicked(object sender, EventArgs e)
    {
        KrediTurPicker.Items.Add("İhtiyaç Kredisi");
        KrediTurPicker.Items.Add("Konut Kredisi");
        KrediTurPicker.Items.Add("Taşıt Kredisi");
        KrediTurPicker.Items.Add("Ticari Kredi");

        double Oran = double.Parse(OranEntry.Text);
        double Vade = double.Parse(VadeEntry.Text);
        double Tutar = double.Parse(TutarEntry.Text);
        double KKDF = 0;
        double BSMV = 0;

        switch (KrediTurPicker.SelectedIndex)
        {
            case 0: // ihtiyaç kredisi
                KKDF = 15;
                BSMV = 10;
                break;
            case 1: // konut kredisi
                KKDF = 0;
                BSMV = 0;
                break;
            case 2: // taşıt kredisi
                KKDF = 15;
                BSMV = 5;
                break;
            case 3: // ticari kredi
                KKDF = 0;
                BSMV = 5;
                break;
        }

        double brutFaiz = ((Oran + (Oran * BSMV) + (Oran * KKDF)) / 100);
        double taksit = ((Math.Pow(1 + brutFaiz, Vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, Vade) - 1)) * Tutar;
        double toplam = taksit * Vade;

        AylikTaksit.Text = taksit.ToString("N2");
        ToplamOdeme.Text = toplam.ToString("N2");
        ToplamFaiz.Text = (toplam - Tutar).ToString("N2");
    }


}