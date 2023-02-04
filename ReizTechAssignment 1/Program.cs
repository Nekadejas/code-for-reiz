namespace ReizTechAssignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours;
            int minutes;
            bool goodInput = false;

            Console.WriteLine("Please enter a number, representing hours on analog clock");
            do
            {
                string hoursString = Console.ReadLine();
                if (!int.TryParse(hoursString, out hours))
                {
                    Console.WriteLine("Wrong Input");
                    continue;
                }
                else if (hours > 12 || hours < 0)
                {
                    Console.WriteLine("There are only 12 hours on the clock");
                    continue;
                }
                else
                    goodInput = true;
            } while (goodInput == false);

            goodInput = false;

            Console.WriteLine("Please enter a number, representing minutes on analog clock");
            do
            {
                string hoursString = Console.ReadLine();
                if (!int.TryParse(hoursString, out minutes))
                {
                    Console.WriteLine("Wrong Input");
                    continue;
                }
                else if (minutes > 60 || minutes < 0)
                {
                    Console.WriteLine("There are only 60 minutes in an hour");
                    continue;
                }
                else
                    goodInput = true;

            } while (goodInput == false);


            Console.WriteLine("Lesser angle in degrees between hours arrow and minutes arrow is {0}", GetSmallestAngle(hours, minutes));


            Console.ReadKey();
        }

        public static double GetSmallestAngle(int hours, int minutes)
        {
            double hoursAngle = hours * 30 + (double)minutes / 2;
            if (hoursAngle >= 360)
            {
                hoursAngle = hoursAngle - 360;
            }

            int minutesAngle = minutes * 6;

            double angleDistance = hoursAngle - minutesAngle;
            if (angleDistance < 0)
            {
                angleDistance = minutesAngle - hoursAngle;
            }
            if (angleDistance > 180)
            {
                return 360 - angleDistance;
            }
            else
            {
                return angleDistance;
            }
        }
    }
}