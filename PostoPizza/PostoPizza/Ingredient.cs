﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PostoPizza
{
    public class Ingredient
    {
        public string name;
        public string imgRef;
        public BitmapImage getImage()
        {
            if (this.name != null)
            {
                Uri uri = new Uri("Images/Ingredients/" + this.name.Trim()+".png", UriKind.Relative);
                return new BitmapImage(uri);
            }
            return null;
            
        }
        public Ingredient(string name)
        {
            this.name = name;
        }
        public Ingredient(string name, string img)
        {
            this.name = name;
            this.imgRef = img;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
