            string a;
            int[] b = new int[100];
            int i=0;
 
            while ((a = Console.ReadLine()) != "end");
                b[i++] = Convert.ToInt32(a); 
 
            for (int k = 0; k < i; k++) 
                Console.Write(b[k]);
 
            Console.ReadKey(true);