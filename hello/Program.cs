using System;
public class hell
{
    static void Main(string[] args)
    {
        Dimonds(5);
        flyds();
        pattern();
        reverse(6);
        AlphaBate(4);
        Alpha();
        pattern1();
        NumPattern();
        starPattern();
        star();

        Console.ReadLine();
    }
    /*01
	     * 
	    * * 
	   * * * 
	  * * * * 
	 * * * * * 
	* * * * * * 
	 * * * * * 
	  * * * * 
	   * * * 
	    * * 
	     * 
*/
    static void Dimonds(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    /* 02
	
	1 
	2 3 
	4 5 6 
	7 8 9 10 
	11 12 13 14 15*/

    static void flyds()
    {
        int count = 1;
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }
    }
    /* 03
	    * 
	   * * 
	  * * * 
	 * * * * 
	* * * * * 
	 */
    static void pattern()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 1; j <= 5 - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
    /* 04
******
*****
****
***
**
*


*/
    static void reverse(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
    // 05
    /* A
     B B
     C C C
     D D D D */
    static void AlphaBate(int n)
    {
        int a = 65;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)a + " ");
            }
            a++;


            Console.WriteLine();
        }
    }
    /* 06
A
AB
ABC
ABCD
ABCDE */

    static void Alpha()
    {
    for(int i = 1; i <= 5; i++)
        {
            int ch = 65;
        for(int j = 1; j <= i; j++)
            {
                Console.Write((char)ch);
                ch++;
            }
            Console.WriteLine();
        }
    }
    /* 07
     
123456
12345
1234
123
12
1
    */
    static void pattern1()
    {
    for(int i = 6; i>=1; i--)
        {
 for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    /*  08
1
12
123
1234 
12345 
    */
    static void NumPattern()
    {
        for(int i = 1; i <= 5; i++)
        {
        for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    /* 09
   *
  **
 ***
****

*/
    static void starPattern()
    {
        for(int i = 1; i <= 4; i++)
        {
        for(int j = 1; j <= 4 - i; j++)
            {
                Console.Write(" ");
            }
        for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    /* 01
	 
   * 
  * * 
 * * * 
* * * * 

	 */
    static void star()
    {
    for(int i = 1; i <= 4; i++)
        {
    for(int j = 1; j <= 4 - i; j++)
            {
                Console.Write(" ");
            }
    for(int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}




















/*int[] Number = { 9, 8, 1, 2, 6, 3, 4, 5, 7 };
Console.WriteLine(Number.Max());
Console.WriteLine(Number.Min());
Console.WriteLine(Number.Sum());*/
// 2D array
//int[,] num = { { 1, 2, 3 }, { 4, 5, 6 } };
/*  foreach(int num1 in num){
      Console.WriteLine(num1);

int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.WriteLine(numbers[i, j]);
    }
}
Console.ReadLine();
}
}
}
/* Array.Sort(Number);
foreach(int no in Number)
{
Console.WriteLine(no);
}
Console.ReadLine();
}
}
}

/* Arrays in string sortC#
string[] Name = { "jyoti", "Dharati", "Nanda", "Aishwarya", "Sneha", "Aaradhya", "Swara" };
Array.Sort(Name);
foreach(string list in Name)
{
Console.WriteLine(list);
}
Console.ReadLine();
} }
}


/*Name[0] = "Jyoti";
for (int i = 0; i < Name.Length; i++)
Console.WriteLine(Name[i]);
Console.WriteLine(Name.Length);
// foreach (string li in Name)
//  Console.WriteLine(li);
Console.WriteLine(Name[5]);
int[] arr = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine(arr[2]);
Console.WriteLine(arr.Length);
}
}
}
/*use a while loop
int num = 10;
int i = 0;

while (i <= num) // Loop until i is 10
{
if (i == 4)
{
// Skip printing when i is 4, but increment i
i++;
continue;
}
Console.WriteLine(i);
i++; // Increment i normally


/* For each loop // break also used // continue also used
string[] name = { "mango", "Banana", "Apple", "Tomato", "Cucumber" };
foreach (string list in name)
{
if (list.Equals("Banana"))
{
 continue;
}
Console.WriteLine(list);
}
Console.ReadLine();
}
/*  if (list.Equals("Apple"))
{
 break;
}
Console.Write(list+" ");
}
/*int a = 15;
//Console.WriteLine(a);
Console.WriteLine("Hello world");
Console.Write("I love jyoti");
Console.ReadLine();

}
}
}
}*/


