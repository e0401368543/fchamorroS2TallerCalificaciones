using System.Numerics;

namespace fchamorroS2TallerCalificaciones.VIEWS;

public partial class Login1 : ContentPage
{
       
    public Login1()
	{
		InitializeComponent();
       
        users = new string[] { "Carlos", "Ana", "Jose", "Freddy" };
        passw = new string[] { "carlos123", "ana123", "jose123", "freddy123" };
    }
    string user="";
    string pasword="";

    private string[] users;
    private string[] passw;
    public Login1(string usuario, string contraseña)
    {
        InitializeComponent();
        user = usuario;
        pasword = contraseña;
       


    }



    private void btnIngreso_Clicked(object sender, EventArgs e)
    {
        int i = 0;
        
        while (txtUsaurio.Text != users[i] && i< users.Length-1)
        {
          //  DisplayAlert("Alerta", "Usuario no existe"+ users[i]+" :pos: " +i, "Ok");

            if (i == users.Length-1) {
                DisplayAlert("Alerta", "Usuario no existe", "Ok");
                }

            i += 1;
        }

        if (txtUsaurio.Text == users[i])
        {
            if (txtContraseña.Text == passw[i])
            {
                Navigation.PushAsync(new vPantallaPrincipal(txtUsaurio.Text));

            }
            else
                DisplayAlert("Alerta", "Contraseña incorrecta", "Ok");

        }
        else
        {


            if (user == txtUsaurio.Text && pasword == txtUsaurio.Text)
            {
                Navigation.PushAsync(new vPantallaPrincipal(txtUsaurio.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario incorrectos", "Ok");
            }
        }
        
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {

        //Navigation.PushAsync(new vPantallaPrincipal());
        Navigation.PushAsync(new Registro());

    }
}