#include <iostream>
#include <string>

using namespace std;

class MyString
{
private:
	string str;

public:
	MyString(string other_string);
	void str_print();
	MyString operator+(const MyString &other_string) const;
	string operator*(const MyString& other_string) const;
	bool operator==(const MyString& other_string) const;
	bool operator>(const MyString& other_string) const;
	bool operator<(const MyString& other_string) const;
	int operator[](int index);
	string operator()(int from_index, int to_index);

	~MyString()
	{
		//cout << "Memory is now free:" << this << endl;
	}
};

////////
MyString::MyString(string other_string)
{
	str = other_string;
}

void MyString::str_print()
{
	cout << str << endl;
}

MyString MyString::operator+(const MyString &other_string) const
{
	MyString res1 = str + other_string.str;
	return res1;
}

string MyString::operator*(const MyString &other_string) const
{
	string stroka;
	for (unsigned i = 0; i < str.length(); i++)
	{
		for (unsigned j = 0; j < other_string.str.length(); j++)
		{
			if (str[i] == other_string.str[i])
			{
				stroka=stroka+str[i];
			}
		}
	}
	return stroka;
}

bool MyString::operator==(const MyString &other_string) const
{
	return str == other_string.str;
}

bool MyString::operator>(const MyString& other_string) const
{
	return str > other_string.str;
}

bool MyString::operator<(const MyString& other_string) const
{
	return str < other_string.str;
}

int MyString::operator[](int index)
{
	return str[index];
}

string MyString::operator()(int from_index, int to_index)
{
	int a = to_index - from_index;
	string s = str.substr(from_index, a);
	return s;
}

///////






int main()
{
	string other_string, stroka;
	cout << "================================\n";
	cout << "Input two strings \n";
	getline(cin, other_string);
	MyString str1(other_string);
	getline(cin, other_string);
	MyString str2(other_string);

	MyString str3 = (str1 + str2);
	cout << "string1+string2: ";
	str3.str_print();
	cout << "string1*string2: ";
	stroka=str1 * str2;
	cout<<stroka<<endl;
	cout << "string1==string2: " << (str1 == str2) << endl;
	cout << "string1>string2: " << (str1 > str2) << endl;
	cout << "string1<string2: " << (str1 < str2) << endl;
	cout << "The first symbol in string1 is: " << char(str1[0])<<endl;
	//cout << "The first symbol in string2 is: " << char(str2[0]) << endl;
	cout << "The substring from 2-nd to 6-th symbol is: " << str1(2, 7) << endl;
	return 0;
}


