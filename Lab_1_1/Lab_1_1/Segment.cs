﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Segment: Figure
    {
        int x1, y1, x2, y2;

        public Segment(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void PrintFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point(x1, y1);
            Point b = new Point(x2, y2);

            graphic.DrawLine(pen, a, b);
        }
    }
}
