using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class MovieRating
    {
        string MovieName;
        string DirectorName;
        String ProducerName;
        String ActorName;
        int Rating;
       

        public void setMovieName(string movie)
        {
            MovieName = movie;
        }
        public string getMovieName()
        {
            return MovieName;
        }
        public void setDirectorName(String name)
        {
            DirectorName = name;
        }
        public String getDirectorName()
        {
            return DirectorName;
        }
        public void setProducerName(String name)
        {
            ProducerName = name;
        }
        public String getProducerName()
        {
            return ProducerName;
        }
        public void setActorName(String name)
        {
            ActorName = name;
        }
        public String getActorName()
        {
            return ActorName;
        }
        public void setRating(int rate)
        {
            Rating = rate;
        }
        public int getRating()
        {
            return Rating;
        }
        public string MovieRate(float rate)
        {
            if(rate>=0&&rate<=3)
            {
                return "Flop";
            }
            else if(rate>=4&&rate<=7)
            {
                return "Average";
            }
            else if(rate>=8&&rate<=10)
            {
                return "Hit";
            }
            return "-";
            }

    }
    class test
    {
        static void Main(string[] args)
        {
            MovieRating g1 = new MovieRating();
            Console.WriteLine("Enter Movie Name");
            g1.setMovieName(Console.ReadLine());
            Console.WriteLine("Enter Director Name");
            g1.setDirectorName(Console.ReadLine());
            Console.WriteLine("Enter Producer Name");
            g1.setProducerName(Console.ReadLine());
            Console.WriteLine("Enter Actor Name");
            g1.setActorName(Console.ReadLine());
            Console.WriteLine("Enter Rating");

            g1.setRating(Convert.ToInt32(Console.ReadLine()));


            Console.WriteLine("Movie Name is" + g1.getMovieName());
            Console.WriteLine("Director Name is" + g1.getDirectorName());
            Console.WriteLine("Producer Name is" + g1.getProducerName());
            Console.WriteLine("Actor Name is" + g1.getActorName());
            Console.WriteLine("Result is " +g1.MovieRate(g1.getRating())+ " Movie");
        }
    }
}
