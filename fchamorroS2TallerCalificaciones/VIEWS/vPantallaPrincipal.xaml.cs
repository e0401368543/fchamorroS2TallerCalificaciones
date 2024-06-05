namespace fchamorroS2TallerCalificaciones.VIEWS;

public partial class vPantallaPrincipal : ContentPage
{
	public vPantallaPrincipal()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		decimal nota1= Convert.ToDecimal(txtSeguimiento.Text);


    }

    private char ConvertToCharOrDefault(char? input, char defaultValue = ' ')
    {
        return input ?? defaultValue;
    }
}