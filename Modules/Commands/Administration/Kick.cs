using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace IllyaBot.Modules.Commands.Administration
{
    public class Kick : ModuleBase<SocketCommandContext>
    {
        private SocketCommandContext _context;
        private SocketGuildUser _mention;
        private SocketGuildUser _user;
        private string _userName;
        public Kick(SocketCommandContext context, SocketGuildUser mention)
        {
            this._context = context;
            this._mention = mention;
        }


        public async Task KickS()
        {
            _user = this._context.User as SocketGuildUser;

            if (!_user.IsBot)
            {


                if (_user.GuildPermissions.KickMembers)
                {              
                    if (!_mention.GuildPermissions.Administrator)
                    {
                        await _mention.KickAsync();
                        await this._context.Channel.SendMessageAsync(string.Join(" ", _mention) + " was kicked");
                    }
                    else
                    {
                        await this._context.Channel.SendMessageAsync("U can not kick a user with administation rights");
                    }
                }
                else
                {
                    await this._context.Channel.SendMessageAsync("U do not have the permissions to kick a user!");
                }
            }
            else
            {
                await this._context.Channel.SendMessageAsync("As a bot u can not kick a user!");
            }
 
        }
        
    }
}