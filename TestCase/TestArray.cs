using System;
using System.Diagnostics;
using System.Threading;

namespace CSharpProj
{
    class TestArray
    {
        public static long[] TestTwoSum(){
            int[] sums = new int[] {230,916,585,981,404,316,785,88,12,70,435,384,
            778,887,755,740,337,86,92,325,815,650,920,125,277,336,221,847,168,23,
            677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,314,
            422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,
            28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,
            538,427,583,368,375,173,809,896,789};
            int target = 542;
            int[] expectedOutput = new int[] {26, 43};
            int[] testOutput = new int[]{};
            long twoPassTime;
            long twoLoopTime;
            long singlePassTime;
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing TwoSumUsingTwoLoop");
            stopwatch.Restart();
            testOutput = Array.TwoSumUsingTwoLoop(sums, target);
            stopwatch.Stop();
            twoLoopTime = stopwatch.ElapsedTicks;
            if( testOutput[0] == expectedOutput[0] &&
                testOutput[1] == expectedOutput[1] ) {
                Console.WriteLine("Test Pass: [{0}, {1}] | Runtime: {2} ticks", 
                testOutput[0], testOutput[1], stopwatch.ElapsedTicks);
            } else {
                Console.WriteLine("Test Failed: Test Output [{0}, {1}] | Expected Output [{2}, {3}]", testOutput[0], testOutput[1], expectedOutput[0], expectedOutput[1]);
            }

            Console.WriteLine("Testing TwoSumTwoPass");
            stopwatch.Restart();
            testOutput = Array.TwoSumTwoPass(sums, target);
            stopwatch.Stop();
            twoPassTime = stopwatch.ElapsedTicks;
            if( testOutput[0] == expectedOutput[0] &&
                testOutput[1] == expectedOutput[1] ) {
                Console.WriteLine("Test Pass: [{0}, {1}] | Runtime: {2} ticks", 
                testOutput[0], testOutput[1], stopwatch.ElapsedTicks);
            } else {
                Console.WriteLine("Test Failed: Test Output [{0}, {1}] | Expected Output [{2}, {3}]", testOutput[0], testOutput[1], expectedOutput[0], expectedOutput[1]);
            }
            
            Console.WriteLine("Testing TwoSumSinglePass");
            stopwatch.Restart();
            testOutput = Array.TwoSumSinglePass(sums, target);
            stopwatch.Stop();
            singlePassTime = stopwatch.ElapsedTicks;
            if( testOutput[0] == expectedOutput[0] &&
                testOutput[1] == expectedOutput[1] ) {
                Console.WriteLine("Test Pass: [{0}, {1}] | Runtime: {2} ticks", 
                testOutput[0], testOutput[1], stopwatch.ElapsedTicks);
            } else {
                Console.WriteLine("Test Failed: Test Output [{0}, {1}] | Expected Output [{2}, {3}]", testOutput[0], testOutput[1], expectedOutput[0], expectedOutput[1]);
            }

            return new long[]{twoPassTime, twoLoopTime, singlePassTime};

        }

        public static long[] TestMaxArea() {
            int[] height = new int[]{5, 10, 15, 15, 10, 25, 5, 30};
            Console.WriteLine("Testing MaxArea");
            Stopwatch stopwatch = Stopwatch.StartNew();
            int maxArea = Array.MaxArea(height);
            stopwatch.Stop();
            Console.WriteLine("Test Output: {0} | Runtime: {1}", maxArea, stopwatch.ElapsedTicks);
            return new long[]{stopwatch.ElapsedTicks};

        }
        
    }
}