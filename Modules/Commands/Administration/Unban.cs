using System;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace IllyaBot.Modules.Commands.Administration
{
    public class Unban : ModuleBase<SocketCommandContext>
    {
        private SocketCommandContext _context;
        private string[] _mention;
        private string _userName;
        private SocketGuildUser _user;

        public Unban(SocketCommandContext context, string[] mention)
        {
            this._context = context;
            this._mention = mention;
        }

        public async Task UnbanS()
        {
            _user = this._context.User as SocketGuildUser;
            _userName = string.Join(" ", _mention);

            if (!_user.IsBot)
            {
                if (_user.GuildPermissions.BanMembers)
                {
                    await this._context.Guild.RemoveBanAsync(UInt64.Parse(_userName));
                    await this._context.Channel.SendMessageAsync("<@" + _userName + "> was unbanned from the server");
                }

                else
                {
                    await this._context.Channel.SendMessageAsync("U do not have the permissions to unban a user!");
                }
            }
            else
            {
                await this._context.Channel.SendMessageAsync("As a bot u can not unban a user!");
            }
        }
    }
}