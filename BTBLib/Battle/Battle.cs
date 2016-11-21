using System;
using System.Collections.Generic;
using System.Text;

namespace BTBLib
{
    public class Battle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string PlayerArmy { get; set; }
        public string EnemyArmy { get; set; }
        public string CTL { get; set; }

        public List<Objective> Objectives { get; private set; }
        public List<Obstacle> Obstacles { get; private set; }
        public List<Region> Regions { get; private set; }
        public List<Node> Nodes { get; private set; }

        internal Battle(int width, 
                        int height, 
                        string playerArmy, 
                        string enemyArmy, 
                        string ctl)
        {
            this.Width = width;
            this.Height = height;
            this.PlayerArmy = playerArmy;
            this.EnemyArmy = enemyArmy;
            this.CTL = ctl;

            this.Objectives = new List<Objective>();
            this.Obstacles = new List<Obstacle>();
            this.Regions = new List<Region>();
            this.Nodes = new List<Node>();
        }

    }
}
