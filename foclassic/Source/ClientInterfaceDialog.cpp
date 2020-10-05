#include "Client.h"
#include "MsgStr.h"
#include "Text.h"

void FOClient::RecalcDlgMainTextLinesReal() {
	if (IsScreenPresent(CLIENT_SCREEN_DIALOG))
	{
		DlgMainTextLinesReal = SprMngr.GetLinesCount(DlgWText.W(), 0, DlgMainText.c_str(), dialogFont);
	}
	else if (IsScreenPresent(CLIENT_SCREEN_BARTER))
	{
		DlgMainTextLinesReal = SprMngr.GetLinesCount(DlgWText.W(), 0, BarterText.c_str(), dialogFont);
	}
}

void FOClient::RecalcDlgMainTextLinesRect() {
	DlgMainTextLinesRect = SprMngr.GetLinesCount(0, DlgWText.H(), NULL, dialogFont);
}

void FOClient::RecalcDlgAnswerPositions() {

	DlgCurAnswPage = 0;
	DlgMaxAnswPage = 0;
	DlgAllAnswers.clear();
	DlgAnswers.clear();

	const char answ_beg[] = { ' ', ' ', (char)TEXT_SYMBOL_DOT, ' ', 0 };
	const char page_up[] = { (char)TEXT_SYMBOL_UP, (char)TEXT_SYMBOL_UP, (char)TEXT_SYMBOL_UP, 0 };
	const int  page_up_height = SprMngr.GetLinesHeight(DlgAnswText.W(), 0, page_up, dialogFont);
	const char page_down[] = { (char)TEXT_SYMBOL_DOWN, (char)TEXT_SYMBOL_DOWN, (char)TEXT_SYMBOL_DOWN, 0 };
	const int  page_down_height = SprMngr.GetLinesHeight(DlgAnswText.W(), 0, page_down, dialogFont);

	char str[MAX_FOTEXT];
	int        line = 0, height = 0, page = 0, answ = 0;
	while (true)
	{
		Rect pos(
			DlgAnswText.L + DlgNextAnswX * line,
			DlgAnswText.T + DlgNextAnswY * line + height,
			DlgAnswText.R + DlgNextAnswX * line,
			DlgAnswText.T + DlgNextAnswY * line + height);

		// Up arrow
		if (page && !line)
		{
			height += page_up_height;
			pos.B += page_up_height;
			line++;
			DlgAllAnswers.push_back(Answer(page, pos, page_up, -1));
			continue;
		}

		Str::Copy(str, MsgDlg->GetStr(answers_texts[answ]));
		FormatTags(str, MAX_FOTEXT, Chosen, npc, lexems);
		Str::Insert(str, answ_beg);      // TODO: GetStr

		height += SprMngr.GetLinesHeight(DlgAnswText.W(), 0, str, dialogFont);
		pos.B = DlgAnswText.T + DlgNextAnswY * line + height;

		if (pos.B >= DlgAnswText.B && line > 1)
		{
			// Down arrow
			Answer& answ_prev = DlgAllAnswers.back();
			if (line > 2 && DlgAnswText.B - answ_prev.Position.B < page_down_height)     // Check free space
			{
				// Not enough space
				// Migrate last answer to next page
				DlgAllAnswers.pop_back();
				pos = answ_prev.Position;
				pos.B = pos.T + page_down_height;
				DlgAllAnswers.push_back(Answer(page, pos, page_down, -2));
				answ--;
			}
			else
			{
				// Add down arrow
				pos.B = pos.T + page_down_height;
				DlgAllAnswers.push_back(Answer(page, pos, page_down, -2));
			}

			page++;
			height = 0;
			line = 0;
			DlgMaxAnswPage = page;
		}
		else
		{
			// Answer
			DlgAllAnswers.push_back(Answer(page, pos, str, answ));
			line++;
			answ++;
			if (answ >= count_answ)
				break;
		}
	}
	DlgCollectAnswers(false);
}
