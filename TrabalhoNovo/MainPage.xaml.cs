namespace TrabalhoNovo;

public partial class MainPage : ContentPage
{
	 Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
	    gerenciador= new Gerenciador (labelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5, Pontuacao, Nivel);
	}

	  void ButtonResposta1Clicked(object sender, EventArgs args)
	{
	    gerenciador.VerificaCorreta(1);
	}
	void ButtonResposta2Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(2);
	}
	void ButtonResposta3Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(3);
	}
	void ButtonResposta4Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(4);
	}
	void ButtonResposta5Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(5);
	}

}

