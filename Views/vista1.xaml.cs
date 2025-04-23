namespace jdelgadoS3A.Views;

public partial class vista1 : ContentPage
{
    public vista1()
    {
        InitializeComponent();

    }
    string usuariof = "";
    string contrasenaf = "";
    public vista1(string usuario, string contrasena)
    {
        InitializeComponent();
        this.usuariof = usuario;
        this.contrasenaf = contrasena;

    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == usuariof && txtContraseña.Text == contrasenaf)
        {
            Navigation.PushAsync(new Views.vista2(usuariof));
        }
        else
        {
            DisplayAlert("Erro", "Usuario / Contraseña incorrectos", "Aceptar");
        }

    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vista3());
    }
}