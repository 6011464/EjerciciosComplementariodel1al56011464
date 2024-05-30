namespace Ejerciciosdel1al5MauiApp;

public partial class Ejercicio3 : ContentPage
{
    public Ejercicio3()
    {
        InitializeComponent();
        
    }

    /// Evento Click para el botón para calcular el promedio de las calificaciones.


    private async void OnCalculateClicked(object sender, EventArgs e)
    {

        

        if (double.TryParse(entry1.Text, out double grade1) && double.TryParse(entry2.Text, out double grade2)
            && double.TryParse(entry3.Text, out double grade3) && double.TryParse(entry4.Text, out double grade4)
            && double.TryParse(entry5.Text, out double grade5))
        {
            double average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            resultadoLabel.Text = $"El promedio de las calificaciones es: {average}";
        }
        else
        {
            await DisplayAlert("Error", "Ingrese calificaciones válidas", "OK");

        }

       // Evento click para el boton para poder regresar al menu

    }
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}
