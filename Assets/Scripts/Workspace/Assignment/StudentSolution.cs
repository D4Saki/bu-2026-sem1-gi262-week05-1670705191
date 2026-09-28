using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            int n = result.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = result[i];
                result[i] = result[minIndex];
                result[minIndex] = temp;
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            int n = result.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            int n = result.Length;

            for (int i = 1; i < n; i++)
            {
                int key = result[i];
                int j = i - 1;

                while (j >= 0 && result[j] > key)
                {
                    result[j + 1] = result[j];
                    j--;
                }

                result[j + 1] = key;
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            int n = result.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (result[j] > result[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = result[i];
                result[i] = result[maxIndex];
                result[maxIndex] = temp;
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            int n = result.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (result[j] < result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            int n = result.Length;

            for (int i = 1; i < n; i++)
            {
                int key = result[i];
                int j = i - 1;

                while (j >= 0 && result[j] < key)
                {
                    result[j + 1] = result[j];
                    j--;
                }

                result[j + 1] = key;
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            // Sort from largest to smallest
            for (int i = 0; i < result.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] > result[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = result[i];
                result[i] = result[maxIndex];
                result[maxIndex] = temp;
            }

            // Find the first value different from the largest
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] < result[0])
                {
                    Debug.Log(result[i]);
                    return result[i];
                }
            }

            return result[0];
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Debug.Log("The longest consecutive sequence is: 0");
                return 0;
            }

            int[] result = (int[])numbers.Clone();

            // Sort from smallest to largest
            for (int i = 0; i < result.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = result[i];
                result[i] = result[minIndex];
                result[minIndex] = temp;
            }

            int currentStreak = 1;
            int longestStreak = 1;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1])
                {
                    // Ignore duplicate numbers
                    continue;
                }
                else if (result[i] == result[i - 1] + 1)
                {
                    currentStreak++;

                    if (currentStreak > longestStreak)
                    {
                        longestStreak = currentStreak;
                    }
                }
                else
                {
                    currentStreak = 1;
                }
            }

            Debug.Log("The longest consecutive sequence is: " + longestStreak);

            return longestStreak;
        }

        #endregion
    }
}