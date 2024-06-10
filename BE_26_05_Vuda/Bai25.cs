using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using OfficeOpenXml;


namespace BE_26_05_Vuda
{
    struct Employee
    {
        public string EmployeeID;
        public string EmployeeName;
        public DateTime DateJoined;
        public double SalaryCoefficient;
        public string JobPosition;

        public Employee(string employeeID, string employeeName, DateTime dateJoined, double salaryCoefficient, string jobPosition)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            DateJoined = dateJoined;
            SalaryCoefficient = salaryCoefficient;
            JobPosition = jobPosition;
        }
    }
    public class Bai25
    {
        static List<Employee> employees = new List<Employee>();

        public void InputEmployeesFromKeyboard()
        {
            var nhapSo = new Common.ValidateData();
            Console.Write("Nhập số lượng nhân viên: ");
            double n = nhapSo.NhapSo(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin nhân viên thứ {i + 1}:");
                Console.Write("Mã nhân viên: ");
                string id = Console.ReadLine();
                Console.Write("Tên nhân viên: ");
                string name = Console.ReadLine();
                Console.Write("Ngày vào công ty (dd/MM/yyyy): ");
                DateTime dateJoined = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Hệ số lương: ");
                double salaryCoefficient = double.Parse(Console.ReadLine());
                Console.Write("Vị trí công việc: ");
                string jobPosition = Console.ReadLine();

                employees.Add(new Employee(id, name, dateJoined, salaryCoefficient, jobPosition));
            }
        }

        public void InputEmployeesFromExcel()
        {
            Console.Write("Nhập đường dẫn file excel: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File không tồn tại.");
                return;
            }

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var workbook = package.Workbook;
                if (workbook.Worksheets.Count == 0)
                {
                    Console.WriteLine("File excel không có worksheet.");
                    return;
                }

                var worksheet = workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                for (int row = 2; row <= rowCount; row++) // Bỏ qua dòng tiêu đề
                {
                    try
                    {
                        string id = worksheet.Cells[row, 1].Text;
                        string name = worksheet.Cells[row, 2].Text;
                        DateTime dateJoined = DateTime.ParseExact(worksheet.Cells[row, 3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        double salaryCoefficient = double.Parse(worksheet.Cells[row, 4].Text);
                        string jobPosition = worksheet.Cells[row, 5].Text;

                        employees.Add(new Employee(id, name, dateJoined, salaryCoefficient, jobPosition));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Dòng {row} có lỗi: {ex.Message}");
                    }
                }
            }
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("Danh sách nhân viên:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Mã: {employee.EmployeeID}, Tên: {employee.EmployeeName}, Ngày vào: {employee.DateJoined.ToString("dd/MM/yyyy")}, Hệ số lương: {employee.SalaryCoefficient}, Vị trí: {employee.JobPosition}");
            }
        }

        public void ExportEmployeesToExcel()
        {
            var employees5Years = employees.Where(e => (DateTime.Now - e.DateJoined).TotalDays >= 5 * 365).ToList();
            var employees10Years = employees.Where(e => (DateTime.Now - e.DateJoined).TotalDays >= 10 * 365).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet5Years = package.Workbook.Worksheets.Add("5Years");
                var worksheet10Years = package.Workbook.Worksheets.Add("10Years");

                // Header
                string[] headers = { "Mã nhân viên", "Tên nhân viên", "Ngày vào công ty", "Hệ số lương", "Vị trí công việc" };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet5Years.Cells[1, i + 1].Value = headers[i];
                    worksheet10Years.Cells[1, i + 1].Value = headers[i];
                }

                // 5 years sheet
                for (int i = 0; i < employees5Years.Count; i++)
                {
                    var emp = employees5Years[i];
                    worksheet5Years.Cells[i + 2, 1].Value = emp.EmployeeID;
                    worksheet5Years.Cells[i + 2, 2].Value = emp.EmployeeName;
                    worksheet5Years.Cells[i + 2, 3].Value = emp.DateJoined.ToString("dd/MM/yyyy");
                    worksheet5Years.Cells[i + 2, 4].Value = emp.SalaryCoefficient;
                    worksheet5Years.Cells[i + 2, 5].Value = emp.JobPosition;
                }

                // 10 years sheet
                for (int i = 0; i < employees10Years.Count; i++)
                {
                    var emp = employees10Years[i];
                    worksheet10Years.Cells[i + 2, 1].Value = emp.EmployeeID;
                    worksheet10Years.Cells[i + 2, 2].Value = emp.EmployeeName;
                    worksheet10Years.Cells[i + 2, 3].Value = emp.DateJoined.ToString("dd/MM/yyyy");
                    worksheet10Years.Cells[i + 2, 4].Value = emp.SalaryCoefficient;
                    worksheet10Years.Cells[i + 2, 5].Value = emp.JobPosition;
                }

                Console.Write("Nhập tên file để lưu (bao gồm đuôi .xlsx): ");
                string fileName = Console.ReadLine();
                var fileInfo = new FileInfo(fileName);
                package.SaveAs(fileInfo);
                Console.WriteLine($"File đã được lưu thành công tại {fileInfo.FullName}");
            }
        }
    }
}
