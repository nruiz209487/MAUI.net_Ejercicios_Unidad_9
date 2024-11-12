using Ejercicio5.Models.ENT;

namespace Ejercicio5.Pages;

public partial class DatosDePersona : ContentPage
{

    private ClasePersona detallesPersona;
    public DatosDePersona(ClasePersona persona)
    {
        InitializeComponent();
        try { detallesPersona = persona; }
        catch (Exception ex) { throw new Exception("error al mostrar los detalles de la persona " + ex); }
        BindingContext = persona;
    }
}