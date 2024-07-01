#include "Client.h"
#include "Timer.h"
#include "MsgStr.h"
#include "GameOptions.h"
#include "LogFile.h"
#include "Log.h"

void FOClient::InitMessTabs() {
	IntMessBoxActiveTab = 1;	//	All tab is active by default
	IntMessBoxTabsShown = true;
}

void FOClient::RecalcMessTabs() {

	Rect msgBoxRect;
	//	check if message box is extended or not
	if (IntAddMess)
		msgBoxRect = IntWMessLarge;
	else
		msgBoxRect = IntWMess;

	int top = msgBoxRect.T;
	int bot = msgBoxRect.T + 5 + SprMngr.GetLineHeight(messboxFont);;
	int width = msgBoxRect.R - msgBoxRect.L;

	//	" All  Public  Radio  Social  Combat ";
	IntWMessTabs = Rect(msgBoxRect.L, top, msgBoxRect.R, bot);

	int allWidth = (width * 5) / 36;
	IntWMessTabAll = Rect(msgBoxRect.L, top, msgBoxRect.L + allWidth, bot);

	int localWidth = (width * 8) / 36;
	IntWMessTabLocal = Rect(IntWMessTabAll.R + 1, top, IntWMessTabAll.R + localWidth, bot);

	int radioWidth = (width * 7) / 36;
	IntWMessTabRadio = Rect(IntWMessTabLocal.R + 1, top, IntWMessTabLocal.R + radioWidth, bot);

	int socialWidth = (width * 8) / 36;
	IntWMessTabSocial = Rect(IntWMessTabRadio.R + 1, top, IntWMessTabRadio.R + socialWidth, bot);

	int combatWidth = (width * 8) / 36;
	IntWMessTabCombat = Rect(IntWMessTabSocial.R + 1, top, IntWMessTabSocial.R + combatWidth, bot);
}

void FOClient::AddMess(int mess_type, const char* msg)
{
	if (!msg)
		return;
	if (mess_type == MSGBOX_GAME && !strcmp(msg, "error"))
		return;

	// Time
	DateTime dt;
	Timer::GetCurrentDateTime(dt);
	char mess_time[64];
	Str::Format(mess_time, "%02d:%02d:%02d ", dt.Hour, dt.Minute, dt.Second);

	// Add
	MessBox.push_back(MessBoxMessage(mess_type, msg, mess_time));

	// Generate mess box
	if (std::find(MessBoxFilters.begin(), MessBoxFilters.end(), mess_type) == MessBoxFilters.end())
	{
		if (MessBoxScroll && IsCurInRect(MessBoxCurRectScroll()))
			MessBoxScroll++;
		else
			MessBoxScroll = 0;
	}
	MessBoxGenerate();
}

std::string FOClient::FormatMessBoxMessage(MessBoxMessage& msg) {
	// Text
	const uint str_color[] = { COLOR_TEXT_DGREEN, COLOR_TEXT, COLOR_TEXT_DRED, COLOR_TEXT_DGREEN, COLOR_TEXT };
	char strBuff[MAX_FOTEXT];
	memset(strBuff, 0, MAX_FOTEXT);

	if (msg.Type < 0 || msg.Type > MSGBOX_RADIO_HIDDEN) {
		//Str::Format(strBuff, "%s\n", msg.Mess);
		sprintf(strBuff, "%s\n", msg.Mess.c_str());
	}
	else
		//Str::Format(strBuff, "|%u %s |%u %s\n", str_color[msg.Type], msg.Time, COLOR_TEXT, msg.Mess);
		if (showTimestamps) {
			sprintf(strBuff, "|%u %s|%u %s\n", str_color[msg.Type], msg.Time.c_str(), COLOR_TEXT, msg.Mess.c_str());
		}
		else {
			sprintf(strBuff, "|%u %c|%u %s\n", str_color[msg.Type], TEXT_SYMBOL_DOT, COLOR_TEXT, msg.Mess.c_str());
		}
	return std::string(strBuff);
}

