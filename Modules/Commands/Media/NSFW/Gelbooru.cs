using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using Discord.Commands;
using System.Threading.Tasks;
using System.Xml;
using Discord.Commands;
using Discord.WebSocket;

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
            
                int _randomUrl = _random.Next(0, 100);

                string[] url;
                XmlDocument _xmlDocument = new XmlDocument();
                _xmlDocument.Load("https://gelbooru.com/index.php?page=dapi&s=post&q=index&tags=" + _param);

                XmlNodeList elemlist = _xmlDocument.GetElementsByTagName("post");

                string attrval = elemlist[_randomUrl].Attributes["file_url"].Value;

                await _context.Channel.SendMessageAsync(attrval);
                
        }

 
    }
}