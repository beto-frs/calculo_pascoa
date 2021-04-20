using System;

namespace calculo_pascoa
{
    class Pascoa

    {
        static void Main(string[] args)
        {
            int Ano;
            string dAno;
            Console.WriteLine("Digite o ano: ");
            dAno = Console.ReadLine();
            Console.Clear();
            try{
                Ano = Int32.Parse(dAno);
                int a, b, c, d, e, f, g, h, i, k, l, m, mes, dia;
                a = (Ano % 19);
                b = (Ano / 100);
                c = (Ano % 100);
                d = ( b / 4 );
                e = ( b % 4 );
                f = (( b + 8) / 25 );
                g = (( b - f + 1) / 3 );
                h = (( 19 * a + b - d - g + 15) % 30 );
                i = ( c / 4);
                k = ( c % 4 );
                l = (( 32 + 2 * e + 2 * i - h - k ) % 7 );
                m = (( a + 11 * h + 22 * l  )/ 451);
                mes = (( h + 1 - 7 * m + 114) / 31 );
                dia = ( 1 + ( h + l - 7 * m + 114) % 31 );
                string data = (dia+"/"+mes+"/"+Ano);
                DateTime datac = DateTime.Parse(data);
                DateTime paixao, cinzas, carnaval, corpus;
                paixao = datac.AddDays(-2);
                cinzas = datac.AddDays(-39);
                carnaval = datac.AddDays(-40);
                corpus = datac.AddDays(+60);
                Console.Write(carnaval.ToString("dd / MM / yyyy") + " - Terça-Feira de Carnaval\n\n" + cinzas.ToString("dd / MM / yyyy") + " - Quarta-Feira de Cinzas\n\n" + paixao.ToString("dd / MM / yyyy") + " - Sexta-Feira da Paixão\n\n" + datac.ToString("dd / MM / yyyy")+" - Domingo de Páscoa\n\n" + corpus.ToString("dd / MM / yyyy")+ " - Corpus Christi");
                Console.ReadLine();

            }
            catch (FormatException){
                Console.WriteLine("Parametros incorretos! Digite apenas números...");

            }
        }
    }
}
