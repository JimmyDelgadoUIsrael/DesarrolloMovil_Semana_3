namespace jdelgadoS3A.Views;

public partial class vista2 : ContentPage
{
    public vista2(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void btnAbrirV3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vista3());
    }
}