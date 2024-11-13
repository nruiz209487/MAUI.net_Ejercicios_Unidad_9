using Ejercicio5b.Models.ENT;
using Ejercicio5b.VM;
namespace Ejercicio5b

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
            ClasePersona persona = (ClasePersona)e.SelectedItem;
            if (persona != null)
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

                    BindingContext = persona;
                }
                else
                {
                    throw new Exception("Error al importar la persona");
                }
            }
        }

    }

}
