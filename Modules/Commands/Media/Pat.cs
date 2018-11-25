using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace IllyaBot.Modules.Commands.Media
{
    class Pat : ModuleBase<SocketCommandContext>
    {
        Random random = new Random();
        string[] pat =
        {
            "https://cdn.discordapp.com/attachments/432638505370517514/434282498927886356/47559b2b3ead8eed3fcc768ab1684aa873a97b7c_hq.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434283018346037258/eOJlnwP.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434283040353812490/eUKM3Ay.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434283056539631626/LRDanyb.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434283072251494400/source.gif",
            "https://cdn.discordapp.com/attachments/432638505370517514/434283093780856832/giphy.gif"
         };

        private SocketCommandContext _context;
        private string[] _mention;
        public Pat(SocketCommandContext context, string[] mention)
        {
            this._context = context;
            this._mention = mention;
        }

        public async Task PatS()
        {
            var builder = new EmbedBuilder();

            int randomPatIndex = random.Next(pat.Length);
            string PatToPost = pat[randomPatIndex];
            //await this._context.Channel.SendMessageAsync(String.Join(" ", _mention) + "got a pat " + Environment.NewLine + PatToPost);

            builder.WithDescription(String.Join(" ", _mention) + "**you got a pat** ");
            builder.WithImageUrl(PatToPost);
            builder.WithColor(Color.Purple);
            await this._context.Channel.SendMessageAsync(" ", false, builder);
        }
    }
}
