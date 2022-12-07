using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    enum AccountType
    {
        Текущий,
        Сберегательный
    }
    class Bank
    {
        public Bank(string accountNumber, double balans, AccountType type)
        {
            AccountNumber = accountNumber;
            Balans = balans;
            Type = type;
        }
        public string AccountNumber { get; set; }
        public double Balans { get; set; }
        public AccountType Type { get; set; }
        public override string ToString() => $"Номер счета - {AccountNumber}, Баланс - {Balans}, Тип банковского счета - {Type}";

        public double PutOnAccount(double Balans)
        {
            Console.Write("Введите сумму для пополнения ");
            double temp = Convert.ToDouble(Console.ReadLine());
            return Balans + temp;
        }
        public double WithdrawFromAccount(double Balans)
        {
            Console.Write("Введите сумму для снятия ");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (Balans >= temp)
            {
                return Balans - temp;
            }
            else
            {
                Console.WriteLine("На вашем счёте недостаточно средств!");
                return Balans;
            }
        }
        public void moneytransfer(Bank Bank, int amount)
        {
            this.Balans -= amount;
            Bank.Balans += amount;
        }

    }
    public static class StringExtension
    {
        public static string Reverse(this string str)
        {
            string res = string.Empty;
            for (int i = str.Length - 1; i >= 0; --i)
                res += str[i];
            return res;
        }
    }
    public class Temperature : IFormattable
    {
        private decimal temp;

        public Temperature(decimal temperature)
        {
            if (temperature < -273.15m)
                throw new ArgumentOutOfRangeException(String.Format("{0} is less than absolute zero.", temperature));
            this.temp = temperature;
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return temp.ToString("F2", provider) + " °C";
        }
    }
    class Songs
    {
        private string name;
        private string author;
        private Songs last_song;
        public Songs() { }
        public Songs(string name, string author)
        {
            this.name = name;
            this.author = author;
            last_song = null;
        }
        public Songs(string name, string author, Songs last_song) { }
        public static void Search(List<Songs> songs)
        {
            bool isFounded = false;
            for (int i = 0; i < songs.Count; i++)
            {
                for (int j = 1; j < songs.Count - 1; j++)
                {
                    if (songs[i] != null && songs[j] != null)
                    {
                        if (songs[i].Equals(songs[j]) && i != j)
                        {
                            isFounded = true;
                            Console.WriteLine($"Совпали песни под номерами {i + 1} и {j + 1}, Название {songs[i].name} , автор {songs[i].author} ");
                            songs[i] = null;
                        }
                    }
                }
                if (isFounded)
                {
                    Search(songs);
                }
            }

        }
        public static string Title(Songs song)
        {
            return $"{song.name} {song.author}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Songs)
            {
                if ($"{this.name} {this.author}" == Songs.Title(obj as Songs))
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Program
    {
        static void checkArgImplementInterface(Temperature t)
        {
            IFormattable form, form2;

            if (t is IFormattable)
            {
                form = (IFormattable)t;
            }
            else
            {
                form = null;
            }

            if (form is null)
            {
                Console.WriteLine("Не реализует IFormattable");
            }
            else
            {
                Console.WriteLine("Реализует IFormattable");
            }

            form2 = t as IFormattable;

            if (form2 is null)
            {
                Console.WriteLine("Не реализует IFormattable");
            }
            else
            {
                Console.WriteLine("Реализует IFormattable");
            }
        }
        public static void Readfileto(string way, string way2)
        {
            int k = 0;
            StreamReader reader = new StreamReader(way);
            FileInfo a = new FileInfo(way2);
            a.Create().Dispose();
            StreamWriter writer = new StreamWriter(way2);
            while (reader.ReadLine() != null)
            {
                k++;
            }
            reader.Close();
            StreamReader reader1 = new StreamReader(way);
            for (int i = 0; i < k; i++)
            {
                writer.WriteLine(reader1.ReadLine().Split('#')[1]);
            }
            reader1.Close();
            writer.Close();
        }
        public static string Readstr(string v)
        {
            v = v.Split('#')[1];
            return v;
        }
        static void Main()
        {
            Console.WriteLine("Упражнение8.1");
            AccountType accountType = AccountType.Текущий;
            Bank bank1 = new Bank("764HGS78", 1000, AccountType.Сберегательный);
            Bank bank2 = new Bank("386vfb3", 2000, AccountType.Текущий);
            Console.WriteLine("Какую сумму хотите перевести из первого банка во второй?");
            int monney = Convert.ToInt32(Console.ReadLine());
            bank1.moneytransfer(bank2, monney);
            Console.WriteLine(bank1);
            Console.WriteLine(bank2);
            Console.ReadKey();

            Console.WriteLine("\nУпражнение8.2");
            string s = "фбвгдежзимнклн";
            Console.WriteLine($"Изначальная строка: {s}\nПеревернутая: {s.Reverse()}");

            Console.WriteLine("\nУпражнение8.3");
            const string outputFileName = "ResultText.out";
            Console.WriteLine("Введите название входного файла: ");
            string inputFileName = Console.ReadLine();

            if (File.Exists(inputFileName))
            {
                File.WriteAllText(outputFileName, File.ReadAllText(inputFileName, Encoding.UTF8).ToUpper(), Encoding.UTF8);
                Console.WriteLine("Результат успешно записан в файл с именем \"{0}\"", outputFileName);

            }
            else
            {
                Console.WriteLine("Файл с именем \"{0}\" не найден!", inputFileName);
            }

            Console.ReadKey();

            Console.WriteLine("Упражнение8.4");
            Temperature t = new Temperature(50);
            checkArgImplementInterface(t);
            Console.ReadKey();

            Console.WriteLine("ДЗ упражнение 8.1");
            string way = @"C:\Users\Анастасия\source\repos\29.10\29.10\11.txt";
            string way2 = @"C:\Users\Анастасия\source\repos\29.10\29.10\12.txt";
            Readfileto(way, way2);
            StreamReader reader1 = new StreamReader(way);
            Console.WriteLine(Readstr(reader1.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("ДЗ упражнение 8.2");
            int countSongs = 4;
            List<Songs> songs = new List<Songs>();
            for (int i = 0; i < countSongs; i++)
            {
                Console.WriteLine("Введите название песни:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите название артиста:");
                string author = Console.ReadLine();
                songs.Add(new Songs(name, author));
            }
            Songs.Search(songs);
        }
    }

}