using System;
using System.Collections.Generic;
using System.Text;

namespace practic3
{
    internal class MainPrintFile
    {
      public string Word { get; set; }
        public string Excel{ get; set; }
        public string Pdf { get; set; }
        public MainPrintFile(Word word, Excel excel, PDF pdf)
        {
            Word = word.Print();
            Excel = excel.Print();
            Pdf = pdf.Print();

        }

    }
}
