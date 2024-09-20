namespace TrabalhoNovo
{
    public class Gerenciador
    {
        List<Questao> ListaQuestoes = new List<Questao>();
        List<int> ListaQuestoesRespondidas = new List<int>();
        Questao QuestaoCorrente;

        public Gerenciador(Label labelPerg, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)
        {
            CriaPerguntas(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);

        }
        void CriaPerguntas(Label labelPerg, Button buttonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4,Button ButtonResposta5)
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

            var Q2 = new Questao();
            Q2.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q2.Pergunta = "Qual é o maior país da América do Sul em extensão territorial?";
            Q2.Resposta1 = "Brasil";
            Q2.Resposta2 = "Argentina";
            Q2.Resposta3 = "Colômbia";
            Q2.Resposta4 = "Peru";
            Q2.Resposta5 = "Venezuela";
            Q2.Respostacorreta = 1;

            var Q3 = new Questao();
            Q3.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q3.Pergunta = "Qual planeta do Sistema Solar é conhecido como o Planeta Vermelho?";
            Q3.Resposta1 = "Vênus";
            Q3.Resposta2 = "Marte";
            Q3.Resposta3 = "Júpiter";
            Q3.Resposta4 = "Saturno";
            Q3.Resposta5 = "Urano";
            Q3.Respostacorreta = 2;

            var Q4 = new Questao();
            Q4.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q4.Pergunta = "Quem é o autor da obra 'Dom Quixote'?";
            Q4.Resposta1 = "William Shakespeare";
            Q4.Resposta2 = "Miguel de Cervantes";
            Q4.Resposta3 = "Fyodor Dostoyevsky";
            Q4.Resposta4 = "Victor Hugo";
            Q4.Resposta5 = "Charles Dickens";
            Q4.Respostacorreta = 2;

            var Q5 = new Questao();
            Q5.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q5.Pergunta = "Qual movimento artístico se caracteriza pelo uso de cores vibrantes, formas geométricas e a busca pela representação da realidade de forma abstrata?";
            Q5.Resposta1 = "Impressionismo";
            Q5.Resposta2 = "Realismo";
            Q5.Resposta3 = "Cubismo";
            Q5.Resposta4 = "Barroco";
            Q5.Resposta5 = "Romantismo";
            Q5.Respostacorreta = 3;

        }
            public async void VerificaCorreta (int rr)
            {
                if (QuestaoCorrente.VerificaResposta(rr))
                {
                    await Task.Delay(1000);
                    ProximaQuestao();
                }
            }

            void ProximaQuestao()
            {
                var numAleat=Random.Shared.Next(0,ListaQuestoes.Count);
                while (ListaQuestoesRespondidas.Contains(numAleat))
                numAleat=Random.Shared.Next(0,ListaQuestoes.Count);
                ListaQuestoesRespondidas.Add(numAleat);
                QuestaoCorrente=ListaQuestoes[numAleat];
                QuestaoCorrente.Desenhar();
            }

    }
}