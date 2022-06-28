int n;
int i = 1;       

Console.Write("Input number: ");
n = Convert.ToInt32(Console.ReadLine());
    
	while (i <= n) 
	{        
        if (i % 2 == 0) 
		{              
			Console.WriteLine(i + "");
        }
        i++;                   
    }               
