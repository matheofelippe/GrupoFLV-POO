using System;

namespace DecodificacaoMario
{
    public class Mario
    {
        public int lifes;
        public bool fireFlower;
        public bool mushroom;
        public int score;
        public bool hitEnemy;

        public void Jump()
        {
            Console.WriteLine("Pulou!");
        }

        public void Run()
        {
            Console.WriteLine("Correu!");
        }

        public void ThrowFire()
        {
            if(fireFlower)
            {
                Console.WriteLine("Joga bola de fogo!");
            }
        }

        public void Grow()
        {
            if (mushroom)
            {
                Console.WriteLine("Cresce!");
            }
        }

        public void Hit()
        {
            if (hitEnemy)
            {
                Console.WriteLine("Mata inimigo.");
            }
        }
    }

    public class Enemies
    {
        public int enemyLifes;
        public bool hitMario;
        public int scoreWorth;

        public void Patrol()
        {
            Console.WriteLine("Patrulhando área.");
        }

        public void Hit()
        {
            if (hitMario)
            {
                Console.WriteLine("Causa dano ao Mario.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            mario.lifes = 3;
            mario.fireFlower = false;
            mario.mushroom = false;
            mario.score = 0;
            mario.hitEnemy = false;

            Enemies goomba = new Enemies();
            goomba.enemyLifes = 1;
            goomba.hitMario = false;
            goomba.scoreWorth = 100;

            Enemies koopa = new Enemies();
            koopa.enemyLifes = 1;
            koopa.hitMario = false;
            koopa.scoreWorth = 100;

            mario.Jump();
            mario.ThrowFire();
            mario.Run();
            mario.Grow();
        }
    }
}
