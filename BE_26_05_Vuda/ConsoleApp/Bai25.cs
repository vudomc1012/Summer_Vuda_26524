using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using OfficeOpenXml;


namespace BE_26_05_Vuda.ConsoleApp
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
            var ValidateEmployeeData = new Common.ValidateEmployeeData();
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin nhân viên thứ {i + 1}:");
                Console.Write("Mã nhân viên: ");
                string id = Console.ReadLine();
                Console.Write("Tên nhân viên: ");
                string name = Console.ReadLine();
                Console.Write("Ngày vào công ty (dd/MM/yyyy): ");
                string dateJoinedInput = Console.ReadLine();
                Console.Write("Hệ số lương: ");
                string salaryCoefficientInput = Console.ReadLine();
                Console.Write("Vị trí công việc: ");
                string jobPosition = Console.ReadLine();

                if (ValidateEmployeeData.ValidateEmployee(id, name, dateJoinedInput, salaryCoefficientInput, out DateTime dateJoined, out double salaryCoefficient))
                {
                    employees.Add(new Employee(id, name, dateJoined, salaryCoefficient, jobPosition));
                }
                else
                {
                    Console.WriteLine("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập lại.");
                    i--; // Giảm chỉ số để nhập lại thông tin cho nhân viên này
                }
            }
        }

        public void InputEmployeesFromExcel()
        {
            var ValidateEmployeeData = new Common.ValidateEmployeeData();
            Console.Write("Nhập đường dẫn file excel: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File không tồn tại.");
                return;
            }

            var errorLines = new List<string>();

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
                        string dateJoinedInput = worksheet.Cells[row, 3].Text;
                        string salaryCoefficientInput = worksheet.Cells[row, 4].Text;
                        string jobPosition = worksheet.Cells[row, 5].Text;

                        if (ValidateEmployeeData.ValidateEmployee(id, name, dateJoinedInput, salaryCoefficientInput, out DateTime dateJoined, out double salaryCoefficient))
                        {
                            employees.Add(new Employee(id, name, dateJoined, salaryCoefficient, jobPosition));
                        }
                        else
                        {
                            errorLines.Add($"Dòng {row} có lỗi: Dữ liệu không hợp lệ.");
                        }
                    }
                    catch (Exception ex)
                    {
                        errorLines.Add($"Dòng {row} có lỗi: {ex.Message}");
                    }
                }
            }

            if (errorLines.Count > 0)
            {
                Console.WriteLine("Các dòng lỗi trong file Excel:");
                foreach (var error in errorLines)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                Console.WriteLine("Tất cả các dòng đã được nhập thành công.");
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
                var worksheet5Years = package.Workbook.Worksheets.Add("5 năm");
                var worksheet10Years = package.Workbook.Worksheets.Add("10 năm");

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
