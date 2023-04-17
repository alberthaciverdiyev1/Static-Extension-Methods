using Static__Extension_Methods.Utilities;

namespace Static__Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 3;
            int Number2 = 4;
            int Number3 = 5;
            int Number4 = 6;
            Console.WriteLine($"Daxil etdiyiniz {Number1} reqeminin tek olmasi {Number1.IsOdd()}-dur");
            Console.WriteLine($"Daxil etdiyiniz {Number2} reqeminin tek olmasi {Number2.IsOdd()}-dur");
            Console.WriteLine($"Daxil etdiyiniz {Number3} reqeminin cut olmasi {Number3.IsEven()}-dur");
            Console.WriteLine($"Daxil etdiyiniz {Number4} reqeminin cut olmasi {Number4.IsEven()}-dur");


            string text1 = "albert";
            string text2 = "albert159";
            Console.WriteLine($"Daxil etdiyiniz {text1} sozunde reqem olmasi {text1.HasDigit()}-dur");
            Console.WriteLine($"Daxil etdiyiniz {text2} sozunde reqem olmasi {text2.HasDigit()}-dur");


            string password1 = "albertDeneme123";
            string password2 = "AlbertDeneme";

            Console.WriteLine($"Daxil etdiyiniz {password1} sifresinin duzgunluyu {password1.CheckPassword()}-dur");
            Console.WriteLine($"Daxil etdiyiniz {password2} sifresinin duzgunluyu {password2.CheckPassword()}-dur");


            string text3 = "hal-hazirda saat 20:31-dir";

            Console.WriteLine(text3.Capitalize());


        }
    }
}