namespace Ejerciciosdel1al5MauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // Instancia para dirigirse hacia el ejerccio 1
        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejercicio1());
        }

        // Instancia para dirigirse hacia el ejerccio 2
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejercicio2());
        }

        // Instancia para dirigirse hacia el ejerccio 3
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejercicio3());
        }

        // Instancia para dirigirse hacia el ejerccio 4
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejercicio4());
        }

        // Instancia para dirigirse hacia el ejerccio 5
        private void OnCounterClicked4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejercicio5());
        }

    }

}
