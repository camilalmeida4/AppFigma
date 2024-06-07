using AppFigma.Models;

namespace AppFigma.Pages;

public partial class Perfil : ContentPage
{
    private Usuario _usuario;
	public Perfil()
	{
		InitializeComponent();

        _usuario = App.Usuario;

        ftPerfil.Clicked += async (sender, e) =>
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var file = await MediaPicker.PickPhotoAsync();
                if (file != null)
                {
                    var filePath = file.FullPath;

                    ftPerfil.Source = ImageSource.FromFile(filePath);

                    _usuario.Foto = filePath;
                    await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

                }
            }
        };
    }

    private void btnAtualizar_Clicked(object sender, EventArgs e)
    {

    }

    

    
}