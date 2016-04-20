#pragma once

#include <Windows.h>

extern "C" {
	struct HumanName {
		CHAR FirstName[100];
		CHAR LastName[100];
		DWORD Tall;
	};
}