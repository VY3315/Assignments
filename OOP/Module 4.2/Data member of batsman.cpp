#include <iostream>
#include <iomanip>
#include <string.h>
#include <conio.h>

class CCricket{
	private:
		char country[20], player[20];
		int avg;
	public:
		void getTeams();
		void compTeams(CCricket *, const int);
		void dispTeams(const CCricket *, const int);
	};

void CCricket :: getTeams(){
	std::cout<<"\n Enter the Name of a Country: ";
	std::cin>>country;
	std::cout<<"\n Enter a Player Name: ";
	std::cin>>player;
	std::cout<<"\n Enter the Batting Average: ";
	std::cin>>avg;
	}

void CCricket :: compTeams(CCricket *Ock, const int t_pls){
	int i, j;
	CCricket Otemp;
	// Sorting By Players Name.
	for(i=0; i<=t_pls; i++){
		for(j=i+1; j<=t_pls; j++){
			if(Ock[i].avg < Ock[j].avg){
				Otemp = Ock[i];
				Ock[i] = Ock[j];
				Ock[j] = Otemp;
				}
			}
		}
	// Sorting By Country Name.
	for(i=0; i<=t_pls; i++){
		for(j=i+1; j<=t_pls; j++){
			if(strcmp(Ock[i].country, Ock[j].country) > 0){
				Otemp = Ock[i];
				Ock[i] = Ock[j];
				Ock[j] = Otemp;
				}
			}
		}
	}

void CCricket :: dispTeams(const CCricket *Ock, const int t_pls){
	int i, j;
	char t_c_name[10];
	// Display Players.
	std::cout<<"\n\n Players Sorted According to their Country and Average:- \n";
	std::cout<<"\n COUNTRY \t TEAM \t AVERAGE"<<std::endl;
	for(i=1; i<=t_pls; i++){
		if(strcmp(t_c_name, Ock[i].country) != 0)
		{
			std::cout<<"\n "<<Ock[i].country;
			strcpy(t_c_name, Ock[i].country);
		}
		std::cout<<"\n\t\t"<<Ock[i].player<<"  -  "<<std::setw(5)<<Ock[i].avg<<std::endl;
		}
	}
int main(){
	int i=0;
	char ch;
	CCricket Ock[30], Otemp;

	while(1){
		
		Ock[i].getTeams();
		i++;
		std::cout<<"\n Do you want to Enter next Entry (y/n) ? : ";
		std::cin>>ch;
		if(ch == 'n')
			break;
		} // End of while Loop.

	std::cout<<"\n\n Total Players Entered: "<<i<<std::endl;

	// Sort Teams.
	Otemp.compTeams(Ock, i);

	// Display Teams.
	Otemp.dispTeams(Ock, i);

	getch();
	}