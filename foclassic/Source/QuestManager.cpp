#include "Core.h"

#include <algorithm>

#include "MsgStr.h"
#include "QuestManager.h"
#include "Text.h"

#include "Script.h"
#include "Log.h"

using namespace std;
using namespace Script;

/**
	FOTEXT.MSG:

	# Number formula as in FOTEXT.MSG file on server side.
	#	VariableId * 1000 + Value (1-100) - The text that appears at a given value of the variable (current objective).
	#	VariableId * 1000 + 101 - Name of quest tab.
	#	VariableId * 1000 + 102 - Permanent quest description.

	Example:

	#=======================================
	# 6502
	# Landers Point: Caravan Packer
	#=======================================

	{6502001}{}{The caravan foreman at Landers Point asked me to unload some boxes from the cart to the north-west storage area. After unloading 3 boxes, my pay would be 250 caps.}
	{6502004}{}{DONE:That's all. I should talk to the caravan foreman about my reward!}
	{6502097}{}{SOFT_FAILED:I tried to help the caravan packer but I dropped one of the boxes on the wrong location. Maybe I should work out a bit before trying again.}
	{6502099}{}{SOFT_COMPLETED:I finished the task and got my reward. I could return for more work a bit later.}
	{6502101}{}{JOB:Landers Point Caravan packer}
	{6502102}{}{Unload boxes from the caravan cart.}

	C++ code:

	Full variable (VAR) = {6502001}

	questVarId			= 6502
	questVarValue		= 001
	tabName				= "JOB:Landers Point Caravan packer"

	If VAR ends in 000, that quest is not any kind of progress, so it would be erased from pip boy if present before.

*/

//	Quest
void Quest::refreshQuestTypeAndProgress() {
	// default for quest type is QUEST
	if (info.find("JOB") == 0) {
		type = JOB;
	}
	else if (info.find("STORY") == 0) {
		type = STORY;
	}
	else {
		type = QUEST;
	}

	// default for quest progress is ONGOING
	if (str.find("DONE") == 0) {
		progress = DONE;
	}
	else if (str.find("SOFT_FAILED") == 0) {
		progress = SOFT_FAILED;
	}
	else if (str.find("HARD_FAILED") == 0) {
		progress = HARD_FAILED;
	}
	else if (str.find("SOFT_COMPLETED") == 0) {
		progress = SOFT_COMPLETED;
	}
	else if (str.find("HARD_COMPLETED") == 0) {
		progress = HARD_COMPLETED;
	}
	else if (str.find("NO_POPUP") == 0) {
		progress = NO_POPUP;
	}
	else if (str.find("HIDDEN") == 0) {
		progress = HIDDEN;
	}
	else {
		progress = ONGOING;
	}
}

bool Quest::compare(Quest& left, Quest& right) {
	return left.info < right.info;
}

uint Quest::getQuestColor() {
	uint color = 0U;
	switch (progress) {
		case SOFT_COMPLETED:
			color = 0xFF4DA996;		//	COLOR_DARKTEAL
			break;
		case HARD_COMPLETED:
			color = 0xFF007700;		//	COLOR_DARKGREEN
			break;
		case SOFT_FAILED:
			color = 0xFFEA4600;		//	COLOR_DARKORANGE
			break;
		case HARD_FAILED:
			color = 0xFFEE0500;		//	COLOR_RED
			break;
		case DONE:
			color = COLOR_TEXT;		//	COLOR_TEXT
			break;
		default:
			if (type == JOB) {
				color = 0xFF6DD9C6;			//	COLOR_TEAL
			}
			else if (type == STORY) {
				//color = 0xFFD4AF37;			//	COLOR_METALICGOLD
				//color = 0xFFC5B358;			//	COLOR_VEGASGOLD
				color = 0xFFEFCF30;			//	COLOR_GOLDENYELLOW
			}
			else {
				color = COLOR_TEXT;		//	COLOR_TEXT
			}
			break;
	}
	return color;
}

/// QuestTab
void QuestTab::ReparseText()
{
    text = "";

    char str[128];
    for( uint i = 0; i < quests.size(); ++i )
    {
        Str::Format( str, msg->GetStr( STR_QUEST_NUMBER ), i + 1 );

        text += str;
        text += QuestManager::removeFormat(quests[i].info);
        text += "\n";
        text += msg->GetStr(STR_QUEST_PROCESS);		//	adds tempalte from FOQUEST.MSG, ex: "Current progress:"
        text += QuestManager::removeFormat(quests[i].str);
        text += "\n\n";
    }
}

bool QuestTab::IsEmpty()
{
    return quests.empty();
}

void QuestTab::AddQuest( uint16 num, string info )
{
	Quest quest = Quest(num, info);
    quests.push_back( quest );
	WriteLog("info [%d] [%s]\n", info.length(), info.c_str());
	//quest.refreshQuestTypeAndProgress();
	ReparseText();
}
void QuestTab::RefreshQuest( uint16 num, string str )
{
    Quest* quest = GetQuest( num );
    if( !quest )
        return;
    quest->str = str;
	WriteLog("text [%s] - info [%s] - str [%s]\n", text.c_str(), quest->info.c_str(), quest->str.c_str());
	quest->refreshQuestTypeAndProgress();
	ReparseText();
}
Quest* QuestTab::GetQuest( uint16 num )
{
    auto it = std::find( quests.begin(), quests.end(), num );
    return it != quests.end() ? &(*it) : NULL;
}
void QuestTab::EraseQuest( uint16 num )
{
    auto it = std::find( quests.begin(), quests.end(), num );
    if( it != quests.end() )
        quests.erase( it );
    ReparseText();
}
QuestVec*   QuestTab::GetQuests() { return &quests; }
const char* QuestTab::GetText()   { return text.c_str(); }


