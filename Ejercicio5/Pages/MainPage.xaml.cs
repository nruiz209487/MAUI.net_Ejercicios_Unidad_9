

using Ejercicio5.Models.ENT;
using Ejercicio5.Pages;
using Ejercicio5.VM;

namespace Ejercicio5

{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            List<ClasePersona> listaPersonas;
            try
            {
                listaPersonas = MainPageVM.obtenerListadoDePersonasVM();
                listViewPersonas.ItemsSource = listaPersonas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al importar la lista " + ex);
            }
        }


        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ClasePersona persona = (ClasePersona)e.SelectedItem; ;
            if (e.SelectedItem != null)
            {
                try
                {
                    persona = MainPageVM.obtenerPersonaVM(persona.Id);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al importar la persona " + ex);
                }
                if (persona != null)
                {
                    await Navigation.PushAsync(new DatosDePersona(persona));
                }
                else { throw new Exception("Error al importar la persona "); }
            }
        }
    }

}
