using System;
using System.Text;

namespace Лаб5
{
    class Program
    {   
        static void functional(string a)
        {
            string[] SimpleSentences, Words;
            SimpleSentences =  a.Split(',');
            Words = a.Split(' ');
            for(int i = 0; i < SimpleSentences.Length; i++)
                Console.WriteLine(SimpleSentences[i]);
            for (int i = 0; i < Words.Length; i++)
                Console.WriteLine(Words[i]);
            Console.WriteLine(string.Join(' ', Words));

        }
        static void TestStringBuilder()
        {
            StringBuilder str1 = new StringBuilder("String – example of StringBuilder");
            StringBuilder str2 = new StringBuilder("Строка - это пример Строкопостроителя");
            for(int i = 0; i < str1.Length; i++)
            {
                str2[i] = str1[i];
            }
            if(str1 != str2) Console.WriteLine(str2);
            str1 = str2;
            if (str1 == str2) Console.WriteLine(str1);
        }
        static void PrintCharAr(string a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
        static String CharArrayToString(char[] a)
        {
            string c = new string(a);
            return c;
        }
        static int IndexOfStr(string a, string b)
        {
            int index;
            for(int i = 0; i < a.Length; i++)
                if(a[i] == b[0])
                {
                    int ind = 0;
                    int ii = i;
                    index = i;
                    for (int j = 0; j < b.Length; j++)
                        if (a[ii] == b[j]) 
                        {
                            ind++;
                            ii++; 
                        }
                        else continue;
                    if (ind == b.Length) return index;
                }
            return -1;
        }
        static void TestIndexSym(string a, string b)
        {
            int index;
            Console.Write("Строка \"{0}\" ", b);
            for (int i = 0; i < a.Length; i++)
                if (a[i] == b[0])
                {
                    int ind = 0;
                    int ii = i;
                    index = i;
                    for (int j = 0; j < b.Length; j++)
                        if (a[ii] == b[j])
                        {
                            ind++;
                            ii++;
                        }
                        else continue;
                    if (ind == b.Length) Console.Write("начинается с {0} заканчивается {1} ", index, index + ind - 1);
                }
        }
        static void Main()
        {
            /*Zad 1
            string str1 = "Строка1";
            string str2 = new string('s', 4);      
            char[] charray ={'t','e','s','t'};
            string str3 = new string(charray);
            string str4;
            str4 = str3;
            if (str4 == str3) Console.WriteLine(str4);
            str4 = str1 + str2;
            if (str4 != str1) Console.WriteLine(str4);
            Console.WriteLine(str4[2].ToString().PadLeft(3) + str4[4].ToString().PadLeft(2) + str4[6].ToString().PadLeft(2));
            string str5 = "Вот такая вот \"Строка\" и вообще \", которую надо вывести\"", str6 ="";
            int k = 0;
            for(int i = 0; i < str5.Length; i++)
            {
                if (k != 0 && str5[i] != '\"') str6 += str5[i];
                if (str5[i] == '\"')
                    if (k != 0) k = 0;
                    else k++;
            }
            Console.WriteLine(str6);
            string str7 = "", str8 = "";
            str6 = "Тут нетуstudent студентов";
            for(int i = 0; i < str6.Length; i++)
            {
                if(str6[i] == 's' && i + 7 < str6.Length)
                {
                    int dl = i;
                    for (int l = 0; l < 7; l++)
                    {
                        str8 += str6[dl];
                        dl++;
                    }
                    if (str8 == "student") i += 7;
                }
                str7 += str6[i];
            }
            Console.WriteLine(str7);*/

            /*Zad 2
            string[] thosand =
            {
                "","Тысяча", "Две тысячи", "Три тысячи", "Четыре тысячи", "Пять тысяч","Шесть тысяч", "Семь тысяч", "Восемь тысяч","Девять тысяч"
            };
            string[] hundred =
            {
                ""," сто", " двести", " триста", " четыреста", " пятьсот"," шестьсот", " семьсот", " восемьсот"," девятьсот"
            };
            string[] decide1 =
            {
                ""," десять", " двадцать", " тридцать", " сорок", " пятьдесят"," шестьдесят", " семьдесят", " восемьдесят"," девяносто"
            };
            string[] decide2 =
            {
                ""," одинадцать", " двенадцать", " тринадцать", " четырнадцать", " пятнадцать"," шестнадцать", " семнадцать", " восемнадцать"," девятнадцать"
            };
            string[] val =
            {
                " ноль"," один", " два"," три", " четыре", " пять"," шесть", " семь", " восемь"," девять"
            };
            Console.WriteLine("Введите сумму");
            int a = int.Parse(Console.ReadLine());
            string b = "";
            if(a / 10 % 10 == 1 & a % 10 != 0 ) b += thosand[a / 1000] + hundred[(a / 100) % 10] + decide2[a % 10] + " рублей";
            else b+= thosand[a / 1000] + hundred[(a / 100) % 10] + decide1[(a / 10) % 10] + val[a % 10] + " рублей";
            Console.Write(b);*/

            /*Zad 3
            string a = "Я люблю кушать, Я хочу питцу, Зачем платить больше когда есть сяоми, Вот пример split";
            functional(a);*/

            /*Zad 4*/
            TestStringBuilder();
            StringBuilder a = new StringBuilder("Вот так работает метод ");
            StringBuilder b = new StringBuilder("присоеденил строку в начало");
            a.Append("Append");
            b.Insert(0, "Insert ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            StringBuilder c = new StringBuilder();
            int num = 1;
            string[] sub =
                { "Сердце мое в твоих руках.",  "Не потеряй его и не сломай.",  "Я не могу придумывать предложения." };
            foreach(string substr in sub)
                c.AppendFormat(" {0}: {1} ", num++, substr);
            Console.WriteLine(c);

            /*Zad 5
            StringBuilder a = new StringBuilder("И какой тут интересно размер буфера??");
            StringBuilder b = new StringBuilder("А что у нас тут находится, а вот сейчас выясним");
            Console.WriteLine(a.Capacity);
            Console.WriteLine(b.MaxCapacity);
            a.EnsureCapacity(150);
            Console.WriteLine(a.Capacity);*/

            /*Zad 6
            char[] str1 = { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            //string str2 = "Здравствуй, Мир!";
            string str3;
            str3 = CharArrayToString(str1);
            PrintCharAr(str3);
            string a = "где индекс начинается";
            string b = "где";
            Console.WriteLine(IndexOfStr(a, b));
            TestIndexSym(a, b);*/
        }
    }
}
