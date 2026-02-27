using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace EventHandlerExample
{
    // Driver class with DataChange event
    public class Driver
    {
        private readonly Timer _timer;
        private readonly Random _random;

        public event EventHandler<TagEventArgs> DataChange;

        public Driver()
        {
            _random = new Random();
            _timer = new Timer(50); // 1 second interval
            _timer.Elapsed += OnTimerElapsed;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Simulate new random data
            string tagName = "Temperature";
            int newValue = _random.Next(0, 100);

            // Raise the DataChange event
            DataChange?.Invoke(this, new TagEventArgs(tagName, newValue));
        }
    }
}
