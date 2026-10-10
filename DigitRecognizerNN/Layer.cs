using System;
using System.Collections.Generic;
using System.Text;

namespace DigitRecognizerNN
{
    internal class Layer
    {
        public Neuron[] Neurons { get; set; }
        public double[,] Weights { get; set; }
        public double[] Inputs { get; set; } 

        public Layer(int numberOfNeurons, int numberOfInputs)
        {
            Neurons = new Neuron[numberOfNeurons];

            for (int i = 0; i < Neurons.Length; i++)
            {
                Neurons[i] = new Neuron();
                Neurons[i].Bias = 0;
            }

            Weights = new double[numberOfNeurons, numberOfInputs];

            Random rand = new Random();

            for (int i = 0; i < numberOfNeurons; i++)
            {
                for (int j = 0; j < numberOfInputs; j++)
                {
                    Weights[i, j] = (rand.NextDouble() - 0.5) * 0.5;
                }
            }
        }

        public double[] ComputeOutputs(double[] inputs)
        {
            double[] outputs = new double [Neurons.Length];
            

            for (int i = 0; i < Neurons.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < inputs.Length; j++)
                {
                   sum += inputs[j] * Weights[i, j];
                }

                double z = sum + Neurons[i].Bias;
                Neurons[i].PreActivation = z;
                Inputs = inputs;
                double output = Neurons[i].Activate(z);
                outputs[i] = output;
            }
            return outputs;
        }

        public void ComputeOutputDeltas(double[] targets)
        {
            for (int i = 0; i < Neurons.Length; i++)
            {
                Neurons[i].Delta = 2 * (Neurons[i].Output - targets[i]) * Neurons[i].ActivateDerivative(Neurons[i].PreActivation);           }
        }

       
    }
}
