// See https://aka.ms/new-console-template for more information
static class leetCode {

    public static void ContainsDuplicate() {

        Console.WriteLine("Brutal Force - time complexity = O(Nˆ2)");

        bool result = false;


        int[] nums = { 2, 3, 4, 5, 6, 7, 4 };

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i +1 ; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    result = true;
            }
        }

        
        // print result

        Console.WriteLine("Result :" + result.ToString());


        /////////////////////////////////////////////////////////////
        ///
        Console.WriteLine("Sort - time complexity = O(N lg N)");

        result = false;

        Array.Sort(nums);


        for (int ind = 1; ind < nums.Length; ind++)
        {
            if (nums[ind] == nums[ind - 1])
            {
                result = true;
            }
        }


        // print result

        Console.WriteLine("Result :" + result.ToString());


        /////////////////////////////////////////////////////////////
        ///
        Console.WriteLine("Hash - time complexity = O(N)");

        result = false;

        HashSet<int> secondary = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {

            if (secondary.Contains(nums[i]))
                result = true;

            secondary.Add(nums[i]);

        }

        // print result

        Console.WriteLine("Result :" + result.ToString());

    }

}