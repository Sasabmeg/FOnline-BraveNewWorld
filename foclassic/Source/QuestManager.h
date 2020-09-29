#ifndef __QUEST_MANAGER__
#define __QUEST_MANAGER__

#include "MsgFiles.h"
#include "Types.h"

#define QUEST_MUL    1000

enum QuestProgress {ONGOING, DONE, SOFT_FAILED, HARD_FAILED, SOFT_COMPLETED, HARD_COMPLETED, HIDDEN, NO_POPUP};
enum QuestType {JOB, QUEST, STORY};

struct Quest
{
    uint16			num;
    std::string		str;
    std::string		info;
    bool			isInfo;
	QuestType		type;
	QuestProgress	progress;

    bool operator==( const uint16& _num ) { return _num == num; }
    Quest( uint _num, std::string _info ) : num( _num ), info( _info ), isInfo( false ) {}
	void refreshQuestTypeAndProgress();
	bool static compare(Quest& left, Quest& right);
	uint getQuestColor();
};
typedef std::vector<Quest> QuestVec;

class QuestTab
{
private:
    QuestVec    quests;
    std::string text;
    FOMsg*      msg;

    void ReparseText();

public:
    QuestTab( FOMsg* _msg ) : msg( _msg ) {}
    bool        IsEmpty();
    void		AddQuest( uint16 num, std::string info );
    void        RefreshQuest( uint16 num, std::string str );
    Quest*      GetQuest( uint16 num );
    void        EraseQuest( uint16 num );
    QuestVec*   GetQuests();
    const char* GetText();
};
typedef std::map<std::string, QuestTab, std::less<std::string>> QuestTabMap;

class QuestManager
{
private:
    FOMsg*      msg;
    QuestTabMap tabs;

public:
    void         Init( FOMsg* quest_msg );
    void         Finish();
    void         OnQuest( uint num );
    QuestTabMap* GetTabs();
    QuestTab*    GetTab( uint tab_num );
    Quest*       GetQuest( uint tab_num, uint16 quest_num );
    Quest*       GetQuest( uint num );
	void		 updateQuestASCallback(std::string tabName, std::string tabText);
	static std::string		 removeFormat(std::string questText);
};

#endif // __QUEST_MANAGER__
