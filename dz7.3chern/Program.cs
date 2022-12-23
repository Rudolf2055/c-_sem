using System;
 
namespace fsg
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[,] a=new double[5,5];
            double[] b=new double[5];
            
            //инициализация a
            for (int i=0;i<5;i++) {
                for (int j=0;j<5;j++) {
                    a[i,j]=i*j+1;
                    Console.Write(a[i,j]+ " ");
                }
                Console.WriteLine();
            }
            //
            
            for (int i=1,k=0;i<5;i+=2) 
            {
                double summa=0;
                for (int j=0;j<5;j++) 
                {
                    summa+=a[i,j];
                }
                b[k]=summa/5;
                Console.WriteLine("Среднее арифметическое столбца "+(i+1)+" равно: "+b[k]);
                k++;
            }           
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
