#include <iostream>

using namespace std;

class Matrix
{

private:
	int **arr;
	int rows, cols;



public:
	//конструктор
	Matrix(int r, int c)
	{
		this->rows = r;
		this->cols = c;
		arr = new int[10];

		cout << "Выполнился конструктор " << this << endl;

	};





	//Деструктор
	~Matrix()
	{
		cout << "Выполнился деструктор " << this << endl;
	};

};




void main()
{
	setlocale(LC_ALL, "ru");
	std::cout << "Привет\n";

	Matrix matrix(5, 5);

}