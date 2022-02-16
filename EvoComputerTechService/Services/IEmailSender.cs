using EvoComputerTechService.Models;
using System.Threading.Tasks;

namespace EvoComputerTechService.Services
{
    public interface IEmailSender
    {
        Task SendAsync(EmailMessage message);
    }
}
