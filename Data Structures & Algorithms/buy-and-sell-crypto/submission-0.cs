public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfite = 0;
int bPrice = prices[0];
for (int i = 1; i < prices.Length; i++)
{
    var profile = prices[i] - bPrice;
    maxProfite=Math.Max(maxProfite, profile);
    bPrice = Math.Min(bPrice, prices[i]);
}

return maxProfite;

    }
}
