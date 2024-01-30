namespace ScreenSound.Modelos;


//declarando uma class internal, apenas essa classe irá conseguir ver ela
internal class Avaliacao
{
    public Avaliacao (int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }


    public static Avaliacao Parse (string texto) //metodo estatico - podemos chamar esse metodo direto pelo titulo
    {
        int nota = int.Parse(texto); 
        return new Avaliacao (nota);
    }
}
//Os métodos estáticos são muito importantes e serão bastante utilizados em nossas carreiras como 
//pessoas desenvolvedoras.  Eles permitem a anexação de funções dentro de um tipo