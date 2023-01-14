using Ball_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_NinjaWinFormsApp
{
    class SnippedBall : RandomSizePointBall
    {
       
        Form currentForm;
        public float g = 0.5f;
        public SolidBrush brush;
        List<Color> brushes = new List<Color> { Color.Yellow, Color.DarkCyan, Color.Black, Color.Red, Color.Gray };


        public SnippedBall(Form form) : base(form)
        {
            vy = -15;
            currentForm = form;
            centerY = 400;
            centerX = new Random().Next(100, 800);
            Random random = new Random();
            brush = new SolidBrush(brushes[random.Next(brushes.Count)]);
        }

        
        protected override void Go()
        {
            base.Go();
            vy += g;
            vx = 0;
        }
        public override void Show()
        {
            Draw(brush);
        }


    }
}