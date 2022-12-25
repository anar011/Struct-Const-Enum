using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {


        public int GetSumNumbersArray(int[] numbers)
        {
            int sum = 1;

            foreach (int item in numbers)

                if (item < 20)
                {
                    sum *= item;
                }

            return sum;


        }

        int ICalculateService.GetSumMultiplyAray(int[] numbers)
        {

            int sum = 0;
            foreach(int item in numbers)

            {
                if (item % 2 == 0)
                {
                    sum += item;
                }

            }
            return sum*sum;


        }


    }
}
