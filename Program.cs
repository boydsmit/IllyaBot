using System;
using System.Runtime.Remoting.Channels;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;
using Discord.Commands;


namespace IllyaBot
{
    public class Program
    {
        private Key _botKey = new Key();
        
        static void Main(string[] args) =>  new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public void CommandWithArgs()
        {
            
        }

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            new CommandHandler();

            await _client.LoginAsync(TokenType.Bot, _botKey._key);

            await _client.StartAsync();

            await _client.SetGameAsync("Use t#help for commands!");

            _handler = new CommandHandler();

            await _handler.InitializeAsync(_client);

            await Task.Delay(-1);

 

        }
    }
}
