using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Kurt_sParking
{
    public class ParkingDataServices
    {
        List<Model2> dummyAccount = new List<Model2>();

        public ParkingDataServices()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            Models defaultModel = new Models { value = 100, category = "new member rewards" };

            Model2 account1 = new Model2 { accountNumber = "Kingkurt89", accountPassword = "Kurtjerome11" };
            Model2 account2 = new Model2 { accountNumber = "AlisonBergerz11", accountPassword = "Kurtpogi" };
            Model2 account3 = new Model2 { accountNumber = "KyutsiJohn", accountPassword = "KurtGwapo" };

            dummyAccount.Add(account1);
            dummyAccount.Add(account2);
            dummyAccount.Add(account3);
        }

        public Model2 GetAccount(string accountNumber)
        {
            Model2 foundAccount = new Model2();

            foreach (var dummy in dummyAccount)
            {
                if (accountNumber == dummy.accountNumber)
                {
                    foundAccount = dummy; ;
                }
            }
            return foundAccount;
        }

        public Model2 GetPassword(string accountPassword)
        {
            Model2 foundAccount = new Model2();

            foreach (var dummy in dummyAccount)
            {
                if (accountPassword == dummy.accountPassword)
                {
                    foundAccount = dummy; ;
                }
            }
            return foundAccount;
        }



    }
}