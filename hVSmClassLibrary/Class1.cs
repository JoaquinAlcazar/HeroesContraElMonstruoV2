namespace hVSmLib
{
    public class heroesContraMonstruoClass
    {
        public static bool statChecker(int input, int minRange, int maxRange)
        {
            if (input >= minRange && input <= maxRange)
            {
                return true;
            }
            return false;
        }

        public static int randomNumberGenerator(int minRange, int maxRange)
        {
            Random rand = new Random();
            int genNumber = rand.Next(minRange, (maxRange + 1));
            return genNumber;
        }

        public static string[] nameArrayGenerator(string names)
        {
            string[] namesIntoArray = names.Split(',');

            for (int i = 0; i < namesIntoArray.Length; i++)
            {
                namesIntoArray[i] = namesIntoArray[i].Trim();
            }

            return namesIntoArray;
        }

        public static int damageCalculator(int damage, int damageReduction, bool isDefending)
        {

            if (isDefending)
            {
                damageReduction = damageReduction * 2;
            }
            int damageReduced = (damage * damageReduction) / 100;
           
            return damage - damageReduced;
        }
        public static int damageCalculator(int damage, int damageReduction)
        {
            int damageReduced = (damage * damageReduction) / 100;
            if (randomNumberGenerator(0, 21) < 1)
            {
                Console.WriteLine("¡ATAQUE FALLIDO!");
                return 0;
            }
            if (randomNumberGenerator(0, 11) < 1)
            {
                Console.WriteLine("¡ATAQUE CRÍTICO!");
                return (damage - damageReduced) * 2;
            }
            return damage - damageReduced;
        }

        public static int druidHealing(int actualHP, int maxHP)
        {
            actualHP += 500;
            if (actualHP > maxHP)
            {
                actualHP = maxHP;
            }
            return actualHP;
        }
    }
}
