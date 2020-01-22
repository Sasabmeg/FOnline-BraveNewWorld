#ifndef __INTELLISENSE_CREATOR_DATA__
#define __INTELLISENSE_CREATOR_DATA__

//
// Enables output customization for IntellisenseCreator
//
// Usage:
// - copy and include this file into your project
// - call GetIntellisenseCreatorData() function
// - enable your customizations by calling Set*() function(s)
// - call SetIntellisenseCreatorData() function
//

#include "./../AngelScript/angelscript.h"

#define INTELLISENSE_CREATOR_DATA	(2461) // 2000 + 0x1CD

struct IntellisenseCreatorData
{
#ifndef __INTELLISENSE_CREATOR__
private:
#endif
	vector<int> enumAsFlags;

public:
	const asIScriptEngine* AngelScript;

	IntellisenseCreatorData( asIScriptEngine* engine )
	{
		AngelScript = engine;
	}

#ifndef __INTELLISENSE_CREATOR__
	void SetEnumAsFlags( const char* name )
	{
		int enumTypeId = GetEnumTypeId( name );
		if( !enumTypeId )
			return;

		if( find( enumAsFlags.begin(), enumAsFlags.end(), enumTypeId ) != enumAsFlags.end() )
			return;

		enumAsFlags.push_back( enumTypeId );
	}

	private:
	int GetEnumTypeId( const char* name )
	{
		for( asUINT e=0, eLen=AngelScript->GetEnumCount(); e<eLen; e++ )
		{
			int enumTypeId;
			const char* enumName = AngelScript->GetEnumByIndex( e, &enumTypeId );

			if( !strcmp(name,enumName) )
				return( enumTypeId );
		}

		return( 0 );
	}
#endif
};

static IntellisenseCreatorData* GetIntellisenseCreatorData( asIScriptEngine* as )
{
	if( !as )
		return( NULL );

	IntellisenseCreatorData* icdata = (IntellisenseCreatorData*)as->GetUserData( INTELLISENSE_CREATOR_DATA );
	if( !icdata )
		icdata = new IntellisenseCreatorData( as );

	return( icdata );
}

#ifndef __INTELLISENSE_CREATOR__
static bool SetIntellisenseCreatorData( asIScriptEngine* as, IntellisenseCreatorData* icdata )
{
	if( !as || !icdata )
		return( false );

	as->SetUserData( icdata, INTELLISENSE_CREATOR_DATA );
	return( true );
}
#endif

#endif // __INTELLISENSE_CREATOR_DATA__ //
