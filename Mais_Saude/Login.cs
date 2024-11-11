namespace Mais_Saude;

public partial class Login : ContentPage
{
		string senha = "123456";
		string cpf = "09029866942";
		string tentaSenha;
		string tentaCpf;

	public Login()
	{
		InitializeComponent();

	}

	private void OnEntrarClicked(object sender, EventArgs e)
	{
		tentaCpf = placeholderCpf.Text;
		tentaSenha = placeholderSenha.Text;
		
		if(String.IsNullOrEmpty(tentaCpf))
			DisplayAlert("Erro", "Digite seu CPF e tente novamente!", "Ok");
		else if (String.IsNullOrEmpty(tentaSenha))
			DisplayAlert("Erro", "Digite sua senha e tente novamente!", "Ok");
		else if(senha == tentaSenha && cpf == tentaCpf)
			Application.Current.MainPage = new MainPage();
		else
			DisplayAlert("Erro", "CPF ou senha incorreto!", "Ok");
	}
}

