#include <iostream>
#include <string>

using namespace std;

class processor
{
private:
	string model;
	unsigned freq;

	processor();
		
	processor(string model, unsigned freq);
		
public:
	void print_info();

	~processor();
	
};

processor::processor(string model, unsigned freq)
{
	this->model = model;
	this->freq = freq;
}

processor::print_info()
{
	cout << this->model << endl;


}

int main()
{
	string m = "Intel";
	unsigned f = 2200;
	processor proc1(m, f);


}