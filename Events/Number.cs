using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    //Event subscriber
    class Number
    {
        private int _value;
        private PrintHelper _printHelper;

        public Number(int val)
        {
            _value = val;

            _printHelper = new PrintHelper(); //Number class creates an instance of PrintHelper

            //Number class subscribes to beforePrintEvent event (+=) and gives the name of the function which will handle the event (printHelper_beforePrintEvent)
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
        }

        //beforePrintevent handler
        //Will be called when publisher class (Printhelper) fires an event
        //printHelper_beforePrintEvent need have the same signature as the BeforePrint delegate in the PrintHelper class
        void printHelper_beforePrintEvent() 
        {
            Console.WriteLine("BeforePrintEventHandler: PrintHelper is going to print a value");
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }
}
