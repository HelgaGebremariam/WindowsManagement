// WindowsManagement.CppCore.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <powrprof.h>

__declspec(dllexport) int GetBatteryState()
{
	POWER_INFORMATION_LEVEL infoLevel = SystemBatteryState;
	SYSTEM_BATTERY_STATE outputBuffer;
	long res = CallNtPowerInformation(infoLevel, NULL, 0, &outputBuffer, sizeof(outputBuffer));
	if (outputBuffer.MaxCapacity == 0)
		return 0;
	double remaining = outputBuffer.RemainingCapacity;
	double max = outputBuffer.MaxCapacity;
	double percent = (remaining / max) * 100;
	return (int)percent;
}

__declspec(dllexport) unsigned long long GetLastSleepTime()
{
	POWER_INFORMATION_LEVEL infoLevel = LastSleepTime;
	ULONGLONG outputBuffer;
	long res = CallNtPowerInformation(infoLevel, NULL, 0, &outputBuffer, sizeof(outputBuffer));
	return outputBuffer;
}

__declspec(dllexport) unsigned long long GetLastWakeTime()
{
	POWER_INFORMATION_LEVEL infoLevel = LastWakeTime;
	ULONGLONG outputBuffer;
	long res = CallNtPowerInformation(infoLevel, NULL, 0, &outputBuffer, sizeof(outputBuffer));
	return outputBuffer;
}

__declspec(dllexport) void Sleep()
{
	SetSuspendState(false, false, false);
}

__declspec(dllexport) void Hybernate()
{
	SetSuspendState(true, false, false);
}

__declspec(dllexport) void ReserveHibernationFile()
{
	POWER_INFORMATION_LEVEL infoLevel = SystemReserveHiberFile;
	bool inputBuffer = true;
	long res = CallNtPowerInformation(infoLevel, &inputBuffer, sizeof(inputBuffer), NULL, 0);
}

__declspec(dllexport) void DeleteHibernationFile()
{
	POWER_INFORMATION_LEVEL infoLevel = SystemReserveHiberFile;
	bool inputBuffer = false;
	long res = CallNtPowerInformation(infoLevel, &inputBuffer, sizeof(inputBuffer), NULL, 0);
}

__declspec(dllexport) unsigned long GetSystemIdless()
{
	POWER_INFORMATION_LEVEL infoLevel = SystemPowerInformation;
	SYSTEM_POWER_INFORMATION outputBuffer;

	long res = CallNtPowerInformation(infoLevel, NULL, 0, &outputBuffer, sizeof(outputBuffer));
	return outputBuffer.Idleness;
}