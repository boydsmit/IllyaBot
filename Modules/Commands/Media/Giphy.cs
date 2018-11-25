using System.Threading.Tasks;
using Discord.Commands;
using GiphyDotNet.Model.Parameters;
using Discord;

namespace IllyaBot.Modules.Commands.Media
{
    public class Giphy : ModuleBase<SocketCommandContext>
    {

        private SocketCommandContext _context;
        private string[] _param;

        public Giphy(SocketCommandContext context, string[] param)
        {
            this._context = context;
            this._param = param;
        }

        public async Task RandomGifS()
        {

            var giphy = new GiphyDotNet.Manager.Giphy("0fc5a4774af94bf796261a8d686e7be5");
            var gifresult = await giphy.RandomGif(new RandomParameter()
            {
                Tag = string.Join(" ", _param)
            });
            //await this._context.Channel.SendMessageAsync(gifresult.Data.Url);

            var builder = new EmbedBuilder();


            builder.WithDescription("**Here is your random gif!**");
            builder.WithImageUrl(gifresult.Data.Url);
            builder.WithColor(Color.Purple);
            await this._context.Channel.SendMessageAsync(" ", false, builder);

        }
    }   
}
