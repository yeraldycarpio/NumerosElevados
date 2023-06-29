namespace NumerosElevados;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void Resolver_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(datoA.Text) && !string.IsNullOrEmpty(datoB.Text))
		{
			var n1 = Convert.ToDouble(datoA.Text);
			var n2 = Convert.ToDouble(datoB.Text);
			double resul = Math.Pow(n1 + n2, 2) / 2;
			resultado.Text = Convert.ToString(resul);

		}
		else
		{
			DisplayAlert("Error", "Introduzca todos los números","Aceptar");
		}

	}
}


