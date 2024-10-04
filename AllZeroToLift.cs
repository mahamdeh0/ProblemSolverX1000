public class AllZeroToLift
{
    public static void AllZeroToLift0(int[] numbers)
    {

        int counter = 0;

        foreach (var i in numbers)
        {

            if (i != 0)
            {
                numbers[counter++] = i;
            }

        }

        for (int i = counter; i < numbers.Length; i++)
                                  numbers[counter++] = 0;
       
    }
}