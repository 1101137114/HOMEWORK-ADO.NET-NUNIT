using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cal
    {
        public enum CurrencySelect
        {
            JPY = 0,//日幣
            TWD = 1//台幣
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Age"></param>
        /// <param name="format"</param>
        /// <returns></returns>
        public int GetResult(int USD, CurrencySelect Select)
        {
            if (Select == CurrencySelect.JPY)
                return (USD * 120);
            else if (Select == CurrencySelect.TWD)
                return (USD * 30);

            return 0;
        }
    }
}
