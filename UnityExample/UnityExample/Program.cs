using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var unityContainer = new UnityContainer();

            // Register IGame so when dependecy is detected
            // it provides a TrivialPursuit instance
            unityContainer.RegisterType<IGame, TicTacToe>();

            // Instance a Table class object through Unity
            var game = unityContainer.Resolve<IGame>();

            game.AddPlayer();
            game.AddPlayer();
            Console.WriteLine(string.Format("{0} personas están jugando a {1}", game.CurrentPlayers, game.Name));
            Console.ReadLine();




        }
    }
}