void QuestManager::Init( FOMsg* quest_msg )
{
	//	at this point whole FOTEXT.MSG files is loaded, as a multi map
    msg = quest_msg;
	/*
	WriteLog("QuestManager::Init()\n");
	WriteLog("FOMsg size = %d\n", msg->GetSize());
	for (auto ptr = msg->GetData().begin(); ptr != msg->GetData().end(); ptr++)
	{
		WriteLog("First: %d\t", ptr->first);
		if (!ptr->second.empty() && ptr->first > 1000) {
			WriteLog("Second: %s", ptr->second.c_str());
		}
		WriteLog("\n");
	}
	*/
}

void QuestManager::Finish()
{
    tabs.clear();
}

void QuestManager::OnQuest( uint questVar )
{
	
    // Split
    uint16 questVarId = questVar / QUEST_MUL;
    uint16 questVarValue = questVar % QUEST_MUL;

    // Check valid Name of Tab
	if (!msg->Count(GET_QUEST_NAME_VAR(questVarId))) {
		return;
	}
					  
    string tabName = string( msg->GetStr( GET_QUEST_NAME_VAR( questVarId ) ) );

    // Try get Tab
    QuestTab* tab = NULL;
    auto it = tabs.find( tabName );
	if (it != tabs.end()) {
		tab = &(*it).second;
	}

    // Try get Quest
    Quest* quest = NULL;
	if (tab) {
		quest = tab->GetQuest(questVarId);
	}
		
    // If quest variable value is 000, player is not aware of this quest, need to erase.
    if( !questVarValue )
    {
        if( tab )
        {
            tab->EraseQuest( questVarId );
            if( tab->IsEmpty() )
                tabs.erase( tabName );
        }
        return;
    }

    // Add Tab if not exists
	if (!tab) {
		tab = &(* ( tabs.insert(PAIR(tabName, QuestTab(msg))) ).first ).second;
		//	Generate callback to AS at client when quest changed
		//updateQuestASCallback(tabName, string(msg->GetStr(questVar)));
	}

    // Add Quest if not exists
	if (!quest) {
        tab->AddQuest( questVarId, string( msg->GetStr( GET_QUEST_INFO_VAR( questVarId ) ) ) );
		//	Generate callback to AS at client when quest changed
		//updateQuestASCallback(tabName, string(msg->GetStr(questVar)));
	}

    // Get name of quest
    tab->RefreshQuest( questVarId, string( msg->GetStr( questVar ) ) );

}

QuestTabMap* QuestManager::GetTabs()
{
    return &tabs;
}

QuestTab* QuestManager::GetTab( uint tab_num )
{
    if( tabs.empty() )
        return NULL;

    auto it = tabs.begin();
    while( tab_num )
    {
        ++it;
        --tab_num;
        if( it == tabs.end() )
            return NULL;
    }

    return &(*it).second;
}

Quest* QuestManager::GetQuest( uint tab_num, uint16 quest_num )
{
    QuestTab* tab = GetTab( tab_num );
    return tab ? tab->GetQuest( quest_num ) : NULL;
}

Quest* QuestManager::GetQuest( uint num )
{
    if( !msg->Count( GET_QUEST_NAME_VAR( num / QUEST_MUL ) ) )
        return NULL;
    string tab_name = string( msg->GetStr( GET_QUEST_NAME_VAR( num / QUEST_MUL ) ) );
    auto   it_tab = tabs.find( tab_name );
    return it_tab != tabs.end() ? (*it_tab).second.GetQuest( num / QUEST_MUL ) : NULL;
}

void QuestManager::updateQuestASCallback(std::string tabName, std::string tabText) {
	if (Script::PrepareContext(ClientFunctions.QuestChange, _FUNC_, "Game"))
	{
		ScriptString* event_name_script = new ScriptString(tabName);
		Script::SetArgObject(event_name_script);

		ScriptString* event_text_script = new ScriptString(tabText);
		Script::SetArgObject(event_text_script);

		Script::RunPrepared();
		event_name_script->Release();
		event_text_script->Release();
	}
}

/*
 * Need to remove any Quest Tracker keywords, introduced to classify the quest. 
 */
std::string QuestManager::removeFormat(std::string questText) {
	std::string ret = questText;
	int keywordsSize = 11;
	std::string keywords[11] = {"JOB:", "QUEST:", "STORY:",
								"DONE:", "SOFT_FAILED:", "HARD_FAILED:", "SOFT_COMPLETED:", "HARD_COMPLETED:", "ONGOING:",
								"HIDDEN:", "NO_POPUP:"};
	for (int i = 0; i < keywordsSize; i++) {
		if (questText.find(keywords[i]) == 0) {
			ret = questText.substr(keywords[i].length());
		}
	}
	return ret;
}
