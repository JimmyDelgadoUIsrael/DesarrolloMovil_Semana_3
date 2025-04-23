namespace jdelgadoS3A.Views;

public partial class vista3 : ContentPage
{
    public vista3()
    {
        InitializeComponent();
    }

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuarioc = txtUsuario.Text;
        string contrasenac = txtContrasena.Text;
        if (!string.IsNullOrWhiteSpace(usuarioc) && !string.IsNullOrWhiteSpace(contrasenac))
        {
            DisplayAlert("Alerta", "Usuario Guardado", "Aceptar");

            Navigation.PushAsync(new Views.vista1(usuarioc, contrasenac));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario / Contraseña null", "Aceptar");
        }



    }
}