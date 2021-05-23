using System;
using System.Collections;
using System.Text;
using Tuan2.Models;

namespace Tuan2
{
    class Program
    {
        static ArrayList dsSv = new ArrayList();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Student s1=new Student();
            s1.maSv = 1;
            s1.ten = "Hoàng";
            s1.hoLot = "Lê";
            s1.diaChi = "DT741";
            s1.gioiTinh = "Nam";
            s1.dsMonHoc = new ArrayList();
            s1.ngaySinh = new DateTime();
            dsSv.Add(s1);
            printDsSv();
            int code;
            while ((code = requestCode()) != 0)
            {
                if (code == 1)
                {
                    insertStudent();
                }else
                if (code == 0)
                {
                    break;
                }else
                if(code == 2)
                {
                    removeStudent();

                }
                Console.WriteLine("-----------------------------");
                printDsSv();

            }
                    
            
            

        }
        public static bool removeStudent()
        {
            Console.WriteLine("Nhập thông tin sinh viên cần xóa: ");
            Console.Write("Mã số sinh viên: ");
            int maSv = int.Parse(Console.ReadLine());
            for(int i= dsSv.Count-1; i>=0;i--)
            {
                int tmpMasv = ((Student)dsSv[i]).maSv;
                if (tmpMasv  == maSv)
                {
                    dsSv.RemoveAt(i);
                }

            }
            return true;
        }
        public static bool insertStudent()
        {
            Student student = new Student();
            Console.WriteLine("Nhập thông tin sinh viên: ");
            Console.Write("Mã số sinh viên: ");
            string maSv = Console.ReadLine();
            Console.Write("Tên: ");
            string ten = Console.ReadLine();
            Console.Write("Họ lót: ");
            string hoLot = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.Write("Giới tính: ");
            string gioiTinh = Console.ReadLine();
            Console.Write("Ngày sinh: ");
            string ngaySinh = Console.ReadLine();

            student.ten = ten;
            student.hoLot = hoLot;
            student.maSv = int.Parse(maSv);            
            student.diaChi = diaChi;
            student.gioiTinh = gioiTinh;
            student.dsMonHoc = new ArrayList();
            student.ngaySinh = new DateTime();
            dsSv.Add(student);
            return true;
                

        } 
        public static int requestCode()
        {
            Console.WriteLine("Chọn thao tác: ");
            Console.WriteLine("1: Nhập sinh viên mới");
            Console.WriteLine("2: Xóa sinh viên");
            Console.WriteLine("3: Sửa sinh viên");
            Console.WriteLine("0: Thoát chương trình");
            Console.Write("Bạn muốn thực hiện: ");
            string line = Console.ReadLine();
            int code = int.Parse(line);
            
            return code;
                

        }
        public static void printDsSv()
        {
            Console.WriteLine("Danh sách sinh viên: ");
            foreach (Student sv in dsSv)
            {
                Console.WriteLine(sv);

            }
        }
    }
    
    
}
