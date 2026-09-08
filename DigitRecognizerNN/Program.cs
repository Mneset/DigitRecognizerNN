using System;
using System.Threading;

namespace DigitRecognizerNN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a neuron
            Neuron neuron = new Neuron();
            neuron.Bias = 0.5;

            // Test the Activate method
            double result = neuron.Activate(2.0);
            Console.WriteLine($"Activated output for input 2.0: {result}");

            // Test the ActivateDerivative method
            double derivative = neuron.ActivateDerivative(2.0);
            Console.WriteLine($"Derivative for input 2.0: {derivative}");

            // Test with different values
            Console.WriteLine($"\nActivated output for input 0.0: {neuron.Activate(0.0)}");
            Console.WriteLine($"Activated output for input -5.0: {neuron.Activate(-5.0)}");
            Console.WriteLine($"Activated output for input 5.0: {neuron.Activate(5.0)}");

            int numberOfNeurons = 2;
            int numberOfInputs = 3;

            Layer layer = new Layer(numberOfNeurons, numberOfInputs);
            Layer layer2 = new Layer(numberOfNeurons, layer.Neurons.Length);

            double[] inputs = new double[] { 1.0, 0.9, 0.7 };

            Console.WriteLine($"\nWeight for Neuron 0 in Layer 1: {layer.Weights[0, 0]}");
            Console.WriteLine($"Weight for Neuron 0 in Layer 1: {layer.Weights[0, 1]}");
            Console.WriteLine($"Weight for Neuron 0 in Layer 1: {layer.Weights[0, 2]}");
            Console.WriteLine($"Bias for Neuron 0 in Layer 1: {layer.Neurons[0].Bias}\n");

            double[] outputs = layer.ComputeOutputs(inputs);
            double[] outputs2 = layer2.ComputeOutputs(outputs);

            for (int i = 0; i < outputs.Length; i++)
            {
                Console.WriteLine($"Neuron {i} in Layer 1 output: {outputs[i]}");
            }

            Console.WriteLine("");

            for (int i = 0; i < outputs2.Length; i++)
            {
                Console.WriteLine($"Neuron {i} in Layer 2 output: {outputs2[i]}");
            }

            Console.WriteLine("");

            NeuralNetwork neuralNetwork = new NeuralNetwork(new int[] {3, 2, 4});

            double[] nnOutputs = neuralNetwork.ComputeOutputs(inputs);

            for (int i = 0; i < nnOutputs.Length; i++)
            {
                Console.WriteLine($"Output: {nnOutputs[i]}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}