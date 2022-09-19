using System.Security.Cryptography.X509Certificates;
namespace TaskTimeSheet.Models.ViewModels
{
    public class HomeViewModel
    {
        private readonly LastFiveDaysList lastFiveDaysList;

        public HomeViewModel()
        {
            lastFiveDaysList = new LastFiveDaysList();
        }
    }
}