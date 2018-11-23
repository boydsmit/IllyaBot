using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace IllyaBot.Modules.Commands.Text
{
    class Copy : ModuleBase<SocketCommandContext>
    {
        private SocketCommandContext _context;
        private string[] _text;
        public Copy(SocketCommandContext context, string[] text)
        {          
            this._context = context;
            this._text = text;
        }

        public async Task CopyS()
        {
            await this._context.Channel.SendMessageAsync(string.Join(" ", _text));
        }
    }
}
