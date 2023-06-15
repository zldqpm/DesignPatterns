namespace TemplateMethod
{
    // 抽象类：数据导入模板
    public abstract class DataImportTemplate
    {
        // 模板方法：数据导入流程
        public void ImportData()
        {
            ReadFile();
            ParseData();
            SaveData();
            DisplayResult();
        }

        // 具体方法：读取文件
        private void ReadFile()
        {
            Console.WriteLine("读取文件");
        }

        // 抽象方法：解析数据，由子类实现
        protected abstract void ParseData();

        // 抽象方法：保存数据，由子类实现
        protected abstract void SaveData();

        // 钩子方法：显示导入结果，默认为空实现，子类可选择性重写
        protected virtual void DisplayResult()
        {
            // 默认为空实现
        }
    }

    // 具体类：CSV文件导入
    public class CsvDataImport : DataImportTemplate
    {
        protected override void ParseData()
        {
            Console.WriteLine("解析CSV数据");
        }

        protected override void SaveData()
        {
            Console.WriteLine("保存数据到数据库");
        }
    }

    // 具体类：Excel文件导入
    public class ExcelDataImport : DataImportTemplate
    {
        protected override void ParseData()
        {
            Console.WriteLine("解析Excel数据");
        }

        protected override void SaveData()
        {
            Console.WriteLine("保存数据到文件");
        }

        protected override void DisplayResult()
        {
            Console.WriteLine("显示导入结果到Excel报表");
        }
    }
}
