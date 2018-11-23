using System;
using System.Threading.Tasks;
using Discord.Commands;
using GiphyDotNet.Model.Parameters;
using GiphyDotNet.Manager;
using Discord;

namespace IllyaBot.Modules.Commands.Media
{
    

    class Hug : ModuleBase<SocketCommandContext>
    {
        


        Random random = new Random();
        string[] hug =
        {
            "https://cdn.discordapp.com/attachments/432638505370517514/434283991302930432/tenor-1.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434284009091235841/tenor-5.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434284020856258560/bXDgV.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434284036538761216/tenor-4.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434284048223830027/tenor-3.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434284094826872832/tenor-2.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434284114409947136/zE7XE.gif"
         };

        private SocketCommandContext _context;
        private string[] _mention;

        public Hug(SocketCommandContext context, string[] mention)
        {
            this._context = context;
            this._mention = mention;
        }

        public async Task HugS()
        {
            var builder = new EmbedBuilder();

            int randomHugIndex = random.Next(hug.Length);
            string HugToPost = hug[randomHugIndex];

            builder.WithDescription(String.Join(" ", _mention) +" **got a hug**");
            builder.WithImageUrl(HugToPost);
            builder.WithColor(Color.Purple);
            await this._context.Channel.SendMessageAsync(" ", false, builder);
        }
    }
}
