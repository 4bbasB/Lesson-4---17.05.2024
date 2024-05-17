using System.Diagnostics.Metrics;

namespace Lesson_4___17._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //Console.Write("Nece eded yazmaq istediyinizi daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}
            ////int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            ////Console.WriteLine(DifferenceBetweenOddsAndEvens(numbers));
            //Console.WriteLine("Cut ededler - Tek ededler = " + DifferenceBetweenOddsAndEvens(nums));

            #endregion

            #region Task 2

            //string word = "hello";
            //Console.WriteLine(ReverseString(word));

            #endregion

            #region Task 3

            //string name;
            //while (true)
            //{
            //    Console.Write("Adinizi daxil edin: ");
            //    name = Console.ReadLine();
            //    if (name.Length >= 8)
            //    {
            //        Console.WriteLine(name);
            //        break;
            //    }
            //    else
            //        Console.WriteLine("Adin uzunlugu 8-den boyuk olmalidir!");
            //}

            #endregion

            #region Task 4
            //Console.WriteLine(2.2);
            //Console.WriteLine(CalculateArea(2.1,5.6));
            #endregion

            #region Task 5
            //Console.WriteLine(sumOfDigits(1111));
            #endregion

            #region Task 6
            //Console.WriteLine(ifPolindrome("salam"));
            //Console.WriteLine(ifPolindrome("madam"));
            #endregion

            #region Task 7

            //int[] numbers = { 1, 2, 3};
            //var arr = ReturnArr(numbers);
            //foreach (var num in arr)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region Task 8
            //var ProductObj1 = new { Id = 1, Name = "Samsung", Price = 2400, StockCount = 1 };
            //var ProductObj2 = new { Id = 2, Name = "Iphone", Price = 3000, StockCount = 15 };
            //var ProductObj3 = new { Id = 3, Name = "Xiaomi", Price = 259, StockCount = 20 };
            //var ProductObj4 = new { Id = 4, Name = "Huawei", Price = 509, StockCount = 5 };
            //var ProductObj5 = new { Id = 5, Name = "Oppo", Price = 1230, StockCount = 3 };
            //var ProductObj6 = new { Id = 6, Name = "Lenovo", Price = 1000, StockCount = 19 };

            //int sum = 0;

            //var Products = new[] { ProductObj1, ProductObj2, ProductObj3, ProductObj4, ProductObj5, ProductObj6 };
            //foreach (var Product in Products)
            //{
            //    if (Product.Id % 2 == 1)
            //        sum += Product.Price;
            //}
            //Console.WriteLine(sum);




            var Student1 = new { Id = 1, Name = "Ebil", Age = 10, Grade = 66, Class = 5 };
            var Student2 = new { Id = 2, Name = "Ibrahim", Age = 11, Grade = 75, Class = 6 };
            var Student3 = new { Id = 3, Name = "Abbas", Age = 8, Grade = 20, Class = 3 };
            var Student4 = new { Id = 4, Name = "Bilal", Age = 8, Grade = 100, Class = 3 };
            var Student5 = new { Id = 6, Name = "Emil", Age = 12, Grade = 19, Class = 7 };
            var Student6 = new { Id = 5, Name = "Akif", Age = 11, Grade = 80, Class = 7 };
            var Student7 = new { Id = 6, Name = "Subhan", Age = 9, Grade = 19, Class = 4 };
            var Student8 = new { Id = 6, Name = "Arif", Age = 12, Grade = 90, Class = 6 };
            var Student9 = new { Id = 6, Name = "Eli", Age = 6, Grade = 15, Class = 1 };
            var Student10 = new { Id = 6, Name = "Cabbar", Age = 7, Grade = 85, Class = 2 };
            var Students = new[] { Student1, Student2, Student3, Student4, Student5, Student6, Student7, Student8, Student9, Student10 };

            //AllProperties(Students);
            //Console.WriteLine(Class7(Students));
            //IncreaseGrade(Students);
            //BiggestScore(Students);
            int[] hours = { 5, 1, 4, 2, 2 };
            int target = 2;
            #endregion
        }

        #region Task 1
        static int DifferenceBetweenOddsAndEvens(params int[] numbers)
        {
            int difference;
            int sumOdds = 0;
            int sumEvens = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                    sumOdds += numbers[i];
                else
                    sumEvens += numbers[i];
            }
            difference = sumEvens - sumOdds;
            return difference;
        }
        #endregion

        #region Task 2
        static string ReverseString(string word)
        {
            string reverse = "";
            for (int i = word.Length - 1; i >= 0; i--)
                reverse += word[i];
            return reverse;
        }
        #endregion

        #region Task 4
        static double CalculateArea(double r)
        {
            double pi = 3.14;
            double area = pi * r * r;
            return area;
        }

        static double CalculateArea(double a, double b)
        {
            double area = a * b;
            return area;
        }
        #endregion

        #region Task 5
        static int sumOfDigits(int number)
        {
            int sum = 0;

            for (int i = 0; number > 0; i++)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion

        #region Task 6
        static bool ifPolindrome(string word)
        {
            string reverseWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
                reverseWord += word[i];
            if (reverseWord == word)
                return true;
            else
                return false;
        }
        #endregion

        #region Task 7
        static int[] ReturnArr(int[] arr)
        {
            int[] newArr = new int[arr.Length + arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                newArr[i + arr.Length] = arr[i];
            }

            return newArr;
        }
        #endregion

        #region Task 8

        static void AllProperties(dynamic[] Students)
        {
            foreach (var Student in Students)
            {
                if (Student.Grade > 60 && Student.Class < 5)
                    Console.WriteLine(Student);
            }
        }

        static double Class7(dynamic[] Students)
        {
            double sum = 0;
            int counter = 0;
            foreach (var Student in Students)
            {
                if (Student.Class == 7)
                {
                    sum += Student.Grade;
                    counter++;
                }
            }
            return sum / counter;
        }

        static void IncreaseGrade(dynamic[] Students)
        {
            foreach (var Student in Students)
            {
                if (Student.Class == 6 && Student.Name == "Arif")
                {
                    if ((Student.Grade + 15) > 100)
                        Student.Grade = 100;
                    else
                        Student.Grade = Student.Grade + 15;
                }
                Console.WriteLine(Student);
            }
        }

        static void BiggestScore(dynamic[] Students)
        {
            int maxGrade = 0;
            string MaxGradeStudent = "";
            for (int i = 0; i < Students.Length; i++)
            {
                if (maxGrade < Students[i].Grade)
                {
                    maxGrade = Students[i].Grade;
                    MaxGradeStudent = Students[i].Name;
                }

            }
            Console.WriteLine($"Name: {MaxGradeStudent}    Grade: {maxGrade}");
        }

        #endregion
    }
}