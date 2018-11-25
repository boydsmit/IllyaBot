using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace IllyaBot.Modules.Commands.Gambling
{
    class CoinFlip : ModuleBase<SocketCommandContext>
    {
        private Random _random = new Random();

        private SocketCommandContext _context;

        public CoinFlip(SocketCommandContext context)
        {
            this._context = context;
        }

        public async Task CoinFlipS()
        {
            int CoinSide = _random.Next(1,3);
            if(CoinSide == 1)
            {
                await this._context.Channel.SendMessageAsync("The coin landed on ***tails***!");
            }
            else if(CoinSide == 2)
            {
                await this._context.Channel.SendMessageAsync("The coint landed on ***Heads***!");
            }
        
        }
    }
}
