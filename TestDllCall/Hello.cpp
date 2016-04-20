#include <stdio.h>
#include <Windows.h>
#include "HumanName.h"

extern "C"
{
	__declspec(dllexport) void __cdecl DisplayHelloFromDLL()
	{
		printf("Hello from DLL !\n");
	}

	__declspec(dllexport) void __cdecl DisplayHello(HumanName * name)
	{
		printf("%s,%s\r\n", name->FirstName,name->LastName);
		strcpy_s(name->FirstName, 8, "��ʺ");
		strcpy_s(name->LastName, 8, "����");
		name->Tall = 1000;
	}
}