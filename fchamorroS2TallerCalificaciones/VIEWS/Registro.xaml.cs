namespace fchamorroS2TallerCalificaciones.VIEWS;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;
        DisplayAlert("Alerta", "Usuario Guardado", "Ok");
        Navigation.PushAsync(new Login1(usuario, contrasena));

    }

    private void btnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login1());
        txtUsuario.Text = string.Empty;
        txtContrasena.Text = string.Empty;
    }
}