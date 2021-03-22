using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Tuan1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<HanhKhach> lstHK = new List<HanhKhach>();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            VeMayBay ve = new VeMayBay("HN-HCM", new DateTime(), 30);
            HanhKhach hanhKhach = new HanhKhach("Hoàng Lê","Nam",21,ve, 1);
            Console.WriteLine("Nhập vào số lượng khách hàng mua vé: ");
            String line = "";
            line=Console.ReadLine();
            int n = int.Parse(line);
            for(int i = 0;  i < n;i++)
            {
                Console.WriteLine("Nhập thông tin khách hàng thứ "+ (i+1)+": ");
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine(); 
                Console.Write("Giới tính: ");
                string gioiTinh = Console.ReadLine(); 
                Console.Write("Tuổi: ");
                int tuoi = int.Parse(Console.ReadLine());
                Console.Write("Số lượng vé mua: ");
                int soLuong = int.Parse(Console.ReadLine());
                lstHK.Add(new HanhKhach(hoTen, gioiTinh, tuoi, ve, soLuong));

            }
            
            lstHK.Sort(new SortKhachHang());
            foreach(HanhKhach h in lstHK)
            {
                Console.WriteLine(h.ToString());
            }
            

        }
    }
    public class VeMayBay
    {

        string tenChuyen { get; set; }
        DateTime ngayBay { get; set; }
        public double giaVe { get; set; }

        public VeMayBay(string tenChuyen, DateTime ngayBay, double giaVe)
        {
            this.tenChuyen = tenChuyen;
            this.ngayBay = ngayBay;
            this.giaVe = giaVe;
        }
        public override String ToString()
        {
            Type objType = this.GetType();
            PropertyInfo[] propertyInfoList = objType.GetProperties();
            StringBuilder result = new StringBuilder();
            foreach (PropertyInfo propertyInfo in propertyInfoList)
                result.AppendFormat("{0}={1} ", propertyInfo.Name, propertyInfo.GetValue(this));

            return result.ToString();
        }
    }
    public class ConNguoi
    {
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public int tuoi { get; set; }

        public ConNguoi(string hoTen, string gioiTinh, int tuoi)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.tuoi = tuoi;
        }
        public override String ToString()
        {
            Type objType = this.GetType();
            PropertyInfo[] propertyInfoList = objType.GetProperties();
            StringBuilder result = new StringBuilder();
            foreach (PropertyInfo propertyInfo in propertyInfoList)
                result.AppendFormat("{0}={1} ", propertyInfo.Name, propertyInfo.GetValue(this));

            return result.ToString();
        }
    }
    public class HanhKhach:ConNguoi
    {
        VeMayBay ve { get; set; }
        int soLuong { get; set; }

        public HanhKhach(string hoTen, string gioiTinh, int tuoi,VeMayBay ve, int soLuong) 
            :base(hoTen, gioiTinh,  tuoi)
        {
            
            this.ve = ve;
            this.soLuong = soLuong;
        }

        public double tongTien()
        {
            if (this.soLuong > 3)
            {
                return this.soLuong* this.ve.giaVe *(100-15) / 100;
            }
            return this.soLuong * this.ve.giaVe;
        }
        public override String ToString()
        {
            
            StringBuilder result = new StringBuilder();
            
            result.AppendFormat("Họ và tên: {0},", this.hoTen);
            result.AppendFormat("Giới tính: {0},", this.gioiTinh);
            result.AppendFormat("Tuổi: {0},", this.tuoi);
            result.AppendFormat("Tổng tiền: {0}", this.tongTien());

            return result.ToString();
        }
    }
    public class SortKhachHang : IComparer<HanhKhach>
    {
        
            public int Compare(HanhKhach x, HanhKhach y)
        {
           

            if (x == null || y == null)
            {
                throw new InvalidOperationException();
            }
            return (int)((x.tongTien() - y.tongTien())*1000) ;
        }

       
    }
}
