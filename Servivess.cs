using Kurt_sParking;

namespace Parkingg
{
    public class Servivess
    {
        public bool VerifyAccount(string accountNumber)
        {

            ParkingDataServices dataService = new ParkingDataServices();
            var result = dataService.GetAccount(accountNumber);

            return result.accountNumber != null ? true : false;
        }
        public bool VerifyPassword(string accountPassword)
        {

            ParkingDataServices dataService = new ParkingDataServices();
            var result = dataService.GetAccount(accountPassword);

            return result.accountNumber != null ? true : false;
        }
    }
}