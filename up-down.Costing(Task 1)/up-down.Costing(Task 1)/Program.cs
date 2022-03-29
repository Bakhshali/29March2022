using System;

namespace up_down.Costing_Task_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eger yazdigim sert duzgun deyilse ctrl+c etdiyim sert ile olmali idise
            //bal yazdiqda bildirisde qeyd edersiz zehmet olmasa;



            //Word word = new Word();
            //IPrintable printable = word;

            MainPrintFile word = new Word();

            word.Print();

            MainPrintFile excel = new Excel();

            excel.Print();

            MainPrintFile pdf = new PDF();

            pdf.Print();






        }
    }
}
