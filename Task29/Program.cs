void Main()
        {
            int size = 20;
            int[] array = new int[20];
            Random myRandom = new Random();
 
            Console.WriteLine("Массив n");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 20);
                Console.Write("{0} ", array[i]);
            }
 
        }
