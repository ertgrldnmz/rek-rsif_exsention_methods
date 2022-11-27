internal class Program
{
    private static void Main(string[] args)
    {
        //Rekürsif-Öz yinelemeli
        //3*4=3*3*3*3

        int result=1;
        for(int i=0;i<5;i++)
        {
            result=result*3;

            
        }
        islemler instance=new();
        Console.WriteLine(instance.Expo(5,3));

        string ifade="Ertuğrul Çağrı Dönmez";
        bool sonuc= ifade.CheckSpaces();
        Console.WriteLine(sonuc);

        if(sonuc)
        Console.WriteLine(ifade.RemoveWhiteSpaces());

        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int [] dizi={2,7,0,8,5,7,9,1,6,4};
        dizi.SortArray();
        dizi.ScreenWrite();

        int sayi=5;
        Console.WriteLine(sayi.IsEvenNumber());

        Console.WriteLine(ifade.GetFirstCharacter());






    }

}

public class islemler
{
    public int Expo(int sayi,int üs)
    {
        if(üs<2)
        return sayi;
        
        return Expo(sayi,üs-1)*sayi;

    }

}
    public static class Excetion
    {

        public static bool CheckSpaces(this string param)
        {

            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {

            string [] dizi= param.Split(" ");
            return string.Join("",dizi);

        }

        public static string MakeUpperCase(this string param)
        {

            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();

        }

        public static int[] SortArray(this int[] param)
        
        {
            Array.Sort(param);
            return param;

        }

        public static void ScreenWrite(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int sayi)
        {
            return sayi%2==0;

        }

        public static  string GetFirstCharacter(this  string param)
        {

            return param.Substring(0,1);
        }
    }

