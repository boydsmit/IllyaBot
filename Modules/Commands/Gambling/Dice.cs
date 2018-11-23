using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace IllyaBot.Modules.Commands.Gambling
{
    class Dice : ModuleBase<SocketCommandContext>
    {
        private Random _random = new Random();

        private SocketCommandContext _context;

        private string[] _numbers;
        private string _temp;
        private string[] _separator;

        private string _number1;
        private string _number2;

        public Dice(SocketCommandContext context, string[] numbers)
        {
            this._context = context;
            this._numbers = numbers;
        }

        public async Task DiceS()
        {
            if (_numbers.Length == 0)
            {
                _number1 = "1";
                _number2 = "6";
            }

            else
            {
                _temp = string.Join(" ", _numbers);
                _separator = _temp.Split(' ');
                _number1 = _separator[0];
                _number2 = _separator[1];
            }

            await this._context.Channel.SendMessageAsync("The dice landed on: " + _random.Next(Convert.ToInt32(_number1), Convert.ToInt32(_number2)));
        }
    }
}