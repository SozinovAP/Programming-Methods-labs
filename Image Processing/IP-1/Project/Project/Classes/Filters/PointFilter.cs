﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP1.Imaging.Filters
{
    public abstract class PointFilter : Filter
    {
        public override Image Run(Image image)
        {
            Image result = new Image((uint)image.Width, (uint)image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    result[y, x] = RunColor(image[y, x]);
                }
            }
            return result;
        }

        public abstract Color RunColor(Color color);
    }
}
