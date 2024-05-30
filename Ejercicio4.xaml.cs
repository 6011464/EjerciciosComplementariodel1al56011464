namespace Ejerciciosdel1al5MauiApp;

public partial class Ejercicio4 : ContentPage
{
	public Ejercicio4()
	{
		InitializeComponent();

  
    }

 
    /// Botón para calcular el cuadrado y cubo del número ingresado.
   
    private void OnCalculateClicked(object sender, EventArgs e)
    {
        var backButton = new Button { Text = "Volver al Menú" };

        if (int.TryParse(numberEntry.Text, out int number) && number > 0)
        {
            resultLabel.Text = $"Cuadrado: {number * number}, Cubo: {number * number * number}";
        }
        else
        {
            resultLabel.Text = "Ingrese un número entero positivo válido.";
        }

        
    }


    /// Botón para regresar al menú principal.
    
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
