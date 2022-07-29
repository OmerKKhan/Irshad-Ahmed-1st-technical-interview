using System;
using System.Collections.Generic;
//Task#1
// You are given a function which takes an array of integers "seq" and an integer "target". There exist two elements of the array whose sum is equal to the target. You can assume that there exists only one solution. You have to return the indices of those elements
// [1,9,2,19]  Target = 3, Answer = 0,2

// [2,4]  Target = 6, Answer =0,1

class Program {
  public static void Main (string[] args) {
    int [] seq = new [] {1,9,2,19}; //target=10
    //[1,2,9,11,19]
    int target = 3;
    var result = GetIndices(seq, target);
    Console.WriteLine(result[0] +","+ result[1]);
  }

  public static int [] GetIndices(int [] seq, int target)
  {
    int[] values =new int[2];
    for(int i = 0; i< seq.Length; i++) {
        for(int k = 0; k<seq.Length;k++) {
          //target - seq[i] == seq[k]
          if(seq[i]+seq[k] == target)
          {
            values[0] = i;
            values[1]= k;
            return values;
          }
        }
    }
    return null;
  }
  //O(n^2)

//Task#2
// Given an integer x, return true if x is palindrome integer.

// An integer is a palindrome when it reads the same backward as forward.

// For example, 121 is a palindrome while 123 is not.
 

// Example 1:
// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.

// Example 2:
// Input: x = 10
// Output: false
// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

// Example 3:
// Input: x = 234
  
// Output: false
// Explanation: Reads 432 from right to left. Therefore it is not a palindrome.  
  public static bool IsPalindrome(int num)
  {
    var values = num.ToString().ToCharArray();
      var a = values[0] * 100;
      var b = values[1] * 10;
      var c = values[2] * 1;
      var result = a+b+c;
      return (num==result);
       
  }
  
}