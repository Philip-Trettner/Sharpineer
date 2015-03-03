#pragma once

extern "C" void foo()
{

}

extern "C" void foof();

extern "C" int bar(char c, short s, bool b)
{

}

extern "C"
{
	void baz(int i)
	{

	}

	bool qux(void *i)
	{

	}
	
	void foo();

	void foof()
	{

	}
}

void nofoo();
