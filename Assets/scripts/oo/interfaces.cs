using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }

    public interface IRunnable
    {
        void Run();
    }

    public interface IJumpable
    {
        void Jump();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }

        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }

        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }
    }

    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }

    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creatures = new List<Creature> { new Kangaroo(), new Duck() };
            
            List<IRunnable> runnableCreatures = new List<IRunnable>();
            List<IJumpable> jumpableCreatures = new List<IJumpable>();
            List<ISwimmable> swimmableCreatures = new List<ISwimmable>();

            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            runnableCreatures.Add(kangaroo);
            jumpableCreatures.Add(kangaroo);

            runnableCreatures.Add(duck);
            swimmableCreatures.Add(duck);

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            foreach (IRunnable runner in runnableCreatures)
            {
                runner.Run();
            }

            foreach (IJumpable jumper in jumpableCreatures)
            {
                jumper.Jump();
            }

            foreach (ISwimmable swimmer in swimmableCreatures)
            {
                swimmer.Swim();
            }
        }
    }
}
