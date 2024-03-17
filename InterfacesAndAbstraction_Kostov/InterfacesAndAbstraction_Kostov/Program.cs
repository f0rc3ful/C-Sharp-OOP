using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstraction_Kostov
{
    public interface IPrintable
    {
        void Print();
        void PrintToPDF();
    }
    public interface ISavable
    {
        void SaveToFile(string fileName);
    }

    public interface IDocument : IPrintable, ISavable
    {
        void CreateNewDoc()
        { 
        
        }                       
    }
    public class Document : IDocument
    {
        public void Print()
        {

        }

        public void PrintToPDF()
        {

        }

        public void SaveToFile(string fileName)
        {

        }
    }
    public class Doument : IPrintable, ISavable
    { 
        public void Print() 
        {
        
        }
        public void PrintToPDF()
        { 
        
        }
        public void SaveToFile(string fileName) 
        {
        
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
        
        }
    }
}
