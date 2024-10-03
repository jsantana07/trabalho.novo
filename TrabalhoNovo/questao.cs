

namespace TrabalhoNovo
{
    public class Questao
    {
        public string Pergunta;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int Respostacorreta;
        public int Nivelresposta;
        private Label Labelpergunta;
        private Button ButtonResposta1;
        private Button ButtonResposta2;
        private Button ButtonResposta3;
        private Button ButtonResposta4;
        private Button ButtonResposta5;


        public void ConfiguraEstruturaDesenho(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            Labelpergunta = labelpergunta;
            ButtonResposta1 = button1;
            ButtonResposta2 = button2;
            ButtonResposta3 = button3;
            ButtonResposta4 = button4;
            ButtonResposta5 = button5;
        }
        public void Desenhar()
        {
            Labelpergunta.Text = Pergunta;
            ButtonResposta1.Text = Resposta1;
            ButtonResposta2.Text = Resposta2;
            ButtonResposta3.Text = Resposta3;
            ButtonResposta4.Text = Resposta4;
            ButtonResposta5.Text = Resposta5;

            this.ButtonResposta1!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta1!.TextColor = Colors.White;
            this.ButtonResposta2!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta2!.TextColor = Colors.White;
            this.ButtonResposta3!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta3!.TextColor = Colors.White;
            this.ButtonResposta4!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta4!.TextColor = Colors.White;
            this.ButtonResposta5!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta5!.TextColor = Colors.White;

            ButtonResposta1.IsVisible=true;
            ButtonResposta2.IsVisible=true;
            ButtonResposta3.IsVisible=true;
            ButtonResposta4.IsVisible=true;
            ButtonResposta5.IsVisible=true;

        }

        private Button QualButton(int RespostaSelecionada)
        {
            if (RespostaSelecionada == 1)
                return ButtonResposta1;
            else if (RespostaSelecionada == 2)
                return ButtonResposta2;
            else if (RespostaSelecionada == 3)
                return ButtonResposta3;
            else if (RespostaSelecionada == 4)
                return ButtonResposta4;
            else if (RespostaSelecionada == 5)
                return ButtonResposta5;
            else
                return null;

        }
        public bool VerificaResposta(int RespostaSelecionada)
        {
            if (Respostacorreta == RespostaSelecionada)
            {
                var Button = QualButton(RespostaSelecionada);
                Button.BackgroundColor = Colors.Green;
                return true;
            }
            else
            {
                var ButtonCorreto = QualButton(Respostacorreta);
                var ButtonIncorreto = QualButton(RespostaSelecionada);
                ButtonCorreto.BackgroundColor = Colors.Yellow;
                ButtonIncorreto.BackgroundColor = Colors.Red;
                return false;
            }
        }

        public Questao()
        {

        }
        public Questao(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            Labelpergunta = labelpergunta;
            ButtonResposta1 = button1;
            ButtonResposta2 = button2;
            ButtonResposta3 = button3;
            ButtonResposta4 = button4;
            ButtonResposta5 = button5;
        }
        public bool Equals(Questao Q)
        {
            return this.Nivelresposta == Q.Nivelresposta &&
             this.Pergunta == Q.Pergunta;
        }


    }

}