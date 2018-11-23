using System;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace IllyaBot.Modules.Commands.Text
{
    public class Help : ModuleBase<SocketCommandContext>
    {
        private SocketCommandContext _context;
        public Help(SocketCommandContext context)
        {
            this._context = context;
        }

        public async Task HelpS()
        {
            var builder = new EmbedBuilder();
            builder.WithTitle("These are all my commands");
            builder.WithAuthor("IllyaBot", "https://avatarfiles.alphacoders.com/119/119138.png");

            //Gamling field
            builder.AddInlineField 
                (
                "Gambling",
                "```css" + Environment.NewLine +
                "t#dice         [nr 1] [nr 2]" + Environment.NewLine +
                "t#coinflip     []```"
                );

            //Media field
            builder.AddInlineField
                (
                "Media",
                "```css" + Environment.NewLine +
                "t#slap         [user]" + Environment.NewLine +
                "t#hug          [user]" + Environment.NewLine +
                "t#kiss         [user]" + Environment.NewLine +
                "t#pat          [user]" + Environment.NewLine +
                "t#giphy        [input]```"
                );

            //Text field
            builder.AddInlineField
                (
                "Text",
                "```css" + Environment.NewLine +
                "t#copy         [input]```"
                );

            //Misc field
            builder.AddInlineField
                (
                "Misc",
                "```css" + Environment.NewLine +
                "t#about        []" + Environment.NewLine +
                "t#invite       []```"
                );  
            
            //Administrations field
            builder.AddInlineField
             (
                "Administration",
                "```css" + Environment.NewLine +
                "t#kick        [user]" + Environment.NewLine +
                "t#ban         [user]" + Environment.NewLine +
                "t#unban       [UserID]```"
             );
            builder.WithFooter("Send command using t#<command>     Example: t#invite");
            builder.WithColor(Color.Purple);
            await this._context.Channel.SendMessageAsync(" ", false, builder);


        }
    }
}
