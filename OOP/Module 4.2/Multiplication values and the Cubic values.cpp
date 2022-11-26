#include<iostream>
#include<conio.h>
  
class line
{
   public:
              inline float mul(float x,float y)
              {
                            return(x*y);
              }
              inline float cube(float x)
              {
                            return(x*x*x);
              }
};
 
int main()
{
              line obj;
              float val1,val2;
              std::cout<<"Enter two values:";
              std::cin>>val1>>val2;
              std::cout<<"\nMultiplication value is:"<<obj.mul(val1,val2);
              std::cout<<"\n\nCube value is:"<<obj.cube(val1)<<"\t"<<obj.cube(val2);
              getch();
}