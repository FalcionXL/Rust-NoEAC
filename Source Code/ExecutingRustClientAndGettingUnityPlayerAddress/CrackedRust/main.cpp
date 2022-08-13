#include "getdlladdress_unity.h"
#include "open_execution_file_rust.h"

int main() {
	cout << "UnityPlayer Address: 0x" << GetDLLBaseAddressUnityPlayer() << endl;
	Sleep(12000);
	cout << "Opening RustClient..." << endl;
	RunExecutionFileRust();
	Sleep(4000);
	return 0;
}