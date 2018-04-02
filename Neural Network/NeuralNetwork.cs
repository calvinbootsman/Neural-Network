using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class NeuralNetwork
    {
        public List<Layers> LayerList = new List<Layers>();
        public void InitList(int inputs, int layers, int nodes, int outputs)
        {         
            Layers InputLayer = new Layers();
            for (int i = 0; i < inputs; i++)
            {
                var node = AddNode(inputs);
                InputLayer.Network.Add(node);
            }
            LayerList.Add(InputLayer);

            for (int j = 0; j < layers; j++) {
                Layers network = new Layers();

                //Zorgen dat de tweede laag even veel weights heeft als het aantal inputs
                if (j == 0)
                {
                    for (int i = 0; i < nodes; i++)
                    {
                        var node = AddNode(inputs);
                        network.Network.Add(node);
                    }
                }
                else
                {
                    //Daarna gebruik je gewoon het aantal nodes per layer in de hidden layer.
                    for (int i = 0; i < nodes; i++)
                    {
                        var node = AddNode(nodes);
                        network.Network.Add(node);
                    }
                }
                LayerList.Add(network);
            }

            Layers OutputLayer = new Layers();
            for (int i = 0; i < outputs; i++)
            {
                var node = AddNode(nodes);
                OutputLayer.Network.Add(node);
            }
            LayerList.Add(OutputLayer);
        }

        Random rnd = new Random();
        private Nodes AddNode(int NumberOfWeights)
        {
            Nodes node = new Nodes
            {
                Value = rnd.NextDouble(),
                Bias = rnd.NextDouble() * 10
            };
            for (int i = 0; i < NumberOfWeights; i++)
            {
                node.Weights.Add((rnd.NextDouble()-0.5)*5);
            }
            return node;
        }

        /// <summary>
        /// De Bias is buiten proporties. Dus alle waardes moeten gemapped worden tussen 0 en 1. Anders gaat alles exponentieel.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="network"></param>
        /// <returns></returns>
        public List<double> CalculateOutput(List<int> list, NeuralNetwork network)
        {
            int layercount = network.LayerList.Count;
            int counter = 0;
            //Adding the values to the input layer
            for (int i = 0; i < network.LayerList[0].Network.Count; i++)
            {
                network.LayerList[0].Network[i].Value = list[i];
            }
            //H gaat alle layers bij langs in het netwerk.
            for (int i = 0; i < (layercount - 1); i++)
            {
                Layers CurrentLayer = network.LayerList[i];
                Layers NextLayer = network.LayerList[i+1];
                Console.WriteLine("I = {0}", i);

                // i gaat alle nodes van de volgende layer bij langs
                // Bij de node van de volgende layer wordt dan de value berekend.
                // Wanneer die klaar is met het berekenen van 1 node, gaat die naar de volgende.
                for (int j = 0; j < NextLayer.Network.Count; j++)
                {
                    NextLayer.Network[j].Value = 0;

                    // j Gaat alle nodes van de huidige layers bij langs.
                    // De values van die nodes worden vermenigvuldigt met de corronsponderende weight.
                    // Daarna wordt hij bij de volgende layer de huidige node opgeteld.
                    for (int k = 0; k < CurrentLayer.Network.Count; k++)
                    {
                        double CurrentValue = CurrentLayer.Network[k].Value;
                        double Weight = NextLayer.Network[j].Weights[k];

                        NextLayer.Network[j].Value += CurrentValue * Weight;
                        counter++;
                        //Console.WriteLine("i = {0}  Value = {1:0.00}     Current = {2}       Weights = {3}", j, NextLayer.Network[j].Value, CurrentLayer.Network[k].Value, NextLayer.Network[j].Weights[k]);
                    }
                    double alpha = 0.000000005;
                    NextLayer.Network[j].Value += NextLayer.Network[j].Bias;
                    NextLayer.Network[j].Value = 1 / (1 + Math.Exp(-NextLayer.Network[j].Value));
                    network.LayerList[i+1] = NextLayer;
                }
            }
            Console.WriteLine("Counter: {0}", counter);
            List<double> Output = new List<double>();
            foreach (Nodes x in network.LayerList[layercount - 1].Network)
            {
                Output.Add(x.Value);
            }
            return Output;
        }
    }

    class Layers
    {
        public List<Nodes> Network = new List<Nodes>();
    }

    class Nodes
    {
        public double Value { get; set; }
        public double Bias { get; set; }
        public List<double> Weights = new List<double>();
    }
}
