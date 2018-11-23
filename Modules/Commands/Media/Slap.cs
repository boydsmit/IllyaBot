using System;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace IllyaBot.Modules.Commands.Media
{
    class Slap : ModuleBase<SocketCommandContext>
    {
        Random random = new Random();
        string[] Slaps =
        {
                "http://pa1.narvii.com/6400/090445db917c22b460ea1fa1f3402d23ed78ef22_hq.gif",
                "http://i1.kym-cdn.com/photos/images/newsfeed/000/846/661/240.gif",
                "https://media.giphy.com/media/Zau0yrl17uzdK/giphy.gif",
                "https://media.giphy.com/media/jLeyZWgtwgr2U/giphy.gif",
                "https://s-media-cache-ak0.pinimg.com/originals/65/57/f6/6557f684d6ffcd3cd4558f695c6d8956.gif",
                "https://media.giphy.com/media/oL7evncYvZ9II/giphy.gif",
                "https://gifimage.net/wp-content/uploads/2017/07/anime-slap-gif-11.gif",
         };

        private SocketCommandContext _context;
        private string[] _mention;
        public Slap(SocketCommandContext context, string[] mention)
        {

            this._context = context;
            this._mention = mention;
        }

        public async Task SlapS()
        {
            int randomSlapIndex = random.Next(Slaps.Length);
            string SlapToPost = Slaps[randomSlapIndex];
            //await this._context.Channel.SendMessageAsync("Take that!! " + string.Join(" ", _mention) + Environment.NewLine + SlapToPost);

            var builder = new EmbedBuilder();

            builder.WithDescription("**Take that!!** " + string.Join(" ", _mention));
            builder.WithImageUrl(SlapToPost);
            builder.WithColor(Color.Purple);
            await this._context.Channel.SendMessageAsync(" ", false, builder);
        }
    }
}
