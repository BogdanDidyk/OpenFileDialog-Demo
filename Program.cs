namespace OpenFileDialogDemo
{
    public class Program
    {
        static void PrintFileInfo(FileInfo file)
        {
            Console.WriteLine($"FullName: {file.FullName}");
            Console.WriteLine($"Name: {file.Name}");
            Console.WriteLine($"Extension: {Path.GetExtension(file.Name)}");
            Console.WriteLine($"CreationTime: {file.CreationTime}");
            Console.WriteLine($"LastWriteTime: {file.LastWriteTime}");
            Console.WriteLine($"LastAccessTime: {file.LastAccessTime}");
            Console.WriteLine($"Size: {file.Length} bytes");
        }

        [STAThread]
        public static void Main(string[] args)
        {
            OpenFileDialog openDlg = new OpenFileDialog() { InitialDirectory = Directory.GetCurrentDirectory() };
            if (openDlg.ShowDialog() == DialogResult.Cancel) return;

            FileInfo file = new FileInfo(openDlg.FileName);
            PrintFileInfo(file);

            Console.ReadKey();
        }
    }
}