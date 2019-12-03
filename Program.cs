using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpProj
{
    class Program
    {
        static void Main(string[] args)
        {
            long twoPassTime = 0;
            long twoLoopTime = 0;
            long singlePassTime = 0;
            long maxAreaTime = 0;
            int loop = 100;

            for(int i = 0; i <= loop; i++) {
            long[] time = TestArray.TestTwoSum();
            if(i > 2) {
            twoPassTime = twoPassTime + time[0];
            twoLoopTime = twoLoopTime + time[1];
            singlePassTime = singlePassTime + time[2];
            }
            }
            Console.WriteLine("Average Runtime\n TwoPass: {0}, TwoLoop: {1}, SinglePass: {2}",
            twoPassTime / loop - 2, twoLoopTime / loop - 2, singlePassTime / loop - 2);

            for(int i = 0; i <= loop; i++) {
            long[] time = TestArray.TestMaxArea();
            if (i > 2) {
            maxAreaTime = maxAreaTime + time[0];
            }
            }
            Console.WriteLine("Average Runtime: {0}", maxAreaTime / loop - 2);

        }

    }
}
