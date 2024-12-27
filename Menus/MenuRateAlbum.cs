using AluraPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraPOO.Menus
{
    internal class MenuRateAlbum : Menu
    {
        public override void Execute(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Execute(bandasRegistradas);
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                
                if (banda.Albums.Any(a => a.Title.Equals(tituloAlbum)))
                {
                    Album album = banda.Albums.First(a => a.Title.Equals(tituloAlbum));
                    Console.Write($"Qual a nota que o album {tituloAlbum} merece: ");
                    Rating rate = Rating.Parse(Console.ReadLine()!);

                    album.AddRating(rate);
                    Console.WriteLine($"\nA nota {rate.BandRating} foi registrada com sucesso para o album {tituloAlbum} da banda {nomeDaBanda}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nO album {tituloAlbum} não foi encontrado!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
    }
}
