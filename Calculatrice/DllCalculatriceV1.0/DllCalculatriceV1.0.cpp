// DllCalculatriceV1.0.cpp : Définit les fonctions exportées de la DLL.
//

#include "pch.h"
#include "framework.h"
#include "DllCalculatriceV1.0.h"


// Il s'agit d'un exemple de variable exportée
DLLCALCULATRICEV10_API int nDllCalculatriceV10=0;

// Il s'agit d'un exemple de fonction exportée.
DLLCALCULATRICEV10_API int fnDllCalculatriceV10(void)
{
    return 0;
}

// Il s'agit du constructeur d'une classe qui a été exportée.
CDllCalculatriceV10::CDllCalculatriceV10()
{
    return;
}
