using Microsoft.Maui.Controls.Handlers;
using Microsoft.Maui.Controls.Shapes;

namespace TrabalhoNovo
{
    public class Gerenciador
    {
        List<Questao> ListaQuestoes = new List<Questao>();
        List<int> ListaQuestoesRespondidas = new List<int>();
        Questao QuestaoCorrente;
        Label labelPontuacao;
        Label labelNivel;

        public Questao GetQuestaoCorrente()
        {
            return QuestaoCorrente;
        }
       

        public Gerenciador(Label labelPerg, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5, Label labelPontuacao, Label labelNivel)
        {
            this.labelPontuacao = labelPontuacao;
            this.labelNivel = labelNivel;
            CriaPerguntas(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            ProximaQuestao();
        }
        void CriaPerguntas(Label labelPerg, Button buttonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)
        {
            var Q1 = new Questao();
            Q1.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q1.Pergunta = "Qual evento histórico marcou o fim da Segunda Guerra Mundial na Europa?";
            Q1.Resposta1 = "A queda do Muro de Berlim";
            Q1.Resposta2 = "O ataque a Pearl Harbor";
            Q1.Resposta3 = "A rendição da Alemanha nazista";
            Q1.Resposta4 = "A explosão das bombas atômicas em Hiroshima e Nagasaki";
            Q1.Resposta5 = " A Revolução Francesa";
            Q1.Respostacorreta = 3;
            ListaQuestoes.Add(Q1);

            var Q2 = new Questao();
            Q2.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q2.Pergunta = "Qual é o maior país da América do Sul em extensão territorial?";
            Q2.Resposta1 = "Brasil";
            Q2.Resposta2 = "Argentina";
            Q2.Resposta3 = "Colômbia";
            Q2.Resposta4 = "Peru";
            Q2.Resposta5 = "Venezuela";
            Q2.Respostacorreta = 1;
            ListaQuestoes.Add(Q2);

            var Q3 = new Questao();
            Q3.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q3.Pergunta = "Qual planeta do Sistema Solar é conhecido como o Planeta Vermelho?";
            Q3.Resposta1 = "Vênus";
            Q3.Resposta2 = "Marte";
            Q3.Resposta3 = "Júpiter";
            Q3.Resposta4 = "Saturno";
            Q3.Resposta5 = "Urano";
            Q3.Respostacorreta = 2;
            ListaQuestoes.Add(Q3);

            var Q4 = new Questao();
            Q4.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q4.Pergunta = "Quem é o autor da obra 'Dom Quixote'?";
            Q4.Resposta1 = "William Shakespeare";
            Q4.Resposta2 = "Miguel de Cervantes";
            Q4.Resposta3 = "Fyodor Dostoyevsky";
            Q4.Resposta4 = "Victor Hugo";
            Q4.Resposta5 = "Charles Dickens";
            Q4.Respostacorreta = 2;
            ListaQuestoes.Add(Q4);

            var Q5 = new Questao();
            Q5.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q5.Pergunta = "Qual movimento artístico se caracteriza pelo uso de cores vibrantes, formas geométricas e a busca pela representação da realidade de forma abstrata?";
            Q5.Resposta1 = "Impressionismo";
            Q5.Resposta2 = "Realismo";
            Q5.Resposta3 = "Cubismo";
            Q5.Resposta4 = "Barroco";
            Q5.Resposta5 = "Romantismo";
            Q5.Respostacorreta = 3;
            ListaQuestoes.Add(Q5);

            var Q6 = new Questao();
            Q6.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q6.Pergunta = "Qual é a capital da França?";
            Q6.Resposta1 = "Paris";
            Q6.Resposta2 = "Londres";
            Q6.Resposta3 = "Berlim";
            Q6.Resposta4 = "Madri";
            Q6.Resposta5 = "Roma";
            Q6.Respostacorreta = 1;
            ListaQuestoes.Add(Q6);

            var Q7 = new Questao();
            Q7.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q7.Pergunta = "Quem escreveu 'A Divina Comédia'?";
            Q7.Resposta1 = "Dante Alighieri";
            Q7.Resposta2 = "Homer";
            Q7.Resposta3 = "Virgílio";
            Q7.Resposta4 = "Eurípides";
            Q7.Resposta5 = "Virgílio";
            Q7.Respostacorreta = 1;
            ListaQuestoes.Add(Q7);

            var Q8 = new Questao();
            Q8.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q8.Pergunta = "Qual é o elemento químico representado pelo símbolo 'O'?";
            Q8.Resposta1 = "Ouro";
            Q8.Resposta2 = "Oxigênio";
            Q8.Resposta3 = "Prata";
            Q8.Resposta4 = "Cobre";
            Q8.Resposta5 = "Água";
            Q8.Respostacorreta = 2;
            ListaQuestoes.Add(Q8);

            var Q9 = new Questao();
            Q9.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q9.Pergunta = "Qual é a moeda utilizada no Japão?";
            Q9.Resposta1 = "Yuan";
            Q9.Resposta2 = "Dólar";
            Q9.Resposta3 = "Euro";
            Q9.Resposta4 = "Iene";
            Q9.Resposta5 = "Libra";
            Q9.Respostacorreta = 4;
            ListaQuestoes.Add(Q9);

            var Q10 = new Questao();
            Q10.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q10.Pergunta = "Qual é o maior animal terrestre?";
            Q10.Resposta1 = "Elefante";
            Q10.Resposta2 = "Girafa";
            Q10.Resposta3 = "Hipopótamo";
            Q10.Resposta4 = "Rinoceronte";
            Q10.Resposta5 = "Baleia Azul";
            Q10.Respostacorreta = 1;
            ListaQuestoes.Add(Q10);

            var Q11 = new Questao();
            Q11.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q11.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
            Q11.Resposta1 = "Buzz Aldrin";
            Q11.Resposta2 = "Yuri Gagarin";
            Q11.Resposta3 = "Neil Armstrong";
            Q11.Resposta4 = "Michael Collins";
            Q11.Resposta5 = "John Glenn";
            Q11.Respostacorreta = 3;
            ListaQuestoes.Add(Q11);

            var Q12 = new Questao();
            Q12.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q12.Pergunta = "Qual é a capital do Brasil?";
            Q12.Resposta1 = "Brasília";
            Q12.Resposta2 = "Rio de Janeiro";
            Q12.Resposta3 = "São Paulo";
            Q12.Resposta4 = "Salvador";
            Q12.Resposta5 = "Belo Horizonte";
            Q12.Respostacorreta = 1;
            ListaQuestoes.Add(Q12);

            var Q13 = new Questao();
            Q13.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q13.Pergunta = "Qual é o maior continente do mundo?";
            Q13.Resposta1 = "África";
            Q13.Resposta2 = "Ásia";
            Q13.Resposta3 = "América do Norte";
            Q13.Resposta4 = "Europa";
            Q13.Resposta5 = "Oceania";
            Q13.Respostacorreta = 2;
            ListaQuestoes.Add(Q13);

            var Q14 = new Questao();
            Q14.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q14.Pergunta = "Quem pintou a Mona Lisa?";
            Q14.Resposta1 = "Vincent van Gogh";
            Q14.Resposta2 = "Pablo Picasso";
            Q14.Resposta3 = "Leonardo da Vinci";
            Q14.Resposta4 = "Claude Monet";
            Q14.Resposta5 = "Rembrandt";
            Q14.Respostacorreta = 3;
            ListaQuestoes.Add(Q14);

            var Q15 = new Questao();
            Q15.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q15.Pergunta = "Qual a língua mais falada do mundo?";
            Q15.Resposta1 = "Inglês";
            Q15.Resposta2 = "Mandarim";
            Q15.Resposta3 = "Espanhol";
            Q15.Resposta4 = "Árabe";
            Q15.Resposta5 = "Francês";
            Q15.Respostacorreta = 2;
            ListaQuestoes.Add(Q15);


            var Q16 = new Questao();
            Q16.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q16.Pergunta = "Qual é o maior oceano do mundo?";
            Q16.Resposta1 = "Oceano Atlântico";
            Q16.Resposta2 = "Oceano Índico";
            Q16.Resposta3 = "Oceano Pacífico";
            Q16.Resposta4 = "Oceano Ártico";
            Q16.Resposta5 = "Oceano Antártico";
            Q16.Respostacorreta = 3;
            ListaQuestoes.Add(Q16);

            var Q17 = new Questao();
            Q17.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q17.Pergunta = "Quem é o autor de '1984'?";
            Q17.Resposta1 = "George Orwell";
            Q17.Resposta2 = "Aldous Huxley";
            Q17.Resposta3 = "Ray Bradbury";
            Q17.Resposta4 = "F. Scott Fitzgerald";
            Q17.Resposta5 = "Ernest Hemingway";
            Q17.Respostacorreta = 1;
            ListaQuestoes.Add(Q17);

            var Q18 = new Questao();
            Q18.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q18.Pergunta = "Qual é a capital da Itália?";
            Q18.Resposta1 = "Veneza";
            Q18.Resposta2 = "Milão";
            Q18.Resposta3 = "Roma";
            Q18.Resposta4 = "Nápoles";
            Q18.Resposta5 = "Florença";
            Q18.Respostacorreta = 3;
            ListaQuestoes.Add(Q18);

            var Q19 = new Questao();
            Q19.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q19.Pergunta = "Qual é a principal fonte de energia do Sol?";
            Q19.Resposta1 = "Energia nuclear";
            Q19.Resposta2 = "Fusão nuclear";
            Q19.Resposta3 = "Fissão nuclear";
            Q19.Resposta4 = "Energia solar";
            Q19.Resposta5 = "Queima de combustíveis fósseis";
            Q19.Respostacorreta = 2;
            ListaQuestoes.Add(Q19);

            var Q20 = new Questao();
            Q20.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q20.Pergunta = "Qual é a fórmula química da água?";
            Q20.Resposta1 = "CO2";
            Q20.Resposta2 = "H2O";
            Q20.Resposta3 = "O2";
            Q20.Resposta4 = "NaCl";
            Q20.Resposta5 = "C6H12O6";
            Q20.Respostacorreta = 2;
            ListaQuestoes.Add(Q20);

            var Q21 = new Questao();
            Q21.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q21.Pergunta = "Qual o menor país do mundo?";
            Q21.Resposta1 = "Mônaco";
            Q21.Resposta2 = "Vaticano";
            Q21.Resposta3 = "Nauru";
            Q21.Resposta4 = "San Marino";
            Q21.Resposta5 = "Malta";
            Q21.Respostacorreta = 2;
            ListaQuestoes.Add(Q21);

            var Q22 = new Questao();
            Q22.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q22.Pergunta = "Quem foi o presidente dos Estados Unidos durante a Grande Depressão?";
            Q22.Resposta1 = "Theodore Roosevelt";
            Q22.Resposta2 = "Franklin D. Roosevelt";
            Q22.Resposta3 = "Harry S. Truman";
            Q22.Resposta4 = "John F. Kennedy";
            Q22.Resposta5 = "Dwight D. Eisenhower";
            Q22.Respostacorreta = 2;
            ListaQuestoes.Add(Q22);

            var Q23 = new Questao();
            Q23.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q23.Pergunta = "Qual é o sistema político onde o poder é exercido pelo povo?";
            Q23.Resposta1 = "Monarquia";
            Q23.Resposta2 = "Ditadura";
            Q23.Resposta3 = "República";
            Q23.Resposta4 = "Democracia";
            Q23.Resposta5 = "Anarquia";
            Q23.Respostacorreta = 4;
            ListaQuestoes.Add(Q23);

            var Q24 = new Questao();
            Q24.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q24.Pergunta = "Quem foi o famoso físico que desenvolveu a teoria da relatividade?";
            Q24.Resposta1 = "Isaac Newton";
            Q24.Resposta2 = "Nikola Tesla";
            Q24.Resposta3 = "Albert Einstein";
            Q24.Resposta4 = "Stephen Hawking";
            Q24.Resposta5 = "Galileu Galilei";
            Q24.Respostacorreta = 3;
            ListaQuestoes.Add(Q24);

            var Q25 = new Questao();
            Q25.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q25.Pergunta = "Qual é o maior deserto do mundo?";
            Q25.Resposta1 = "Deserto do Saara";
            Q25.Resposta2 = "Deserto da Antártica";
            Q25.Resposta3 = "Deserto de Gobi";
            Q25.Resposta4 = "Deserto de Kalahari";
            Q25.Resposta5 = "Deserto de Mojave";
            Q25.Respostacorreta = 2;
            ListaQuestoes.Add(Q25);

            var Q26 = new Questao();
            Q26.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q26.Pergunta = "Qual é o nome do continente onde se localiza o Egito?";
            Q26.Resposta1 = "África";
            Q26.Resposta2 = "Ásia";
            Q26.Resposta3 = "América";
            Q26.Resposta4 = "Europa";
            Q26.Resposta5 = "Oceania";
            Q26.Respostacorreta = 1;
            ListaQuestoes.Add(Q26);

            var Q27 = new Questao();
            Q27.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q27.Pergunta = "Qual é a capital da Austrália?";
            Q27.Resposta1 = "Sydney";
            Q27.Resposta2 = "Melbourne";
            Q27.Resposta3 = "Canberra";
            Q27.Resposta4 = "Brisbane";
            Q27.Resposta5 = "Perth";
            Q27.Respostacorreta = 3;
            ListaQuestoes.Add(Q27);

            var Q28 = new Questao();
            Q28.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q28.Pergunta = "Qual é o nome do famoso navio que afundou em 1912?";
            Q28.Resposta1 = "Lusitânia";
            Q28.Resposta2 = "Britannic";
            Q28.Resposta3 = "Titanic";
            Q28.Resposta4 = "Carpathia";
            Q28.Resposta5 = "Olympic";
            Q28.Respostacorreta = 3;
            ListaQuestoes.Add(Q28);

            var Q29 = new Questao();
            Q29.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q29.Pergunta = "Qual é a maior cadeia montanhosa do mundo?";
            Q29.Resposta1 = "Andes";
            Q29.Resposta2 = "Himalaia";
            Q29.Resposta3 = "Rocosos";
            Q29.Resposta4 = "Alpes";
            Q29.Resposta5 = "Apalaches";
            Q29.Respostacorreta = 2;
            ListaQuestoes.Add(Q29);

            var Q30 = new Questao();
            Q30.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q30.Pergunta = "Qual é o maior planeta do Sistema Solar?";
            Q30.Resposta1 = "Terra";
            Q30.Resposta2 = "Marte";
            Q30.Resposta3 = "Júpiter";
            Q30.Resposta4 = "Saturno";
            Q30.Resposta5 = "Netuno";
            Q30.Respostacorreta = 3;
            ListaQuestoes.Add(Q30);





        }
        public async void VerificaCorreta(int RR)
        {
            if (QuestaoCorrente.VerificaResposta(RR))
            {
                await Task.Delay(1000);
                AdicionaPontuacao(NivelAtual);
                NivelAtual++;
                ProximaQuestao();
                labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
                labelNivel.Text = "Nível:" + NivelAtual.ToString();

                if (NivelAtual >= 10)
                {
                    await App.Current.MainPage.DisplayAlert("Você ganhou!", "Parabéns", "Ok");
                    Inicializar();
                }
            }

            else
            {
                await App.Current.MainPage.DisplayAlert("Fim", "Você errou!", "Ok");
                Inicializar();


            }

        }

       public void ProximaQuestao()
        {
            var numAleat = Random.Shared.Next(0, ListaQuestoes.Count - 1);
            while (ListaQuestoesRespondidas.Contains(numAleat))
                numAleat = Random.Shared.Next(0, ListaQuestoes.Count - 1);
            ListaQuestoesRespondidas.Add(numAleat);
            QuestaoCorrente = ListaQuestoes[numAleat];
            QuestaoCorrente.Desenhar();
        }

        public int Pontuacao { get; private set; }
        int NivelAtual = 0;
        void Inicializar()
        {
            Pontuacao = 0;
            NivelAtual = 1;
            ProximaQuestao();
            labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
            labelNivel.Text = "Nível:" + NivelAtual.ToString();
        }

        void AdicionaPontuacao(int n)
        {
            if (n == 1)
                Pontuacao = 1000;

            else if (n == 2)
                Pontuacao = 2000;

            else if (n == 3)
                Pontuacao = 5000;

            else if (n == 4)
                Pontuacao = 10000;

            else if (n == 5)
                Pontuacao = 20000;

            else if (n == 6)
                Pontuacao = 50000;

            else if (n == 7)
                Pontuacao = 100000;

            else if (n == 8)
                Pontuacao = 200000;

            else if (n == 9)
                Pontuacao = 500000;

            else Pontuacao = 1000000;

        }

    }
}