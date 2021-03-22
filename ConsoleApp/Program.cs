using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Tuan1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> lstHK = new List<Customer>();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            TicketAir ve = new TicketAir("HN-HCM", new DateTime(), 30);
            Customer hanhKhach = new Customer("Hoàng Lê", "Nam", 21, ve, 1);
            Console.WriteLine(hanhKhach);
            Console.WriteLine("Nhập vào số lượng khách hàng mua vé: ");
            String line = "";
            line = Console.ReadLine();
            int n = int.Parse(line);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin khách hàng thứ " + (i + 1) + ": ");
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Giới tính: ");
                string gioiTinh = Console.ReadLine();
                Console.Write("Tuổi: ");
                int tuoi = int.Parse(Console.ReadLine());
                Console.Write("Số lượng vé mua: ");
                int soLuong = int.Parse(Console.ReadLine());
                lstHK.Add(new Customer(hoTen, gioiTinh, tuoi, ve, soLuong));

            }

            lstHK.Sort(new SortKhachHang());
            foreach (Customer h in lstHK)
            {
                Console.WriteLine(h.ToString());
            }


        }

    }
    public class TicketAir
    {

        public string NameTrip { get; set; }
        public DateTime DateOfTakeOff { get; set; }
        public double Price { get; set; }

        public TicketAir(string tenChuyen, DateTime ngayBay, double giaVe)
        {
            this.NameTrip = tenChuyen;
            this.DateOfTakeOff = ngayBay;
            this.Price = giaVe;
        }
        public override String ToString()
        {
            Type objType = this.GetType();
            PropertyInfo[] propertyInfoList = objType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            StringBuilder result = new StringBuilder();
            result.AppendFormat(objType.Name + "[");
            bool flag = false;
            foreach (PropertyInfo propertyInfo in propertyInfoList)
            {
                result.AppendFormat("{0}={1}, ", propertyInfo.Name, propertyInfo.GetValue(this));
                flag = true;
            }
            if (flag)
                result.Remove(result.Length - 2, 1);
            result.AppendFormat("]");
            return result.ToString();

        }



    }
    public class Person
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Person(string hoTen, string gioiTinh, int tuoi)
        {
            this.FullName = hoTen;
            this.Gender = gioiTinh;
            this.Age = tuoi;
        }
        public override String ToString()
        {
            Type objType = this.GetType();
            PropertyInfo[] propertyInfoList = objType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            StringBuilder result = new StringBuilder();
            result.AppendFormat(objType.Name + "[");
            bool flag = false;
            foreach (PropertyInfo propertyInfo in propertyInfoList)
            {
                result.AppendFormat("{0}={1}, ", propertyInfo.Name, propertyInfo.GetValue(this));
                flag = true;
            }
            if (flag)
                result.Remove(result.Length - 2, 1);
            result.AppendFormat("]");
            return result.ToString();
        }


    }
    public class Customer : Person
    {
        public TicketAir Ticket { get; set; }
        public int Count { get; set; }

        public Customer(string hoTen, string gioiTinh, int tuoi, TicketAir ve, int soLuong)
            : base(hoTen, gioiTinh, tuoi)
        {

            this.Ticket = ve;
            this.Count = soLuong;
        }

        public double tongTien()
        {
            if (this.Count > 3)
            {
                return this.Count * this.Ticket.Price * (100 - 15) / 100;
            }
            return this.Count * this.Ticket.Price;
        }
        public String ToStringVi()
        {

            StringBuilder result = new StringBuilder();

            result.AppendFormat("Họ và tên: {0},", this.FullName);
            result.AppendFormat("Giới tính: {0},", this.Gender);
            result.AppendFormat("Tuổi: {0},", this.Age);
            result.AppendFormat("Tổng tiền: {0}", this.tongTien());

            return result.ToString();
        }

        public override String ToString()
        {
            Type objType = this.GetType();
            PropertyInfo[] propertyInfoList = objType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            StringBuilder result = new StringBuilder();
            result.AppendFormat(objType.Name + "[");
            bool flag = false;
            foreach (PropertyInfo propertyInfo in propertyInfoList)
            {
                result.AppendFormat("{0}={1}, ", propertyInfo.Name, propertyInfo.GetValue(this));
                flag = true;
            }
            if (flag)
                result.Remove(result.Length - 2, 1);
            result.AppendFormat("]");
            return result.ToString();
        }
    }
    public class SortKhachHang : IComparer<Customer>
    {

        public int Compare(Customer x, Customer y)
        {


            if (x == null || y == null)
            {
                throw new InvalidOperationException();
            }
            return (int)((x.tongTien() - y.tongTien()) * 1000);
        }


    }
}
