using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25
{
    public class Executar
    {
        public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Construtor é obrigatório para todos os campos e tem parâmetros não padrão
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Distancia(Point p)
    {
        return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
    }
}

    public struct Player
    {
        public string Name { get; set; }
        public Point Position { get; set; }

        public Player(string name, Point position)
        {
            Name = name;
            Position = position;
        }

        public void Move()
        {
            Position = new Position;
            }
        }
    }
}