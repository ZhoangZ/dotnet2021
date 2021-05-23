using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2.Models
{
    class Student
    {
        public int maSv { get; set; }
        public string hoLot { get; set; }
        public string ten { get; set; }
        public DateTime ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public ArrayList dsMonHoc { get; set; }

        public Student()
        {

        }
        public Student(string ten, string hoLot)
        {
            this.ten = ten;
            this.hoLot = hoLot;

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
        public class SortStudent : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                if (x == null || y == null)
                {
                    throw new InvalidOperationException();
                }
                return x.ten.CompareTo(y.ten);
            }

            
        }
    }
}
