using System;
using System.Collections.Generic;
using System.Text;

namespace gurkin
{
    public class Calculator
    {
        private int _firstNum = 0;
        private int _secondNum = 0;
        private int _total = 0;

        public Calculator()
        {

        }

        public void SetFirstNumber(int value)
        {
            _firstNum = value;
        }

        public void SetSecondNumber(int value)
        {
            _secondNum = value;
        }

        public void AddNumbers()
        {
            _total = _firstNum + _secondNum;
        }

        public int Result
        {
            get
            {
                return _total;
            }
        }
    }
}
