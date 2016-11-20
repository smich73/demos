using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Threading.Tasks;

namespace BotStockDemo2
{
    [LuisModel("fa524414-012e-4813-801e-3c8f303ecc68", "b3cbf914a8414205a40c99172686c62d")]
    [Serializable]
    public class StockDialog : LuisDialog<object>
    {
        [LuisIntent("StockPrice")]
        public async Task StockPrice(IDialogContext context, LuisResult result)
        {
            string strRet = result.Entities[0].Entity;

            //store this stock for the conversation
            context.ConversationData.SetValue<string>("LastStock", strRet);

            await context.PostAsync(await Yahoo.GetStock(strRet));
            context.Wait(MessageReceived);
        }

        [LuisIntent("RepeatLastStock")]
        public async Task RepeatLastStock(IDialogContext context, LuisResult result)
        {
            string strRet = string.Empty;
            string strStock = string.Empty;
            if (!context.ConversationData.TryGetValue("LastStock", out strStock))
            {
                strRet = "I don't have a previous stock to look up!";
            }
            else
            {
                strRet = await Yahoo.GetStock(strStock);
            }
            await context.PostAsync(strRet);
            context.Wait(MessageReceived);
        }

        [LuisIntent("None")]
        public async Task NoneHandler(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I'm sorry, I don't understand");
            context.Wait(MessageReceived);
        }
    }
}