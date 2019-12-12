using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    [Serializable]
    public class Player
    {
        public override string ToString()
        {
            return this.name;
        }
        public string name { get; private set; }
        public int age { get; private set; }
        public string photoURL { get; private set; }
        public string nationality { get; private set; }
        public string flagURL { get; private set; }
        public int overall { get; private set; }
        public int potential { get; private set; }
        public string foot { get; private set; }
        public string height { get; private set; }
        public string weight { get; private set; }
        public double stamina { get; private set; }
        public void changePhoto(string photo)
        {
            this.photoURL = photo;
        }
        public Player(string name,
        int age,
        string photoURL,
        string nationality,
        string flagURL,
        int overall,
        int potential,
        string foot,
        string height,
        string weight,
        double stamina)
        {
            this.name = name;
            this.age = age;
            this.photoURL = photoURL;
            this.nationality = nationality;
            this.flagURL = flagURL;
            this.overall = overall;
            this.potential = potential;
            this.foot = foot;
            this.height = height;
            this.weight = weight;
            this.stamina = stamina;
        }
        
    }
}
