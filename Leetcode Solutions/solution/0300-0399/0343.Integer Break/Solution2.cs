public class Solution {
    public int IntegerBreak(int n) {
        if (n < 4) {
            return n - 1;
        }
        if (n % 3 == 0) {
            return (int)Math.Pow(3, n / 3);
        }
        if (n % 3 == 1) {
            return (int)Math.Pow(3, n / 3 - 1) * 4;
        }
        return (int)Math.Pow(3, n / 3) * 2;
    }
}