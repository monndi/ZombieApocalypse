﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
   public class Boss2:Boss
    {
        public Boss2(int y):base(y)
        {
            this.Image = Properties.Resources.z2bright;
        }
        public new void Move(Point HeroLocation)
        {
            int hor = Math.Abs(HeroLocation.X - Position.X);
            int ver = Math.Abs(HeroLocation.Y - Position.Y);

            if (Position.X > HeroLocation.X)
            {
                if (hor > ver)
                {
                    Image = Properties.Resources.z2left;
                    Direction = Hero.Direction.Left;
                }
                Position = new Point(Position.X - Velocity, Position.Y);
            }

            if (Position.X < HeroLocation.X)
            {
                if (hor > ver)
                {
                    Image = Properties.Resources.z2bright;
                    Direction = Hero.Direction.Right;
                }
                Position = new Point(Position.X + Velocity, Position.Y);
            }

            if (Position.Y > HeroLocation.Y)
            {
                if (hor < ver)
                {
                    Image = Properties.Resources.z2bright;
                    Direction = Hero.Direction.Up;
                }
                Position = new Point(Position.X, Position.Y - Velocity);
            }

            if (Position.Y < HeroLocation.Y)
            {
                if (hor < ver)
                {
                    Image = Properties.Resources.z2left;
                    Direction = Hero.Direction.Down;
                }
                Position = new Point(Position.X, Position.Y + Velocity);
            }
        }

        public new void Draw(Graphics g)
        {
            g.DrawImage(Image, Position.X, Position.Y, 115, 115);
        }
    }
}
