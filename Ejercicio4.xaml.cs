namespace Ejerciciosdel1al5MauiApp;

public partial class Ejercicio4 : ContentPage
{
	public Ejercicio4()
	{
		InitializeComponent();

  
    }

 
    /// Bot�n para calcular el cuadrado y cubo del n�mero ingresado.
   
    private void OnCalculateClicked(object sender, EventArgs e)
    {
        var backButton = new Button { Text = "Volver al Men�" };

        if (int.TryParse(numberEntry.Text, out int number) && number > 0)
        {
            resultLabel.Text = $"Cuadrado: {number * number}, Cubo: {number * number * number}";
        }
        else
        {
            resultLabel.Text = "Ingrese un n�mero entero positivo v�lido.";
        }

        
    }


    /// Bot�n para regresar al men� principal.
    
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
