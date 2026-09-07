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

            double[] inputs = new double[] {1.0, 0.9, 0.7};

            double[] outputs = layer.ComputeOutputs(inputs);

            for(int i = 0; i < outputs.Length; i++)
            {
                Console.WriteLine($"Neuron {i} output: {outputs[i]}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}