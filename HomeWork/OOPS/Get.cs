using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class Get
    {
        long VoterId;
        String VoterName;
        String VoterCasted;

        public void setVoterId(long card)
        {
            VoterId = card;
        }
        public long getVoterId()
        {
            return VoterId; 
        }
        public void setVoterName(String name)
        {
            VoterName = name;
        }
        public String getVoterName()
        {
            return VoterName;
        }
        public void setVoterCasted(String name)
        {
            VoterCasted = name;
        }
        public String getVoterCasted()
        {
            return VoterCasted;
        }
        

    }
    class display
    {
        static void Main(string[] args)
        {
            Get g1=new Get();
            g1.setVoterId(52645896);
            g1.setVoterName("Ketan");
            g1.setVoterCasted("BJP");

            Console.WriteLine(g1.getVoterId());
            Console.WriteLine(g1.getVoterName());
            Console.WriteLine(g1.getVoterCasted());
        }
    }
}
