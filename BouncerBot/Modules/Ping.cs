using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BouncerBot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Welcome,")
                .WithDescription("Make sure you've read the rules.")
                .WithColor(Color.Red);

            await ReplyAsync("", false, builder.Build());
        }

        [Command("hello again!")]
        public async Task PingAsync2()
        {
            await ReplyAsync("Welcome back, come on in.");
        }

        [Command("fight")]
        public async Task PingAsync3(string name)
        {
            await ReplyAsync($"{name} is no match for me.");
        }

        [Command("lets fight")]
        public async Task PingAsync4()
        {
            await ReplyAsync("You *really* don't want to do that.");
        }

        [Command("say")]
        public async Task PingAsync5([Remainder]string stuffToSay)
        {
            await ReplyAsync(stuffToSay);
        }

        [Command("bhelp")]
        public async Task PingAsync6()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Overview:", "List of Bouncer's commands and prefix(es):")
                .AddInlineField("Prefix(es):", "'.'")
                .AddInlineField("Commands:", "hello    hello again!    fight (username)    lets fight     say (whatever you want bouncer to say)")
                .WithColor(Color.Gold);
            
            await ReplyAsync("", false, builder.Build());
        }
    }
}
