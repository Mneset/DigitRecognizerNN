using System;
using System.Collections.Generic;
using System.Text;

namespace DigitRecognizerNN
{
    internal class NeuralNetwork
    {
        private List<Layer> Layers { get; set; }

        public NeuralNetwork(int[] layerSizes)
        {
            Layers = new List<Layer>();

            for(int i =1; i <= layerSizes.Length -1; i++)
            {
                Layers.Add(new Layer(layerSizes[i], layerSizes[i - 1]));
            }
        }
    }
}
