using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Password
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password");
            string ss=Console.ReadLine();
            bool iscap = false;
            bool issmall = false;
            bool isdigit = false;
            bool issym=false;

            if(ss.Length>=5)
                for(int i=0;i<ss.Length;i++)
                {
                    if(ss[i]>='A'&&ss[i]<='Z')
                    {
                        iscap=true;
                    }
                    if(ss[i]>='a'&&ss[i]<='z')
                    {
                        issmall=true;
                    }
                    if(ss[i]>=0&&ss[i]<=0)
                    {
                        isdigit=true;   
                    }
                    if(ss[i]=='@'||ss[i]=='$'||ss[i]=='^')
                    {

                        issym=true;
                    }
                    
                    
                }
            if (iscap && issmall && isdigit && issym)
            {
                Console.WriteLine("Correct Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
