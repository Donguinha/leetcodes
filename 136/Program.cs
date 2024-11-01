var result = SingleNumber([9, 1, 3, 9, 5, 5, 3]);

Console.WriteLine(result);

int SingleNumber(int[] nums)
{
    var numbers = new List<int>(nums);

    while (numbers.Count > 1)
    {
        var first = numbers.First();

        numbers.RemoveAt(0);

        if (numbers.Contains(first))
        {
            numbers.Remove(first);

            continue;
        }

        return first;
    }

    return numbers.First();
}