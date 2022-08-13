#pragma once
#include "includes.h"

void RunExecutionFileRust() 
{
	STARTUPINFO x12;
	PROCESS_INFORMATION x1;
	// set the size of the structures
	ZeroMemory(&x1, sizeof(x1));
	x12.cb = sizeof(x12);
	ZeroMemory(&x12, sizeof(x12));

	// start the program up
	CreateProcessW((LPCWSTR)L"RustClient.exe",   // the path
		0,        // Command line
		NULL,           // Process handle not inheritable
		NULL,           // Thread handle not inheritable
		FALSE,          // Set handle inheritance to FALSE
		0,              // No creation flags
		NULL,           // Use parent's environment block
		NULL,           // Use parent's starting directory 
		&x12,            // Pointer to STARTUPINFO structure
		&x1             // Pointer to PROCESS_INFORMATION structure (removed extra parentheses)
	);
	// Close process and thread handles. 
	CloseHandle(x1.hProcess);
	CloseHandle(x1.hThread);
}