using System.Threading.Tasks;
using Discord.Commands;

namespace IllyaBot.Modules.Commands.Text
{
    class About : ModuleBase<SocketCommandContext>
    {
        private SocketCommandContext _context;
        public About(SocketCommandContext context)
        {
            this._context = context;
        }

        public async Task AboutS()
        {
            await this._context.Channel.SendMessageAsync("I'm IllyaBot!! IllyaBot is now version: IllyaBot-A4.0.1");
        }
        
    }
}
