﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNet.Neurons;

namespace NNet.Layers
{
    class HiddenLayer:Layer
    {
        public HiddenLayer(int capacity)
        {
            this.Neurons=new List<Neuron>();
            this.Output = new double[capacity];
            for (int i = 0; i < capacity; i++)
            {
                this.Neurons.Add(new HiddenNeuron());
            }
        }
        public virtual void Train(double lRate, double momentum = 0.0)
        {
            foreach (var neuron in Neurons)
            {
                neuron.AdjustWeights(lRate, momentum);
            }
        }
    }
}
