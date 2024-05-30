namespace Ejerciciosdel1al5MauiApp;

public partial class Ejercicio5 : ContentPage
{
	public Ejercicio5()
	{
		InitializeComponent();
       
    }


    /// Bot�n para calcular el per�metro y la superficie del rect�ngulo.

    private void CalcularClicked(object sender, EventArgs e)
    {
        if (double.TryParse(alturaEntry.Text, out double altura) && double.TryParse(baseEntry.Text, out double @base))
        {
            double perimetro = 2 * (@base + altura);
            double superficie = @base * altura;

            // Mostrar los resultados
            perimetroLabel.Text = $"Per�metro: {perimetro}";
            superficieLabel.Text = $"Superficie: {superficie}";
        }
        else
        {
            // Mostrar mensaje de error 
            perimetroLabel.Text = "Ingrese valores v�lidos para la altura y la base.";
            superficieLabel.Text = "";
        }
    }


    /// bot�n para regresar al men� principal.

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}