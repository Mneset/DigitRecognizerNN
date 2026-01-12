using System;
using System.Collections.Generic;
using System.Text;

namespace DigitRecognizerNN
{
    internal class Layer
    {
        public Neuron[] Neurons { get; set; }
        public double[,] Weights { get; set; }

        public Layer(int numbersOfNeurons, int numberOfInputs)
        {

        }

        public double[] ComputeOutputs(double[] inputs)
        {

        }
    }
}
