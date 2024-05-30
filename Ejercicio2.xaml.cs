namespace Ejerciciosdel1al5MauiApp;

public partial class Ejercicio2 : ContentPage
{
	public Ejercicio2()
	{
		InitializeComponent();
        InitializeUI();
        //Interfaz de campo 
    }

     private void InitializeUI()
    {

        // Entradas para los n�meros A y B.
        var entryA = new Entry { Placeholder = "A", Keyboard = Keyboard.Numeric };
        var entryB = new Entry { Placeholder = "B", Keyboard = Keyboard.Numeric };

        // Bot�n para calcular.
        var calculateButton = new Button { Text = "Calcular" };

        // Mostrar el resultado.
        var resultLabel = new Label();

        // Bot�n para volver al men� principal.
        var backButton = new Button { Text = "Volver al Men�" };

        // Mostrar la imagen por medio de URL.
        var imageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjmUoC3jdCHmg2rSkF768iDRuCLi0KRfYmCUjIpnU9yK_Tm5OqF62EKqXQ0RONQGuHcMFIWdSQukVEIu3hj63mHOWLgwov76jjtOjEi22mV4xIGCXPR23mERmiGknNRpCkfLG65ufOBmEIf/s1600/(a+b)2=a2+2ab+b2.jpg";
        var image = new Image { Source = ImageSource.FromUri(new Uri(imageUrl)), HeightRequest = 200 };

        // Bot�n de c�lculo.
        calculateButton.Clicked += (sender, e) =>
        {
            if (double.TryParse(entryA.Text, out double A) && double.TryParse(entryB.Text, out double B))
                resultLabel.Text = $"Resultado: {(A + B) * (A + B) / 2}";
            else
                resultLabel.Text = "Ingrese n�meros v�lidos para A y B.";
        };

        // Bot�n de volver al men�.
        backButton.Clicked += async (sender, e) =>
        {
            await Navigation.PopAsync();
        };

        // Estructura de la p�gina.
        Content = new StackLayout
        {
            Padding = new Thickness(20),
            Children = { entryA, entryB, calculateButton, resultLabel, backButton, image }
        };

    }
}
