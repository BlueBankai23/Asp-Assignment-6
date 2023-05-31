namespace Assignment_chapter_6.Services
{
    public class ArithmaticAndMath
    {
        public int getSum(int item1, int item2, int item3) {
            return item1 + item2 + item3;
        }
        public int getProd(int item1, int item2, int item3)
        {
            if (item2 == 0) return item1 * 1;
            if (item3 == 0) return item1 * item2;
            return item1 * item2 * item3;
        }
        public int getMax(int item1, int item2, int item3)
        {
            int max = item1;
            if (item2 == 0 && item3 == 0) return item1;
            if (item3 == 0)
            {
                if (item1 > item2) return item1;
                if (item1 < item2) return item2;
            }

            if (item2 > max)
            {
                max = item2;
            }

            if (item3 > max)
            {
                max = item3;
            }

            return max;
        }
        public int getMin(int item1, int item2, int item3)
        {
            int min = item1;
            if (item2 == 0 && item3 == 0) return item1;
            if (item3 == 0)
            {
                if (item1 > item2) return item2;
                if (item1 < item2) return item3;
            }

            if (item2 < min)
            {
                min = item2; 
            }

            if (item3 < min)
            {
                min = item3; 
            }

            return min; 
        }
        public int gcd(int item1, int item2)
        {
            while (item2 != 0)
            {
                int remainder = item1 % item2;
                item1 = item2;
                item2 = remainder;
            }
            return item1;
        }
        public int lcm(int item1, int item2)
        {
            int Gcd = gcd(item1, item2);
            int Lcm = (item1 * item2) / Gcd;
            return Lcm;
        }
    }
}
