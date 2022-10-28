using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Судебные рабирательства: 
 *  -Суд или судья прокурор следователь дознаватель(органы госудраства должностные лица)
 *  -подозреваемый адвокат ответчик потерпевший гражданский истец(участники уголовного процесса)
 *  -Присяжные свидетели(привелкаемые лица)
 * инкапсуляция, наследование, полиморфизм
 
 */
namespace HW6
{
    //public class Prestupnik
    //{
    //    public string f_name;
    //    public string F_name
    //    {
    //        get { return f_name; }
    //        set { f_name = value; }
    //    }
    //    public string s_name;
    //    public string S_name
    //    {
    //        get { return s_name; }
    //        set { s_name = value; }
    //    }
    //    public int age;
    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value; }
    //    }
    //    public void GetInfo(string[] file)
    //    {
    //        f_name = file[0];
    //        s_name = file[1];
    //        age = int.Parse(file[2]);
    //    }
    //    public void SetInfo()
    //    {
    //        Console.WriteLine("Информация о преступнике:");
    //        Console.WriteLine($"Name: {f_name} {s_name}, Age: {age}");
    //    }
    //    public void SLova() { }
    //}
    //public class Poterpevshiy
    //{
    //    public string f_name;
    //    public string F_name
    //    {
    //        get { return f_name; }
    //        set { f_name = value; }
    //    }
    //    public string s_name;
    //    public string S_name
    //    {
    //        get { return s_name; }
    //        set { s_name = value; }
    //    }
    //    public int age;
    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value; }
    //    }
    //    public void GetInfo(string[] file)
    //    {
    //        f_name = file[0];
    //        s_name = file[1];
    //        age = int.Parse(file[2]);
    //    }
    //    public void SetInfo()
    //    {
    //        Console.WriteLine("Информация о потерпевшем:");
    //        Console.WriteLine($"Name: {f_name} {s_name}, Age: {age}");
    //    }
    //}
    //public class Prestuplenie
    //{
    //    public string sostav;
    //    public string Sostav
    //    {
    //        get { return sostav; }
    //        set { sostav = value; }
    //    }
    //    public void GetS(string[] file)
    //    {
    //        sostav = file[0];
    //    }
    //}
    //abstract class Process
    //{
    //    public int id;
    //    public int ID
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }
    //    public void Rnadom_ID()
    //    {
    //        Random r = new Random();
    //        id = r.Next(0, 1000);
    //    }
    //}
    //class Zasedanie : Process
    //{
    //    public string name;
    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //    public Zasedanie() { }
    //    public void GI(string[] file)
    //    {
    //        Name = file[0];
    //    }
    //    public void Nachalo_Zasedaniya()
    //    {
    //        Console.WriteLine($"Всем встать! Суд идёт. Сегодня рассматривается дело №{id} на имя {Name}");
    //    }
    //}
    //class Prigovor : Process
    //{
    //}
    //class Reshenie_Prisyajhnih : Process
    //{
    //}
    public class Incapsulation
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void GetInfo()
        {
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter age");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void SetInfo()
        {
            Console.WriteLine($"Name is {Name}, Age is {Age}");
        }
    }
    public class NasledovanieAndPolomorphism
    {
        public string shape { get; set; }
        public string size { get; set; }
        public void GetInfo()
        {
            Console.WriteLine("Enter shape");
            shape = Console.ReadLine();
            Console.WriteLine("Enter size");
            size = Console.ReadLine();
        }
        public virtual void Info()
        {
            Console.WriteLine("New figure");
        }
    }
    public class f1 : NasledovanieAndPolomorphism
    {
        public string color = "Red";
        public override void Info()
        {
            Console.WriteLine("Figure is {0}, color is {1}, size is {2}", shape, color, size);
        }
    }
    public class f2 : NasledovanieAndPolomorphism
    {
        public string color = "Green";
        public override void Info()
        {
            Console.WriteLine("Color of figure is {1}, shape is {0} and the size is {2}", shape, color, size);
        }
    }
    public class Construktor
    {
        public int speed;
        public string type;
        public byte wheels;
        public Construktor() { speed = 0; type = "Broken Car"; wheels = 1; }
        public Construktor(int n) { speed = n; type = "Truck"; wheels = 6; }
        public Construktor(int n, string n2) { speed = n; type = n2; wheels = 4; }
        public Construktor(int n, string n2, byte n3) { speed = n; type = n2; wheels = n3; }
        public void Print()
        {
            Console.WriteLine($"SPEED - {speed} , TYPE - {type} , WHEELS - {wheels}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prestupnik p = new Prestupnik();
            //Poterpevshiy py = new Poterpevshiy();
            //Zasedanie z = new Zasedanie();
            //z.Rnadom_ID();
            //z.Nachalo_Zasedaniya();
            //Console.ReadKey();
            Incapsulation n1 = new Incapsulation();
            n1.GetInfo();
            n1.SetInfo();
            NasledovanieAndPolomorphism n2 = new NasledovanieAndPolomorphism();
            n2.Info();
            f1 n3 = new f1();
            n3.GetInfo();
            n3.Info();
            f2 n4 = new f2();
            n4.GetInfo();
            n4.Info();
            Construktor c1 = new Construktor();
            Construktor c2 = new Construktor(60);
            Construktor c3 = new Construktor(100, "Sport-car");
            Construktor c4 = new Construktor(300, "Bike", 2);
            c1.Print();
            c2.Print();
            c3.Print();
            c4.Print();
            Console.ReadKey();
        }
    }
}
