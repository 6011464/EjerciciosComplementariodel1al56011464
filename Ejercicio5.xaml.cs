namespace Ejerciciosdel1al5MauiApp;

public partial class Ejercicio5 : ContentPage
{
	public Ejercicio5()
	{
		InitializeComponent();
       
    }


    /// Botón para calcular el perímetro y la superficie del rectángulo.

    private void CalcularClicked(object sender, EventArgs e)
    {
        if (double.TryParse(alturaEntry.Text, out double altura) && double.TryParse(baseEntry.Text, out double @base))
        {
            double perimetro = 2 * (@base + altura);
            double superficie = @base * altura;

            // Mostrar los resultados
            perimetroLabel.Text = $"Perímetro: {perimetro}";
            superficieLabel.Text = $"Superficie: {superficie}";
        }
        else
        {
            // Mostrar mensaje de error 
            perimetroLabel.Text = "Ingrese valores válidos para la altura y la base.";
            superficieLabel.Text = "";
        }
    }


    /// botón para regresar al menú principal.

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}