using System.Threading.Tasks;
using Discord.Commands;

namespace IllyaBot.Modules.Commands.Administration
{
    public class Mute : ModuleBase<SocketCommandContext>
    {
        private SocketCommandContext _context;
        private string[] _mention;
        public Mute(SocketCommandContext context, string[] mention)
        {
            this._context = context;
            this._mention = mention;
        }

        public async Task MuteS()
        {
                
        }
        
    }
}