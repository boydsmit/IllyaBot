using System;
using Discord.Commands;
using System.Threading.Tasks;
using System.Xml;

namespace IllyaBot.Modules.Commands.Media.NSFW
{
    public class Gelbooru : ModuleBase<SocketCommandContext>
    {
        
        private Random _random = new Random();
        private SocketCommandContext _context;
        private string[] _param;
        public Gelbooru(SocketCommandContext context, string[] param)
        {
            this._context = context;
            this._param = param;
        }

        public async Task GelbooruS()
        {
            if (_context.Channel.IsNsfw)
            {


                int _randomUrl = _random.Next(0, 100);

                string[] url;
                XmlDocument _xmlDocument = new XmlDocument();
                _xmlDocument.Load("https://gelbooru.com/index.php?page=dapi&s=post&q=index&tags=" + _param);

                XmlNodeList elemlist = _xmlDocument.GetElementsByTagName("post");

                string attrval = elemlist[_randomUrl].Attributes["file_url"].Value;

                await _context.Channel.SendMessageAsync(attrval);
            }
            else
            {
                await _context.Channel.SendMessageAsync("This command can only be used in a NSFW channel!");
            }

        }

 
    }
}