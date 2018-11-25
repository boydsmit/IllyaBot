using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;
using IllyaBot.Modules.Commands.Administration;
using IllyaBot.Modules.Commands.Gambling;
using IllyaBot.Modules.Commands.Media;
using IllyaBot.Modules.Commands.Media.NSFW;
using IllyaBot.Modules.Commands.Text;

namespace IllyaBot.Modules
{
    public class CommandIn : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        [Summary("Gives all the available commands")]
        public async Task Help()
        {
            Help help = new Help(Context);
            await help.HelpS();
        }

        [Command("about")]
        [Summary("Gives IllyaBot's current version")]
        public async Task About()
        {
            About about = new About(Context);
            await about.AboutS();
        }

        [Command("slap")]
        [Summary("Gives a random slap gif")]
        public async Task Slap(params string[] mention)
        {
            Slap slap = new Slap(Context,mention);
            await slap.SlapS();
        }

        [Command("invite")]
        [Summary("Gives the invite link of IllyaBot")]
        public async Task Invite()
        {
            Invite invite = new Invite(Context);
            await invite.InviteS();
        }
        
        [Command("hug")]
        [Summary("Gives a random hug gif")]
        public async Task Hug(params string[] mention)
        {
            Hug hug = new Hug(Context, mention);
            await hug.HugS();
        }

        [Command("copy")]
        [Summary("Copies ur message")]
        public async Task Copy(params string[] text)
        {            
            Copy copy = new Copy(Context, text);        
            await copy.CopyS();
        }

        [Command("pat")]
        [Summary("Gives a random pat gif")]
        public async Task Pat(params string[] mention)
        {
            Pat pat = new Pat(Context, mention);
            await pat.PatS();
        }

        [Command("kiss")]
        [Summary("Gives a random kiss gif")]
        public async Task Kiss(params string[] mention)
        {
            Kiss kiss = new Kiss(Context, mention);
            await kiss.KissS();
        }

        [Command("giphy")]
        [Summary("Sends a gif from Giphy by the given parameter")]
        public async Task RandomGif(params string[] param)
        {
            Giphy giphy = new Giphy(Context, param);
            await giphy.RandomGifS();
        }

        [Command("coinFlip")]
        [Summary("Flips a coin landing on tails or heads")]
        public async Task CoinFlip()
        {
            CoinFlip coinFlip = new CoinFlip(Context);
            await coinFlip.CoinFlipS();
        }

        [Command("dice")]
        [Summary("Gets a random number from user input or from 1 - 6")]
        public async Task Dice(params string[] numbers)
        {
            Dice dice = new Dice(Context, numbers);
            await dice.DiceS();
        }
        
        
        [Command("Kick")]
        [Summary("Kicks the specified user")]
        public async Task Kick(SocketGuildUser mention)
        {
            Kick kick = new Kick(Context, mention);
            await kick.KickS();
        }
        
             
        [Command("Ban")]
        [Summary("Bans the specified user")]
        public async Task Ban(SocketGuildUser mention)
        {
            Ban ban = new Ban(Context, mention);
            await ban.BanS();
        }
        
        [Command("Unban")]
        [Summary("Bans the specified user")]
        public async Task UnBan(params string[] mention)
        {
            Unban unban = new Unban(Context, mention);
            await unban.UnbanS();
        }

        [Command("Mute")]
        [Summary("Mutes the specified user")]
        public async Task Mute(params string[] mention)
        {
            Mute mute = new Mute(Context, mention);
            await mute.MuteS();
        }
        
        [Command("Gelbooru")]
        [Summary("Mutes the specified user")]
        public async Task Gelbooru(params string[] param)
        {
            if (param.Length != 0)
            {
                Gelbooru gelbooru = new Gelbooru(Context, param);
                await gelbooru.GelbooruS();
            }
            else
            {
                await Context.Channel.SendMessageAsync("Please specify a tag!");
            }

        }
    }
}
