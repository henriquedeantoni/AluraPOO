﻿using AluraPOO.Models;

namespace AluraPOO.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeCaracteres = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeCaracteres, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
    
}
