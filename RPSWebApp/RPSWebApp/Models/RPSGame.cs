using RPSWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSWebApp
{
    public class RPSGame
    {
        private Random rand = new Random();

        private int lossTurns = 0;

        public GameOver PlayGame(Player user)
        {
            Player computer = new Player();
            
            //get random number and set computer choice
            int compChoice = rand.Next(1,4);
            switch(compChoice)
            {
                case 0:
                    computer.Choice = Choice.rock;
                    break;
                case 1:
                    computer.Choice = Choice.paper;
                    break;
                case 2:
                    computer.Choice = Choice.scissors;
                    break;
            }

            if (user.Choice == computer.Choice)
            {
                user.Result = GameResult.tie;
                lossTurns++;
            }
            else if(user.Choice == Choice.rock && computer.Choice == Choice.paper)
            {
                computer.Result = GameResult.win;
                user.Result = GameResult.loss;
                lossTurns++;
            }
            else if (user.Choice == Choice.rock && computer.Choice == Choice.scissors)
            {
                computer.Result = GameResult.loss;
                user.Result = GameResult.win;
                lossTurns = 0;

            }
            else if (user.Choice == Choice.paper && computer.Choice == Choice.rock)
            {
                computer.Result = GameResult.loss;
                user.Result = GameResult.win;
                lossTurns = 0;
            }
            else if (user.Choice == Choice.paper && computer.Choice == Choice.scissors)
            {
                computer.Result = GameResult.win;
                user.Result = GameResult.loss;
                lossTurns++;
            }
            else if (user.Choice == Choice.scissors && computer.Choice == Choice.rock)
            {
                computer.Result = GameResult.win;
                user.Result = GameResult.loss;
                lossTurns++;
            }
            else if (user.Choice == Choice.scissors && computer.Choice == Choice.paper)
            {
                computer.Result = GameResult.loss;
                user.Result = GameResult.win;
                lossTurns = 0;
            }

            GameOver game = new GameOver
            {
                Computer = computer,
                User = user,
                Turns = lossTurns
            };

            return game;
        }
    }
}
