using System;
using System.Reflection;
using GoF_Patterns.Composite.Example;
using GoF_Patterns.Composite.OwnExample;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Composite
{
    class CompositePresenter : IPresenter
    {
        public void PresentExample()
        {
            Component fileSystem = new Directory("File system");
            Component driveC = new Directory("DriveC");
            Component txtFile = new File("message.txt");
            Component docxFile = new File("NewDocument1.docx");

            driveC.Add(docxFile);
            driveC.Add(txtFile);
            fileSystem.Add(driveC);

            fileSystem.Print();

            Console.WriteLine("driveC.Remove(txtFile)");
            driveC.Remove(txtFile);

            fileSystem.Print();

            Component myDownloads = new Directory("MyDownloads");
            myDownloads.Add(txtFile);
            driveC.Add(myDownloads);

            fileSystem.Print();
        }

        public void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        public void PresentOwnExample()
        {
            XmlComponent html = new XmlNode("html");
            XmlComponent content = new XmlNode("content");
            XmlComponent body = new XmlNode("body");
            html.Add(content);
            html.Add(body);
            XmlLeaf label = new XmlLeaf("Main label");
            body.Add(label);

            html.Print();
        }

        public void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }

    }
}
