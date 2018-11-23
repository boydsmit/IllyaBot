using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace IllyaBot.Modules.Commands.Administration
{
    public class Ban : ModuleBase<SocketCommandContext>
    {
        private SocketCommandContext _context;
        private SocketGuildUser _mention;
        private SocketGuildUser _user;
        public Ban(SocketCommandContext context, SocketGuildUser mention)
        {
            this._context = context;
            this._mention = mention;
        }

        public async Task BanS()
        {
            _user = this._context.User as SocketGuildUser;

            if (!_user.IsBot)
            {


                if (_user.GuildPermissions.BanMembers)
                {              
                    if (!_mention.GuildPermissions.Administrator)
                    {
                        await this._context.Guild.AddBanAsync(_mention);
                        await this._context.Channel.SendMessageAsync(string.Join(" ", _mention) + " was ***BANNED*** from the server");
                    }
                    else
                    {
                        await this._context.Channel.SendMessageAsync("U can not ban a user with administation rights");
                    }
                }
                else
                {
                    await this._context.Channel.SendMessageAsync("U do not have the permissions to ban a user!");
                }
            }
            else
            {
                await this._context.Channel.SendMessageAsync("As a bot u can not ban a user!");
            }
        }
        
    }
}