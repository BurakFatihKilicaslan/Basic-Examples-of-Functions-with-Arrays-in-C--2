namespace study1_Array_With_Functions_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1:Girilen Cümlenin Kaç Kelimeden Oluştugunu Bulan Metodu Yazınız
            //Console.Write("Bir Cümle Giriniz: ");
            //string word = Console.ReadLine();
            //int space = FindSpaceLength(word);
            //Console.WriteLine($"Cumlenizdeki Karakter Sayisi: {word.Length}");
            //Console.WriteLine($"Cumlenizdeki Kelime Sayisi: {word.Length - space}");
            //Console.WriteLine($"Cumlenizdeki Bosluk Sayisi: {space}");
            #endregion

            #region Question2:Bir Sayi Dizisinin En Büyük Elemanını Bulan Metodu Yazınız(Array Ici Deger Random Olusturulmustur).
            //Random rnd = new Random();
            //int[] numbers = new int[rnd.Next(1, 10)];
            //int[] randomNumbers = GenerateRandomNumber(numbers);
            //int bigNumbers = FindBigNumber(randomNumbers);
            //Write(bigNumbers);
            #endregion

            #region Question3:Girilen Kelimenin Tersini Bulan Metodu Yazınız
            //string keyboardWord;
            //Console.Write("Bir Kelime Giriniz:");
            //keyboardWord = Console.ReadLine();
            //InvertWord(keyboardWord);
            #endregion

            #region Question4:10 luk Tabandaki Sayıyı 2 lik Tabana Ceviren Metodu Yazınız( 0 - 256 Arası Degerler Icın )
            //int number;
            //Console.Write("Lutfen Bir Sayi Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //int[] newNumber = DoArray(number);
            //WriteArray(newNumber);
            #endregion
            #region Question5:10 Elemanlı Bir Sayı Dizisinin Ortalaması Tam Sayıysa Bu Tam Sayıdan Dizide Kaç Tane Oldugunu Veren Programın Algoritması
            //int[] numbers = new int[] { 10, 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            //int average = CompareArrayNumber(numbers);
            //int counter = CompareNumber(numbers, average);
            //Write(counter);
            #endregion

            #region Question6:Random Boyutta Uretilen Bir Sayi Dizisinde Pozitif ve Negatif Sayiların Sayısını Bulan Metodu Yazınız
            //Random rnd = new Random();
            //int random = rnd.Next(1, 21);
            //int[] randomNumber = new int[random];
            //int[] randomArray = MakeRandomNumber(randomNumber);
            //int numberCounter = CompareNumber(randomArray);
            //Write(numberCounter, randomArray);

            #endregion
        }
        #region Solutıon for A Question1
        //static int FindSpaceLength(string tempWord)
        //{
        //    int counter = 0;
        //    for (int i = 0; i < tempWord.Length; i++)
        //    {
        //        if (tempWord[i] == ' ')
        //        {
        //            counter++;
        //        }
        //    }
        //    return counter;
        //}
        //static void Write(int tempPieces)
        //{
        //    Console.WriteLine($"Girmis Oldugunuz Kelime Adedi Sayisi: {tempPieces}");
        //} 
        #endregion

        #region Solution for A Question2
        //static int[] GenerateRandomNumber(int[] array)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = rnd.Next(1, 50);
        //        Console.WriteLine(array[i]);
        //    }
        //    return array;
        //}
        //static int FindBigNumber(int[] array)
        //{
        //    int temp = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = 0; i < array.Length - 1; i++)
        //        {
        //            if (array[i] > array[i + 1])
        //            {
        //                temp = array[i];
        //                array[i] = array[i + 1];
        //                array[i + 1] = temp;
        //            }
        //            else temp = array[i + 1];

        //        }
        //    }
        //    return temp;
        //}
        //static void Write(int bigNumber)
        //{
        //    Console.WriteLine(bigNumber);
        //}
        #endregion

        #region Solution for A Question3
        //static void InvertWord(string word)
        //{
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(word[i]);
        //    }
        //}
        #endregion

        #region Solution for A Question4
        //static int[] DoArray(int array)
        //{
        //    int[] result = new int[8];
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        result[i] = array % 2;
        //        array /= 2;
        //        if (array < 2)
        //        {
        //            i += 1;
        //            result[i] = array;
        //            break;
        //        }
        //    }
        //    return result;
        //}
        //static void WriteArray(int[] array)
        //{
        //    for (int i = array.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(array[i]);
        //    }
        //}
        #endregion

        #region Solution for A Question5
        //static int CompareArrayNumber(int[] array)
        //{
        //    int average = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        average += array[i];
        //    }
        //    return average / array.Length;
        //}
        //static int CompareNumber(int[] array, int average)
        //{
        //    int counter = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == average)
        //        {
        //            counter++;
        //        }
        //    }
        //    return counter;
        //}
        //static void Write(int counter)
        //{
        //    Console.WriteLine($"Arrayin Ortalaması Arrayin Icerisinde {counter} Tane Var.. ");
        //}
        #endregion

        #region Solution for A Question6
        //static int[] MakeRandomNumber(int[] random)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < random.Length; i++)
        //    {
        //        random[i] = rnd.Next(-100, 100);
        //    }
        //    return random;
        //}
        //static int CompareNumber(int[] random)
        //{
        //    int counter = 0;
        //    for (int i = 0; i < random.Length; i++)
        //    {
        //        if (random[i] < 0)
        //        {
        //            counter++;
        //        }
        //    }
        //    return counter;
        //}
        //static void Write(int counter, int[] array)
        //{
        //    Console.WriteLine($"Arrayin Uzunlugu:{array.Length}\n(-) Tam Sayi Adedi: {counter}\n(+) Tam Sayi: {array.Length - counter}");
        //}
        #endregion
    }
}