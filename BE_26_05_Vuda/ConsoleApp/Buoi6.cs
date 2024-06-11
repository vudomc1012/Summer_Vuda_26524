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
        public  void Bai1()
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
    }
}