void FOClient::MessBoxGenerate()
{

	MessBoxCurText = "";
	if (MessBox.empty())
		return;

	Rect ir = MessBoxCurRectDraw();
	int max_lines = SprMngr.GetLinesCount(0, ir.H(), NULL, messboxFont);

	if (ir.IsZero() || max_lines <= 0)
	{
		MessBoxMaxScroll = 0;
		MessBoxScrollLines = 0;
		return;
	}

	MessBoxScrollLines = -1;
	bool check_filters = IsMainScreen(CLIENT_MAIN_SCREEN_GAME);
	int cur_mess = (int)MessBox.size() - 1;
	int lines = 0;
	for (; cur_mess >= 0; cur_mess--)
	{
		MessBoxMessage& m = MessBox[cur_mess];
		//WriteLog("Message debug: tab = %d, type = %d, msg = %s\n", IntMessBoxActiveTab, m.Type, m.Mess.c_str());

		// Filters
		if (check_filters && std::find(MessBoxFilters.begin(), MessBoxFilters.end(), m.Type) != MessBoxFilters.end())
			continue;
				
		if (IsMainScreen(CLIENT_MAIN_SCREEN_GAME) && IntMessBoxActiveTab == 2	//	Public
			&& m.Type != MSGBOX_TALK) {
			continue;
		}

		if (IsMainScreen(CLIENT_MAIN_SCREEN_GAME) && IntMessBoxActiveTab == 3	//	Radio
			&& (m.Type != MSGBOX_RADIO && m.Type != MSGBOX_RADIO_HIDDEN)) {
			continue;
		}
		
		//	Radio hidden/trade spam channel (curently radio chan 2) shall not pop up in the 'all' chat tab
		if (IsMainScreen(CLIENT_MAIN_SCREEN_GAME) && IntMessBoxActiveTab != 3 && m.Type == MSGBOX_RADIO_HIDDEN) {
			continue;
		}		
		
		if (IsMainScreen(CLIENT_MAIN_SCREEN_GAME) && IntMessBoxActiveTab == 4	//	Social
			&& (m.Type != MSGBOX_SOCIAL)) {
			continue;
		}

		if (IsMainScreen(CLIENT_MAIN_SCREEN_GAME) && IntMessBoxActiveTab == 5	//	Combat log
			&& m.Type != MSGBOX_COMBAT_RESULT) {
			continue;
		}

		// Skip scrolled lines
		int lines_ = lines;
		lines += SprMngr.GetLinesCount(ir.W(), 0, FormatMessBoxMessage(m).c_str(), messboxFont);
		if (MessBoxScrollLines < 0)
		{
			if (lines <= MessBoxScroll)
				continue;
			MessBoxScrollLines = MessBoxScroll - lines_;
		}

		if (lines_ - MessBoxScroll < max_lines)
		{
			// Add to message box
			if (GameOpt.MsgboxInvert)
				MessBoxCurText += FormatMessBoxMessage(m).c_str();                          // Back
			else
				MessBoxCurText = FormatMessBoxMessage(m).c_str() + MessBoxCurText;          // Front
		}
		else
			break;
	}
	MessBoxMaxScroll = lines - max_lines;
	if (MessBoxScrollLines < 0)
		MessBoxScrollLines = 0;
}

void FOClient::MessBoxDraw()
{
	if (IntMessBoxTabsShown && IntVisible && IsMainScreen(CLIENT_MAIN_SCREEN_GAME)) {
		RecalcMessTabs();
		SprMngr.DrawStr(IntWMessTabAll, "All", FONT_FLAG_CENTERX, IntMessBoxActiveTab == 1 ? 0xFFF8F993 : COLOR_TEXT_DGREEN, messboxFont);
		SprMngr.DrawStr(IntWMessTabLocal, "Public", FONT_FLAG_CENTERX, IntMessBoxActiveTab == 2 ? 0xFFF8F993 : COLOR_TEXT_DGREEN, messboxFont);
		SprMngr.DrawStr(IntWMessTabRadio, "Radio", FONT_FLAG_CENTERX, IntMessBoxActiveTab == 3 ? 0xFFF8F993 : COLOR_TEXT_DGREEN, messboxFont);
		SprMngr.DrawStr(IntWMessTabSocial, "Social", FONT_FLAG_CENTERX, IntMessBoxActiveTab == 4 ? 0xFFF8F993 : COLOR_TEXT_DGREEN, messboxFont);
		SprMngr.DrawStr(IntWMessTabCombat, "Combat", FONT_FLAG_CENTERX, IntMessBoxActiveTab == 5 ? 0xFFF8F993 : COLOR_TEXT_DGREEN, messboxFont);
	}

	if (MessBoxCurText.empty())
		return;

	uint flags = 0;
	if (!GameOpt.MsgboxInvert)
		flags |= FONT_FLAG_UPPER | FONT_FLAG_BOTTOM;

	Rect ir = MessBoxCurRectDraw();
	if (ir.IsZero())
		return;
		
	//	draw messages
	SprMngr.DrawStr(ir, MessBoxCurText.c_str(), flags | (GameOpt.MsgboxInvert ? FONT_FLAG_SKIPLINES(MessBoxScrollLines) : FONT_FLAG_SKIPLINES_END(MessBoxScrollLines)), 0, messboxFont);
}

