using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace Информационная_система_v2
{
    public static class ExcelWorker
    {
        public static void ParseFile(string fileDirectory, out bool correct, out string name, out DateTime birthDate, out Male male, out byte height, out byte weight, out DeviceFunction function, out bool access)
        {
            correct = true;
            name = string.Empty;
            birthDate = new DateTime();
            male = Male.Male;
            height = 0;
            weight = 0;
            function = 0;
            access = true;

            Excel.Application workExcel = new Excel.Application(); // открытие Excel
            Excel.Workbook excelFile = workExcel.Workbooks.Open(fileDirectory, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing); // открытие файла 

            Excel.Worksheet sheet = (Excel.Worksheet) excelFile.Worksheets[1]; // открываем лист файла

            int row = 3;
            int column = 2;

            try
            {
                name = GetName(sheet, row, column, out correct); // чтение имени

                if (!correct)
                    return;

                column++;                           // переход к дате рождения

                birthDate = GetBirthDate(sheet, row, column, out correct); // чтение даты рождения

                if (!correct)  // проверка корректности чтения
                    return;

                column++;   // переход к полу

                male = GetMale(sheet, row, column, out correct);  // чтение пола

                if (!correct)   // проверка корректности чтения
                    return;

                column++; // переход к весу
                weight = GetWeight(sheet, row, column, out correct); // чтение веса 

                if (!correct)
                    return;

                column++; // переход к росту

                height = GetHeight(sheet, row, column, out correct);  // чтение роста

                if (!correct)   // проверка корректноти чтения
                    return;

                column++; // переход к типу прибора 

                function = GetDeviceFunction(sheet, row, column, out correct);

                if (!correct)
                    return;

                column++; // переход к возможности доступа

                access = GetAccessRights(sheet, row, column, out correct); // чтение возможности доступа

                workExcel.Quit();
            }
            catch (Exception)
            {
                correct = false;
                return;
            }
        }

        static string GetName(Excel.Worksheet sheet, int row, int column, out bool correct)
        {
            correct = true;

            string name = sheet.Cells[row, column].Text.ToString();

            

            foreach (char symbol in name)
            {
                if (!(symbol >= 'А' && symbol <= 'Я' || symbol >= 'а' && symbol <= 'я' || symbol == ' '))
                    correct = false;
            }

            return name;
        }

        static DateTime GetBirthDate(Excel.Worksheet sheet, int row, int column, out bool correct)
        {
            DateTime birthDate = new DateTime();
            correct = true;

            try
            {
                string birthString = sheet.Cells[row, column].Text.ToString();
                string[] date = birthString.Split('.');

                birthDate = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            }
            catch (Exception)
            {
                correct = false;
            }
            return birthDate;
        }

        static Male GetMale(Excel.Worksheet sheet, int row, int column, out bool correct)
        {
            Male male = Male.Male;
            correct = true;

            string maleInfo = sheet.Cells[row, column].Text.ToString();

            maleInfo = maleInfo.ToLower();

            if (maleInfo == "жен" || maleInfo == "ж" || maleInfo == "женский")
                male = Male.Female;
            else
            {
                if (maleInfo == "муж" || maleInfo == "м" || maleInfo == "мужской")
                    male = Male.Male;
                else
                {
                    correct = false;
                }
            }

            return male;
        }
        
        static byte GetHeight(Excel.Worksheet sheet, int row, int column, out bool correct)
        {
            byte height;
            correct = byte.TryParse(sheet.Cells[row, column].Text.ToString(), out height);

            if (correct && height <= 0)
                correct = false;

            return height;
        }

        static byte GetWeight(Excel.Worksheet sheet, int row, int column, out bool correct)
        {
            byte weight;

            correct = byte.TryParse(sheet.Cells[row, column].Text.ToString(), out weight);

            if (correct && weight <= 0)
                correct = false;

            return weight;
        }

        static DeviceFunction GetDeviceFunction(Excel.Worksheet sheet, int row, int column, out bool correct)
        {
            DeviceFunction function = 0;
            correct = true;

            string deviceFunction = sheet.Cells[row, column].Text.ToString();

            deviceFunction = deviceFunction.ToLower();

            if (deviceFunction == "глюкометр")
                function = DeviceFunction.Glucometer;
            else
            {
                if (deviceFunction == "пульсометр")
                    function = DeviceFunction.HeartRateMonitor;
                else
                {
                    if (deviceFunction == "измеритель артериального давления" || deviceFunction == "тонометр")
                        function = DeviceFunction.BloodPressureMonitor;
                    else
                    {
                        correct = false;
                    }
                }
            }

            return function;
        }

        static bool GetAccessRights(Excel.Worksheet sheet, int row, int column, out bool correct)
        {
            bool haveAccess = true;
            correct = true;

            string access = sheet.Cells[row, column].Text.ToString();
            access = access.ToLower();

            if (access == "да" || access == "д" || access == "+")
                haveAccess = true;
            else
            {
                if (access == "нет" || access == "н" || access == "-")
                    haveAccess = false;
                else
                    correct = false;
            }

            return haveAccess;
        }

        public static void WriteResults(object data)
        {
            ExcelExportData resultsInfo = data as ExcelExportData;

            Excel.Application workExcel = new Excel.Application();
            workExcel.Workbooks.Add();

            Worksheet sheet = (Worksheet) workExcel.ActiveSheet;
            
            int beginRow = 2, beginColumn = 3;
            

            WritePatientInfo(sheet, ref beginRow, beginColumn, resultsInfo.patient);
            beginRow += 2;

            if (resultsInfo.measures.Count != 0)
            {
                // запись состояний здоровья
                sheet.Cells[beginRow++, beginColumn] = "Записанные измерения прибора";
                string[] headers = {"Время", "Измерение"};

                WriteHeader(sheet, beginRow++, beginColumn, headers);
                WriteMeasuredData(sheet, ref beginRow, beginColumn, resultsInfo.measures);
                
                beginRow += 3;
            }

            if (resultsInfo.statuses.Count != 0)
            {
                // запись состояний здоровья
                sheet.Cells[beginRow++, beginColumn] = "Записанные состояния здоровья";
                string[] headers = {"Время", "Запись"};

                WriteHeader(sheet, beginRow++, beginColumn, headers);
                WriteHealthStatuses(sheet, ref beginRow, beginColumn, resultsInfo.statuses);
            }
            
            // выравниваем стобцы
            ((Excel.Range) sheet.Columns[beginColumn, Type.Missing]).EntireColumn.AutoFit();
            ((Excel.Range) sheet.Columns[beginColumn + 1, Type.Missing]).EntireColumn.AutoFit();

            sheet.SaveAs(resultsInfo.fileDirectory, Excel.XlFileFormat.xlOpenXMLWorkbook);
            workExcel.Quit();
        }

        static void WritePatientInfo(Excel.Worksheet sheet, ref int row, int beginColumn, Patient patient)
        {
            sheet.Cells[row++, beginColumn] = DateTime.Now.ToLongDateString();

            sheet.Cells[row++, beginColumn] = patient.FullName;
            sheet.Cells[row, beginColumn] = "Дата рождения";
            sheet.Cells[row++, beginColumn + 1] = patient.BirthDate.ToShortDateString();
            sheet.Cells[row, beginColumn] = "Пол";

            if (patient.Male == Male.Male)
                sheet.Cells[row++, beginColumn + 1] = "Мужской";
            else
                sheet.Cells[row++, beginColumn + 1] = "Женский";
            
        }

        static void WriteHeader(Excel.Worksheet sheet, int row, int beginColumn, string[] headers)
        {
            foreach (string header in headers)
            {
                sheet.Cells[row, beginColumn++] = header;
            }
        }

        static void WriteHealthStatuses(Excel.Worksheet sheet, ref int beginRow, int beginColumn, List<string[]> statuses)
        {
            foreach (string[] status in statuses)
            {
                sheet.Cells[beginRow, beginColumn] = status[0];
                sheet.Cells[beginRow++, beginColumn + 1] = status[1];
            }
        }

        static void WriteMeasuredData(Excel.Worksheet sheet, ref int beginRow, int beginColumn, List<string[]> measures)
        {
            foreach (string[] status in measures)
            {
                sheet.Cells[beginRow, beginColumn] = status[0];
                sheet.Cells[beginRow++, beginColumn + 1] = status[1];
            }
        }
    }

    public class ExcelExportData
    {
        public string fileDirectory;
        public List<string[]> measures;
        public List<string[]> statuses;
        public Patient patient;

        public ExcelExportData(string file, List<string[]> measuredData, List<string[]> writenData, Patient patInfo)
        {
            fileDirectory = file;
            measures = measuredData;
            statuses = writenData;
            patient = patInfo;
        }
    }
}
