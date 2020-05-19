﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class ImageView
    {
        private Image image;

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(image);
        }
    }
}