Rect FOClient::MessBoxCurRectDraw()
{
	static Rect r(0, 0, 0, 0);

	if (IsMainScreen(CLIENT_MAIN_SCREEN_LOGIN))
		return LogWChat;
	else if (IsMainScreen(CLIENT_MAIN_SCREEN_REGISTRATION))
		return r(0, 0, MODE_WIDTH, 60);
	else if (IsMainScreen(CLIENT_MAIN_SCREEN_WORLDMAP))
		return WorldmapWChat;
	else if (IsMainScreen(CLIENT_MAIN_SCREEN_GAME) && IntVisible && !IsScreenPresent(CLIENT_SCREEN_WM_TOWNVIEW))
	{
		if (IntAddMess)
			if (IntMessBoxTabsShown) 
				return Rect (IntWMessLarge.L, IntWMessLarge.T + IntWMessTabAll.H(), IntWMessLarge.R, IntWMessLarge.B);
			else
				return IntWMessLarge;
		else
			if (IntMessBoxTabsShown)
				return Rect(IntWMess.L, IntWMess.T + IntWMessTabAll.H(), IntWMess.R, IntWMess.B);
			else
				return IntWMess;
	}

	return r(0, 0, 0, 0);
}

Rect FOClient::MessBoxCurRectScroll()
{
	if (IsCurMode(CURSOR_WAIT) || IsLMenu())
		return Rect(0, 0, 0, 0);

	if (GetActiveScreen() == CLIENT_SCREEN_NONE)
	{
		if (IsMainScreen(CLIENT_MAIN_SCREEN_LOGIN))
			return LogWChat;
		else if (IsMainScreen(CLIENT_MAIN_SCREEN_REGISTRATION))
			return Rect(0, 0, MODE_WIDTH, 60);
		else if (IsMainScreen(CLIENT_MAIN_SCREEN_WORLDMAP))
			return WorldmapWChat;
		else if (IsMainScreen(CLIENT_MAIN_SCREEN_GAME) && IntVisible && !IsScreenPresent(CLIENT_SCREEN_WM_TOWNVIEW))
		{
			if (IntAddMess)
				if (IntMessBoxTabsShown)
					return Rect(IntWMessLarge.L, IntWMessLarge.T + IntWMessTabAll.H(), IntWMessLarge.R, IntWMessLarge.B);
				else
					return IntWMessLarge;
			else
				if (IntMessBoxTabsShown)
					return Rect(IntWMess.L, IntWMess.T + IntWMessTabAll.H(), IntWMess.R, IntWMess.B);
				else
					return IntWMess;
		}
	}

	return Rect(0, 0, 0, 0);
}

void FOClient::MessBoxTabLMouseDown() {
	if (!IntMessBoxTabsShown)
		return;
	if (IsCurInRect(IntWMessTabAll)) {
		IntMessBoxActiveTab = 1;
		MessBoxGenerate();
	}
	else if (IsCurInRect(IntWMessTabLocal)) {
		IntMessBoxActiveTab = 2;
		MessBoxGenerate();
	}
	else if (IsCurInRect(IntWMessTabRadio)) {
		IntMessBoxActiveTab = 3;
		MessBoxGenerate();
	}
	else if (IsCurInRect(IntWMessTabSocial)) {
		IntMessBoxActiveTab = 4;
		MessBoxGenerate();
	}
	else if (IsCurInRect(IntWMessTabCombat)) {
		IntMessBoxActiveTab = 5;
		MessBoxGenerate();
	}
}

bool FOClient::MessBoxLMouseDown()
{
	Rect rmb = MessBoxCurRectScroll();
	if (!rmb.IsZero() && IsCurInRect(rmb))
	{
		if (IsCurInRect(Rect(rmb.L, rmb.T, rmb.R, rmb.CY())))
		{
			if (GameOpt.MsgboxInvert && MessBoxScroll > 0)
				MessBoxScroll--;
			if (!GameOpt.MsgboxInvert && MessBoxScroll < MessBoxMaxScroll)
				MessBoxScroll++;
			MessBoxGenerate();
		}
		else
		{
			if (GameOpt.MsgboxInvert && MessBoxScroll < MessBoxMaxScroll)
				MessBoxScroll++;
			if (!GameOpt.MsgboxInvert && MessBoxScroll > 0)
				MessBoxScroll--;
			MessBoxGenerate();
		}
		return true;
	}
	return false;
}
