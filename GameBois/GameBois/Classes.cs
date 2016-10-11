using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameBois {
    public class Tile {

        public Vector2 Position = new Vector2();
        public Object Contained { get; set; }

        public bool Contains { get; set; }

        public Tile(int x, int y) {
            Position.X = x;
            Position.Y = y;
        }

        public void AddToContainer(Object v) {
            Contained = v;
            Contained.Position.X = Position.X;
            Contained.Position.Y = Position.Y;
            Contains = true;
        }

    }


    public class Object {
        public int Number { get; set; }
        public Vector2 Position = new Vector2();
        public Object(int number) {
            this.Number = number;
        }
        public void GetLocal(Tile[,] T) {
            if (T[(int)Position.X + 1, (int)Position.Y].Contains) {
                T[(int)Position.X + 1, (int)Position.Y].Contained.Number++;
            }
        }

    }
}
