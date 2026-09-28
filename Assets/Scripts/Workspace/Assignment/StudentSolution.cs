using UnityEngine;

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

                (result[i], result[minIndex]) = (result[minIndex], result[i]);
            }

            foreach (var n_ in result)
            {
                Debug.Log(n_);
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

            foreach (var n_ in result)
            {
                Debug.Log(n_);
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

            foreach (var n_ in result)
            {
                Debug.Log(n_);
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

                (result[i], result[maxIndex]) = (result[maxIndex], result[i]);
            }

            foreach (var n_ in result)
            {
                Debug.Log(n_);
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

            foreach (var n_ in result)
            {
                Debug.Log(n_);
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

            foreach (var n_ in result)
            {
                Debug.Log(n_);
            }

            return result;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

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

                (result[i], result[maxIndex]) = (result[maxIndex], result[i]);
            }

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] != result[0])
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
            if (numbers.Length == 0)
            {
                return 0;
            }

            int[] result = (int[])numbers.Clone();

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

                (result[i], result[minIndex]) = (result[minIndex], result[i]);
            }

            int currentStreak = 1;
            int longestStreak = 1;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1])
                {
                    continue;
                }

                if (result[i] == result[i - 1] + 1)
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