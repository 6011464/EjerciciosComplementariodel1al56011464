namespace Ejerciciosdel1al5MauiApp;

public partial class Ejercicio1 : ContentPage
{
	public Ejercicio1()
	{
		InitializeComponent();
        // Creaci�n para los n�meros.
        var numberEntries = new Entry[3];
        //Etiqueta para mostrar los numeros invertidos
        var resultLabel = new Label { Text = "N�meros invertidos:" };

        // Codigo para mostrar imagenes por medio de URL
        var imageUrl = "https://previews.123rf.com/images/clairev/clairev1904/clairev190400009/120581426-imagen-de-tema-de-n%C3%BAmeros-de-dibujos-animados-1-ilustraci%C3%B3n-de-vector-de-eps10.jpg";
        var image = new Image { Source = ImageSource.FromUri(new Uri(imageUrl)), HeightRequest = 200 };


        //Creacion para los numeros
        for (int i = 0; i < 3; i++)
        {
            numberEntries[i] = new Entry { Placeholder = $"N�mero {i + 1}", Keyboard = Keyboard.Numeric };
        }

        // Boton para invertir los numeros ingresados

        var invertButton = new Button
        {
            Text = "Invertir",
            Command = new Command(() =>
            {
                resultLabel.Text = $"N�meros invertidos: {numberEntries[2].Text}, {numberEntries[1].Text}, {numberEntries[0].Text}";
            })
        };

        //Boton para regresar al menu principal
        var backButton = new Button
        {
            Text = "Men� principal",
            Command = new Command(async () =>
            {
                await Navigation.PopAsync();
            })
        };

  // Codigo para el programa para invertir los numeros
      
        Content = new StackLayout
        {
            Children = { numberEntries[0], numberEntries[1], numberEntries[2], invertButton, resultLabel, backButton, image }
        };
    }
}