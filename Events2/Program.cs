using System;

namespace Events2
{
    class Program
    {
        public event EventHandler OnSpacePressed;
        static void Main(string[] args)
        {

            var program = new Program();
            program.Start();
        }

        public void Start()
        {
            OnSpacePressed += Program_OnSpacePressed;
            var key=Console.ReadKey();
            Update(key);
        }

        private void Program_OnSpacePressed(object sender, EventArgs e)
        {
            Console.WriteLine("Space pressed");
        }

        private void Update(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Spacebar)
            {
                OnSpacePressed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
