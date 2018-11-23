using System;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace IllyaBot.Modules.Commands.Media
{
    class Kiss : ModuleBase<SocketCommandContext>
    {
        Random random = new Random();
        string[] kiss =
        {
                
         };

        private SocketCommandContext _context;
        private string[] _mention;

        public Kiss(SocketCommandContext context, string[] mention)
        {
            this._context = context;
            this._mention = mention;
        }

        public async Task KissS()
        {
            int randomKissIndex = random.Next(kiss.Length);
            string kissToPost = kiss[randomKissIndex];
            var builder =  new EmbedBuilder();
            
            //await this._context.Channel.SendMessageAsync("Awww " + String.Join(" ", _mention) + " " + "Got a kiss" + Environment.NewLine + KissToPost);

            builder.WithDescription(String.Join(" ", _mention) + " **got a kiss**");
            builder.WithImageUrl(kissToPost);
            builder.WithColor(Color.Purple);
            await this._context.Channel.SendMessageAsync(" ", false, builder);
        }
    }
}