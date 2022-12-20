using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Misuiro.Kirill
{
    class ATM
    {
        uint count20;
        uint count50;
        uint count100;

        public ATM(uint count20, uint count50, uint count100)
        {
            this.count20 = count20;
            this.count50 = count50;
            this.count100 = count100;
        }

        public void AddMoney(uint count20, uint count50, uint count100)
        {
            this.count20 += count20;
            this.count50 += count50;
            this.count100 += count100;
        }

        public bool RemoveMoney(uint cashout)
        {
            uint moneyInATM = MoneyInAtm();
            if (cashout > moneyInATM || cashout % 10 != 0)
            {
                return false;
            }
            uint cashoutCount100;
            uint cashoutCount50;
            uint cashoutCount20;
            if (cashout / 100 > count100)
            {

                cashoutCount100 = count100;
                count100 = 0;
                cashout -= cashoutCount100 * 100;
            }
            else
            {
                cashoutCount100 = cashout / 100;
                count100 -= cashoutCount100;
                cashout %= 100;
            }
            if (cashout / 50 > count50 && (cashout - count50 * 50) % 20 == 0)
            {
                cashoutCount50 = count50;
                count50 = 0;
                cashout -= cashoutCount50 * 50;
            }
            else
            {
                cashoutCount50 = cashout / 50 - 1;
                count50 -= cashoutCount50;
                cashout %= 50 + 50;
            }
            if (cashout / 20 > count20)
            {

                cashoutCount20 = count20;
                count20 = 0;
                cashout -= cashoutCount20 * 20;
            }
            else
            {
                cashoutCount20 = cashout / 20;
                count20 -= cashoutCount20;
                cashout %= 20;
            }
            Console.WriteLine("Number of 100 denomination bills = {0}", cashoutCount100);
            Console.WriteLine("Number of 50 denomination bills = {0}", cashoutCount50);
            Console.WriteLine("Number of 20 denomination bills = {0}", cashoutCount20);
            return true;
        }

        public uint MoneyInAtm()
        {
            return count100 * 100 + count50 * 50 + count20 * 20;
        }
    }
}
