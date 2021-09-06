using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Common_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter string 1");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Enter string 1");
            //string s2 = Console.ReadLine();
            //LongestCommonSubstring(s1, s2, s1.Length, s2.Length);


            //int[] arr = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            //Console.WriteLine("longest increasing subsequence is " + LengthOfLIS(arr));


            //Console.WriteLine(ModifyVariableName("thisIsAVariableIHave"));

            //stringFrequencyCount("phqgh");

            //Console.WriteLine(anagramChecker("LISTEN", "SILENP"));
            string test = "Hello how are you";
            //Console.WriteLine(reverseWords1(test));
            //Console.WriteLine(reverseWords2(test.ToCharArray())); 

            // RemoveChar("SCHOOL", 'O');

            // Console.WriteLine(NthPrimeNumber(1049));

            Pairs(4);



        }

        private static void Pairs(int n)
        {
            int count = 0;
            int[] Arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Arr[i] = i;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int hcf = gcd(Arr[i], Arr[j]);
                    if (hcf==1)
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine(count);
        }

        private static int gcd(int a, int b)
        {
            if (a==0)
            {
                return b;
            }
            if (b==0)
            {
                return a;
            }
            if (a==b)
            {
                return a;
            }
            if (a>b)
            {
                return gcd(a - b, b);
            }
            else
            {
                return gcd(a, b - a);
            }
        }

        protected static string ModifyVariableName(string input)

        {

            input = input.Trim();

            if (string.IsNullOrEmpty(input)) return input;

            String result = "";
            if (input.Contains('_'))
            {
                Console.WriteLine("c++");
                string[] strArr = input.Split('_');
                result = strArr[0];
                for (int i = 1; i < strArr.Length; i++)
                {
                    result += strArr[i].First().ToString().ToUpper() + strArr[i].Substring(1);
                }
            }
            else
            {
                Console.WriteLine("Java");
                char[] charArr = input.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (char.IsUpper(charArr[i]))
                    {
                        result += "_" + charArr[i].ToString().ToLower();

                    }
                    else
                    {
                        result += charArr[i];
                    }
                }

            }

            return result;

        }

        static void print2largest(int[] arr,
                          int arr_size)
        {
            int i;

            // There should be
            // atleast two elements
            if (arr_size < 2)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            // Sort the array
            Array.Sort(arr);

            // Start from second last element
            // as the largest element is at last
            for (i = arr_size - 2; i >= 0; i--)
            {

                // If the element is not
                // equal to largest element
                if (arr[i] != arr[arr_size - 1])
                {
                    Console.Write("The second largest " +
                                  "element is {0}\n", arr[i]);
                    return;
                }
            }
        }

        static void findMajority(int[] arr, int n)
        {
            int maxCount = 0;
            int index = -1; // sentinels
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }

                // update maxCount if count of
                // current element is greater
                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }
            }

            // if maxCount is greater than n/2
            // return the corresponding element
            if (maxCount > n / 2)
                Console.WriteLine(arr[index]);

            else
                Console.WriteLine("No Majority Element");
        }

        private static void LongestCommonSubstring(string s1, string s2, int length1, int length2)
        {
            int maxlen = 0;
            int endindex = 0;
            int[,] lookup = new int[length1 + 1, length2 + 1];
            for (int i = 1; i <= length1; i++)
            {
                for (int j = 1; j <= length2; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        lookup[i, j] = lookup[i - 1, j - 1] + 1;
                        //update maxlength and endindex
                        if (lookup[i, j] > maxlen)
                        {
                            maxlen = lookup[i, j];
                            endindex = i;
                        }

                    }
                }
            }
            Console.WriteLine(maxlen);
            Console.WriteLine(s1.Substring(endindex - maxlen, maxlen));


        }

        static void stringFrequencyCount(string s)
        {
            // To store the frequency
            // of the characters
            int[] freq = new int[26];

            // Update the frequency array
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }

            // Print the frequency in alphatecial order
            for (int i = 0; i < 26; i++)
            {

                // If the current alphabet doesn't
                // appear in the string
                if (freq[i] == 0)
                    continue;

                Console.Write((char)(i + 'a') + "" + freq[i]);
            }
        }

        static void RemoveChar(string s, char c)
        {
            char[] sArr = s.ToCharArray();
            int j = 0;
            int count = 0;
            for (int i = j = 0; i < sArr.Length; i++)
            {
                if (s[i] != c)
                {
                    sArr[j++] = s[i];
                }
                else
                {
                    count++;
                }
            }
            while (count > 0)
            {
                sArr[j++] = '\0';
                count--;
            }
            Console.Write(sArr);
        }

        public static long NthPrimeNumber(int num)
        {
            int MAX = 1000005;
            ArrayList primes = new ArrayList();
            bool[] isPrime = new bool[MAX];
            for (int i = 0; i < MAX; i++)
            {
                isPrime[i] = true;
            }

            for (int j = 2; j * j < MAX; j++)
            {
                if (isPrime[j] == true)
                {
                    for (int i = j * j; i < MAX; i += j)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            for (int j = 2; j < MAX; j++)
            {
                if (isPrime[j] == true)
                {
                    primes.Add(j);
                }
            }

            return (int)primes[num - 1];
        }

        private static string reverseWords1(string test)
        {
            string[] s = test.Split(' ');
            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            return ans;
        }


        static bool anagramChecker(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            if (str1 == str2)
                return true;//or false: Don't know whether a string counts as an anagram of itself

            Dictionary<char, int> pool = new Dictionary<char, int>();
            foreach (char element in str1.ToCharArray()) //fill the dictionary with that available chars and count them up
            {
                if (pool.ContainsKey(element))
                    pool[element]++;
                else
                    pool.Add(element, 1);
            }
            foreach (char element in str2.ToCharArray()) //take them out again
            {
                if (!pool.ContainsKey(element)) //if a char isn't there at all; we're out
                    return false;
                if (--pool[element] == 0) //if a count is less than zero after decrement; we're out
                    pool.Remove(element);
            }
            return pool.Count == 0;
        }

        static int isPalindrome(long x)
        {
            long l = 1; // Initialize left position
            long r = 4 * 8; // initialize right position

            // One by one compare bits
            while (l < r)
            {
                if (isKthBitSet(x, l) != isKthBitSet(x, r))
                {
                    return 0;
                }
                l++; r--;
            }
            return 1;
        }

        private static object isKthBitSet(long x, long k)
        {
            int rslt = ((x & (1 << (int)(k - 1))) != 0) ? 1 : 0;
            return rslt;
        }

        static char[] reverseWords2(char[] s)
        {

            // Reversing individual words as
            // explained in the first step

            int start = 0;
            for (int end = 0; end < s.Length; end++)
            {

                // If we see a space, we
                // reverse the previous
                // word (word between
                // the indexes start and end-1
                // i.e., s[start..end-1]
                if (s[end] == ' ')
                {
                    reverse(s, start, end);
                    start = end + 1;
                }
            }

            // Reverse the last word
            reverse(s, start, s.Length - 1);

            // Reverse the entire String
            reverse(s, 0, s.Length - 1);
            return s;
        }
        static void reverse(char[] str,
                    int start,
                    int end)
        {
            // Temporary variable
            // to store character
            char temp;
            while (start <= end)
            {
                // Swapping the first
                // and last character
                temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }
        }

        private static int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            var lookup = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                lookup[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        lookup[i] = Math.Max(lookup[i], lookup[j] + 1);
                    }
                }
            }

            return lookup.Max();
        }

        static void print2largest2(int[] arr, int arr_size)
        {
            // int first;
            int i, second;

            // There should be atleast two elements
            if (arr_size < 2)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            int largest = second = int.MinValue;

            // Find the largest element
            for (i = 0; i < arr_size; i++)
            {
                largest = Math.Max(largest, arr[i]);
            }

            // Find the second largest element
            for (i = 0; i < arr_size; i++)
            {
                if (arr[i] != largest)
                    second = Math.Max(second, arr[i]);
            }

            if (second == int.MinValue)
                Console.Write("There is no second " +
                              "largest element\n");
            else
                Console.Write("The second largest " +
                              "element is {0}\n", second);
        }



    }
}
