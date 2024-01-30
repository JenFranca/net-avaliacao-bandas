﻿using System;

namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(Banda banda, string nome)
        => (Artista, Nome) = (banda, nome);

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }


    public string DescricaoResumida =>  //lambda, quando é algo que queremos apenas mostrar 'get'
        $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}