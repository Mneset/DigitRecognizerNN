using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DigitRecognizerNN
{
    internal class NeuralNetwork
    {
        private List<Layer> Layers { get; set; }

        public NeuralNetwork(int[] layerSizes)
        {
            Layers = new List<Layer>();

            for (int i = 1; i <= layerSizes.Length - 1; i++)
            {
                Layers.Add(new Layer(layerSizes[i], layerSizes[i - 1]));
            }
        }

        public double[] ComputeOutputs(double[] inputs)
        {
            double[] currentData = inputs;

            foreach(Layer layer in Layers)
            {
                currentData = layer.ComputeOutputs(currentData);
            }

            return currentData;
        }
    }
}
