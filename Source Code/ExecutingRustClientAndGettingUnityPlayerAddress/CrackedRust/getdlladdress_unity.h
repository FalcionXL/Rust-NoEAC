#pragma once
#include "includes.h"

DWORD GetDLLBaseAddressUnityPlayer() 
{
	DWORD dllhandle = (DWORD)GetModuleHandleA("UnityPlayer.dll");
	return dllhandle;
}
