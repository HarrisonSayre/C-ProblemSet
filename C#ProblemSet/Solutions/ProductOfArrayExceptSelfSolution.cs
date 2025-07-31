using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class ProductOfArrayExceptSelfSolution
{

    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] products = new int[nums.Length];
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];


        ////Do this to allow initial multiplication
        //prefix[0] = 1;
        //suffix[nums.Length-1] = 1;

        Array.Fill(products, 1);

        for (int i = 1; i < nums.Length; i++)
        {
            //prefix[i] = prefix[i-1] * nums[i-1];
            products[i] = products[i-1] * nums[i-1];
        }

        //for (int i = nums.Length - 2; i >= 0; i--)
        //{
        //    suffix[i] = suffix[i+1] * nums[i+1];
        //}

        //for (int i = 0; i<nums.Length; i++)
        //{
        //    products[i] = prefix[i] * suffix[i];
        //}

        int suffixInt = 1;
        for (int i = nums.Length -1; i >= 0; i--)
        {
            products[i] *= suffixInt;
            suffixInt *= nums[i];
            //suffix[i] = suffix[i + 1] * nums[i + 1];
        }


        return products;
    }
}
