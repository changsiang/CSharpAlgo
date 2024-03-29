using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpProj
{
    class Array {
        public static int[] TwoSumUsingTwoLoop(int[] sums, int target) {
            for(int i = 0; i <= sums.Length - 1; i++) {
                int remainder = target - sums[i];
                for(int j = i + 1; j <= sums.Length -1; j++) {
                    if(sums[j] == remainder) {
                        return new int[] {i, j};
                    }

                }
            }
            throw new Exception("No Two Sum is found");
        }

        public static int[] TwoSumSinglePass(int[] sums, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i <= sums.Length - 1; i++) {
                int remainder = target - sums[i];
                if(dict.ContainsKey(remainder)) {
                    int j = dict.GetValueOrDefault(remainder);
                    return new int[] {j, i};
                }
                dict.Add(sums[i], i);
            }
            throw new Exception("No Two Sum is Found");
        }

        public static int[] TwoSumTwoPass(int[] sums, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i <= sums.Length - 1; i++) {
                dict.Add(sums[i], i);
            }
            for (int i = 0; i <= sums.Length - 1; i++) {
                int remainder = target - sums[i];
                if (dict.ContainsKey(remainder) && 
                dict.GetValueOrDefault(remainder) != i) {
                    int j = dict.GetValueOrDefault(remainder);
                    return new int[] {i , j};
                }
            }
            throw new Exception("No Two Sum is Found");
        }

        public static int MaxArea(int[] height) {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while(left < right) {
                maxArea = Math.Max(maxArea, 
                Math.Min(height[left], height[right]) * (right - left));
                if(height[left] < height[right]) {
                    left++;
                } else {
                    right--;
                }
            }
            return maxArea;
        }

        public static int[] ThreeSum(int[] nums) {
            System.Array.Sort(nums);
        }

    }
}
