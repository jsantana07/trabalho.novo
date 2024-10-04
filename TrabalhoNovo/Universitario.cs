using TrabalhoNovo;

public class Universitario : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;
        for (int i = 0; i < 5; i ++ )
        {
            int numRand = 0;
            if (porcentagem > 0)
            {
                numRand = Random.Shared.Next(0, porcentagem);
                porcentagem -= numRand;
            }
            switch (i)
            {
                case 0:
                    ButtonResposta1.Text += "=" + numRand.ToString() + "%";
                    break;

                case 1:
                    ButtonResposta2.Text += "=" + numRand.ToString() + "%";
                    break;

                case 2:
                    ButtonResposta3.Text += "=" + numRand.ToString() + "%";
                    break;

                case 3:
                    ButtonResposta4.Text += "=" + numRand.ToString() + "%";
                    break;

                case 4:
                    ButtonResposta5.Text += "=" + numRand.ToString() + "%";
                    break;

            }
        }
    }
}