using Microsoft.Extensions.Logging.Abstractions;

namespace Görsel_Programlama_Ödev;

public partial class Vucut_Kitle_Indeksi : ContentPage
{
	public Vucut_Kitle_Indeksi()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double kilo = 0, boy = 0, vki = 0;

        if (double.TryParse(Kilo.Text, out kilo) && double.TryParse(Boy.Text, out boy))
        {
            boy /= 100.0; // boyu metre cinsine çevir

            vki = kilo / (boy * boy);
            string sonuc = "";

            if (vki < 16)
                sonuc = "İleri Düzeyde Zayıf";
            else if (vki >= 16 && vki <= 16.99)
                sonuc = "OrtaDüzeyde Zayıf";
            else if (vki >= 17 && vki <= 18.49)
                sonuc = "Hafif Düzeyde Zayıf";
            else if (vki >= 18.50 && vki <= 24.99)
                sonuc = "Normal Kilolu";
            else if (vki >= 25 && vki <= 29.99)
                sonuc = "Hafif Şiman / Fazla Kilolu";
            else if (vki >= 30 && vki <= 34.99)
                sonuc = "1. Derecede Obez";
            else if (vki >= 35 && vki <= 39.99)
                sonuc = "2. Derecede Obez";
            else if (vki >= 40)
                sonuc = "3. Derecede Obez / Morbid Obez";

            SayisalSonuc.Text = vki.ToString("N2");
            SozelSonuc.Text = sonuc.ToString();
        }

    }


    private void Kilo_TextChanged(object sender, TextChangedEventArgs e)
    {
        double kilo = 0;
        if (double.TryParse(Kilo.Text, out double kiloValue))
        {
            kilo = kiloValue;
        }
    }

    private void Boy_TextChanged(object sender, TextChangedEventArgs e)
    {
        double boy = 0;
        if (double.TryParse(Boy.Text, out double boyValue))
        {
            boy = boyValue;
        }
    }
}