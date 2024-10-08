namespace TrabalhoNovo;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;
	private int clickcount=0;

	private int vezesclicked=0;

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5, Pontuacao, Nivel);
		
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

	void retirarClicked(object sender, EventArgs args)
	{
		var ajuda = new RetiraErrada();
		ajuda.ConfiguraDesenho( ButtonResposta1, ButtonResposta2,  ButtonResposta3,  ButtonResposta4, ButtonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;

	}

	void universitarioClicked(object sender, EventArgs args)
	{
		var ajuda = new Universitario();
		ajuda.ConfiguraDesenho( ButtonResposta1, ButtonResposta2,  ButtonResposta3,  ButtonResposta4, ButtonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;

	}


	void pulaclicado(object sender, EventArgs args)
	{
		gerenciador.ProximaQuestao();
		clickcount++;
		vezesclicked++;
       if  (clickcount>=3)
	   {
		(sender as Button).IsVisible = false;
	   }
	   else
	   {
	   (sender as Button).IsVisible = true;
	   }

		if (vezesclicked==1)
		{
			pular.Text="restam 2 pula";
		}
		else if (vezesclicked==2)
		{
			pular.Text="restam 1 pula";
		}
		else if(vezesclicked>=3)
		{
			(sender as Button).IsVisible = false;
		}


	}

}

