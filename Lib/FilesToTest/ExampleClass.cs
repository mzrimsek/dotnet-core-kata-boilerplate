using System;
using System.Collections;
using System.Collections.Generic;

namespace Lib.FilesToTest
{
    public class ExampleClass
    {
        private readonly List<double> _numbers;

        public ExampleClass()
        {
          _numbers = new List<double>();
        }

        public void AddToList(double number)
        {
            _numbers.Add(number);
        }

        public List<double> GetList()
        {
            return _numbers;
        }
    }
}