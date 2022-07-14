namespace Traffic_lights_namespace
{
    internal class TrafficLights
    {
        delegate void TrafficLightsDelegate();
        TrafficLightsDelegate trafficLights;

        void ActionWhileRed()
        {
            Console.WriteLine("Stop");
        }

        void ActionWhileYellow()
        {
            Console.WriteLine("Get ready");
        }

        void ActionWhileGreen()
        {
            Console.WriteLine("Go");
        }

        public TrafficLights(string color)
        {
            if (color.ToLower().Equals("red"))
                this.trafficLights += ActionWhileRed;
            else if (color.ToLower().Equals("yellow"))
                this.trafficLights += ActionWhileYellow;
            else if (color.ToLower().Equals("green"))
                this.trafficLights += ActionWhileGreen;
            else
                Console.WriteLine("The traffic light doesn't have this color");
        }


        public void Run()
        {
            this.trafficLights?.Invoke();
        }
    }
}
