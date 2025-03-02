using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _262255
{
    internal class University
    {
        List<Student> uni=new List<Student>{ };
        public  void AddStudent(Student student) 
            { uni.Add(student);
            InsSort(uni);}
        public static void InsSort(List<Student> uni) //insertion sort adjusted
            { int n=uni.Length;

             for(int i=1;i<n;i++)
                {Student keyS=uni[i];
                int key=uni[i].Score;//name&score
                    int j=i-1;
                    while(j>=0&&uni[j].Score>key)
                        {uni[j+1]=uni[j];
                            j--;}
                        uni[j+1]=keyS;}}
        public void FindStByScore(int target) {
        int left=0;
            int right=array.Length-1;
            while(left<=right)
                {int mid=left+(right-left)/2;
                    if(uni[mid].Score==target)
                        {return mid;}
                    else if(uni[mid].Score<target)
                        {let=mid+1;}
                    else
                        {right=mid-1;}
                 }
            return -1; }//dwoichno
    }
}
