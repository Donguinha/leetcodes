var result = RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);

Console.WriteLine(result);

int RemoveDuplicates(int[] nums)
{
    var hashSet = new HashSet<int>(nums);

    return hashSet.Count;
}