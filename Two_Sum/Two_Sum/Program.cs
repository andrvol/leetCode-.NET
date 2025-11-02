using Two_Sum.Entities;

var sol = new Solution();
int[] solArr = [2, 7, 11, 15];

for (int i = 0; i < sol.TwoSum(solArr, 9).Length; i++)
{
    Console.Write($"{sol.TwoSum(solArr, 9)[i]} ");
}