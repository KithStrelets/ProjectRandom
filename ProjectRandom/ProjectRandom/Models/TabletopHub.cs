using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ProjectRandom.Models
{
    public class TabletopHub : Hub
    {
        public async Task Send(string clientData)
        {
            // ToDo: Detect clients to separate data (probably use Group)
            //       Check a CORS (Cross Origin Resource Sharing) pattern
            var separateData = clientData;
            await this.Clients.All.SendAsync("UpdateInfo", separateData);
        }
    }
}
