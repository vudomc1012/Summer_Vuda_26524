using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Buoi6
    {
        /*Bài 1.Tạo một lớp generic MyStack<T> mô phỏng hành vi 
         * của cấu trúc dữ liệu stack với các phương thức:
        Push(T item) : Thêm một phần tử vào đỉnh stack.
        Pop(): Lấy và xóa phần tử ở đỉnh stack.
        Peek(): Lấy phần tử ở đỉnh stack nhưng không xóa.
        IsEmpty(): Kiểm tra stack có rỗng không.
        Viết chương trình kiểm tra các phương thức này với các kiểu dữ liệu khác nhau.
        Viết chương trình để thực hiện các hàm trên*/
        public class MyStack<T>
        {
            private List<T> _generic;

            public MyStack()
            {
                _generic = new List<T>();
            }

            public void Push(T item)
            {
                _generic.Add(item);
            }

            public T Pop()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty.");

                T item = _generic[_generic.Count - 1];
                _generic.RemoveAt(_generic.Count - 1);
                return item;
            }

            public T Peek()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty.");

                return _generic[_generic.Count - 1];
            }

            public bool IsEmpty()
            {
                return _generic.Count == 0;
            }
        }
        public void Bai1()
        {
            // Kiểm tra generic với kiểu int
            Console.WriteLine("Kiểm tra MyStack với kiểu int:");
            MyStack<int> myStack = new MyStack<int>();
            //thêm các phần tử vào stack bằng phương thức Push()
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            //lấy và hiển thị phần tử ở đỉnh bằng phương thức Peek()
            Console.WriteLine("Phần tử ở đỉnh: " + myStack.Peek());//c
            //lấy và xóa phần tử ở đỉnh bằng phương thức Pop()
            Console.WriteLine("Lấy và xóa phần tử ở đỉnh: " + myStack.Pop());
            Console.WriteLine("Phần tử ở đỉnh sau khi Pop: " + myStack.Peek());
            //kiểm tra stack có rỗng không bằng phương thức IsEmpty()
            Console.WriteLine("Stack có rỗng không? " + myStack.IsEmpty());                   
        }
        //Bài 2.Tạo một lớp Student với các thuộc tính: ID, Name, Grade. Sau đó:Tạo một Dictionary<int, Student> để quản lý sinh viên theo ID.Thêm một vài sinh viên vào dictionary.Sử dụng LINQ để thực hiện các truy vấn:
        //Tìm sinh viên có điểm số cao nhất.
        //Lấy danh sách tên sinh viên có điểm lớn hơn một giá trị cho trước.
        //Đếm số lượng sinh viên đạt điểm trung bình trở lên.
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Grade { get; set; }

            public Student(int id, string name, double grade)
            {
                ID = id;
                Name = name;
                Grade = grade;
            }
        }
        public void Bai2()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>
            {
                // Thêm một vài sinh viên vào dictionary
                { 1, new Student(1, "Apply", 8.5) },
                { 2, new Student(2, "Adidog", 7.0) },
                { 3, new Student(3, "Niek", 9.2) },
                { 4, new Student(4, "SamSang", 6.5) },
                { 5, new Student(5, "Toyolo", 7.8) }
            };

            // Tìm sinh viên có điểm số cao nhất
            var topStudent = students.Values.OrderByDescending(s => s.Grade).FirstOrDefault();
            if (topStudent != null)
            {
                Console.WriteLine($"Sinh viên có điểm số cao nhất: {topStudent.Name}, Điểm: {topStudent.Grade}");
            }

            // Lấy danh sách tên sinh viên có điểm lớn hơn một giá trị cho trước
            double threshold = 7.5;
            var highGradeStudents = students.Values.Where(s => s.Grade > threshold).Select(s => s.Name).ToList();
            Console.WriteLine($"Danh sách sinh viên có điểm lớn hơn {threshold}:");
            foreach (var name in highGradeStudents)
            {
                Console.WriteLine(name);
            }

            // Đếm số lượng sinh viên đạt điểm trung bình trở lên (giả sử điểm trung bình là 5.0)
            double averageGrade = 5.0;
            int countAboveAverage = students.Values.Count(s => s.Grade >= averageGrade);
            Console.WriteLine($"Số lượng sinh viên đạt điểm trung bình trở lên: {countAboveAverage}");
        }   
        
    }
}
