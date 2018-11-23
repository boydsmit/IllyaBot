using System.Threading.Tasks;
using Discord.Commands;

namespace IllyaBot.Modules.Commands.Text
{
    class Invite : ModuleBase<SocketCommandContext>
    {
        private SocketCommandContext _context;
        public Invite(SocketCommandContext context)
        {
            this._context = context; 
        }

        public async Task InviteS()
        {
            await this._context.Channel.SendMessageAsync("This is my invite link: https://discordapp.com/api/oauth2/authorize?client_id=440127970187673600&permissions=2146958839&scope=bot");
        }
    }
}
