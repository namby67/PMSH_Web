using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace Miscellaneous.Hubs
{
    public class TagScanHub : Hub
    {
        public async Task SendCode(string code)
        {
            await Clients.All.SendAsync("ReceiveCode", code);
        }
    }
}
