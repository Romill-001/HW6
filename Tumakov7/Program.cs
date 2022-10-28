using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov7
{
    public class Bank_Account
    {
        private byte ID { get; set; }
        private decimal Balance { get; set; }
        public enum Acc_Type: byte
        {
            Сберегательный,
            Накопительный
        }
        private Acc_Type Type { get; set; }
        private static HashSet<byte> Last_Random_ID = new HashSet<byte>( 0 );

        public Bank_Account() { }
        public Bank_Account(byte iD, decimal balance, Acc_Type type)
        {
            ID = iD;
            Balance = balance;
            Type = type;
        }
        //public void Input(out byte id, out decimal balance, out Bank_Account.Acc_Type acc_Type)
        //{
        //    id = Convert.ToByte(Console.ReadLine());
        //    balance = Convert.ToByte(Console.ReadLine());
        //    byte acc = Convert.ToByte(Console.ReadLine());
        //    acc_Type = Enum.Get;
        //}
        public void Print() => Console.WriteLine($"Id: {ID}\nBalace: {Balance}\nType: {Type}");
        public byte new_ID()
        {
            Random r = new Random();
            ID = (byte)r.Next(0, 255);
            if (!Last_Random_ID.Contains(ID))
            {
                ID++;
            }
            return ID;
        }

        public void Add(decimal cash)
        {
            Balance+=cash;
            Console.WriteLine($"Done! Balance: {Balance}");
        }
        public void Lower(decimal cash)
        {
            if(Balance > 0)
            {
                if(Balance - cash > 0)
                {
                    Balance -= cash;
                    Console.WriteLine($"Done! Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine($"Not enougth money! Balance: {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Something is wrong!");
            }
        }

    }
    public class Buiding
    {
        public Buiding() { }
        public uint id, height, floors, flat_count, entrance_count;
        private static HashSet<uint> Last_Random_ID = new HashSet<uint>( 0 ); 
        public Buiding(uint id, uint height, uint floors, uint flat_count, uint entrance_count)
        {
            this.id = id;
            this.height = height;
            this.floors = floors;
            this.flat_count = flat_count;
            this.entrance_count = entrance_count;
        }
        public uint new_id()
        {
            Random r = new Random();
            id = (uint)r.Next(0, 255);
            if (!Last_Random_ID.Contains(id))
            {
                id++;
            }
            return id;
        }
       
        public void HeightOfFloor()
        {
            Console.WriteLine($"Height of floor is: {(double)height/(double)floors}");
        }
        public void FlatCountPerEntrance()
        {
            Console.WriteLine($"Flats per entrance: {flat_count/entrance_count}");
        }
        public void FlatCountPerFloor()
        {
            Console.WriteLine($"Flats per floor : {flat_count / entrance_count/floors}");
        }
        public void Print() => Console.WriteLine($"ID: {id}\nHeight: {height}\nFloors: {floors}\nAmount of flats: {flat_count}\nAmount of entrances: {entrance_count}");
        //public void InputB(out uint Id, out uint Height, out uint Floors, out uint Flat_Count, out uint Entrance_Count)
        //{
        //    Console.WriteLine("Enter ID");
        //    Id = Convert.ToUInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Height");
        //    Height = Convert.ToUInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Floors");
        //    Floors = Convert.ToUInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Amount of flats");
        //    Flat_Count = Convert.ToUInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Amount of entrances");
        //    Entrance_Count = Convert.ToUInt32(Console.ReadLine());

        //}

    }
    internal class Program
    {
        static void new_task()
        {
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {

            // Task7.1 CW
            Bank_Account account = new Bank_Account(123,22800,Bank_Account.Acc_Type.Сберегательный);
            account.Print();
            new_task();

            //Task7.2 CW
            byte new_ID = account.new_ID();
            Bank_Account account1 = new Bank_Account(new_ID,228000,Bank_Account.Acc_Type.Накопительный);
            account1.Print();
            new_task();

            //Task7.3 CW
            new_ID = account1.new_ID();
            Bank_Account account2 = new Bank_Account(new_ID, 0, Bank_Account.Acc_Type.Сберегательный);
            account2.Print();
            account2.Add(1000);
            Console.WriteLine();
            account2.Lower(2000);
            Console.WriteLine();
            account2.Lower(500);
            Console.WriteLine();
            new_task();

            //Task7.1 HW

            Buiding building1 = new Buiding(100,100,20,400,5);
            building1.Print();
            building1.HeightOfFloor();
            building1.FlatCountPerEntrance();
            building1.FlatCountPerFloor();
            new_task();

            uint new_id = building1.new_id();
            Buiding building2 = new Buiding(new_id, 200, 50,1000, 5);
            building2.Print();
            building2.HeightOfFloor();
            building2.FlatCountPerEntrance();
            building2.FlatCountPerFloor();
            new_task();
        }
    }
}
