namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File file1 = new File("file1.txt");
            File file2 = new File("file2.doc");
            File file3 = new File("file3.png");

            Folder root = new Folder("Root");
            Folder documents = new Folder("Documents");
            Folder pictures = new Folder("Pictures");

            root.Add(file1);
            root.Add(documents);
            root.Add(pictures);

            documents.Add(file2);
            pictures.Add(file3);

            root.ShowDetails();

            // Output:
            //  [Folder] Root
            //  --file1.txt
            //  --[Folder]Documents
            //  ----file2.doc
            //  --[Folder]Pictures
            //  ----file3.png
        }
    }
}
