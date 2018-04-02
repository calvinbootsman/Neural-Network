using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network
{
    public partial class Form1 : Form
    {
        int[] data = new int[760];
        NeuralNetwork neural = new NeuralNetwork();

        public Form1()
        {
            InitializeComponent();
            
            foreach (int i in data)
            {
                InputList.Items.Add(i.ToString());
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            neural.LayerList.Clear();
            neural.InitList(760,2,16,10);
            foreach(Layers layer in neural.LayerList)
            {
                foreach(Nodes node in layer.Network)
                {
                    Console.WriteLine(node.Bias);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //List<int> hoi = data.ToList();
            Random rnd = new Random();
            for (int i = 0; i < 760; i++)
            {
                data[i] = rnd.Next(); 
            }
            var OutputData = neural.CalculateOutput(data.ToList(), neural);
            foreach(double x in OutputData)
            {
                Console.WriteLine(x.ToString());
            }

        }

    }
}
