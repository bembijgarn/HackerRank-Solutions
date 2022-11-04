public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int result = -1;
        int left = 0;
        int right = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            right = 0;
            if (i != 0)
            {
                left += arr[i - 1];
            }
            for (int j = i + 1; j < arr.Length; j++)
            {
                right += arr[j];
            }
            if (right == left)
            {
                result = i;
            }

        }
        return result;
    }
}