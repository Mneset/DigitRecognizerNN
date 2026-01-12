using System;
using System.Collections.Generic;
using System.Text;

namespace DigitRecognizerNN
{
    internal class Neuron
    {
        public double Output { get; set; }

        public double Bias { get; set; }

        public double Activate(double input)
        {
            Output = 1 / (1 + Math.Exp(-input));
            return Output;
        }

        public double ActivateDerivative(double input)
        {
            double sigmoid = Activate(input);
            return sigmoid * (1.0 - sigmoid);
        }
     }
 }

