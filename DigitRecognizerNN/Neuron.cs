using System;
using System.Collections.Generic;
using System.Text;

namespace DigitRecognizerNN
{
    internal class Neuron
    {
        public double Output { get; set; }

        public double Bias { get; set; }
        public double PreActivation { get; set; }
        public double Delta { get; set; }

        private double CalculateSigmoid(double input)
        {
            double sigmoid = 1 / (1 + Math.Exp(-input));
            return sigmoid;        }

        public double Activate(double input)
        {
            Output = CalculateSigmoid(input);
            return Output;
        }

        public double ActivateDerivative(double input)
        {
            double sigmoid = CalculateSigmoid(input);
            return sigmoid * (1.0 - sigmoid);
        }
     }
 }

